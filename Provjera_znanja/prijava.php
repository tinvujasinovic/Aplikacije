<?php
require './baza.class.php';
require './dnevnik.php';
require './sesija.class.php';
$baza = new Baza();
if ($_SERVER["HTTPS"] != "on") {
    header("Location: https://" . $_SERVER["HTTP_HOST"] . $_SERVER["REQUEST_URI"]);
    exit();
}
$greske = array();

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $baza->spojiSe();

    $dohvatiBrojNeuspjesnih = "select broj_neuspjesnih from konfiguracija";
    $dohvat = $baza->select($dohvatiBrojNeuspjesnih);
    $broj_dozvoljenih = $dohvat[0]["broj_neuspjesnih"];
    $username = $_POST["korime"];
    $password = $_POST["lozinka_prijava"];

    $session = "";
    $uloga = "";

    $sqlUpit = "select username, lozinka_kript,uloga_id from korisnik";
    $rezultat = $baza->select($sqlUpit);
    $i = 0;
    foreach ($rezultat as $value) {
        if ($rezultat[$i]["username"] == $username) {
            $pronaden = TRUE;
            $session = $rezultat[$i]["username"];
            $uloga = $rezultat[$i]["uloga_id"];
            $salt = "125bjdfk3248fks";
            $lozinka = $rezultat[$i]["lozinka_kript"];
            $neuspjesno = "select broj_neuspjesnih from korisnik where username='$session'";
            $rezultatNeuspjesne = $baza->select($neuspjesno);
            $broj_neuspjesnih = $rezultatNeuspjesne[0]["broj_neuspjesnih"];
            break;
        } else {
            $pronaden = FALSE;
        }
        $i++;
    }
    if ($pronaden) {
        $provjera = "select status from korisnik where username='$session'";
        $blokiran = $baza->select($provjera);
        $status = $blokiran[0]["status"];
        if ($status == "b") {
            $greske[] = "Račun je blokiran, javite se administratoru!";
        } else {

            if ($lozinka == sha1($password . $salt) && $lozinka != "") {
                $aktiviran = "select aktiviran from korisnik where username='$session'";
                $aktiviranRez = $baza->select($aktiviran);
                $value = $aktiviranRez[0]["aktiviran"];
                if ($value == NULL) {
                    $greske[] = "Korisnički račun nije aktiviran, provjeri email!";
                }
            } else {
                $broj_neuspjesnih++;
                DnevnikDodajAnonimno($username, "Neuspjesna prijava");
                if ($broj_neuspjesnih == $broj_dozvoljenih) {
                    $blokiraj = "update korisnik set status='b' where username='$session'";
                    $baza->upit($blokiraj);
                    $greske[] = "Račun je blokiran, previše netočnih unosa!";
                    $reset = "update korisnik set broj_neuspjesnih=0 where username='$session'";
                    $baza->upit($reset);
                } else {
                    $greske[] = "Neuspješna prijava!($broj_neuspjesnih)";
                    $insert = "update korisnik set broj_neuspjesnih=$broj_neuspjesnih where username='$session'";
                    $rez = $baza->upit($insert);
                }
            }
        }
    } else {
        $greske[] = "Ovaj korisnik ne postoji u bazi!";
    }
    if (empty($greske)) {

        Sesija::kreirajKorisnika($session, $uloga);
        $baza->spojiSe();
        setcookie("sesija", $uloga);
        setcookie("korisnik", $session, time() + 60 * 60 * 24 * 2);
        DnevnikDodajAnonimno($session, "Prijava u sustav");
        $reset = "update korisnik set broj_neuspjesnih=0 where username='$session'";
        $baza->upit($reset);
        header('Location: index.php');
    }
    $i = 0;
}

foreach ($greske as $value) {
    echo "<p style='color:red'>$value<br></p>";
}
?>
<!DOCTYPE html>
<html lang="hr">
    <head>
        <title>Liverpool FC</title>
        <meta charset="utf-8">
        <link rel ="stylesheet" type="text/css" href="css/stil.css">
        <meta name="naslov" content="Liverpool FC">
        <meta name="datum posljednje promjene" content="14.3.2018.">
        <meta name="autor" content="Tin Vujasinović">
        <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.4/themes/smoothness/jquery-ui.css">   
        <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.js"></script>  
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script src="tinvujasi_javascript.js"></script>
        <script src="tinvujasi_jquery.js"></script>
    </head>
    <body>
        <header>
            <h2>Provjera znanja</h2>
            <?php
            $mode = "";

            if (!empty($_COOKIE["sesija"])) {
                $mode = "Odjava";
            } else {
                $mode = "Prijava";
            }
            echo "<a href = 'provjeraSesije.php?mode=$mode'>$mode</a>";
            ?> 
            <div id="google_translate_element"></div><script type="text/javascript">
                function googleTranslateElementInit() {
                    new google.translate.TranslateElement({pageLanguage: 'hr', includedLanguages: 'de,en,fr,sl', layout: google.translate.TranslateElement.InlineLayout.SIMPLE, autoDisplay: false}, 'google_translate_element');
                }
            </script><script type="text/javascript" src="//translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>

        </header>
        <nav class="navi">
            <ul>
                <li><a href="index.php">Početna</a></li>
                <li><a href="natjecanja.php">Kategorije</a></li>
                <li><a href="pregledOglasa.php">Oglasi</a></li>
                <li><a href="moderator.php">Moderator</a></li>
                <li><a href="admin.php">Admin</a></li>
                <li><a href="registracija.php">Registracija</a></li>
                <li><a href="prijava.php">Prijava</a></li>
            </ul>
        </nav>
        <section id="prijava">
            <fieldset id='prijava1'>
                <legend>Prijava</legend>
                <form method='post' name='prijava'>
                    <p>
                        <label for='korime'>Korisničko ime: </label>
                        <?php
                        $korisnik = "";
                        if (isset($_COOKIE["korisnik"])) {
                            $korisnik = $_COOKIE["korisnik"];
                        }

                        if ($korisnik == "") {
                            echo "<input type='text' id='korime' name='korime' size='20' maxlength='20' placeholder='Unesi korisničko ime..' required='required'><br>";
                        } else {
                            echo "<input type='text' id='korime' name='korime' size='20' maxlength='20' placeholder='Unesi korisničko ime..' required='required' value=$korisnik><br>";
                        }
                        ?>

                        <label for='lozinka'>Lozinka: </label>
                        <input type='password' id='lozinka' name='lozinka_prijava' size='20' maxlength='20' placeholder='Upiši lozinku..' required='required'><br>
                        <input type='submit' name='prijavaSEND' value=' Prijavi se '><a href="zaboravljena.php">Zaboravljena lozinka?</a><br>
                    </p>
                </form>
            </fieldset>
        </section>
        <footer>
            <a href="https://jigsaw.w3.org/css-validator/check/referer"><img src="slike/CSS3.png" alt="CSS3 ikona"></a>
            <a href="https://validator.w3.org/check?uri=referer"><img id="html" src="slike/HTML5.png" alt="HTML5 ikona"></a>
        </footer>
    </body>
</html>

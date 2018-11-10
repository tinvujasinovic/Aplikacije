<?php
require './baza.class.php';
require './dnevnik.php';
require './sesija.class.php';
$baza = new Baza();
$greske = array();
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $ime = $_POST["ime"];
    $prezime = $_POST["prezime"];
    $korime = $_POST["korisnicko_ime"];
    $email = $_POST["email"];
    $lozinka = $_POST["lozinka"];
    $lozinka_ponovo = $_POST["ponovljena_lozinka"];
    if ($ime == "" || $prezime == "" || $email == "" || $korime == "" || $lozinka == "" || $lozinka_ponovo == "") {
        $greske[] = "Nisu ispunjena sva polja!";
    } else {
        if (!ctype_upper($ime[0])) {
            $greske[] = "Ime mora početi velikim slovom!";
        }
        if (!ctype_upper($prezime[0])) {
            $greske[] = "Prezime mora početi velikim slovom!";
        }
        if (strlen($korime) < 5) {
            $greske[] = "Korisnicko ime mora imati barem 5 slova!";
        }
        if ($lozinka !== $lozinka_ponovo) {
            $greske[] = "Lozinke se ne podudaraju!";
        }
        if (strlen($lozinka) < 8) {
            $greske[] = "Lozinka mora sadrzavati barem 8 znakova!";
        }
        if (isset($email)) {
            $match = preg_match("/(?=^.{10,30}$)([a-zA-Z\d*])+(\.?)([a-zA-Z\d*])*@{1}([a-zA-z\d*])+(\.){1}([a-zA-Z\d*]){2,}/", $email);
            if ($match === 0) {
                $greske[] = "Pogrešan format emaila!";
            }
        }
    }
    foreach ($greske as $val) {
        echo "<p style='color:red'>$val<br></p>";
    }

    if (empty($greske)) {
        $baza->spojiSe();
        $salt = "125bjdfk3248fks";
        $lozinkaKript = sha1($lozinka . $salt);
        $token = md5(uniqid($korime, true));
        $sqlUpit3 = "INSERT INTO korisnik (username,lozinka,lozinka_kript,ime,prezime,email,uloga_id,token,timestamp_stvaranja) VALUES ('" . $korime . "','" . $lozinka . "','" . $lozinkaKript . "','" . $ime . "','" . $prezime . "','" . $email . "','" . 3 . "','" . $token . "','" . date("Y-m-d H:i:s") . "')";
        $baza->upit($sqlUpit3);
        $sati = "select trajanje_emaila from konfiguracija";
        $satiRez = $baza->select($sati);
        $trajanje = $satiRez[0]["trajanje_emaila"];
        $baza->zatvori();

        $poruka = "<html><head></head><body style='font-size:24px; text-align:center; border: 2px solid;'><p style='padding: 2 2 2 2;'>Ovo je aktivacijski mail za aplikaciju Provjera znanja!<br> Klikom na ovaj link aktivirat će se Vaš račun!<br> Link:<a href='http://barka.foi.hr/WebDiP/2017_projekti/WebDiP2017x155/Provjera_znanja/aktiviraj.php?token=$token'>$token</a></p><p style='font-size:12px'>(Ovaj link ističe za $trajanje h!)</body></html>";
        $headers = "MIME-Version: 1.0" . "\r\n";
        $headers .= "Content-type:text/html;charset=UTF-8" . "\r\n";
        $headers .= 'From: Provjera.znanja' . "\r\n";
        mail($email, "Aktivacija", $poruka, $headers);
        DnevnikDodajAnonimno($korime, "Registracija korisnika");
        header("Location:prijava.php");
    }
}
?>
<!DOCTYPE html>
<html lang="hr">
    <head>
        <title>Liverpool FC</title>
        <meta charset="utf-8">
        <script src='https://www.google.com/recaptcha/api.js'></script>
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
    <body onload="Dogadaji();">
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
        <section >
            <fieldset id='registracija' >
                <legend>Registracija</legend>
                <form method='post' name='registracija' id="regForma" action="">
                    <p>
                        <label class='labela' for='ime'>Ime: </label>
                        <input type='text' id='ime' name='ime' size='20' maxlength='30' placeholder='Upiši ime..'><br>
                        <label class='labela' for='prezime'>Prezime: </label>
                        <input type='text' id='prezime' name='prezime' size='20' maxlength='50' placeholder='Upiši prezime..'><br>
                        <label class='labela' for='korime_reg'>Korisničko ime: </label>
                        <input type='text' id='korime_reg' name='korisnicko_ime' size='20' maxlength='20' placeholder='Upiši korisničko ime..' ><br>                
                        <label class='labela' for='email'>Email: </label>
                        <input type='email' id='email' name='email' size='20' placeholder='id@poslužitelj.domena'><br>
                        <label class='labela' for='lozinka_reg1'>Lozinka: </label>
                        <input type='password' id='lozinka_reg1' name='lozinka' size='20' placeholder='Upiši lozinku..'><br>
                        <label class='labela' for='lozinka_reg2'>Ponovi lozinku: </label>
                        <input type='password' id='lozinka_reg2' name='ponovljena_lozinka' size='20' placeholder='Ponovi lozinku..' ><br>
                    <div class="g-recaptcha" data-sitekey="6Lc1uFsUAAAAAM6jvWTKWt2jpLSXFJiyf479opMu"></div>
                    <input type='submit' name='regSEND' value=' Registriraj se' id="regBtn">
                    <a href='prijavaRegistracija.php?mod=prijava'>Prijava</a><br>
                    </p>
                </form>
            </fieldset>
        </section>
        <footer>
            <a href="http://jigsaw.w3.org/css-validator/check/referer"><img src="slike/CSS3.png" alt="CSS3 ikona"></a>
            <a href="http://validator.w3.org/check?uri=referer"><img id="html" src="slike/HTML5.png" alt="HTML5 ikona"></a>
        </footer>
    </body>
</html>


<?php
require './baza.class.php';


if ($_SERVER["REQUEST_METHOD"] == "POST") {
    require './dnevnik.php';
    require './sesija.class.php';
    $korisnicko = $_POST["korimeZab"];
    $baza = new Baza();
    $baza->spojiSe();
    $sqlEmail = "select email from korisnik where username='$korisnicko'";
    $rezultatEmail = $baza->select($sqlEmail);
    $email = $rezultatEmail[0]["email"];
    $lozinka = str_shuffle(bin2hex(openssl_random_pseudo_bytes(4)));
    $salt = "125bjdfk3248fks";
    $lozinka_kript = sha1($lozinka . $salt);
    $insert = "update korisnik set lozinka='$lozinka',lozinka_kript='$lozinka_kript' where username='$korisnicko'";
    echo $baza->upit($insert);
    $poruka = "<html><head></head><body style='font-size:24px; text-align:center; border: 2px solid;'><p style='padding: 2 2 2 2;'>Korisničko ime: <b>$korisnicko</b> <br> Vaša nova lozinka je: <b>$lozinka</b></body></html>";
    $headers = "MIME-Version: 1.0" . "\r\n";
    $headers .= "Content-type:text/html;charset=UTF-8" . "\r\n";
    $headers .= 'From: Provjera.znanja' . "\r\n";
    mail($email, "Password reset", $poruka, $headers);
    DnevnikDodaj("Reset lozinke");
    $baza->zatvori();
    header("Location:prijava.php");
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
        <script src="tinvujasi_javascript.js" type="text/javascript"></script>
        <script src="tinvujasi_jquery.js" type="text/javascript"></script>
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
                <legend>Zaboravljena lozinka</legend>
                <form method='post' name='zaboravljena'>
                    <p>
                        <label for='korime'>Korisničko ime: </label>
                        <input type='text' id='korimeZab' name='korimeZab' size='20' maxlength='20' placeholder='Unesi korisničko ime..' required='required'><br>
                        <input type='submit' name='prijavaSEND' value=' Resetiraj lozinku '>
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
<?php
require './sesija.class.php';
if (!empty($_COOKIE["sesija"])) {
    $korisnik = Sesija::dajKorisnika();
    if ($korisnik["tip"] == 2 || $korisnik["tip"] == 3 || $korisnik["tip"] == 4) {
        header("Location: index.php");
    }
} else {
    header("Location: index.php");
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
        <section>
            <fieldset>
                <legend>Administracija</legend>
                <form method='post' name='administrator'>
                    <input class='kreiranje' type='button' id="blokiranje" value="Blokiranje korisnika">
                    <input class='kreiranje' type='button' id="deblokiranje" value="Deblokiranje korisnika">
                    <input class='kreiranje' type='button' id="dnevnik" value="Dnevnik">
                    <input class='kreiranje' type='button' id="konfiguracija" value="Konfiguracija sustava">
                </form>
                <div id="admin"></div>
            </fieldset>
        </section>
        <footer>
            <a href="https://jigsaw.w3.org/css-validator/check/referer"><img src="slike/CSS3.png" alt="CSS3 ikona"></a>
            <a href="https://validator.w3.org/check?uri=referer"><img id="html" src="slike/HTML5.png" alt="HTML5 ikona"></a>
        </footer>
    </body>
</html>

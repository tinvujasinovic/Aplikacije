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
        <section id="indeks">
            
            <div>
                <h2>Dobro došli na stranicu Provjera znanja!</h2>
                <p>
                    Ovdje možete provjeriti svoje znanje iz raznih kategorija i natjecati se s drugim igračima!<br>
                    Odaberite kategoriju u kojoj se želite natjecati, odgovorite točno na što više pitanja i usporedite svoje znanje s ostalima!
                </p>

                <div class="ad" id="poz7">
                    <span class="span" id='span7'></span>
                    <a id="link7"><img id="img7"></a>
                </div>
                <?php
                require './sesija.class.php';
                if (!empty($_COOKIE["sesija"])) {
                    $korisnik = Sesija::dajKorisnika();
                    if ($korisnik["tip"] == 1 || $korisnik["tip"] == 3 || $korisnik["tip"] == 4) {
                        echo '<a href="" id="blokiraj7">Blokiraj</a>';
                    }
                }
                ?>

            </div>
        </section>
        <footer>
            <a href="http://validator.w3.org/check?uri=referer"><img id="html" src="slike/HTML5.png" alt="HTML5 ikona"></a>
            <a href="http://jigsaw.w3.org/css-validator/check/referer"><img src="slike/CSS3.png" alt="CSS3 ikona"></a>
            <a href="o_autoru.html"><img id="o_autoru" src="slike/profilna.jpeg" alt="profilna"></a><a href="o_autoru.html" id="info">O autoru</a><br>
            <a href="dokumentacija.html" id="info1">Dokumentacija</a>

        </footer>
    </body>
</html>

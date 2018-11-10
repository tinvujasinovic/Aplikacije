<?php
error_reporting(0);
require './baza.class.php';
$baza = new Baza();
$baza->spojiSe();
require './sesija.class.php';
if (!empty($_COOKIE["sesija"])) {
    $korisnik = Sesija::dajKorisnika();
    if ($korisnik["tip"] == 2) {
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
        <section id="pregledOglasa">
            <fieldset>
                <legend>Pregled mojih zahtjeva</legend>
                <a id="kreirajNovi" href='kreiranjeOglasa.php'>Kreiraj novi oglas</a><br>
                <?php
                $dohvatKorisnika = "select * from korisnik where username='" . $korisnik['korisnik'] . "'";
                $podaciKorisnika = $baza->select($dohvatKorisnika);

                $dohvatiOglaseKorisnika = "select * from zahtjev where korisnik_id=" . $podaciKorisnika[0]['korisnik_id']. " and vrsta='k'";
                $oglasiKorisnika = $baza->select($dohvatiOglaseKorisnika);
                $j = 0;
                foreach ($oglasiKorisnika as $value) {
                    $dohvatPodatakaOglasa = "select * from oglas where oglas_id=" . $oglasiKorisnika[$j]['oglas_id'];
                    $podaciOglasi[] = $baza->select($dohvatPodatakaOglasa);
                    $j++;
                }
                $i = 0;
                foreach ($podaciOglasi as $value) {
                    echo '<div class="oglas"><img class="slikaOglas" src=slike/' . $podaciOglasi[$i][0]['slika'] .
                    "><br>";
                    if($podaciOglasi[$i][0]['status']!='o' && $podaciOglasi[$i][0]['status']!='p'){
                        echo "<label class='uredi'>Uredi</label>";
                    }
                    $i++;
                    echo "</div>";
                }
                ?>
                <br>
                <div id="ads2">
                    <p style='text-align: center; font-size: 22px; font-weight:bold;'><b>Oglasi</b>
                    </p>
                    <div class="ad" id="poz4">
                        <span class="span" id='span4'></span>
                        <a id="link4"><img id="img4"></a>
                    </div>
                    <?php

                    if (!empty($_COOKIE["sesija"])) {
                        $korisnik = Sesija::dajKorisnika();
                        if ($korisnik["tip"] == 1 || $korisnik["tip"] == 3 || $korisnik["tip"] == 4) {
                            echo '<a href="" id="blokiraj4">Blokiraj</a>';
                        }
                    }
                    ?>
                    <div class="ad" id="poz5">
                        <span class="span" id='span5'></span>
                        <a id="link5"><img id="img5"></a>
                    </div>
                    <?php
                    if (!empty($_COOKIE["sesija"])) {
                        $korisnik = Sesija::dajKorisnika();
                        if ($korisnik["tip"] == 1 || $korisnik["tip"] == 3 || $korisnik["tip"] == 4) {
                            echo '<a href="" id="blokiraj5">Blokiraj</a>';
                        }
                    }
                    ?>
                    <div class="ad" id="poz6">
                        <span class="span" id='span6'></span>
                        <a id="link6"><img id="img6"></a>
                    </div>
                    <?php
                    if (!empty($_COOKIE["sesija"])) {
                        $korisnik = Sesija::dajKorisnika();
                        if ($korisnik["tip"] == 1 || $korisnik["tip"] == 3 || $korisnik["tip"] == 4) {
                            echo '<a href="" id="blokiraj6">Blokiraj</a>';
                        }
                    }
                    ?>
                </div>
                </div>
            </fieldset>
        </section>
        <footer>
            <a href="http://validator.w3.org/check?uri=referer"><img id="html" src="slike/HTML5.png" alt="HTML5 ikona"></a>
            <a href="http://jigsaw.w3.org/css-validator/check/referer"><img src="slike/CSS3.png" alt="CSS3 ikona"></a>
            <a href="o_autoru.html"><img id="o_autoru" src="slike/profilna.jpeg" alt="profilna"></a><a href="o_autoru.html" id="info">O autoru</a><br>
            <a href="dokumentacija.html" id="info1">Dokumentacija</a>

        </footer>
    </body>
</html>

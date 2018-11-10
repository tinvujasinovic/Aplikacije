<?php
require './sesija.class.php';
require './dnevnik.php';
if (!empty($_COOKIE["sesija"])) {
    $korisnik = Sesija::dajKorisnika();
    if ($korisnik["tip"] < 1) {
        header("Location: index.php");
    }
}
if (isset($_GET['url'])) {
    setcookie("url",$_GET['url']);
}

if (isset($_GET["spremi"])) {
    require './baza.class.php';
    $link = $_COOKIE['url'];
    setcookie("url","",-3600);
    $baza = new Baza();
    $baza->spojiSe();
    $dohvatOglasId = "select oglas_id from oglas where url='" . $link . "'";
    $oglasID = $baza->select($dohvatOglasId);
    $oglas_id = $oglasID[0][0];
    $korime = $korisnik["korisnik"];
    $dohvatKorisnikId = "select korisnik_id from korisnik where username='" . $korime . "'";
    $korisnikID = $baza->select($dohvatKorisnikId);
    $id_korisnik = $korisnikID[0][0];
    $razlog = $_GET["razlog"];
    DnevnikDodaj("Zahtjev za blokiranjem oglasa");
    $upis = "insert into zahtjev (vrsta,razlog,korisnik_id,oglas_id,status) values ('b','".$razlog."',".$id_korisnik.",".$oglas_id.",'na čekanju')";
    $baza->upit($upis);
    $baza->zatvori();
    header("Location: pregledOglasa.php");
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
        <section id="blokiraj">
            <div>
                <form method="get">
                    <label class="labela">Razloga blokiranja oglasa</label><br> 
                    <textarea name="razlog" placeholder="Upisi razlog blokiranja.." rows="10" cols="50" required    ></textarea><br>
                    <input type="submit" value="Spremi" name="spremi">
                </form>
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

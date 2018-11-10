<?php
require './sesija.class.php';
require './baza.class.php';
require './dnevnik.php';
$baza = new Baza();
$baza->spojiSe();

if (!empty($_COOKIE["sesija"])) {
    $korisnik = Sesija::dajKorisnika();
    if ($korisnik["tip"] == 2) {
        header("Location: index.php");
    }
} else {
    header("Location: index.php");
}

if (isset($_POST['spremi'])) {
    $greske = array();
    $naziv = $_POST['naziv'];
    $opis = $_POST['opis'];
    $url = $_POST['url'];
    $slika = $_FILES['datoteka']['name'];
    $aktivanOd = $_POST['aktivanOd'];
    $vrsta = $_POST['vrsta'];


    $regSlika = preg_match("/([^\s]+(\.(jpg|png|JPG|PNG))$)/", $slika);
    if ($regSlika === 0) {
        $greske[] = "Pogrešan format slike!";
    }
    foreach ($greske as $value) {
        echo $value . "<br>";
    }

    if (empty($greske)) {
        $dohvatiIDvrste = "select vrsta_id, trajanje_prikaza from vrsta_oglasa where naziv_vrste='" . $vrsta . "'";
        $vrstaIDUpit = $baza->select($dohvatiIDvrste);
        $vrstaID = $vrstaIDUpit[0]['vrsta_id'];
        $trajanje = $vrstaIDUpit[0]['trajanje_prikaza'];
        $dohvatiKorisnikID = "select korisnik_id from korisnik where username='" . $korisnik["korisnik"] . "'";
        $korisnikIDrezultat = $baza->select($dohvatiKorisnikID);
        $korisnikID = $korisnikIDrezultat[0][0];

        $datum = new DateTime($aktivanOd);
        $datum->add(DateInterval::createFromDateString('' . $trajanje . ' hours'));

        $o = new ReflectionObject($datum);
        $p = $o->getProperty('date');
        $datum_plus_trajanje = $p->getValue($datum);

        $insertOglasa = "insert into oglas (naziv,opis,url,slika,aktivan_od,aktivan_do,broj_klikova,korisnik_id,vrsta_id,status) value ('" . $naziv . "','" . $opis . "','" . $url . "','" . $slika . "','" . $aktivanOd . "','" . $datum_plus_trajanje . "',0," . $korisnikID . "," . $vrstaID . ",'n')";
        $baza->upit($insertOglasa);

        $userfile = $_FILES["datoteka"]["tmp_name"];
        $userfile_name = $_FILES["datoteka"]["name"];
        $userfile_size = $_FILES["datoteka"]["size"];
        $userfile_type = $_FILES["datoteka"]["type"];
        $userfile_error = $_FILES["datoteka"]["error"];

        if ($userfile_error > 0) {
            echo 'Problem: ';
            switch ($userfile_error) {
                case 1: echo 'Veličina veća od ' . ini_get('upload_max_filesize');
                    break;
                case 2: echo 'Veličina veća od ' . $_POST["MAX_FILE_SIZE"] . 'B';
                    break;
                case 3: echo 'Datoteka djelomično prenesena';
                    break;
                case 4: echo 'Datoteka nije prenesena';
                    break;
            }
            exit;
        }

        $upfile = 'slike/' . $userfile_name;

        if (is_uploaded_file($userfile)) {
            if (!move_uploaded_file($userfile, $upfile)) {
                echo 'Problem: nije moguće prenijeti datoteku na odredište';
                exit;
            }
        } else {
            echo 'Problem: mogući napad prijenosom. Datoteka: ' . $userfile_name;
            exit;
        }

        $dohvatOglasID= "select oglas_id from oglas where naziv='".$naziv."'";
        $oglasIDrezultat = $baza->select($dohvatOglasID);
        $oglasID = $oglasIDrezultat[0][0];
        
        $insertZahtjev = "insert into zahtjev (vrsta,korisnik_id,oglas_id) values ('k',".$korisnikID.",".$oglasID.")";
        $baza->upit($insertZahtjev);
        DnevnikDodaj("Kreiran novi oglas $naziv");
        header("Location:pregledOglasa.php");
    }
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
        <section id="kreiranje">
            <div>
                <fieldset>
                    <legend>Kreiranje zahtjeva za oglas</legend>
                    <h2>Pregled vrsta oglasa</h2>
                    <?php
                    $upit = "select * from vrsta_oglasa";
                    $vrsteOglasa = $baza->select($upit);
                    $listaVrste = array();
                    $i = 0;
                    echo "<table><tr><th>Naziv</th><th>Trajanje prikaza</th><th>Brzina izmjene</th><th>Cijena</th></tr>";
                    foreach ($vrsteOglasa as $value) {
                        echo "<tr><td>" . $vrsteOglasa[$i]['naziv_vrste'] . "</td><td>" . $vrsteOglasa[$i]['trajanje_prikaza'] . "</td><td>" . $vrsteOglasa[$i]['brzina_izmjene'] . "</td><td>" . $vrsteOglasa[$i]['cijena'] . "</td></tr>";
                        $listaVrste[] = $vrsteOglasa[$i]['naziv_vrste'];
                        $i++;
                    }
                    echo "</table>";
                    ?>
                    <fieldset>
                        <legend>Unesi podatke o novom oglasu</legend>
                        <div>
                            <form class="obr" id="test" enctype="multipart/form-data" method="post">
                                <?php
                                $j = 0;
                                $opcije = "";
                                foreach ($listaVrste as $value) {
                                    $opcije .= "<option value='$listaVrste[$j]'>$listaVrste[$j]</option>";
                                    $j++;
                                }
                                echo "<label class='labela'>Vrsta oglasa</label><select class='select' required name='vrsta'>" . $opcije . "</select>";
                                ?>
                                <br><label class='labela'>Naziv</label><input type="text" name="naziv" required><br>
                                <label class='labela'>Opis</label><input type="text" name="opis" required><br>
                                <label class='labela'>Url</label><input type="text" name="url" required><br>
                                <label class='labela'>Slika</label><input type='file' name='datoteka' id='datoteka' required><br>
                                <label class="labela">Aktivan od</label><input type="date" name='aktivanOd' required><br>
                                <input type="submit" value="Kreiraj" name="spremi"><br><br>
                            </form>
                        </div>
                    </fieldset>
                </fieldset>
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

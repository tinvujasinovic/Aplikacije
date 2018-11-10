<!DOCTYPE html>
<html lang="hr">
    <head>
        <title>Liverpool FC</title>
        <meta charset="UTF-8">
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
            error_reporting(0);
            require './dnevnik.php';
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
        <section id="kategorije">
            <h2>Natjecanja iz znanja o pojedinim kategorijama</h2>
            <fieldset>
                <legend>Kategorije natjecanja</legend>
                <form method='post' name='prijava'>
                    <div id="ads">
                        <p style='text-align: center; font-size: 22px; font-weight:bold;'><b>Oglasi</b>
                        </p>
                        <div class="ad" id="poz1">
                            <span class="span" id='span1'></span>
                            <a id="link1"><img id="img1"></a>
                        </div>
                        <?php
                        require './sesija.class.php';
                        if (!empty($_COOKIE["sesija"])) {
                            $korisnik = Sesija::dajKorisnika();
                            if ($korisnik["tip"] == 1 || $korisnik["tip"] == 3 || $korisnik["tip"] == 4) {
                                echo '<a href="" id="blokiraj1">Blokiraj</a>';
                            }
                        }
                        ?>
                        <div class="ad" id="poz2">
                            <span class="span" id='span2'></span>
                            <a id="link2"><img id="img2"></a>
                        </div>
                        <?php
                        if (!empty($_COOKIE["sesija"])) {
                            $korisnik = Sesija::dajKorisnika();
                            if ($korisnik["tip"] == 1 || $korisnik["tip"] == 3 || $korisnik["tip"] == 4) {
                                echo '<a href="" id="blokiraj2">Blokiraj</a>';
                            }
                        }
                        ?>
                        <div class="ad" id="poz3">
                            <span class="span" id='span3'></span>
                            <a id="link3"><img id="img3"></a>
                        </div>
                        <?php
                        if (!empty($_COOKIE["sesija"])) {
                            $korisnik = Sesija::dajKorisnika();
                            if ($korisnik["tip"] == 1 || $korisnik["tip"] == 3 || $korisnik["tip"] == 4) {
                                echo '<a href="" id="blokiraj3">Blokiraj</a>';
                            }
                        }
                        ?>
                    </div>
                    <?php
                    require './baza.class.php';
                    $baza = new Baza();
                    $baza->spojiSe();
                    if ($_SERVER["REQUEST_METHOD"] != "POST") {
                        $dohvat = "select naziv from kategorija";
                        $kategorije = $baza->select($dohvat);
                        $i = 0;
                        echo "<label class='labela'>Odaberi kategoriju natjecanja</label><br>";
                        echo '<select name="kategorija" id="select">';
                        foreach ($kategorije as $value) {
                            echo '<option value=' . $kategorije[$i]["naziv"] . '>' . $kategorije[$i]["naziv"] . '</option>';
                            $i++;
                        }
                        echo '</select>';
                        echo "<input type='submit' name='odabirKategorije' id='odabirKat' value='Odaberi'><br><br>";
                        echo "<label class='labela'>Pregled prošlih natjecanja</label>";
                        $ima = FALSE;
                        $dohvatiNatjecanja = "select * from natjecanje";
                        $svaNatjecanja = $baza->select($dohvatiNatjecanja);
                        $q = 0;
                        foreach ($svaNatjecanja as $value) {

                            if (date($svaNatjecanja[$q]["dostupno_do"]) < date("Y-m-d")) {
                                echo "<table><tr><th>Natjecanje</th><th>Nadimak</th><th>Rezultat</th><th>Trajanje</th></tr>";
                                $ima = TRUE;
                                $idNatjecanja = $svaNatjecanja[$q]["natjecanje_id"];
                                $nazivNatjecanja = $svaNatjecanja[$q]["naziv"];



                                $dohvatNatjecatelja = "select nadimak, rezultat, pocetak, zavrsetak from sudjeluje where natjecanje_id=" . $idNatjecanja;
                                $natjecatelj = $baza->select($dohvatNatjecatelja);
                                $r = 0;
                                foreach ($natjecatelj as $value) {
                                    $nadimak = $natjecatelj[$r]["nadimak"];
                                    $rezultat = $natjecatelj[$r]["rezultat"];
                                    $pocetak = new DateTime($natjecatelj[$r]["pocetak"]);
                                    $zavrsetak = new DateTime($natjecatelj[$r]["zavrsetak"]);
                                    $trajanje = date_diff($zavrsetak, $pocetak);
                                    $ukupnoTrajanje = ($trajanje->h * 3600) + ($trajanje->i * 60) + $trajanje->s;

                                    echo "<tr><td>$nazivNatjecanja</td><td>$nadimak</td><td>$rezultat</td><td> $ukupnoTrajanje sec</td></tr>";
                                    $r++;
                                }
                                echo "</table>";
                            }
                            $q++;
                        }
                        if (!$ima) {
                            echo "<br><label style='color:red;' class='labela'>Nema prošlih natjecanja!</label>";
                        } else {
                            echo "<input class='input' type='text' name='unosNadimak' placeholder='Unesi nadimak..'><input class='input' type='submit' name='pretraziNadimak' value='Pretrazi'>";
                        }
                    } else if (isset($_POST["pretraziNadimak"])) {
                        $nadimak = $_POST["unosNadimak"];
                        $dohvatiNatjecanja = "select * from natjecanje";
                        $svaNatjecanja = $baza->select($dohvatiNatjecanja);
                        DnevnikDodaj("Pretrazivanje natjecanja korisnika: " . $nadimak);
                        $q = 0;
                        foreach ($svaNatjecanja as $value) {

                            if (date($svaNatjecanja[$q]["dostupno_do"]) < date("Y-m-d")) {
                                echo "<table><tr><th>Natjecanje</th><th>Nadimak</th><th>Rezultat</th><th>Trajanje</th></tr>";
                                $ima = TRUE;
                                $idNatjecanja = $svaNatjecanja[$q]["natjecanje_id"];
                                $nazivNatjecanja = $svaNatjecanja[$q]["naziv"];



                                $dohvatNatjecatelja = "select nadimak, rezultat, pocetak, zavrsetak from sudjeluje where natjecanje_id=" . $idNatjecanja . " and nadimak='" . $nadimak . "'";
                                $natjecatelj = $baza->select($dohvatNatjecatelja);
                                $r = 0;
                                foreach ($natjecatelj as $value) {
                                    $nadimak = $natjecatelj[$r]["nadimak"];
                                    $rezultat = $natjecatelj[$r]["rezultat"];
                                    $pocetak = new DateTime($natjecatelj[$r]["pocetak"]);
                                    $zavrsetak = new DateTime($natjecatelj[$r]["zavrsetak"]);
                                    $trajanje = date_diff($zavrsetak, $pocetak);
                                    $ukupnoTrajanje = ($trajanje->h * 3600) + ($trajanje->i * 60) + $trajanje->s;

                                    echo "<tr><td>$nazivNatjecanja</td><td>$nadimak</td><td>$rezultat</td><td> $ukupnoTrajanje sec</td></tr>";
                                    $r++;
                                }
                                echo "</table>";
                            }

                            $q++;
                        }
                        echo "<a style='font-size:22px; margin-left:3%;' href='natjecanja.php'>Povratak</a>";
                    } else {
                        $odabrana = $_POST["kategorija"];

                        $dohvatID = "Select kategorija_id from kategorija where naziv='$odabrana'";
                        $rezKatergorije = $baza->select($dohvatID);

                        $odabranaID = $rezKatergorije[0]["kategorija_id"];

                        $dohvatNatjecanja = "select naziv,opis,dostupno_od,dostupno_do,broj_korisnika,natjecanje_id from natjecanje where kategorija_id=$odabranaID order by dostupno_do";
                        $natjecanja = $baza->select($dohvatNatjecanja);
                        if (isset($_POST["odabirKategorije"])) {
                            if (empty($natjecanja)) {
                                echo "<br>Nema natjecanja u ovoj kategoriji!<br><a href='natjecanja.php'>Povratak</a>";
                            } else {
                                echo "<div id='kategorijaOdabrane'>";
                                echo "<h2>Odaberi natjecanje</h2>";
                                $y = 0;
                                $ukupniBroj = array();
                                foreach ($natjecanja as $value) {
                                    $dohvatBrojKorisnika = "select count(*) from sudjeluje where natjecanje_id=" . $natjecanja[$y]["natjecanje_id"];
                                    $brojKorisnika = $baza->select($dohvatBrojKorisnika);
                                    $ukupniBroj[] = $brojKorisnika[0][0];
                                    $y++;
                                }
                                $j = 0;
                                foreach ($natjecanja as $value) {
                                    if (date($natjecanja[$j]["dostupno_od"]) <= date("Y-m-d") && date($natjecanja[$j]["dostupno_do"] >= date("Y-m-d")) && $natjecanja[$j]["broj_korisnika"] > $ukupniBroj[$j]) {
                                        echo '<input type="radio" value=' . $natjecanja[$j]["naziv"] . ' name="radio">&nbsp;&nbsp;<label class="labela">' . $natjecanja[$j]["naziv"] . ' - ' . $natjecanja[$j]["opis"] . '</label><br>';
                                    }
                                    $j++;
                                }
                                echo "<br><input type='submit' name='odabirNatjecanja' value='Odaberi natjecanje'>";

                                echo "</div>";
                            }
                        } else if (isset($_POST["odabirNatjecanja"])) {
                            $odabranoNatjecanje = $_POST["radio"];
                            
                            $pocetak = date("Y-m-d_H:i:s");
                            $dohvatiIDnatjecanja = "select natjecanje_id from natjecanje where naziv='" . $odabranoNatjecanje . "'";
                            $rezNatjecanja = $baza->select($dohvatiIDnatjecanja);
                            
                            $dohvatPitanja = "select pitanja_id from pitanja_za_natjecanje where natjecanje_id='" . $rezNatjecanja[0]["natjecanje_id"] . "'";
                            $rezPitanja = $baza->select($dohvatPitanja);
                            $dohvatiSveNadimke = "select nadimak from sudjeluje where natjecanje_id=" . $rezNatjecanja[0]["natjecanje_id"];
                            $sviNadimci = $baza->select($dohvatiSveNadimke);

                            $x = 0;
                            $fileNadimci = fopen("pomocne/nadimci.txt", "w") or die("Nisam mogao otvoriti datoteku!");
                            foreach ($sviNadimci as $value) {
                                $txt = $sviNadimci[$x][0] . "\n";
                                fwrite($fileNadimci, $txt);
                                $x++;
                            }

                            $l = 0;
                           
                            foreach ($rezPitanja as $value) {
                                $dohvatTekstaPitanja = "select pitanje from pitanja where pitanja_id=" . $rezPitanja[$l]['pitanja_id'];

                                $rezultatTekst[] = $baza->select($dohvatTekstaPitanja);
                                $l++;
                            }
                            
                            $k = 0;
                            $broj = 1;
                            echo '<br><br><br>';
                            foreach ($rezultatTekst as $value) {

                                echo '<div id="pitanje">';
                                echo '<label class="pitanja">Pitanje ' . $broj . '</label><br>';
                                echo "<label class='pitanja'> - " . $rezultatTekst[$k][0]["pitanje"] . "</label><br>";
                                $e = 0;
                                $dohvatOdgovora = "select tocan_odgovor,odgovor1,odgovor2,odgovor3,odgovor4 from pitanja where pitanja_id=" . $rezPitanja[$k]["pitanja_id"];
                                $rezultatOdgovori = $baza->select($dohvatOdgovora);
                                foreach ($rezultatOdgovori as $value) {
                                    echo "<input required class='btn' type='radio' name='pitanje" . $k . "' value=" . $rezultatOdgovori[$e]["odgovor1"] . "><label class='pitanja'>" . $rezultatOdgovori[$e]["odgovor1"] . "</label><br>";
                                    echo "<input required class='btn' type='radio' name='pitanje" . $k . "' value=" . $rezultatOdgovori[$e]["odgovor2"] . "><label class='pitanja'>" . $rezultatOdgovori[$e]["odgovor2"] . "</label><br>";
                                    echo "<input required class='btn' type='radio' name='pitanje" . $k . "' value=" . $rezultatOdgovori[$e]["odgovor3"] . "><label class='pitanja'>" . $rezultatOdgovori[$e]["odgovor3"] . "</label><br>";
                                    echo "<input required class='btn' type='radio' name='pitanje" . $k . "' value=" . $rezultatOdgovori[$e]["odgovor4"] . "><label class='pitanja'>" . $rezultatOdgovori[$e]["odgovor4"] . "</label><br>";
                                    $e++;
                                }
                                $k++;
                                $broj++;

                                echo "</div>";
                            }
                            echo "<label class='labela' for='nadimak'>Unesi nadimak</label><br>";
                            echo "<input type='text' name='nadimak' id='nadimak' required placeholder='Unesi nadimak..'>";
                            echo "<input id='predaj' type='submit' value='Predaj odgovore' name='predaj'>";

                            $h = 0;
                            foreach ($rezPitanja as $value) {
                                $dohvatTocnih = "select tocan_odgovor from pitanja where pitanja_id=" . $rezPitanja[$h]["pitanja_id"];
                                $rezTocni[] = $baza->select($dohvatTocnih);
                                $h++;
                            }
                            $m = 0;
                            $zaSpremiti = "";
                            foreach ($rezTocni as $value) {
                                $zaSpremiti .= $rezTocni[$m][0][0] . ";";
                                $m++;
                            }
                            echo "<input type='hidden' name='tocni' value=" . $zaSpremiti . ">";
                            echo "<input type='hidden' name='pocetak' value=" . $pocetak . ">";
                            echo "<input type='hidden' name='natjecanje_id' value=" . $rezNatjecanja[0]["natjecanje_id"] . ">";
                        }
                        if (isset($_POST["predaj"])) {
                            $bodovi = 0;

                            $tocni = $_POST["tocni"];
                            $tocniOdgovori = explode(";", $tocni);
                            $brojTocnih = count($tocniOdgovori);
                            for ($i = 0; $i < $brojTocnih - 1; $i++) {
                                $tocniArray[] = $tocniOdgovori[$i];
                            }
                            for ($j = 0; $j < $brojTocnih - 1; $j++) {
                                $odgovor = $_POST["pitanje$j"];
                                if ($odgovor == $tocniArray[$j]) {
                                    $bodovi++;
                                }
                            }
                            $natjecanjeID = $_POST["natjecanje_id"];
                            $pocetakKrivo = $_POST["pocetak"];
                            $pocetakArray = explode("_", $pocetakKrivo);
                            $pocetak = $pocetakArray[0] . " " . $pocetakArray[1];
                            $nadimak = $_POST["nadimak"];
                            $zavrsetak = date("Y-m-d H:i:s");

                            $maksBodovi = $brojTocnih - 1;
                            $provjeraNadimak = "select nadimak from sudjeluje where natjecanje_id=" . $natjecanjeID;
                            $nadimci = $baza->select($provjeraNadimak);
                            $o = 0;
                            $zauzetNadimak = FALSE;
                            foreach ($nadimci as $value) {
                                if ($nadimak == $nadimci[$o]["nadimak"]) {
                                    $zauzetNadimak = TRUE;
                                    break;
                                }
                                $o++;
                            }
                            if ($zauzetNadimak) {
                                echo "Ovaj nadimak je zauzet!";
                            } else {
                                $baza = new Baza();
                                $baza->spojiSe();
                                $insertSudjeluje = "insert into sudjeluje values ('" . $natjecanjeID . "','" . $pocetak . "','" . $nadimak . "','" . $bodovi . "','" . $zavrsetak . "')";
                                $baza->upit($insertSudjeluje);
                                DnevnikDodaj("Predani odgovori");
                                echo "<p style='font-size:22px; color: red; font-weight:bold;'>Ostvareni rezultat je $bodovi/$maksBodovi!</p>";
                                echo "<a href='natjecanja.php'>Povratak</a>";
                            }
                        }
                    }
                    ?>
                </form>
            </fieldset>
        </section>
        <footer>
            <a href="https://jigsaw.w3.org/css-validator/check/referer"><img src="slike/CSS3.png" alt="CSS3 ikona"></a>
            <a href="https://validator.w3.org/check?uri=referer"><img id="html" src="slike/HTML5.png" alt="HTML5 ikona"></a>
        </footer>
    </body>
</html>

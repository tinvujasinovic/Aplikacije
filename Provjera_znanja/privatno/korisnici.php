<?php

require '../baza.class.php';
$baza = new Baza();

$baza->spojiSe();

$sqlUpit = "SELECT korisnik.username, korisnik.lozinka, uloga.naziv from korisnik inner join uloga on korisnik.uloga_id=uloga.uloga_id";

$rezultat = $baza->select($sqlUpit);
echo '<head><meta charset="UTF-8"></head>';
echo "<table border=5 style='font-size:24px'>
            <tr>
            <th width='20%'>#</th>
                <th width='20%'>Korisničko ime</th>
                <th width='20%'>Lozinka</th>
                <th width='20%'>Uloga</th>
            </tr>";
$i = 0;
$broj = 1;
foreach ($rezultat as $value) {


    echo '<tr><td>'
    . $broj . '</td><td>'
    . $rezultat[$i]["username"] . '</td><td>'
    . $rezultat[$i]["lozinka"] . '</td><td>'
    . $rezultat[$i]["naziv"] . '</td></tr>';
    $i++;
    $broj++;
}
echo "</table>";
echo "<a href='../index.php'>Povratak</a>";

$baza->zatvori();
?>


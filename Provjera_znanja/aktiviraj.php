<?php

$token = $_GET["token"];
require './dnevnik.php';
require './baza.class.php';
require './sesija.class.php';

$baza = new Baza();

$baza->spojiSe();
$getTrajanje = "Select trajanje_emaila from konfiguracija";
$rezTrajanje = $baza->select($getTrajanje);
$trajanje = $rezTrajanje[0]["trajanje_emaila"];
$getDate = "select timestamp_stvaranja,username from korisnik where token ='$token'";
DnevnikDodajAnonimno($getDate[0]["username"], "Aktivacija računa(mail)");
$date = $baza->select($getDate);

$datumStvaranja = $date[0]["timestamp_stvaranja"];

$datum = new DateTime($datumStvaranja);
$datum->add(DateInterval::createFromDateString('' . $trajanje . ' hours'));

$o = new ReflectionObject($datum);
$p = $o->getProperty('date');
$datum_plus_trajanje = $p->getValue($datum);
$trenutniDate = date("Y-m-d H:i:s");

if ($trenutniDate > $datum_plus_trajanje) {

    echo '<html><head><meta charset="utf-8"></head><body style="font-size:20px;">Link za aktivaciju je istekao!</body></html>';
    echo "<a href='index.php'>Povratak</a>";
} else {
    $sqlInsert = "update korisnik set aktiviran='1', token='' where token='$token'";
    $baza->upit($sqlInsert);
    header("Location:prijava.php");
}
$baza->zatvori();
?>
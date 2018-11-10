<?php
require './dnevnik.php';
require './sesija.class.php';
echo "<head><meta charset='utf-8'></head>";
$listaPitanja = array();
for ($i = 0; $i < 20; $i++) {
    if (isset($_GET["pitanje$i"])) {
        $listaPitanja[]=$_GET["pitanje$i"];
    }else{
        break;
    }
}

$kategorija = $_GET['kategorija'];
$naziv = $_GET['naziv'];
$opis = $_GET['opis'];
$broj_korisnika = $_GET['broj_korisnika'];
$dostupno_od = $_GET['dostupno_od'];
$dostupno_do = $_GET['dostupno_do'];

require './baza.class.php';

$baza = new Baza();

$baza->spojiSe();
$dohvatKatID="select kategorija_id from kategorija where naziv='".$kategorija."'";
$rez = $baza->select($dohvatKatID);
$katID = $rez[0][0];

$insertNatjecanja = "insert into natjecanje (naziv,opis,dostupno_od,dostupno_do,broj_korisnika,kategorija_id) values ('".$naziv."','".$opis."','".$dostupno_od."','".$dostupno_do."','".$broj_korisnika."',".$katID.")";
$baza->upit($insertNatjecanja);

$select = "select natjecanje_id from natjecanje where naziv='".$naziv."'";
$rez2 = $baza->select($select);
$natID = $rez2[0][0];

$duljina = sizeof($listaPitanja);
$listaID = array();
for($i=0;$i<$duljina;$i++){
    $dohvatiIDpitanja = "select pitanja_id from pitanja where pitanje='".$listaPitanja[$i]."'";
     $rezultat = $baza->select($dohvatiIDpitanja);
    $listaID[] = $rezultat[0][0];
}

$duljinaID = sizeof($listaID);
for($j=0;$j<$duljinaID;$j++){
    $insertNaNatjecanje = "insert into pitanja_za_natjecanje values ('".$listaID[$j]."','".$natID."')";
     $baza->upit($insertNaNatjecanje);
}
DnevnikDodaj("Dodano natjecanje $naziv");
header("Location: natjecanja.php");


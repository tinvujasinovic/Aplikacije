<?php
require './dnevnik.php';
require './sesija.class.php';
$kategorija = $_GET['kategorija'];

$pitanje =  $_GET['pitanje'];
$odg1 =  $_GET['odg1'];
$odg2 =  $_GET['odg2'];
$odg3 =  $_GET['odg3'];
$odg4 =  $_GET['odg4'];
$tocan =  $_GET['tocan'];

require './baza.class.php';
$baza=new Baza();

$baza->spojiSe();

$selectKatID = "select kategorija_id from kategorija where naziv='".$kategorija."'";
$rez = $baza->select($selectKatID);

$katID = $rez[0][0];

$insert = "insert into pitanja (pitanje, tocan_odgovor, odgovor1,odgovor2,odgovor3,odgovor4,kategorija_id) values ('".$pitanje."','".$tocan."','".$odg1."','".$odg2."','".$odg3."','".$odg4."','".$katID."')";
$baza->upit($insert);
DnevnikDodaj("Dodano pitanje $pitanje");
header("Location: natjecanja.php");
$baza->zatvori();
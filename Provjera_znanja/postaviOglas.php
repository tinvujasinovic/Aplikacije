<?php
require './sesija.class.php';
require './baza.class.php';
require './dnevnik.php';

$baza= new Baza();
$baza->spojiSe();

$poz = $_GET['pozicija'];
$oglas = $_GET['oglas'];
$date = date("Y/m/d");

$insert1 = "insert into oglas_na_poziciji values ('".$poz."','".$oglas."','".$date."')";
$baza->upit($insert1);

$insert2 = "update oglas set status='p' where oglas_id='".$oglas."'";
$baza->upit($insert2);

DnevnikDodaj("oglas $oglas postavljen na poziciju $poz");
$baza->zatvori();

header("Location: moderator.php");
<?php
require './dnevnik.php';
require './sesija.class.php';
require './baza.class.php';
$baza=new Baza();
$baza->spojiSe();
$naziv = $_GET["naziv"];
$cijena = $_GET["cijena"];
$trajanje = $_GET["trajanje"];
$brzina = $_GET["brzina"];
$insertVrsta = "insert into vrsta_oglasa (naziv_vrste,trajanje_prikaza,brzina_izmjene,cijena) value ('".$naziv."','".$trajanje."','".$brzina."','".$cijena."')";
$baza->upit($insertVrsta);

$select = "select vrsta_id from vrsta_oglasa where naziv_vrste='".$naziv."'";
$vrstaID = $baza->select($select);

$vrsta = $vrstaID[0][0];
$pozicija = $_GET['pozicija'];

$insertPoz = "insert into vrsta_na_poziciji values (".$vrsta.",".$pozicija.")";
echo $baza->upit($insertPoz);
DnevnikDodaj("Dodana vrsta $naziv");
$baza->zatvori();

header("Location:pregledOglasa.php");
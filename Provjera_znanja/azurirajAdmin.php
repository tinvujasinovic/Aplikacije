<?php

require './sesija.class.php';
require './dnevnik.php';
require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();

$mail = $_GET['trajanje_maila'];
$kolacic = $_GET['trajanje_kolacica'];
$broj = $_GET['broj_neuspjesnih'];
$stranice = $_GET['stranicenje'];

$upit = "update konfiguracija set stranicenje='".$stranice."',trajanje_kolacica='".$kolacic."',broj_neuspjesnih='".$broj."',trajanje_emaila='".$mail."' where naziv='konfiguracija'";
$baza->upit($upit);

DnevnikDodaj("Ažurirana konfiguracija");

$baza->zatvori();
header("Locastion: admin.php");



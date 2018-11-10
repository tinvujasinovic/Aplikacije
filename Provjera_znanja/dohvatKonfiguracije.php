<?php

require './sesija.class.php';
require './dnevnik.php';
require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();

$upit = "select * from konfiguracija";
$rez = $baza->select($upit);

echo json_encode($rez);

$baza->zatvori();

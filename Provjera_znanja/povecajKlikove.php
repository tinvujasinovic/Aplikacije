<?php

require './dnevnik.php';
require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();

$broj = $_GET["broj"];
$oglas = $_GET["oglas"];

$insert = "update oglas set broj_klikova=" . $broj . " where url='" . $oglas . "'";
require './sesija.class.php';

$baza->upit($insert);
DnevnikDodaj("klik na oglas $oglas");
$baza->zatvori();


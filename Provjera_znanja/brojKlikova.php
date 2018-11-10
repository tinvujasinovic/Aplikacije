<?php
require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();
$link=$_GET["link"];

$upit = "select broj_klikova from oglas where url='".$link."'";
$brojKlikova = $baza->select($upit);

echo $brojKlikova[0][0];

$baza->zatvori();
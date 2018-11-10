<?php
require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();

$upit = "select naziv_vrste from vrsta_oglasa";
$vrste = $baza->select($upit);

echo json_encode($vrste);
$baza->zatvori();

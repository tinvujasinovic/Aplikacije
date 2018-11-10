<?php

require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();
$pozicija = $_GET["pozicija"];

$upit = "select * from vrsta_na_poziciji where pozicija_id='".$pozicija."'";
$vrsteNaPozicji = $baza->select($upit);

$k=0;
$poljeCijena = array();
foreach ($vrsteNaPozicji as $value) {
    $upit = "select cijena from vrsta_oglasa where vrsta_id='".$vrsteNaPozicji[$k][0]."'";
    $rezultat = $baza->select($upit);
    $poljeCijena[] = $rezultat[0]['cijena'];
    $k++;
}

echo json_encode(min($poljeCijena));
<?php

require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();

$select1 = "select pozicija_id from pozicija";
$rez = $baza->select($select1);

$select2 = "select oglas_id from oglas";
$rez2 = $baza->select($select2);

$array = array();

$array[] = $rez;
$array[] = $rez2;

echo json_encode($array);
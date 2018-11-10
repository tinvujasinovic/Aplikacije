<?php
require './baza.class.php';
$baza = new Baza();
$baza->spojiSe();

$select = " select naziv from kategorija";
$rez = $baza->select($select);

echo json_encode($rez);
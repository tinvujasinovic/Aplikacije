<?php

require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();
$upit = "select * from dnevnik";
$rez = $baza->select($upit);

echo json_encode($rez);

$baza->zatvori();


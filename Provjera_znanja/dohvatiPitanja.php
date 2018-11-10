<?php

require './baza.class.php';
$baza=new Baza();

$baza->spojiSe();

$kategorija = $_GET['kategorija'];

$upit = "select kategorija_id from kategorija where naziv='".$kategorija."'";
$rez = $baza->select($upit);

$select = "select pitanje from pitanja where kategorija_id='".$rez[0][0]."'";
$pitanja = $baza ->select($select);

echo json_encode($pitanja);
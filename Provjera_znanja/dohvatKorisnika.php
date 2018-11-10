<?php

require './baza.class.php';
$baza=new Baza();

$baza->spojiSe();

$select = "select username,status from korisnik";
$rez = $baza->select($select);

echo json_encode($rez);
$baza->zatvori();

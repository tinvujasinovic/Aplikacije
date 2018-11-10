<?php
require './baza.class.php';

$baza=new Baza();
$baza->spojiSe();

$upit = "select * from oglas where slika='".$_GET['slika']."'";
$podaci = $baza->select($upit);

echo json_encode($podaci);
$baza->zatvori();
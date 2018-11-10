<?php

require './baza.class.php';

$baza = new Baza();

$baza->spojiSe();
$korime=$_POST["korime_reg"];
$sqlUpit = "select username from korisnik where username='$korime'";

$rezultat  = $baza->select($sqlUpit);

if(empty($rezultat)){
    echo 0;
}else{
    echo 1;
}
$baza->zatvori();

<?php
require './sesija.class.php';
require './dnevnik.php';
require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();

$username=$_GET['username'];

$upit = "update korisnik set status=NULL where username='".$username."'";
$baza->select($upit);
DnevnikDodaj("deblokiran korisnik $username");
$baza->zatvori();

header("Location: admin.php");


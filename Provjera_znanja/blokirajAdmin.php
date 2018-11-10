<?php
require './sesija.class.php';
require './dnevnik.php';
require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();

$username=$_GET['username'];

$upit = "update korisnik set status='b' where username='".$username."'";
$baza->select($upit);
DnevnikDodaj("blokiran korisnik $username");
$baza->zatvori();

header("Location: admin.php");


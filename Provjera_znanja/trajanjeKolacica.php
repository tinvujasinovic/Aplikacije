<?php

require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();

$dohvatKolacica = "select trajanje_kolacica from konfiguracija where naziv='konfiguracija'";
$trajanje = $baza->select($dohvatKolacica);
$trajanjeKolacica = $trajanje[0][0];

echo $trajanjeKolacica;
$baza->zatvori();
?>


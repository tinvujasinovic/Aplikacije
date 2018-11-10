 <?php

require './baza.class.php';
$baza = new Baza();
$baza->spojiSe();

$pozicija = $_GET["pozicija"];

$sql = "SELECT * FROM oglas_na_poziciji WHERE pozicija_id=$pozicija";
$oglasiNaPozicji = $baza->select($sql);

$brojOglasa = sizeof($oglasiNaPozicji);

$dohvatiPoziciju = "select * from pozicija where pozicija_id=".$pozicija;
$pozcijaInfo = $baza->select($dohvatiPoziciju);

if ($brojOglasa == 1) {

    $dohvatiOglas = "select * from oglas where oglas_id=" . $oglasiNaPozicji[0][1];
    $oglas = $baza->select($dohvatiOglas);
    $oglas[]=$pozcijaInfo;
    echo json_encode($oglas);
} else {
    $i = 0;
    $oglasi = array();
    foreach ($oglasiNaPozicji as $value) {

        $dohvatiOglase = "select * from oglas where oglas_id=" . $oglasiNaPozicji[$i][1];
        $oglasi[] = $baza->select($dohvatiOglase);
        $i++;
    }
    
    $oglasi[]=$pozcijaInfo;
    echo json_encode($oglasi);
}
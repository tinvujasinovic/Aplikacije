<?php

$naziv = $_POST['nazivOglasa'];
$opis = $_POST['opisOglasa'];
$url = $_POST['urlOglasa'];
$aktivanOd = $_POST['datumOglasa'];
$vrsta = $_POST['vrsta'];
$slika = $_FILES['slikaOglasa']['name'];

require './baza.class.php';
$baza = new Baza();

$baza->spojiSe();

$dohvatiIDOglasa = "select oglas_id from oglas where naziv='".$naziv."'";
$idOglasa = $baza->select($dohvatiIDOglasa);

var_dump($idOglasa);

$dohvatiIDvrste = "select vrsta_id, trajanje_prikaza from vrsta_oglasa where naziv_vrste='" . $vrsta . "'";
$podaciVrsta = $baza->select($dohvatiIDvrste);



$vrstaID = $podaciVrsta[0]['vrsta_id'];
$trajanje = $podaciVrsta[0]['trajanje_prikaza'];

$datum = new DateTime($aktivanOd);
$datum->add(DateInterval::createFromDateString('' . $trajanje . ' hours'));

$o = new ReflectionObject($datum);
$p = $o->getProperty('date');
$datum_plus_trajanje = $p->getValue($datum);

$update = "update oglas set naziv='" . $naziv . "',opis='" . $opis . "',url='" . $url . "',slika='" . $slika . "',aktivan_od='"
        . $aktivanOd . "',vrsta_id=" . $vrstaID . ",aktivan_do='" . $datum_plus_trajanje . "' where oglas_id='" . $idOglasa[0][0]."'";

$baza->upit($update);

$userfile = $_FILES["slikaOglasa"]["tmp_name"];
$userfile_name = $_FILES["slikaOglasa"]["name"];
$userfile_size = $_FILES["slikaOglasa"]["size"];
$userfile_type = $_FILES["slikaOglasa"]["type"];
$userfile_error = $_FILES["slikaOglasa"]["error"];

if ($userfile_error > 0) {
    echo 'Problem: ';
    switch ($userfile_error) {
        case 1: echo 'Veličina veća od ' . ini_get('upload_max_filesize');
            break;
        case 2: echo 'Veličina veća od ' . $_POST["MAX_FILE_SIZE"] . 'B';
            break;
        case 3: echo 'Datoteka djelomično prenesena';
            break;
        case 4: echo 'Datoteka nije prenesena';
            break;
    }
    exit;
}

$upfile = 'slike/' . $userfile_name;

if (is_uploaded_file($userfile)) {
    if (!move_uploaded_file($userfile, $upfile)) {
        echo 'Problem: nije moguće prenijeti datoteku na odredište';
        exit;
    }
} else {
    echo 'Problem: mogući napad prijenosom. Datoteka: ' . $userfile_name;
    exit;
}

header("Location: pregledOglasa.php");
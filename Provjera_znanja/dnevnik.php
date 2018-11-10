<?php

function DnevnikDodaj($akcija) {
    global $baza;
    $korisnik=" ";

    if (isset($_COOKIE["sesija"])) {
        $ime = Sesija::dajKorisnika();
        $korisnik = $ime["korisnik"];
    }


    $baza->spojiSe();
    $insert = "INSERT into dnevnik (vrijeme_unosa,korisnik,akcija) values ('" . date("Y-m-d H:i:s") . "','" . $korisnik . "','" . $akcija . "')";

    $baza->upit($insert);


}

function DnevnikDodajAnonimno($korisnik, $akcija) {
    global $baza;

    $baza->spojiSe();
    $insert = "INSERT into dnevnik (vrijeme_unosa,korisnik,akcija) values ('" . date("Y-m-d H:i:s") . "','" . $korisnik . "','" . $akcija . "')";

    $baza->upit($insert);

}

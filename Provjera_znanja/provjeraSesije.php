<?php

session_name("session");
require './sesija.class.php';
require './baza.class.php';
require './dnevnik.php';
$mode = $_GET["mode"];
if (!empty($_COOKIE["sesija"])) {
    if ($mode == "Odjava") {
        $_SESSION = array();
        $baza = new Baza();
        DnevnikDodaj("Odjava sa sustava");
        if (ini_get("session.use_cookies")) {
            $params = session_get_cookie_params();
            setcookie(session_name(), '', time() - 42000, $params["path"], $params["domain"], $params["secure"], $params["httponly"]
            );
        }
        session_destroy();
        setcookie("sesija", "", time() - 3600);
        $baza->zatvori();
        header("Location: prijava.php");
    }
} else {
    if ($mode == "Prijava") {
        header("Location: prijava.php");
    }
}
$baza->zatvori();
?>

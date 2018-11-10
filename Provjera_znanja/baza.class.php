<?php

class Baza {

    private $link;

    public function spojiSe() {

        $this->link = mysqli_connect("localhost", "WebDiP2017x155", "admin_I396", "WebDiP2017x155");
        $this->link->set_charset("utf8");
    }

    public function zatvori() {

        mysqli_close($this->link);
    }

    public function select($upit) {
        $poljeRedova = array();

        $result = mysqli_query($this->link, $upit);

        if ($result->num_rows > 0) {
            while ($row = $result->fetch_array()) {
                $poljeRedova[] = $row;
            }
        }
        return $poljeRedova;
    }

    public function upit($upit) {

        $rezultat = mysqli_query($this->link, $upit);

        return $rezultat;
    }

}

?>
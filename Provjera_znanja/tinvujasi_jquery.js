$(document).ready(function () {
    $("#korime_reg").blur(function () {
        var korisnicko = $("#korime_reg").val();

        $.ajax({
            type: "post",
            url: "provjeraKorisnika.php",
            data: {'korime_reg': korisnicko},
            success: function (data) {
                if (data != 0) {
                    alert("Korisnik s tim imenom postoji!");
                    $("#korime_reg").val("");
                }
            }
        });
    });
    function getCookie(name) {
        var value = "; " + document.cookie;
        var parts = value.split("; " + name + "=");
        if (parts.length == 2)
            return parts.pop().split(";").shift();
    }

    var uvjeti = getCookie("uvjeti");
    $.ajax({
        url: 'trajanjeKolacica.php',
        dataType: 'text',
        success: function (data) {
            trajanjeKolacica = parseInt(data);
            if (uvjeti == null) {
                var timestamp = new Date();
                timestamp.setTime(timestamp.getTime() + (trajanjeKolacica * 24 * 60 * 60 * 1000));
                alert("Ova stranica sprema kolačiće kako bi se poboljšalo korisničlo iskustvo, pristikom na Ok prihvaćate uvjete korištenja!");
                var kolacic = "uvjeti=prihvaćeno; expires=" + timestamp;
                document.cookie = kolacic;
            }
        }
    });

    $("#nadimak").blur(function () {
        var nadimak = $("#nadimak").val();
        $.ajax({
            url: 'pomocne/nadimci.txt',
            type: 'GET',
            dataType: 'text',

            success: function (file) {
                var array = file.split("\n");
                var size = array.length;

                for (i = 0; i < size; i++) {
                    if (array[i] == nadimak) {
                        $("#predaj").prop('disabled', true);
                        alert("Ovaj nadimak je već zauzet!");
                        break;
                    } else {
                        $("#predaj").removeAttr("disabled");
                    }
                }
            }
        });
    });

    $.ajax({
        url: 'oglasi.php?pozicija=1',
        dataType: 'json',
        success: function (data) {
            var prazni = true;
            duljina1 = data.length - 1;
            visina1 = data[duljina1][0].visina;
            sirina1 = data[duljina1][0].sirina;
            $("#poz1").css('width', sirina1);
            $("#poz1").css('height', visina1);
            if (duljina1 == 1) {
                if (data[0].status == 'p') {
                    var aktivanOd = new Date(data[0].aktivan_od).getTime();
                    var aktivanDo = new Date(data[0].aktivan_do).getTime();
                    var trenutni = new Date().getTime();
                    if (trenutni > aktivanOd && trenutni < aktivanDo) {
                        $("#img1").prop('src', 'slike/' + data[0].slika);
                        $("#link1").prop('href', data[0].url);
                        $("#span1").text("Broj klikova:" + data[0].broj_klikova);
                        prazni = false;
                    }
                }

            } else if (duljina1 > 1) {
                var listaSlika1 = new Array();
                var listaLink1 = new Array();
                var listaKlikova = new Array();
                brojElemenata = duljina1;
                for (i = 0; i < brojElemenata; i++) {
                    if (data[i][0].status != 'b' && data[i][0].status == 'p') {
                        var aktivanOd = new Date(data[i][0].aktivan_od).getTime();
                        var aktivanDo = new Date(data[i][0].aktivan_do).getTime();
                        var trenutni = new Date().getTime();
                        if (trenutni > aktivanOd && trenutni < aktivanDo) {
                            listaSlika1.push(data[i][0].slika);
                            listaLink1.push(data[i][0].url);
                            listaKlikova.push(data[i][0].broj_klikova);
                            prazni = false;
                        }
                    }
                }
                indeks1 = 0;
                function remProp1() {
                    $("#img1").prop('src', null);
                    $("#link1").prop('href', null);
                }
                function slider1() {
                    $("#img1").prop('src', 'slike/' + listaSlika1[indeks1]);
                    $("#link1").prop('href', listaLink1[indeks1]);
                    $("#span1").text("Broj klikova:" + listaKlikova[indeks1]);
                    indeks1++;
                    if (indeks1 == listaSlika1.length) {
                        indeks1 = 0;
                    }

                }
                if (!prazni) {
                    setInterval(remProp1(), 10000);
                    slider1();
                    setInterval(slider1, 10000);
                }
            }
            if (prazni) {
                var cijena;
                $.ajax({
                    data: {'pozicija': 1},
                    url: 'cijenaOglasa.php',
                    type: 'get',
                    async: false,
                    dataType: 'json',
                    success: function (data) {
                        cijena = data;
                    }
                });
                $("#img1").prop('alt', '<Kupite oglas po cijeni od ' + cijena + " kuna!");
            }
        }

    });
    $.ajax({
        url: 'oglasi.php?pozicija=2',
        dataType: 'json',
        success: function (data) {
            var prazni = true;
            duljina2 = data.length - 1;
            visina2 = data[duljina2][0].visina;
            sirina2 = data[duljina2][0].sirina;
            $("#poz2").css('width', sirina2);
            $("#poz2").css('height', visina2);
            if (duljina2 == 1) {
                if (data[0].status == 'p') {
                    var aktivanOd = new Date(data[0].aktivan_od).getTime();
                    var aktivanDo = new Date(data[0].aktivan_do).getTime();
                    var trenutni = new Date().getTime();
                    if (trenutni > aktivanOd && trenutni < aktivanDo) {
                        $("#img2").prop('src', 'slike/' + data[0].slika);
                        $("#link2").prop('href', data[0].url);
                        $("#span2").text("Broj klikova:" + data[0].broj_klikova);
                        prazni = false;
                    }
                }
            } else if (duljina2 > 1) {
                var listaSlika2 = new Array();
                var listaLink2 = new Array();
                var listaKlikova = new Array();
                brojElemenata = duljina2;
                for (i = 0; i < brojElemenata; i++) {
                    if (data[i][0].status != 'b' && data[i][0].status == 'p') {
                        var aktivanOd = new Date(data[i][0].aktivan_od).getTime();
                        var aktivanDo = new Date(data[i][0].aktivan_do).getTime();
                        var trenutni = new Date().getTime();
                        if (trenutni > aktivanOd && trenutni < aktivanDo) {
                            listaSlika2.push(data[i][0].slika);
                            listaLink2.push(data[i][0].url);
                            listaKlikova.push(data[i][0].broj_klikova);
                            prazni = false;
                        }
                    }
                }
                indeks2 = 0;
                function remProp2() {
                    $("#img2").prop('src', null);
                    $("#link2").prop('href', null);
                }
                function slider2() {
                    $("#img2").prop('src', 'slike/' + listaSlika2[indeks2]);
                    $("#link2").prop('href', listaLink2[indeks2]);
                    $("#span2").text("Broj klikova:" + listaKlikova[indeks2]);
                    indeks2++;
                    if (indeks2 == listaSlika2.length) {
                        indeks2 = 0;
                    }
                }
                if (!prazni) {
                    setInterval(remProp2(), 10000);
                    slider2();
                    setInterval(slider2, 10000);
                }
            }
            if (prazni) {
                var cijena;
                $.ajax({
                    data: {'pozicija': 2},
                    url: 'cijenaOglasa.php',
                    type: 'get',
                    async: false,
                    dataType: 'json',
                    success: function (data) {
                        cijena = data;
                    }
                });
                $("#img2").prop('alt', 'Kupite oglas po cijeni od ' + cijena + " kuna!");
            }

        }
    });
    $.ajax({
        url: 'oglasi.php?pozicija=3',
        dataType: 'json',
        success: function (data) {
            var prazni = true;
            duljina3 = data.length - 1;
            visina3 = data[duljina3][0].visina;
            sirina3 = data[duljina3][0].sirina;
            $("#poz3").css('width', sirina3);
            $("#poz3").css('height', visina3);
            if (duljina3 == 1) {
                if (data[0].status == 'p') {
                    var aktivanOd = new Date(data[0].aktivan_od).getTime();
                    var aktivanDo = new Date(data[0].aktivan_do).getTime();
                    var trenutni = new Date().getTime();
                    if (trenutni > aktivanOd && trenutni < aktivanDo) {
                        $("#img3").prop('src', 'slike/' + data[0].slika);
                        $("#link3").prop('href', data[0].url);
                        $("#span3").text("Broj klikova:" + data[0].broj_klikova);
                        prazni = false;
                    }
                }
            } else {
                var listaSlika2 = new Array();
                var listaLink2 = new Array();
                var listaKlikova = new Array();
                brojElemenata = duljina3;
                for (i = 0; i < brojElemenata; i++) {
                    if (data[i][0].status != 'b' && data[i][0].status == 'p') {
                        var aktivanOd = new Date(data[i][0].aktivan_od).getTime();
                        var aktivanDo = new Date(data[i][0].aktivan_do).getTime();
                        var trenutni = new Date().getTime();
                        if (trenutni > aktivanOd && trenutni < aktivanDo) {
                            listaSlika2.push(data[i][0].slika);
                            listaLink2.push(data[i][0].url);
                            listaKlikova.push(data[i][0].broj_klikova);
                            prazni = false;
                        }
                    }
                }
                indeks3 = 0;
                function remProp3() {
                    $("#img3").prop('src', null);
                    $("#link3").prop('href', null);
                }
                function slider3() {
                    $("#img3").prop('src', 'slike/' + listaSlika2[indeks3]);
                    $("#link3").prop('href', listaLink2[indeks3]);
                    $("#span3").text("Broj klikova:" + listaKlikova[indeks3]);
                    indeks3++;
                    if (indeks3 == listaSlika2.length) {
                        indeks3 = 0;
                    }
                }
                if (!prazni) {
                    setInterval(remProp3(), 10000);
                    slider3();
                    setInterval(slider3, 10000);
                }
            }
            if (prazni) {
                var cijena;
                $.ajax({
                    data: {'pozicija': 3},
                    url: 'cijenaOglasa.php',
                    type: 'get',
                    async: false,
                    dataType: 'json',
                    success: function (data) {
                        cijena = data;
                    }
                });
                $("#img3").prop('alt', 'Kupite oglas po cijeni od ' + cijena + " kuna!");
            }
        }

    });

    $.ajax({
        url: 'oglasi.php?pozicija=4',
        dataType: 'json',
        success: function (data) {
            var prazni = true;
            duljina4 = data.length - 1;
            visina4 = data[duljina4][0].visina;
            sirina4 = data[duljina4][0].sirina;
            $("#poz4").css('width', sirina4);
            $("#poz4").css('height', visina4);
            if (duljina4 == 1) {
                if (data[0].status == 'p') {
                    var aktivanOd = new Date(data[0].aktivan_od).getTime();
                    var aktivanDo = new Date(data[0].aktivan_do).getTime();
                    var trenutni = new Date().getTime();
                    if (trenutni > aktivanOd && trenutni < aktivanDo) {
                        $("#img4").prop('src', 'slike/' + data[0].slika);
                        $("#link4").prop('href', data[0].url);
                        $("#span4").text("Broj klikova:" + data[0].broj_klikova);
                        prazni = false;
                    }
                }
            } else {
                var listaSlika2 = new Array();
                var listaLink2 = new Array();
                var listaKlikova = new Array();
                brojElemenata = duljina4;
                for (i = 0; i < brojElemenata; i++) {
                    if (data[i][0].status != 'b' && data[i][0].status == 'p') {
                        var aktivanOd = new Date(data[i][0].aktivan_od).getTime();
                        var aktivanDo = new Date(data[i][0].aktivan_do).getTime();
                        var trenutni = new Date().getTime();
                        if (trenutni > aktivanOd && trenutni < aktivanDo) {
                            listaSlika2.push(data[i][0].slika);
                            listaLink2.push(data[i][0].url);
                            listaKlikova.push(data[i][0].broj_klikova);
                            prazni = false;
                        }
                    }
                }
                indeks4 = 0;
                function remProp4() {
                    $("#img4").prop('src', null);
                    $("#link4").prop('href', null);
                }
                function slider4() {
                    $("#img4").prop('src', 'slike/' + listaSlika2[indeks4]);
                    $("#link4").prop('href', listaLink2[indeks4]);
                    $("#span4").text("Broj klikova:" + listaKlikova[indeks4]);
                    indeks4++;
                    if (indeks4 == listaSlika2.length) {
                        indeks4 = 0;
                    }
                }
                if (!prazni) {
                    setInterval(remProp4(), 10000);
                    slider4();
                    setInterval(slider4, 10000);
                }
            }
            if (prazni) {
                var cijena;
                $.ajax({
                    data: {'pozicija': 4},
                    url: 'cijenaOglasa.php',
                    type: 'get',
                    async: false,
                    dataType: 'json',
                    success: function (data) {
                        cijena = data;
                    }
                });
                $("#img4").prop('alt', 'Kupite oglas po cijeni od ' + cijena + " kuna!");
            }
        }

    });

    $.ajax({
        url: 'oglasi.php?pozicija=5',
        dataType: 'json',
        success: function (data) {
            var prazni = true;
            var duljina = data.length - 1;
            var visina = data[duljina][0].visina;
            var sirina = data[duljina][0].sirina;
            $("#poz5").css('width', sirina);
            $("#poz5").css('height', visina);
            if (duljina == 1) {
                if (data[0].status == 'p') {
                    var aktivanOd = new Date(data[0].aktivan_od).getTime();
                    var aktivanDo = new Date(data[0].aktivan_do).getTime();
                    var trenutni = new Date().getTime();
                    if (trenutni > aktivanOd && trenutni < aktivanDo) {
                        $("#img5").prop('src', 'slike/' + data[0].slika);
                        $("#link5").prop('href', data[0].url);
                        $("#span5").text("Broj klikova:" + data[0].broj_klikova);
                        prazni = false;
                    }
                }
            } else {
                var listaSlika2 = new Array();
                var listaLink2 = new Array();
                var listaKlikova = new Array();
                var brojElemenata = duljina;
                for (i = 0; i < brojElemenata; i++) {
                    if (data[i][0].status != 'b' && data[i][0].status == 'p') {
                        var aktivanOd = new Date(data[i][0].aktivan_od).getTime();
                        var aktivanDo = new Date(data[i][0].aktivan_do).getTime();
                        var trenutni = new Date().getTime();
                        if (trenutni > aktivanOd && trenutni < aktivanDo) {
                            listaSlika2.push(data[i][0].slika);
                            listaLink2.push(data[i][0].url);
                            listaKlikova.push(data[i][0].broj_klikova);
                            prazni = false;
                        }
                    }
                }
                var indeks = 0;
                function remProp5() {
                    $("#img5").prop('src', null);
                    $("#link5").prop('href', null);
                }
                function slider5() {
                    $("#img5").prop('src', 'slike/' + listaSlika2[indeks]);
                    $("#link5").prop('href', listaLink2[indeks]);
                    $("#span5").text("Broj klikova:" + listaKlikova[indeks]);
                    indeks++;
                    if (indeks == listaSlika2.length) {
                        indeks = 0;
                    }
                }
                if (!prazni) {
                    setInterval(remProp5(), 10000);
                    slider5();
                    setInterval(slider5, 10000);
                }
            }
            if (prazni) {
                var cijena;
                $.ajax({
                    data: {'pozicija': 5},
                    url: 'cijenaOglasa.php',
                    type: 'get',
                    async: false,
                    dataType: 'json',
                    success: function (data) {
                        cijena = data;
                    }
                });
                $("#img5").prop('alt', 'Kupite oglas po cijeni od ' + cijena + " kuna!");
            }
        }

    });

    $.ajax({
        url: 'oglasi.php?pozicija=6',
        dataType: 'json',
        success: function (data) {
            var prazni = true;
            var duljina = data.length - 1;
            var visina = data[duljina][0].visina;
            var sirina = data[duljina][0].sirina;
            $("#poz6").css('width', sirina);
            $("#poz6").css('height', visina);
            if (duljina == 1) {
                if (data[0].status == 'p') {
                    var aktivanOd = new Date(data[0].aktivan_od).getTime();
                    var aktivanDo = new Date(data[0].aktivan_do).getTime();
                    var trenutni = new Date().getTime();
                    if (trenutni > aktivanOd && trenutni < aktivanDo) {
                        $("#img6").prop('src', 'slike/' + data[0].slika);
                        $("#link6").prop('href', data[0].url);
                        $("#span6").text("Broj klikova:" + data[0].broj_klikova);
                        prazni = false;
                    }
                }
            } else {
                var listaSlika2 = new Array();
                var listaLink2 = new Array();
                var listaKlikova = new Array();
                var brojElemenata = duljina;
                for (i = 0; i < brojElemenata; i++) {
                    if (data[i][0].status != 'b' && data[i][0].status == 'p') {
                        var aktivanOd = new Date(data[i][0].aktivan_od).getTime();
                        var aktivanDo = new Date(data[i][0].aktivan_do).getTime();
                        var trenutni = new Date().getTime();
                        if (trenutni > aktivanOd && trenutni < aktivanDo) {
                            listaSlika2.push(data[i][0].slika);
                            listaLink2.push(data[i][0].url);
                            listaKlikova.push(data[i][0].broj_klikova);
                            prazni = false;
                        }
                    }
                }
                var indeks = 0;
                function remProp6() {
                    $("#img6").prop('src', null);
                    $("#link6").prop('href', null);
                }
                function slider6() {
                    $("#img6").prop('src', 'slike/' + listaSlika2[indeks]);
                    $("#link6").prop('href', listaLink2[indeks]);
                    $("#span6").text("Broj klikova:" + listaKlikova[indeks]);
                    indeks++;
                    if (indeks == listaSlika2.length) {
                        indeks = 0;
                    }
                }
                if (!prazni) {
                    setInterval(remProp6(), 10000);
                    slider6();
                    setInterval(slider6, 10000);
                }
            }
            if (prazni) {
                var cijena;
                $.ajax({
                    data: {'pozicija': 6},
                    url: 'cijenaOglasa.php',
                    type: 'get',
                    async: false,
                    dataType: 'json',
                    success: function (data) {
                        cijena = data;
                    }
                });
                $("#img6").prop('alt', 'Kupite oglas po cijeni od ' + cijena + " kuna!");
            }
        }

    });

    $.ajax({
        url: 'oglasi.php?pozicija=7',
        dataType: 'json',
        success: function (data) {
            var prazni = true;
            var duljina = data.length - 1;
            var visina = data[duljina][0].visina;
            var sirina = data[duljina][0].sirina;
            $("#poz7").css('width', sirina);
            $("#poz7").css('height', visina);

            if (duljina == 1) {
                if (data[0].status == "p") {
                    var aktivanOd = new Date(data[0].aktivan_od).getTime();
                    var aktivanDo = new Date(data[0].aktivan_do).getTime();
                    var trenutni = new Date().getTime();
                    if (trenutni > aktivanOd && trenutni < aktivanDo) {
                        $("#img7").prop('src', 'slike/' + data[0].slika);
                        $("#link7").prop('href', data[0].url);
                        $("#span7").text("Broj klikova:" + data[0].broj_klikova);
                        prazni = false;
                    }
                }
            } else {
                var listaSlika2 = new Array();
                var listaLink2 = new Array();
                var listaKlikova = new Array();
                var brojElemenata = duljina;
                for (i = 0; i < brojElemenata; i++) {
                    if (data[i][0].status != 'b' && data[i][0].status == 'p') {
                        var aktivanOd = new Date(data[i][0].aktivan_od).getTime();
                        var aktivanDo = new Date(data[i][0].aktivan_do).getTime();
                        var trenutni = new Date().getTime();
                        if (trenutni > aktivanOd && trenutni < aktivanDo) {
                            listaSlika2.push(data[i][0].slika);
                            listaLink2.push(data[i][0].url);
                            listaKlikova.push(data[i][0].broj_klikova);
                            prazni = false;
                        }
                    }

                }

                var indeks = 0;
                function remProp7() {
                    $("#img7").prop('src', null);
                    $("#link7").prop('href', null);
                }
                function slider7() {
                    $("#img7").prop('src', 'slike/' + listaSlika2[indeks]);
                    $("#link7").prop('href', listaLink2[indeks]);
                    $("#span7").text("Broj klikova:" + listaKlikova[indeks]);
                    indeks++;
                    if (indeks == listaSlika2.length) {
                        indeks = 0;
                    }
                }
                if (!prazni) {
                    setInterval(remProp7(), 10000);
                    slider7();
                    setInterval(slider7, 10000);
                }

            }
            if (prazni) {
                var cijena;
                $.ajax({
                    data: {'pozicija': 7},
                    url: 'cijenaOglasa.php',
                    type: 'get',
                    async: false,
                    dataType: 'json',
                    success: function (data) {
                        cijena = data;
                    }
                });
                $("#img7").prop('alt', 'Kupite oglas po cijeni od ' + cijena + " kuna!");
            }
        }
    });

    $("#img1").on('click', function () {
        var oglas = $("#link1").prop("href");
        var broj = 0;
        $.ajax({
            data: {'link': oglas},
            url: 'brojKlikova.php',
            async: false,
            type: 'GET',
            dataType: 'text',
            success: function (data) {
                broj = parseInt(data) + 1;
            }
        });
        $.ajax({
            data: {'broj': broj, 'oglas': oglas},
            type: 'GET',
            async: false,
            url: 'povecajKlikove.php'
        });

    });
    $("#img2").click(function () {
        var oglas = $("#link2").prop("href");
        var broj = 0;
        $.ajax({
            data: {'link': oglas},
            url: 'brojKlikova.php',
            async: false,
            type: 'GET',
            dataType: 'text',
            success: function (data) {
                broj = parseInt(data) + 1;
            }
        });
        $.ajax({
            data: {'broj': broj, 'oglas': oglas},
            type: 'GET',
            async: false,
            url: 'povecajKlikove.php'
        });
    });
    $("#img3").click(function () {
        var oglas = $("#link3").prop("href");
        var broj = 0;
        $.ajax({
            data: {'link': oglas},
            url: 'brojKlikova.php',
            async: false,
            type: 'GET',
            dataType: 'text',
            success: function (data) {
                broj = parseInt(data) + 1;
            }
        });
        $.ajax({
            data: {'broj': broj, 'oglas': oglas},
            type: 'GET',
            async: false,
            url: 'povecajKlikove.php'
        });
    });

    $("#img4").click(function () {
        var oglas = $("#link4").prop("href");
        var broj = 0;
        $.ajax({
            data: {'link': oglas},
            url: 'brojKlikova.php',
            async: false,
            type: 'GET',
            dataType: 'text',
            success: function (data) {
                broj = parseInt(data) + 1;
            }
        });
        $.ajax({
            data: {'broj': broj, 'oglas': oglas},
            type: 'GET',
            async: false,
            url: 'povecajKlikove.php'
        });
    });

    $("#img5").click(function () {
        var oglas = $("#link5").prop("href");
        var broj = 0;
        $.ajax({
            data: {'link': oglas},
            url: 'brojKlikova.php',
            async: false,
            type: 'GET',
            dataType: 'text',
            success: function (data) {
                broj = parseInt(data) + 1;
            }
        });
        $.ajax({
            data: {'broj': broj, 'oglas': oglas},
            type: 'GET',
            async: false,
            url: 'povecajKlikove.php'
        });
    });

    $("#img6").click(function () {
        var oglas = $("#link6").prop("href");
        var broj = 0;
        $.ajax({
            data: {'link': oglas},
            url: 'brojKlikova.php',
            async: false,
            type: 'GET',
            dataType: 'text',
            success: function (data) {
                broj = parseInt(data) + 1;
            }
        });
        $.ajax({
            data: {'broj': broj, 'oglas': oglas},
            type: 'GET',
            async: false,
            url: 'povecajKlikove.php'
        });
    });

    $("#img7").click(function () {
        var oglas = $("#link7").prop("href");
        var broj = 0;
        $.ajax({
            data: {'link': oglas},
            url: 'brojKlikova.php',
            async: false,
            type: 'GET',
            dataType: 'text',
            success: function (data) {
                broj = parseInt(data) + 1;
            }
        });
        $.ajax({
            data: {'broj': broj, 'oglas': oglas},
            type: 'GET',
            async: false,
            url: 'povecajKlikove.php'
        });
    });

    $("#blokiraj1").on('click', function () {
        var link = $("#link1").prop('href');
        $("#blokiraj1").prop('href', 'blokiraj.php?url=' + link);
    });

    $("#blokiraj2").on('click', function () {
        var link = $("#link2").prop('href');
        $("#blokiraj2").prop('href', 'blokiraj.php?url=' + link);
    });

    $("#blokiraj3").on('click', function () {
        var link = $("#link3").prop('href');
        $("#blokiraj3").prop('href', 'blokiraj.php?url=' + link);
    });

    $("#blokiraj4").on('click', function () {
        var link = $("#link4").prop('href');
        $("#blokiraj4").prop('href', 'blokiraj.php?url=' + link);
    });

    $("#blokiraj5").on('click', function () {
        var link = $("#link5").prop('href');
        $("#blokiraj5").prop('href', 'blokiraj.php?url=' + link);
    });

    $("#blokiraj6").on('click', function () {
        var link = $("#link6").prop('href');
        $("#blokiraj6").prop('href', 'blokiraj.php?url=' + link);
    });

    $("#blokiraj7").on('click', function () {
        var link = $("#link7").prop('href');
        $("#blokiraj7").prop('href', 'blokiraj.php?url=' + link);
    });

    $("#korimeZab").blur(function () {
        var korisnickoIme = $("#korimeZab").val();
        $.ajax({
            type: "post",
            url: "provjeraKorisnika.php",
            data: {'korime_reg': korisnickoIme},
            success: function (data) {
                if (data == 0) {
                    alert("Korisnik s tim imenom ne postoji!");
                    $("#korimeZab").val("");
                }
            }
        });
    });

    $(".uredi").on('click', function UrediOglas() {
        $(this).append("</label>");
        var putanjaSlike = $(this).siblings('.slikaOglas').prop('src');

        var listaNaziva = new Array();
        $.ajax({
            url: 'dohvatiVrsteOglasa.php',
            dataType: 'json',
            async: false,
            success: function (data) {
                for (i = 0; i < data.length; i++) {
                    listaNaziva.push(data[i]['naziv_vrste']);
                }
            }
        });
        $(this).after("<div id='formaUredi'><form method='post' id='formaUredivanje' enctype='multipart/form-data' action='azuriraj.php'><label>Naziv</label><input required size='25' class='uredivanje' type='text' id='nazivOglasa' name='nazivOglasa'><br><label>Opis</label><input required size='25' class='uredivanje' type='text' id='opisOglasa' name='opisOglasa'><br><label>Url</label><input required size='25' class='uredivanje' type='text' id='urlOglasa' name='urlOglasa'><br><label>Slika</label><input required type='file' class='uredivanje' id='fileUpload' name='slikaOglasa'><br><label>Aktivan od</label><input required class='uredivanje' type='date' id='datumOglasa' name='datumOglasa'><br>");
        $('#formaUredivanje').append("<label class='uredivanje'>Vrsta</label>");
        var opcije = "";
        for (i = 0; i < listaNaziva.length; i++) {
            opcije += "<option value='" + listaNaziva[i] + "'>" + listaNaziva[i] + "</option>";
        }
        $('#formaUredivanje').append("<select class='select' name='vrsta' required>" + opcije + "</select><br>");
        $('#formaUredivanje').append("<input type='submit' value='Spremi' id='spremanje'></form></div>");

        var slika = putanjaSlike.split("/");

        var _slika = slika[slika.length - 1];

        var naziv = "";
        var opis = "";
        var url_slike = "";
        $.ajax({
            data: {'slika': _slika},
            url: 'podaciOglasa.php',
            dataType: 'json',
            type: 'get',
            async: false,
            success: function (data) {
                naziv = data[0]['naziv'];
                opis = data[0]['opis'];
                url_slike = data[0]['url'];
            }

        });

        $("#nazivOglasa").val(naziv);
        $("#opisOglasa").val(opis);
        $("#urlOglasa").val(url_slike);
        $(".uredi").unbind();
    });
    $("#spremanje").on('click', function () {
        $(".uredi").click(UrediOglas);

    });

    $("#kreirajVrstu").on('click', function () {
        $("#postaviOglas").hide();
        $("#kreirajNatjecanje").attr('disabled', ':disabled')
        $("#kreirajPitanje").hide();
        $("#kreirajVrstu").unbind();
        $("#forma").addClass("desno");
        $("#forma").append("<form method='get' action='kreirajVrstu.php'><label class='labela'>Naziv</label><input type=text name='naziv' required><br><label class='labela'>Trajanje prikaza(h)</label><input type='number' name='trajanje' required><br><label class='labela'>Brzina izmjene</label><input type='number' name='brzina' required><br><label class='labela'>Cijena</labela><input type='number' name='cijena' required><br><label class='labela'>Pozicija</label><select name='pozicija' required><option value='1'>1</option><option value='2'>2</option><option value='3'>3</option><option value='4'>4</option><option value='5'>5</option><option value='6'>6</option><option value='7'>7</option></select><input type='submit' value='Spremi'></form>");
    });

    $("#kreirajNatjecanje").on('click', function () {
        $("#postaviOglas").hide();
        $("#kreirajPitanje").hide();
        $("#kreirajVrstu").attr('disabled', ':disabled')
        $("#kreirajNatjecanje").unbind();
        $("#forma").addClass("lijevo");
        var listaKat = new Array();
        $.ajax({
            url: 'dohvatiKategorije.php',
            dataType: 'json',
            async: false,
            success: function (data) {
                var duljina = data.length;
                for (i = 0; i < duljina; i++) {
                    listaKat.push(data[i].naziv);
                }
            }
        });
        var opcije = "";
        for (i = 0; i < listaKat.length; i++) {
            opcije += "<option value='" + listaKat[i] + "'>" + listaKat[i] + "</option>";
        }
        $("#forma").append("<form method='get' action='kreirajNatjecanje.php' id='formaNatjecanje'>");
        $("#formaNatjecanje").append("<select class='select' id='kategorija' name='kategorija'><option value='' disabled selected required></option>" + opcije + "</select>");
        var listaPitanja = new Array();
        $("#kategorija").change(function () {

            var kategorija = $("#kategorija").val();
            $("#kategorija").prop('disabled', 'true');
            $.ajax({
                url: "dohvatiPitanja.php",
                data: {'kategorija': kategorija},
                dataType: 'json',
                async: false,
                type: 'GET',
                success: function (data) {
                    var duljina = data.length;
                    for (i = 0; i < duljina; i++) {
                        listaPitanja.push(data[i].pitanje);
                    }
                }
            });
            $("#formaNatjecanje").append("<br><label class='labela'>Naziv</label><input type='text' name='naziv' required><br><label class='labela'>Opis</label><textarea name='opis' rows=3 columns=10 required></textarea><br><label class='labela'>Broj korisnika</label><input type='number' name='broj_korisnika' required><br><label class='labela'>Dostupno od</label><input type='date' name='dostupno_od' required><br><label class='labela'>Dostupno do</label><input type='date' name='dostupno_do' required><br><legend>Odaberi pitanja za natjecanje:</legend>")
            var brojPitanja = listaPitanja.length;
            var pitanja = "";
            for (i = 0; i < brojPitanja; i++) {
                pitanja += "<br><label class='labela'><input type='checkbox' name='pitanje" + i + "' value='" + listaPitanja[i] + "'>" + listaPitanja[i] + "</label><br>";
            }
            $("#formaNatjecanje").append(pitanja);
            $("#formaNatjecanje").on('submit', function (e) {
                $("#kategorija").removeAttr('disabled');
                if (($(":checkbox:checked").length < 5)) {
                    alert("Moraš označiti minimalno 5 pitanja!");
                    e.preventDefault();
                }

            });
            $("#formaNatjecanje").append("<input type='submit' class='kreiraj' value='Kreiraj'></form>");
        });
    });
    $("#kreirajPitanje").on('click', function () {
        $("#postaviOglas").hide();
        $("#kreirajPitanje").unbind();
        $("#kreirajVrstu").hide();
        $("#kreirajNatjecanje").hide();
        var listaKat = new Array();
        $.ajax({
            url: 'dohvatiKategorije.php',
            dataType: 'json',
            async: false,
            success: function (data) {
                var duljina = data.length;
                for (i = 0; i < duljina; i++) {
                    listaKat.push(data[i].naziv);
                }
            }
        });
        var opcije = "";
        for (i = 0; i < listaKat.length; i++) {
            opcije += "<option value='" + listaKat[i] + "'>" + listaKat[i] + "</option>";
        }
        $("#forma").addClass("lijevo");
        $("#forma").append("<form method='get' action='kreirajPitanje.php' id='formaPitanja'>");
        $("#formaPitanja").append("<label class='labela'>Kategorija</label><select class='select' id='kategorija' name='kategorija' required><option value='' disabled selected></option>" + opcije + "</select>");
        $("#formaPitanja").append("<br><label class='labela'>Pitanje</label><textarea name='pitanje' rows=3 columns=10 required></textarea>");
        $("#formaPitanja").append("<br><label class='labela'>Odgovor1</label><input name='odg1' id='odg1' type='text' required><br>");
        $("#formaPitanja").append("<br><label class='labela'>Odgovor2</label><input name='odg2' id='odg2' type='text' required><br>");
        $("#formaPitanja").append("<br><label class='labela'>Odgovor3</label><input name='odg3' id='odg3' type='text' required><br>");
        $("#formaPitanja").append("<br><label class='labela'>Odgovor4</label><input name='odg4' id='odg4' type='text' required><br>");
        $("#formaPitanja").append("<br><label class='labela'>Točan odgovor</label><input name='tocan' id='tocan' type='text' required><br>");
        $("#formaPitanja").append("<input type='submit' value='Spremi' id='pitanja'>");
        $("#formaPitanja").on('submit', function (e) {
            var odg1 = $("#odg1").val();
            var odg2 = $("#odg2").val();
            var odg3 = $("#odg3").val();
            var odg4 = $("#odg4").val();
            var tocan = $("#tocan").val();
            if (odg1 != tocan && odg2 != tocan && odg3 != tocan && odg4 != tocan) {
                alert("Točan odgovor se ne poklapa s nijednim odgovorom!");
                e.preventDefault();
            }
        });
    });

    $("#postaviOglas").on('click', function () {
        $("#kreirajVrstu").hide();
        $("#kreirajNatjecanje").hide();
        $("#kreirajPitanje").hide();
        $("#postaviOglas").unbind();
        $("#forma").addClass("lijevo");
        var duljina1;
        var duljina2;
        var opcije = "";
        var opcije2 = "";
        $.ajax({
            url: 'dohvatiPozicijeIoglase.php',
            dataType: 'json',
            async: false,
            success: function (data) {
                duljina1 = data[0].length;
                for (var j = 0; j < duljina1; j++) {
                    opcije += "<option value='" + data[0][j][0] + "'>" + data[0][j][0] + "</option>";
                }
                duljina2 = data[1].length;
                for (var i = 0; i < duljina2; i++) {
                    opcije2 += "<option value='" + data[1][i][0] + "'>" + data[1][i][0] + "</option>";
                }
            }
        });
        $("#forma").append("<form method='get' action='postaviOglas.php' id='formaOglasi'>");
        $("#formaOglasi").append("<label class='labela'>Pozicija</label><select name='pozicija' required>" + opcije + "</select><br><label class='labela'>Oglas</label><select name='oglas' required>" + opcije2 + "</select><br><input type='submit' value='Spremi'>");
    });

    $("#blokiranje").on('click', function () {
        $("#blokiranje").unbind();
        $("#deblokiranje").hide();
        $("#konfiguracija").hide();
        $("#dnevnik").hide();
        $("#admin").addClass('lijevo');
        $("#admin").append("<form method='get' action='blokirajAdmin.php' id='formaBlok'></form>");
        var opcije = "";
        $.ajax({
            url: 'dohvatKorisnika.php',
            dataType: 'json',
            async: false,
            success: function (data) {
                var duljina = data.length;
                for (var i = 0; i < duljina; i++) {
                    if (data[i]['status'] != 'b') {
                        opcije += "<option value='" + data[i]['username'] + "'>" + data[i]['username'] + "</option>";
                    }
                }
            }
        });

        $("#formaBlok").append("<label class='labela'>Odaberi korisnika</label><select required name='username'>" + opcije + "</select>");
        $("#formaBlok").append("<input type='submit' value='Blokiraj'>");
    });

    $("#deblokiranje").on('click', function () {
        $("#deblokiranje").unbind();
        $("#blokiranje").hide();
        $("#konfiguracija").hide();
        $("#dnevnik").hide();
        $("#admin").addClass('lijevo');
        $("#admin").append("<form method='get' action='deblokiraj.php' id='formaBlok'></form>");
        var opcije = "";
        $.ajax({
            url: 'dohvatKorisnika.php',
            dataType: 'json',
            async: false,
            success: function (data) {
                var duljina = data.length;
                for (var i = 0; i < duljina; i++) {
                    if (data[i]['status'] == 'b') {
                        opcije += "<option value='" + data[i]['username'] + "'>" + data[i]['username'] + "</option>";
                    }
                }
            }
        });

        $("#formaBlok").append("<label class='labela'>Odaberi korisnika</label><select required name='username'>" + opcije + "</select>");
        $("#formaBlok").append("<input type='submit' value='Deblokiraj'>");
    });

    $("#konfiguracija").on('click', function () {
        $("#konfiguracija").unbind();
        $("#blokiranje").hide();
        $("#deblokiranje").hide();
        $("#dnevnik").hide();
        $("#admin").addClass('lijevo');
        $("#admin").append("<form method='get' action='azurirajAdmin.php' id='formaBlok'></form>");
        $("#formaBlok").append("<label class='labela'>Straničenje</label><input type='number' name='stranicenje' required><br><label class='labela'>Trajanje kolačića</label><input type='number' name='trajanje_kolacica' required><br><label class='labela'>Broj neuspješnih prijava</label><input type='number' name='broj_neuspjesnih' required><br><label class='labela'>Trajanje aktivacijskog emaila</label><input type='number' name='trajanje_maila' required><br> ")
        $("#formaBlok").append("<input type='submit' value='Spremi'><br><br>");
        $.ajax({
            url: 'dohvatKonfiguracije.php',
            dataType: 'json',
            async: false,
            success: function (data) {
                $("#formaBlok").append("<table><tr><th>Naziv</th><th>Straničenje</th><th>Trajanje kolačića</th><th>Broj nedozvoljenih</th><th>Trajanje emaila</th></tr><tr><td>" + data[0][0] + "</td><td>" + data[0][1] + "</td><td>" + data[0][2] + "</td><td>" + data[0][3] + "</td><td>" + data[0][4] + "</td></tr></table>");
            }
        });
    });
    $("#dnevnik").on('click', function () {
        $("#dnevnik").unbind();
        $("#blokiranje").hide();
        $("#deblokiranje").hide();
        $("#konfiguracija").hide();

        var podaci = "";
        $.ajax({
            url: 'dohvatDnevnika.php',
            dataType: 'json',
            async: false,
            success: function (data) {
                for (x = 0; x < data.length; x++) {
                    podaci += "<tr><td>" + data[x][2] + "</td><td>" + data[x][3] + "</td><td>" + data[x][1] + "</td></tr>";
                }
            }
        });
        $("#admin").append("<table><tr><th>Korisnik</th><th>Akcija</th><th>Vrijeme</th></tr>" + podaci + "</table>");
    });
});

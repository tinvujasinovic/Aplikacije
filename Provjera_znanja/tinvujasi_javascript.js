function Dogadaji() {
    var form = document.getElementById('regForma');
    form.addEventListener("submit", function (event) {
        var ispunjena = true;
        formular = document.getElementById("regForma");
        var brojElemenata = formular.length;

        for (var i = 0; i < brojElemenata; i++) {
            if (formular[i].value === "") {
                ispunjena = false;
            }
        }
        if (!ispunjena) {
            alert("Nisu ispunjena sva polja!");
            event.preventDefault();
        }
    if (grecaptcha.getResponse() === '') {
        event.preventDefault();
        alert('Nije označena reCaptcha!');
    }
        var korisnicko = document.getElementById("korime_reg").value;
        if (korisnicko.length < 5) {
            alert("Korisničko ime mora se sastojati od minimalno 5 slova!");
            korisnicko = "";
            event.preventDefault();
        }
        var email = document.getElementById("email").value;
        var reg = /(?=^.{10,30}$)([a-zA-Z\d*])+(\.?)([a-zA-Z\d*])*@{1}([a-zA-z\d*])+(\.){1}([a-zA-Z\d*]){2,}/;
        if (!reg.test(email)) {
            alert("Email nije dobrog formata!");
            event.preventDefault();
        }
        var ime = document.getElementById("ime").value;
        var prezime = document.getElementById("prezime").value;
        if (ime[0] !== ime[0].toUpperCase()) {
            alert("Ime mora početi velikim slovom!");
            event.preventDefault();
        }
        if (prezime[0] !== prezime[0].toUpperCase()) {
            alert("Prezime mora početi velikim slovom!");
            event.preventDefault();
        }
        var lozinka1 = "";
        var lozinka2 = "";
        lozinka1 = document.getElementById("lozinka_reg1").value;
        lozinka2 = document.getElementById("lozinka_reg2").value;
        if (lozinka1 !== lozinka2) {
            alert("Lozinke se ne podudaraju!");
            event.preventDefault();
        }
        if (lozinka1.length < 8 || lozinka2.length < 8) {
            alert("Lozinka mora biti minimalno 8 znakova!");
            event.preventDefault();
        }
    }, false);
}





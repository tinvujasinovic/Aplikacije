using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkyApp
{
    public partial class KorisničkiProfilVlasnik : Form
    {

        private korisnici korisnikZaUredivanje;

        public KorisničkiProfilVlasnik(korisnici korisnik)
        {
            InitializeComponent();
            OnemoguciUredivanje();
            OblikujPanel();
            PopuniComboBox();

           

            korisnikZaUredivanje = korisnik;
        }

        #region Metode za konstruktor

        //Popunjava comboBoxeve na formi sa podacima
        private void PopuniComboBox()
        {
            uiOutputStrucna.Items.Add("NSS");
            uiOutputStrucna.Items.Add("SSS");
            uiOutputStrucna.Items.Add("VŠS");
            uiOutputStrucna.Items.Add("VSS");

            uiOutputRadnoMjesto.Items.Add("Radnik u proizvodnji");
            uiOutputRadnoMjesto.Items.Add("Tehničar");
            uiOutputRadnoMjesto.Items.Add("Računovođa");
            uiOutputRadnoMjesto.Items.Add("Poslovođa");
            uiOutputRadnoMjesto.Items.Add("Prodavač");
        }

        //Onemogucuje upis u texbox
        private void OnemoguciUredivanje()
        {
            uiOutputDatumRodenja.Enabled = false;
            uiOutputGrad.Enabled = false;
            uiOutputIme.Enabled = false;
            uiOutputMail.Enabled = false;
            uiOutputPrezime.Enabled = false;
            uiOutputRadnoMjesto.Enabled = false;
            uiOutputStrucna.Enabled = false;
            uiOutputTelefon.Enabled = false;
            uiOutputUlica.Enabled = false;
            uiOutputZanimanje.Enabled = false;
            uiOutputBrojRacuna.Enabled = false;
            uiOutputOIB.Enabled = false;
            uiOutputLozinka.Enabled = false;

            uiActionSpremi.Enabled = false;
        }

        //Crtanje panela na formi iza kontrola
        private void OblikujPanel()
        {
            panelProfil.Anchor = AnchorStyles.None;
            panelProfil.Left = (this.ClientSize.Width - panelProfil.Width) / 2;
            panelProfil.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);
        }
        #endregion

        #region Popunjavanje forme
        private void KorisničkiProfilVlasnik_Load(object sender, EventArgs e)
        {


            if (korisnikZaUredivanje != null)
            {
                uiOutputIme.Text = korisnikZaUredivanje.ime;
                uiOutputPrezime.Text = korisnikZaUredivanje.prezime;
                uiOutputOIB.Text = korisnikZaUredivanje.OIB.ToString();
                uiOutputDatumRodenja.Text = korisnikZaUredivanje.datum_rodenja.ToString();
                uiOutputUlica.Text = korisnikZaUredivanje.ulica_i_kucni_broj;
                uiOutputGrad.Text = korisnikZaUredivanje.grad;
                uiOutputStrucna.Text = korisnikZaUredivanje.strucna_sprema;
                uiOutputZanimanje.Text = korisnikZaUredivanje.zanimanje;
                uiOutputTelefon.Text = korisnikZaUredivanje.telefon;
                uiOutputRadnoMjesto.Text = korisnikZaUredivanje.radno_mjesto;
                uiOutputBrojRacuna.Text = korisnikZaUredivanje.broj_racuna;
                uiOutputMail.Text = korisnikZaUredivanje.email;
            }
            PrikaziBiljeske(korisnikZaUredivanje);
            PrikaziZadatke(korisnikZaUredivanje);
        }

        #endregion

        #region Uređivanje profila

        //Omogucava upis u texboxeve
        private void uiActionUredi_Click(object sender, EventArgs e)
        {
            uiOutputDatumRodenja.Enabled = true;
            uiOutputGrad.Enabled = true;
            uiOutputIme.Enabled = true;
            uiOutputMail.Enabled = true;
            uiOutputPrezime.Enabled = true;
            uiOutputRadnoMjesto.Enabled = true;
            uiOutputStrucna.Enabled = true;
            uiOutputTelefon.Enabled = true;
            uiOutputUlica.Enabled = true;
            uiOutputZanimanje.Enabled = true;
            uiOutputBrojRacuna.Enabled = true;
            uiOutputOIB.Enabled = true;

            uiActionSpremi.Enabled = true;
        }
        //Zatvara formu
        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }


        //sprema promijenjene podatke
        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            if (uiOutputIme.Text != "" && uiOutputPrezime.Text != "" && uiOutputOIB.Text != null && uiOutputDatumRodenja.Value != null && uiOutputUlica.Text != "" &&
                     uiOutputGrad.Text != "" && uiOutputStrucna.Text != "" && uiOutputZanimanje.Text != "" && uiOutputTelefon.Text != "" && uiOutputRadnoMjesto.Text != "" &&
                     uiOutputBrojRacuna.Text != "" && uiOutputMail.Text != "")
            {
                using (var db = new MilkyAppDataBaseEntities())
                {
                    db.korisnici.Attach(korisnikZaUredivanje);

                    korisnikZaUredivanje.ime = uiOutputIme.Text;
                    korisnikZaUredivanje.prezime = uiOutputPrezime.Text;
                    korisnikZaUredivanje.OIB = decimal.Parse(uiOutputOIB.Text);
                    korisnikZaUredivanje.datum_rodenja = uiOutputDatumRodenja.Value;
                    korisnikZaUredivanje.ulica_i_kucni_broj = uiOutputUlica.Text;
                    korisnikZaUredivanje.grad = uiOutputGrad.Text;
                    korisnikZaUredivanje.strucna_sprema = uiOutputStrucna.Text;
                    korisnikZaUredivanje.zanimanje = uiOutputZanimanje.Text;
                    korisnikZaUredivanje.telefon = uiOutputTelefon.Text;
                    korisnikZaUredivanje.radno_mjesto = uiOutputRadnoMjesto.Text;
                    korisnikZaUredivanje.broj_racuna = uiOutputBrojRacuna.Text;
                    korisnikZaUredivanje.email = uiOutputMail.Text;

                    db.SaveChanges();

                }

                MessageBox.Show("Promjene su spremljene!");
                OnemoguciUredivanje();
            }
            else
            {
                MessageBox.Show("Nisu uneseni svi podaci!");
            }

        }

        //Prikaz/sakrivanje lozinke oznacavanjem kucice
        private void uiPrikaziSakrijLozinku_CheckedChanged(object sender, EventArgs e)
        {
            if (uiPrikaziSakrijLozinku.Checked == true)
            {
                if (korisnikZaUredivanje != null)
                {

                    uiOutputLozinka.Text = korisnikZaUredivanje.lozinka;
                }
                uiPrikaziSakrijLozinku.Text = "Sakrij lozinku";
            }
            if (uiPrikaziSakrijLozinku.Checked == false)
            {
                uiOutputLozinka.Text = "";
                uiPrikaziSakrijLozinku.Text = "Prikaži lozinku";
            }
        }

        //Provjerava da li OIB ima 11 znakova kada se texbox napusti
        private void uiOutputOIB_Leave(object sender, EventArgs e)
        {
            using (var db = new MilkyAppDataBaseEntities())
            {
                foreach (korisnici kor in db.korisnici)
                {
                    if (uiOutputOIB.Text.Length != 11)
                    {
                        MessageBox.Show("OIB mora sadržavati 11 znamenki");
                        uiOutputOIB.Text = "";
                    }
                }
            }
        }

        //Kada se texbox napusti provjerava u bazi da li postoji takav email
        private void uiOutputMail_Leave(object sender, EventArgs e)
        {
            using (var db = new MilkyAppDataBaseEntities())
            {
                foreach (korisnici kor in db.korisnici)
                {
                    if (kor.email.ToString() == uiOutputMail.Text)
                    {
                        MessageBox.Show("Korisnik pod tim emailom već postoji!");
                        uiOutputMail.Text = "";
                    }
                }
            }
        }

        #endregion

        #region Biljeske

        //prikaz biljeski u DGV
        private void PrikaziBiljeske(korisnici korisnik)
        {
            BindingList<biljeske> listaBiljeski = null;
            using (var db = new MilkyAppDataBaseEntities())
            {
                db.korisnici.Attach(korisnik);
                listaBiljeski = new BindingList<biljeske>(korisnik.biljeske.ToList<biljeske>());
            }
            biljeskeBindingSource.DataSource = listaBiljeski;

        }
        //Dodavanje nove bilješke
        private void uiActionDodajBilješku_Click(object sender, EventArgs e)
        {
            if (uiInputNovaBilješka.Text != "")
            {
                using (var db = new MilkyAppDataBaseEntities())
                {
                    db.korisnici.Attach(korisnikZaUredivanje);
                    biljeske biljeska = new biljeske
                    {
                        biljeska = uiInputNovaBilješka.Text,
                        korisnik_ID = korisnikZaUredivanje.korisnik_ID,
                        korisnici = korisnikZaUredivanje


                    };
                    db.biljeske.Add(biljeska);
                    db.SaveChanges();
                }
                uiInputNovaBilješka.Clear();
                PrikaziBiljeske(korisnikZaUredivanje);
            }
            else
            {
                MessageBox.Show("Da bi dodali bilješku morate ju upisati!");
            }
        }

        //Brisanje bilješke
        private void uiActionObrisiBiljesku_Click(object sender, EventArgs e)
        {
            biljeske oznacenaBiljeska = biljeskeBindingSource.Current as biljeske;
            if (oznacenaBiljeska != null)
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati označenu bilješku? ", "Upozorenje",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new MilkyAppDataBaseEntities())
                    {

                        db.biljeske.Attach(oznacenaBiljeska);
                        db.biljeske.Remove(oznacenaBiljeska);

                        db.SaveChanges();
                    }

                    MessageBox.Show("Bilješka je obrisana!");
                }
            }
            PrikaziBiljeske(korisnikZaUredivanje);
        }

        #endregion

        #region Zadaci

        //Prikaz zadataka u DGV
        private void PrikaziZadatke(korisnici korisnik)
        {
            BindingList<zadaci> listaZadataka = null;
            using (var db = new MilkyAppDataBaseEntities())
            {
                db.korisnici.Attach(korisnik);
                listaZadataka = new BindingList<zadaci>(korisnik.zadaci.ToList<zadaci>());
            }
            zadaciBindingSource.DataSource = listaZadataka;
            
        }

        //Omogucuje brisanje zadataka
        private void uiActionObrisiZadatak_Click(object sender, EventArgs e)
        {
            zadaci oznaceniZadatak = zadaciBindingSource.Current as zadaci;
            if (oznaceniZadatak != null)
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati označeni zadatak? ", "Upozorenje",
                       MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new MilkyAppDataBaseEntities())
                    {
                        db.zadaci.Attach(oznaceniZadatak);
                        db.zadaci.Remove(oznaceniZadatak);

                        db.SaveChanges();
                    }
                    MessageBox.Show("Zadatak je obrisan!");
                }
            }
            PrikaziZadatke(korisnikZaUredivanje);
        }

        //Dodavanje novog zadatka
        private void uiActionDodajZadatak_Click(object sender, EventArgs e)
        {
            if (uiInputNoviZadatak.Text != "")
            {
                using (var db = new MilkyAppDataBaseEntities())
                {
                    db.korisnici.Attach(korisnikZaUredivanje);
                    zadaci zadatak = new zadaci
                    {
                        opis = uiInputNoviZadatak.Text,
                        datum_izvrsenja = datumZadatka.Value,
                        korisnik_ID = korisnikZaUredivanje.korisnik_ID

                    };
                    db.zadaci.Add(zadatak);
                    db.SaveChanges();
                }
                uiInputNoviZadatak.Clear();
                PrikaziZadatke(korisnikZaUredivanje);
            }
            else
            {
                MessageBox.Show("Da bi dodali zadatak morate ga upisati i odrediti datum!");
            }
        }

        #endregion
    }

}

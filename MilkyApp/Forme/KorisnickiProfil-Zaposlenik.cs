using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkyApp.Forme
{
    public partial class Profil_Zaposlenik : Form
    {
        private korisnici korisnikZaPregled;

       
            public Profil_Zaposlenik(korisnici korisnik)
        {
            InitializeComponent();
            panelProfilZaposlenik.Anchor = AnchorStyles.None;
            panelProfilZaposlenik.Left = (this.ClientSize.Width - panelProfilZaposlenik.Width) / 2;
            panelProfilZaposlenik.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);
            OnemoguciUredivanje();

            korisnikZaPregled = korisnik;
        }

        //Onemogućuje upis u textboxeve
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

        //Popunjuje textboxeve podacima iz baze za prijavljenog zaposlenika
        private void Profil_Zaposlenik_Load(object sender, EventArgs e)
        {
            uiOutputIme.Text = korisnikZaPregled.ime;
            uiOutputPrezime.Text = korisnikZaPregled.prezime;
            uiOutputOIB.Text = korisnikZaPregled.OIB.ToString();
            uiOutputDatumRodenja.Text = korisnikZaPregled.datum_rodenja.ToString();
            uiOutputUlica.Text = korisnikZaPregled.ulica_i_kucni_broj;
            uiOutputGrad.Text = korisnikZaPregled.grad;
            uiOutputStrucna.Text = korisnikZaPregled.strucna_sprema;
            uiOutputZanimanje.Text = korisnikZaPregled.zanimanje;
            uiOutputTelefon.Text = korisnikZaPregled.telefon;
            uiOutputRadnoMjesto.Text = korisnikZaPregled.radno_mjesto;
            uiOutputBrojRacuna.Text = korisnikZaPregled.broj_racuna;
            uiOutputMail.Text = korisnikZaPregled.email;

            PrikaziBiljeske();
            PrikaziZadatke();

        }

        //Prikazuje bilješke u DGV
        private void PrikaziBiljeske()
        {
            
            BindingList<biljeske> listaBiljeski = null;
            using (var db = new MilkyAppDataBaseEntities())
            {
                foreach (korisnici kor in db.korisnici)
                {
                    if (kor.email == uiOutputMail.Text)
                    {
                        db.korisnici.Attach(kor);
                        listaBiljeski = new BindingList<biljeske>(kor.biljeske.ToList<biljeske>());
                    }
                }
                biljeskeBindingSource.DataSource = listaBiljeski;
            }
           
            
        }

        //Prikazuje zadatke u DGV
        private void PrikaziZadatke()
        {

            BindingList<zadaci> listaZadataka = null;

            using (var db = new MilkyAppDataBaseEntities())
            {
                foreach (korisnici kor in db.korisnici)
                {
                    if (kor.email == uiOutputMail.Text)
                    {
                        db.korisnici.Attach(kor);
                        listaZadataka = new BindingList<zadaci>(kor.zadaci.ToList<zadaci>());
                    }
                }

                zadaciBindingSource.DataSource = listaZadataka;

            }
        }

        //Zatvranje forme
        private void uiActionOdustani_Click(object sender, EventArgs e)
        {

            Close();

        }

        //Oznacavanjem kucice se prikazuje lozinka u texbox i kada se odznaci se sakrije
        private void uiPrikaziSakrijLozinku_CheckedChanged(object sender, EventArgs e)
        {
            if (uiPrikaziSakrijLozinku.Checked == true)
            {

                using (var db = new MilkyAppDataBaseEntities())
                {
                    foreach (korisnici korisnik in db.korisnici)
                    {
                        if (korisnik.email == uiOutputMail.Text)
                        {
                            uiOutputLozinka.Text= korisnik.lozinka;
                        }
                    }

                    
                }

                uiPrikaziSakrijLozinku.Text = "Sakrij lozinku";
            }
            if (uiPrikaziSakrijLozinku.Checked == false)
            {
                uiOutputLozinka.Text = "";
                uiPrikaziSakrijLozinku.Text = "Prikaži lozinku";
            }
        }

        //Omogucuje upis nove lozinke
        private void uiActionPromijeniLozinku_Click(object sender, EventArgs e)
        {
            uiActionSpremi.Enabled = true;
            uiOutputLozinka.Enabled = true;
            uiPrikaziSakrijLozinku.Enabled = false;

        }

        //sprema novo odabranu lozinku za prijavljenog zapolenika
        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new MilkyAppDataBaseEntities())
            {
                foreach (korisnici korisnik in db.korisnici)
                {
                    if (korisnik.email == uiOutputMail.Text)
                    {
                        korisnik.lozinka = uiOutputLozinka.Text;
                    }
                }

                db.SaveChanges();
            }
            MessageBox.Show("Lozinka je promijenjena!");
            OnemoguciUredivanje();
            uiPrikaziSakrijLozinku.Enabled = true;
            uiOutputLozinka.Text = "";

        }
    }
}

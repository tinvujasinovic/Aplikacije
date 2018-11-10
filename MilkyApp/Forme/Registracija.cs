using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneriranjeLozinke;

namespace MilkyApp
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
            panelRegistracija.Anchor = AnchorStyles.None;
            panelRegistracija.Left = (this.ClientSize.Width - panelRegistracija.Width) / 2;
           panelRegistracija.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);

            uiInputStrucna.Items.Add("NSS");
            uiInputStrucna.Items.Add("SSS");
            uiInputStrucna.Items.Add("VŠS");
            uiInputStrucna.Items.Add("VSS");

            uiInputRadnoMjesto.Items.Add("Radnik u proizvodnji");
            uiInputRadnoMjesto.Items.Add("Tehničar");
            uiInputRadnoMjesto.Items.Add("Računovođa");
            uiInputRadnoMjesto.Items.Add("Poslovođa");
            uiInputRadnoMjesto.Items.Add("Prodavač");


        }

        //Nakon napuštanja texboxa provjerava da li postoji takav email u bazi
        private void uiInputMail_Leave(object sender, EventArgs e)
        {
            using (var db = new MilkyAppDataBaseEntities())
            {
                foreach (korisnici kor in db.korisnici)
                {
                    if (kor.email.ToString() == uiInputMail.Text)
                    {
                        MessageBox.Show("Korisnik pod tim emailom već postoji!");
                        uiInputMail.Text = "";
                    }
                }
            }
        }

        //Nakon napuštanja texboxa provjerava da li OIB ima 11 znakova
        private void uiInputOib_Leave(object sender, EventArgs e)
        {
            using (var db = new MilkyAppDataBaseEntities())
            {
                foreach (korisnici kor in db.korisnici)
                {
                    if (uiInputOib.Text.Length != 11)
                    {
                        MessageBox.Show("OIB mora sadržavati 11 znamenki");
                        uiInputOib.Text = "";
                    }
                }
            }
        }

        //Ako su ispunjeni svi podaci dodaje se novi zaposlenik
        private void uiActionDodajZaposlenika_Click(object sender, EventArgs e)
        {
            LozinkaKorisnika lozinka = new LozinkaKorisnika();
                string lozinkaKorisnika = lozinka.GenerirajLozinku();

                if (uiInputIme.Text != "" && uiInputPrezime.Text != "" && uiInputOib.Text != null && uiInputDatum.Value != null && uiInputUlica.Text != "" &&
                     uiInputGrad.Text != "" && uiInputStrucna.Text != "" && uiInputZanimanje.Text != "" && uiInputTelefon.Text != "" && uiInputRadnoMjesto.Text != "" &&
                     uiInputBrojRacuna.Text != "" && uiInputMail.Text != "")
                {

                    using (var db = new MilkyAppDataBaseEntities())
                    {
                    db.korisnici.Add(new korisnici
                    {

                        ime = uiInputIme.Text,
                        prezime = uiInputPrezime.Text,
                        OIB = decimal.Parse(uiInputOib.Text),
                        datum_rodenja = uiInputDatum.Value,
                        ulica_i_kucni_broj = uiInputUlica.Text,
                        grad = uiInputGrad.Text,
                        strucna_sprema = uiInputStrucna.Text,
                        zanimanje = uiInputZanimanje.Text,
                        telefon = uiInputTelefon.Text,
                        radno_mjesto = uiInputRadnoMjesto.Text,
                        broj_racuna = uiInputBrojRacuna.Text,
                        email = uiInputMail.Text,
                        lozinka = lozinkaKorisnika,
                        vlasnik = 0,
                        biljeske = null,
                        zadaci = null
                    });
                    
                    
                    db.SaveChanges();
                }


                MessageBox.Show("Novi korisnik je uspješno dodan! \n" +
                        "Podaci za prijavu \n" +
                        "email: " + uiInputMail.Text + "\n" +
                        "lozinka: " + lozinkaKorisnika);

                    uiInputIme.Text = "";
                    uiInputPrezime.Text = "";
                    uiInputOib.Text = null;
                    uiInputDatum.Value = DateTime.Now;
                    uiInputUlica.Text = "";
                    uiInputGrad.Text = "";
                    uiInputStrucna.Text = "";
                    uiInputZanimanje.Text = "";
                    uiInputTelefon.Text = "";
                    uiInputRadnoMjesto.Text = "";
                    uiInputBrojRacuna.Text = "";
                    uiInputMail.Text = "";

                   
            }
                else
                {
                    MessageBox.Show("Niste popunili sva polja!");
                }
            
        }

        
        //Zatvara formu 
        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

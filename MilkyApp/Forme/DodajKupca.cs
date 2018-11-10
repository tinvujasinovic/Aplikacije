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
    public partial class DodajKupca : Form
    {
        private bool uredi = false;
        private kupci kupacIzmjena;
        /// <summary>
        /// Konstruktor forme 
        /// </summary>
        public DodajKupca()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Konstruktor forme koji kao parametar prime kupca kojeg smo odabrali za izmjenu i njegove podatke upisuje u textbox-e
        /// </summary>
        public DodajKupca(kupci kupacIzmjena)
        {
            InitializeComponent();
            this.kupacIzmjena = kupacIzmjena;
            uredi = true;
            uiInputNaziv.Text = kupacIzmjena.naziv;
            uiInputOIB.Text = kupacIzmjena.OIB.ToString();
            uiInputTelefon.Text = kupacIzmjena.telefon;
            uiInputAdresa.Text = kupacIzmjena.adresa;
        }
        /// <summary>
        /// Metoda za zatvaranje trenutne forme
        /// </summary>
        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metoda koja stvara novog kupca i unesene podatke sprema u bazu podataka. Ukoliko podaci nisu ispravno uneseni
        /// javlja greška o tome i spreječava unos.
        /// </summary>
        private void uiActionDodajKupca_Click(object sender, EventArgs e)
        {
            
            if(uiInputAdresa.Text != "" || uiInputNaziv.Text!="" || uiInputOIB.Text != "" || uiInputTelefon.Text != "")
            {
                if (uiInputOIB.Text.Length == 11)
                {
                    using (var db = new MilkyAppDataBaseEntities())
                    {
                        try
                        {
                            db.kupci.Add(new kupci
                            {
                                naziv = uiInputNaziv.Text,
                                adresa = uiInputAdresa.Text,
                                telefon = uiInputTelefon.Text,
                                OIB = decimal.Parse(uiInputOIB.Text)
                            });

                            db.SaveChanges();
                            MessageBox.Show("Kupac uspješno dodan!");

                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Podaci nisu ispravni!");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("OIB mora sadržavati 11 brojki!");
                }

            }
            else
            {
                MessageBox.Show("Nisu ispunjena sva polja!");
            }
        }
        /// <summary>
        /// Funkcija koja se poziva kod Load-a forme kako bi se utvrdilo u kojem je modu otvorena, za kreiranje novog ili za uređivanje postojećeg
        /// kupca
        /// </summary>
        private void DodajKupca_Load(object sender, EventArgs e)
        {
            uiActionSpremiUredeni.Hide();
            if (uredi)
            {
                uiActionDodajKupca.Hide();
                uiActionSpremiUredeni.Show();
            }
        }
        /// <summary>
        /// Metoda koja kupca kojeg smo odabrali za uređivanje sprema u bazu podataka s novim podacima.
        /// </summary>
        private void uiActionSpremiUredeni_Click(object sender, EventArgs e)
        {
            using (var db = new MilkyAppDataBaseEntities())
            {
                db.kupci.Attach(kupacIzmjena);
                kupacIzmjena.naziv = uiInputNaziv.Text;
                kupacIzmjena.adresa = uiInputAdresa.Text;
                kupacIzmjena.OIB = decimal.Parse(uiInputOIB.Text);
                kupacIzmjena.telefon = uiInputTelefon.Text;
                db.SaveChanges();
            }
            this.Close();
        }
    }
}

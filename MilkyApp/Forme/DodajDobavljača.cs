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

    public partial class DodajDobavljača : Form
    {

        bool uredi = false;
        private dobavljaci dobavljacIzmjena;
        /// <summary>
        /// Konstruktor forme 
        /// </summary>
        public DodajDobavljača()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Konstruktor koji prima dobavljača kojeg ćemo mjenjati kao parametar, njegove podatek upisuje u textboxe.
        /// </summary>
        public DodajDobavljača(dobavljaci dobavljacIzmjena)
        {
            InitializeComponent();
            this.dobavljacIzmjena = dobavljacIzmjena;
            uredi = true;
            uiInputNaziv.Text = dobavljacIzmjena.naziv;
            uiInputOIB.Text = dobavljacIzmjena.OIB.ToString();
            uiInputTelefon.Text = dobavljacIzmjena.telefon;
            uiInputAdresa.Text = dobavljacIzmjena.adresa;
        }
        /// <summary>
        /// Metoda koja dobavljaca kojeg smo odabrali za uređivanje sprema u bazu podataka s novim podacima.
        /// </summary>
        private void uiActionSpremiUredeni_Click(object sender, EventArgs e)
        {
            using (var db = new MilkyAppDataBaseEntities())
            {
                db.dobavljaci.Attach(dobavljacIzmjena);
                dobavljacIzmjena.naziv = uiInputNaziv.Text;
                dobavljacIzmjena.adresa = uiInputAdresa.Text;
                dobavljacIzmjena.OIB = decimal.Parse(uiInputOIB.Text);
                dobavljacIzmjena.telefon = uiInputTelefon.Text;
                db.SaveChanges();
            }
            this.Close();
        }
        /// <summary>
        /// Metoda koja stvara novog dobavljača i unesene podatke sprema u bazu podataka. Ukoliko podaci nisu ispravno uneseni
        /// javlja greška o tome i spreječava unos.
        /// </summary>
        private void uiActionDodajDobavljaca_Click(object sender, EventArgs e)
        {
            if (uiInputAdresa.Text != "" && uiInputNaziv.Text != "" && uiInputOIB.Text != "" && uiInputTelefon.Text != "")
            {
                if (uiInputOIB.Text.Length == 11)
                {
                    using (var db = new MilkyAppDataBaseEntities())
                    {
                        try
                        {
                            db.dobavljaci.Add(new dobavljaci
                            {
                                naziv = uiInputNaziv.Text,
                                adresa = uiInputAdresa.Text,
                                telefon = uiInputTelefon.Text,
                                OIB = decimal.Parse(uiInputOIB.Text)
                            });

                            db.SaveChanges();
                            MessageBox.Show("Dobavljač uspješno dodan!");

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
        /// dobavljača
        /// </summary>
        private void DodajDobavljača_Load(object sender, EventArgs e)
        {
            uiActionSpremiUredeni.Hide();
            if (uredi)
            {
                uiActionDodajDobavljaca.Hide();
                uiActionSpremiUredeni.Show();
            }
        }
        /// <summary>
        /// Metoda za zatvaranje trenutne forme
        /// </summary>
        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

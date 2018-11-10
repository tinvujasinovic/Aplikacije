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
    public partial class NarudžbaSirovine : Form
    {
        private sirovine sirovinaIzmjena;
        /// <summary>
        /// Konstruktor forme koji skriva kontrole za uređivanje sirovina
        /// </summary>
        public NarudžbaSirovine()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            uiInputKolicina.Hide();
            labelSirovina.Hide();
            uiActionNaruciSirovinu.Hide();
        }
        /// <summary>
        /// Konstruktor forme koji skriva kontrole za dodavanje novih sirovina
        /// </summary>
        public NarudžbaSirovine(sirovine sirovinaIzmjena)
        {
            InitializeComponent();
            this.sirovinaIzmjena = sirovinaIzmjena;
            labelSirovina.Text = sirovinaIzmjena.naziv;
            uiInputNaziv.Hide();
            uiInputOpis.Hide();
            uiActionDodaj.Hide();
            label3.Hide();
            label4.Hide();
        }
        /// <summary>
        /// Metoda koja dodaje novu naručenu količinu u bazu podataka
        /// </summary>
        private void uiActionNaruciSirovinu_Click(object sender, EventArgs e)
        {
            using (var db = new MilkyAppDataBaseEntities())
            {
                db.sirovine.Attach(sirovinaIzmjena);
                int trenutno = sirovinaIzmjena.raspolozivo;
                sirovinaIzmjena.raspolozivo = trenutno + int.Parse(uiInputKolicina.Text);
                db.SaveChanges();
            }
            this.Close();
        }
        /// <summary>
        /// Metoda koja provjerava da smo količinu unijeli kao broj(int)
        /// </summary>
        private void uiInputKolicina_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(uiInputKolicina.Text);
            }
            catch
            {
                MessageBox.Show("Količina mora biti unesena kao broj!");
            }
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metoda koja dodaje novu sirovinu u sustav
        /// </summary>
        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new MilkyAppDataBaseEntities())
            {
                if (uiInputNaziv.Text != "" && uiInputOpis.Text != "")
                {
                    db.sirovine.Add(new sirovine
                    {
                        naziv = uiInputNaziv.Text,
                        raspolozivo = 0,
                        opis=uiInputOpis.Text
                    });

                    db.SaveChanges();
                    MessageBox.Show("Sirovina uspješno dodana!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nisu ispunjena sva polja!");
                }
            }
        }
    }
}

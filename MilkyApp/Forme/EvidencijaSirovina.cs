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
    public partial class EvidencijaSirovina : Form
    {
        /// <summary>
        /// Konstruktor forme koji kod pokretanja prikazuje sve sirovine iz baze podataka
        /// </summary>
        public EvidencijaSirovina()
        {
            InitializeComponent();
            PrikaziSirovine();
        }
        /// <summary>
        /// Metoda koja dohvaća sve sirovine i prikazuje ih u DGV
        /// </summary>
        private void PrikaziSirovine()
        {
            BindingList<sirovine> listaSirovina = null;
            using (var db = new MilkyAppDataBaseEntities())
            {
                listaSirovina = new BindingList<sirovine>(db.sirovine.ToList());
            }
            sirovineBindingSource.DataSource = listaSirovina;
        }

        /// <summary>
        /// Metoda koja otvara formu za naručivanje novih količina odabrane sirovine
        /// </summary>
        private void uiActionNaruci_Click(object sender, EventArgs e)
        {
            sirovine sirovinaIzmjena = sirovineBindingSource.Current as sirovine;

            NarudžbaSirovine narudzba = new NarudžbaSirovine(sirovinaIzmjena);
            narudzba.ShowDialog();
            PrikaziSirovine();
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metoda koja otvara formu za dodavanje nove sirovine u bazu podataka
        /// </summary>
        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            NarudžbaSirovine dodaj = new NarudžbaSirovine();
            dodaj.ShowDialog();
            PrikaziSirovine();
        }
    }
}

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
    public partial class EvidencijaKupaca : Form
    {
        public EvidencijaKupaca()
        {
            InitializeComponent();
            PrikaziKupca();

        }
        /// <summary>
        /// Funkcija koja otvara formu za dodavanje novog kupca
        /// </summary>
        private void DodajKupca_Click(object sender, EventArgs e)
        {
            DodajKupca kupacAdd = new DodajKupca();
            kupacAdd.ShowDialog();
            PrikaziKupca();
        }
        /// <summary>
        /// Funkcija koja dohvaća sve kupca i prikazuje ih u DGV
        /// </summary>
        private void PrikaziKupca()
        {
            BindingList<kupci> listaKupaca = null;
            using (var db = new MilkyAppDataBaseEntities())
            {
                listaKupaca = new BindingList<kupci>(db.kupci.ToList());
            }
            kupciBindingSource.DataSource = listaKupaca;
        }
        /// <summary>
        /// Funkcija koja odabranog kupca u DGV briše iz baze podataka
        /// </summary>
        private void uiActionObrisiKupca_Click(object sender, EventArgs e)
        {
            kupci kupacDelete = kupciBindingSource.Current as kupci;
            if (kupacDelete != null)
            {
                if(MessageBox.Show("Želite li stvarno obrisati ovog kupca?", "Upozorenje", MessageBoxButtons.YesNoCancel)==System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new MilkyAppDataBaseEntities())
                    {
                        db.kupci.Attach(kupacDelete);
                        if (kupacDelete.narudzbe.Count != 0)
                        {
                            MessageBox.Show("Kupac ima neisporučene narudžbe, ne mogu ga obrisati!");
                        }
                        else
                        {
                            db.kupci.Remove(kupacDelete);
                            db.SaveChanges();
                            PrikaziKupca();
                        }
                    }
                   
                }
            }

        }
        /// <summary>
        /// Funkcija koja otvara formu za uređivanje dobavljača s prosljeđenim parametrom odabranog dobavljača
        /// </summary>
        private void uiActionUrediKupca_Click(object sender, EventArgs e)
        {
            kupci kupacIzmjena = kupciBindingSource.Current as kupci;
            if (kupacIzmjena != null)
            {
                DodajKupca uredi = new DodajKupca(kupacIzmjena);
                uredi.ShowDialog();
            }
            PrikaziKupca();
        }
        /// <summary>
        /// Funkcija koja ponovo prikazuje sve kupce i brise tekst iz tekstboxa za pretraživanje
        /// </summary>
        private void uiActionReset_Click(object sender, EventArgs e)
        {
            PrikaziKupca();
            uiInputPretrazivanje.Text = "";
        }
        /// <summary>
        /// Funkcija koja prema unesenom tekstu pretražuje bazu podataka i prikazuje kupce koji sadrže taj tekst u nazivu
        /// </summary>
        private void uiActionPretrazi_Click(object sender, EventArgs e)
        {
            var db = new MilkyAppDataBaseEntities();

            string naziv = uiInputPretrazivanje.Text;

            var connection = (System.Data.SqlClient.SqlConnection)db.Database.Connection;

            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var dt = new DataTable();

            using (var com = new System.Data.SqlClient.SqlDataAdapter("Select * from kupci where naziv like '%"+naziv+"%'", connection))
            {
                com.Fill(dt);
            }
            kupciBindingSource.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

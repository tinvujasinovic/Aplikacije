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
    public partial class EvidencijaDobavljača : Form
    {
        /// <summary>
        /// Konstruktor forme 
        /// </summary>
        public EvidencijaDobavljača()
        {
            InitializeComponent();
            PrikaziDobavljace();
        }
        /// <summary>
        /// Funkcija koja dohvaća sve dobavljače i prikazuje ih u DGV
        /// </summary>
        private void PrikaziDobavljace()
        {
            BindingList<dobavljaci> listaDobavljaca = null;
            using (var db = new MilkyAppDataBaseEntities())
            {
                listaDobavljaca = new BindingList<dobavljaci>(db.dobavljaci.ToList());
            }
            dobavljaciBindingSource.DataSource = listaDobavljaca;
        }
        /// <summary>
        /// Funkcija koja otvara formu za dodavanje novog dobavljača
        /// </summary>
        private void uiActionDodajDobavljaca_Click(object sender, EventArgs e)
        {
            DodajDobavljača dodaj = new DodajDobavljača();
            dodaj.ShowDialog();
            PrikaziDobavljace();
        }
        /// <summary>
        /// Funkcija koja otvara formu za uređivanje dobavljača s prosljeđenim parametrom odabranog dobavljača
        /// </summary>
        private void uiActionUrediDobavljaca_Click(object sender, EventArgs e)
        {
            dobavljaci dobavljacIzmjena = dobavljaciBindingSource.Current as dobavljaci;
            if (dobavljacIzmjena != null)
            {
                DodajDobavljača uredi = new DodajDobavljača(dobavljacIzmjena);
                uredi.ShowDialog();
            }
            PrikaziDobavljace();
        }
        /// <summary>
        /// Funkcija koja ponovo prikazuje sve dobavljače i brise tekst iz tekstboxa za pretraživanje
        /// </summary>
        private void uiActionReset_Click(object sender, EventArgs e)
        {
            PrikaziDobavljace();
            uiInputPretrazivanje.Text = "";
        }
        /// <summary>
        /// Funkcija koja prema unesenom tekstu pretražuje bazu podataka i prikazuje dobavljače koji sadrže taj tekst u nazivu
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

            using (var com = new System.Data.SqlClient.SqlDataAdapter("Select * from dobavljaci where naziv like '%" + naziv + "%'", connection))
            {
                com.Fill(dt);
            }
            dobavljaciBindingSource.DataSource = dt;
        }
        /// <summary>
        /// Funkcija koja odabranog dobavljača u DGV briše iz baze podataka
        /// </summary>
        private void uiActionObrisiDobavljaca_Click(object sender, EventArgs e)
        {
            dobavljaci dobavljacDelete = dobavljaciBindingSource.Current as dobavljaci;
            if (dobavljacDelete != null)
            {
                if (MessageBox.Show("Želite li stvarno obrisati ovog dobavljača?", "Upozorenje", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new MilkyAppDataBaseEntities())
                    {
                        db.dobavljaci.Attach(dobavljacDelete);
                        if (dobavljacDelete.dobavlja.Count != 0)
                        {
                            MessageBox.Show("Dobavljač dobavlja sirovine, ne mogu ga obrisati!");
                        }
                        else
                        {
                            db.dobavljaci.Remove(dobavljacDelete);
                            db.SaveChanges();
                            PrikaziDobavljace();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

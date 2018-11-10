using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkyApp
{
    public partial class EvidencijaRačuna : Form
    {
        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public EvidencijaRačuna()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda koja dohvaća podatke o automatski odabranom kupcu u ComboBoxu i prikazuje ih u DGV
        /// </summary>
        private void EvidencijaRačuna_Load(object sender, EventArgs e)
        {
            var db = new MilkyAppDataBaseEntities();
           
            var connection = (System.Data.SqlClient.SqlConnection)db.Database.Connection;

            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var dt = new DataTable();

            using (var com = new System.Data.SqlClient.SqlDataAdapter("Select * from kupci", connection))
            {
                com.Fill(dt);
            }
            comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "naziv";
            comboBox1.ValueMember = "kupac_ID";
        }
        /// <summary>
        /// Metoda koja dohvaća podatke o  odabranom kupcu u ComboBoxu i prikazuje ih u DGV
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView view = comboBox1.SelectedItem as DataRowView;
            int id = Convert.ToInt32(view["kupac_ID"]);

            var db = new MilkyAppDataBaseEntities();

            var connection = (System.Data.SqlClient.SqlConnection)db.Database.Connection;

            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var dt = new DataTable();

            using (var com = new System.Data.SqlClient.SqlDataAdapter("Select * from narudzbe where kupac_ID='"+id+"'", connection))
            {
                com.Fill(dt);
            }

            dataGridView1.DataSource = dt;
        }
        /// <summary>
        /// Metoda koja otvara formu za izradu novog računa i prosljeđuje joj podatke o odabranoj narudžbi i kupcu
        /// </summary>
        private void uiActionIzradiRacun_Click(object sender, EventArgs e)
        {
            try
            {
                string kupac = comboBox1.Text;
                int narudzba_ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int kupac_ID = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                string datum = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string[] date = datum.Split(' ');

                IzradaRačuna izrada = new IzradaRačuna(narudzba_ID, kupac_ID, kupac, date[0]);
                izrada.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Nije odabrani ni jedan redak!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

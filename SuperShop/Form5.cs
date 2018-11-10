using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace baze_rad
{
    public partial class Form5 : Form
    {
        string connectionString = "Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;";
        int id_lokacije = 0;

        public Form5()
        {
            InitializeComponent();
            Fill();
            GridFill();
            brisi.Enabled = false;
        }

        void Fill()
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string Querry = "select * from lista.trgovina;";
                MySqlCommand sqlCmd = new MySqlCommand(Querry, mysqlCon);
                mysqlCon.Open();
                MySqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string Sname = reader.GetString("ID_trgovine");
                    comboBox1.Items.Add(Sname);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string Querry = "select Naziv from lista.trgovina where ID_trgovine = " + comboBox1.Text + ";";
                MySqlCommand sqlCmd = new MySqlCommand(Querry, mysqlCon);
                mysqlCon.Open();
                MySqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string Sname = reader.GetString("Naziv");
                    trg.Text = Sname;

                }
            }
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllLokacija", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblLokacija = new DataTable();
                sqlDa.Fill(dtblLokacija);
                dataGridView1.DataSource = dtblLokacija;
                dataGridView1.Columns[0].Visible = false;
            }

        }


        void clear()
        {
            tel.Text = adr.Text = search.Text = "";
            comboBox1.Refresh();
            id_lokacije = 0;
            spremi.Text = "Spremi";
            brisi.Enabled = false;
            comboBox1.ResetText();
            trg.Text = "";
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("lokAddEdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_lokacije", id_lokacije);
                mysqlCmd.Parameters.AddWithValue("_Adresa", adr.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Telefon", tel.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_trgovina_ID_trgovine", comboBox1.SelectedIndex+1);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                adr.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                id_lokacije = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                spremi.Text = "Azuriraj";
                brisi.Enabled = Enabled;

            }
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("DeleteByIDLokacija", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_lokacije", id_lokacije);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pretraziSve_Click(object sender, EventArgs e)
        {
            GridFill();
            clear();
        }

        private void pretrazi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchLokacija", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchVal", search.Text);
                DataTable dtblLokacija = new DataTable();
                sqlDa.Fill(dtblLokacija);
                dataGridView1.DataSource = dtblLokacija;

            }
        }
    }

}

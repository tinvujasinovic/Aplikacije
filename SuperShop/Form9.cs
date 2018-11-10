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
    public partial class Form9 : Form
    {
        string connectionString = "Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;";

        public Form9()
        {
            InitializeComponent();
            clear();
            GridFill();
            brisi.Enabled = false;
            Fill();
            Fill1();
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            update.Visible = Enabled;
            brisi.Enabled = Enabled;
            spremi.Visible = false;

        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            search.Text = "";
            update.Visible = false;

        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllStavka", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblRacun = new DataTable();
                sqlDa.Fill(dtblRacun);
                dataGridView1.DataSource = dtblRacun;
                clear();
                dataGridView1.Columns[0].HeaderText = "ID racuna";
                dataGridView1.Columns[1].HeaderText = "ID proizvoda";
                dataGridView1.Columns[2].HeaderText = "ID proizvoda_proizvod";
                dataGridView1.Columns[2].Width = 138;
            }
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
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchStavka", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchVal", search.Text);
                DataTable dtblStavka = new DataTable();
                sqlDa.Fill(dtblStavka);
                dataGridView1.DataSource = dtblStavka;
                clear();
            }
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("DeleteByIDStavka", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_proizvodi_na_racunu_ID_racuna", comboBox1.SelectedIndex + 1);
                mysqlCmd.Parameters.AddWithValue("_proizvodi_na_racunu_ID_proizvoda", comboBox2.SelectedIndex + 1);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
                brisi.Enabled = false;
                spremi.Visible = true;

            }
        }
        void Fill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string Querry = "select * from lista.racun;";
                MySqlCommand sqlCmd = new MySqlCommand(Querry, mysqlCon);
                mysqlCon.Open();
                MySqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string Sname = reader.GetString("ID_racuna");
                    comboBox1.Items.Add(Sname);
                }
            }
        }

        void Fill1()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string Querry = "select * from lista.proizvod;";
                MySqlCommand sqlCmd = new MySqlCommand(Querry, mysqlCon);
                mysqlCon.Open();
                MySqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string Sname = reader.GetString("ID_proizvoda");
                    comboBox2.Items.Add(Sname);
                }
            }
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("StavkaAdd", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_proizvodi_na_racunu_ID_proizvoda", comboBox2.SelectedIndex + 1);
                mysqlCmd.Parameters.AddWithValue("_proizvod_ID_proizvoda", comboBox2.SelectedIndex + 1);
                mysqlCmd.Parameters.AddWithValue("_proizvodi_na_racunu_ID_racuna", comboBox1.SelectedIndex + 1);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("StavkaEdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_proizvodi_na_racunu_ID_proizvoda", comboBox2.Text.ToString());
                mysqlCmd.Parameters.AddWithValue("_proizvodi_na_racunu_ID_racuna", comboBox1.Text.ToString());
                mysqlCmd.ExecuteNonQuery();
                spremi.Visible = true;
                clear();
                GridFill();
            }
        }
    }
}

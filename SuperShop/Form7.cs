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
    public partial class Form7 : Form
    {
        string connectionString = "Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;";
        public Form7()
        {
            InitializeComponent();
            Fill();
            Fill1();
            GridFill();
            brisi.Enabled = false;
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            update.SendToBack();
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

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllCijene", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblCijene = new DataTable();
                sqlDa.Fill(dtblCijene);
                dataGridView1.DataSource = dtblCijene;
                clear();
            }

        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            search.Text = cijena.Text = "";
            spremi.Text = "Spremi";
            brisi.Enabled = false;
            comboBox2.ResetText();
            comboBox1.ResetText();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string Querry = "select Naziv from lista.proizvod where ID_proizvoda = " + comboBox2.Text + ";";
                MySqlCommand sqlCmd = new MySqlCommand(Querry, mysqlCon);
                mysqlCon.Open();
                MySqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string Sname = reader.GetString("Naziv");
                    pro.Text = Sname;
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

        private void spremi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("cijenaAdd", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_Cijena", cijena.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_proizvod_ID_proizvoda", comboBox2.SelectedIndex + 1);
                mysqlCmd.Parameters.AddWithValue("_trgovina_ID_trgovine", comboBox1.SelectedIndex + 1);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            cijena.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            brisi.Enabled = Enabled;

            spremi.Visible = false;

        }

        private void update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("cijenaEdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_Cijena", cijena.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_trgovina_ID_trgovine", comboBox1.Text.ToString());
                mysqlCmd.Parameters.AddWithValue("_proizvod_ID_proizvoda", comboBox2.Text.ToString());
                mysqlCmd.ExecuteNonQuery();
                spremi.Visible = true;
                clear();
                GridFill();
            }
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("DeleteByIDCijena", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_trgovina_ID_trgovine", comboBox1.SelectedIndex+1);
                mysqlCmd.Parameters.AddWithValue("_proizvod_ID_proizvoda", comboBox2.SelectedIndex+1);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
                brisi.Enabled = false;
                spremi.Visible = true;

            }
        }

        private void pretrazi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchCijene", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchVal", search.Text);
                DataTable dtblKorisnik = new DataTable();
                sqlDa.Fill(dtblKorisnik);
                dataGridView1.DataSource = dtblKorisnik;
                clear();
            }
        }

        private void pretraziSve_Click(object sender, EventArgs e)
        {
            GridFill();
            clear();
        }
    }
}

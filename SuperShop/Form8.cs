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
    public partial class Form8 : Form
    {
        string connectionString = "Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;";
        public Form8()
        {
            InitializeComponent();
            GridFill();
            update.Visible = false;
            Fill();
            Fill1();
            brisi.Enabled = false;
        }

        void clear()
        {
            update.Visible = false;
            kolicina.Text = "";
            comboBox1.ResetText();
            comboBox2.ResetText();

        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllPnaR", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblRacun = new DataTable();
                sqlDa.Fill(dtblRacun);
                dataGridView1.DataSource = dtblRacun;
                clear();
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
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchPnaR", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchVal", search.Text);
                DataTable dtblRacun = new DataTable();
                sqlDa.Fill(dtblRacun);
                dataGridView1.DataSource = dtblRacun;
                clear();
            }
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("DeleteByIDPnaR", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_racuna", comboBox1.SelectedIndex + 1);
                mysqlCmd.Parameters.AddWithValue("_ID_proizvoda", comboBox2.SelectedIndex + 1);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
                brisi.Enabled = false;
                spremi.Visible = true;

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            update.Visible = Enabled;
            kolicina.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            brisi.Enabled = Enabled;

            spremi.Visible = false;

        }

        private void update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("PnaREdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_Kolicina", kolicina.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_ID_racuna", comboBox1.Text.ToString());
                mysqlCmd.Parameters.AddWithValue("_ID_proizvoda", comboBox2.Text.ToString());
                mysqlCmd.ExecuteNonQuery();
                spremi.Visible = true;
                clear();
                GridFill();
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
                MySqlCommand mysqlCmd = new MySqlCommand("PnaRAdd", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_Kolicina", kolicina.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_ID_proizvoda", comboBox2.SelectedIndex + 1);
                mysqlCmd.Parameters.AddWithValue("_ID_racuna", comboBox1.SelectedIndex + 1);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }
        }
    }
}

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
    public partial class Form3 : Form
    {
        string connectionString = "Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;";
        int id_proizvoda = 0;
        public Form3()
        {
            InitializeComponent();
            Fill();
            Fill1();
            GridFill();
            brisi.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string Querry = "select Naziv from lista.proizvodac where ID_proizvodaca = " + comboBox2.Text + ";";
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
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllProizvod", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblProizvod = new DataTable();
                sqlDa.Fill(dtblProizvod);
                dataGridView1.DataSource = dtblProizvod;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 165;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[0].Visible = false;
            }

        }

        void Fill()
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string Querry = "select * from lista.proizvodac;";
                MySqlCommand sqlCmd = new MySqlCommand(Querry, mysqlCon);
                mysqlCon.Open();
                MySqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string Sname = reader.GetString("ID_proizvodaca");
                    comboBox2.Items.Add(Sname);
                }
            }
        }
        void Fill1()
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string Querry = "select * from lista.mjerne_jedinice;";
                MySqlCommand sqlCmd = new MySqlCommand(Querry, mysqlCon);
                mysqlCon.Open();
                MySqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string Sname = reader.GetString("ID_mjerne_jedinice");
                    comboBox1.Items.Add(Sname);
                }
            }
        }
        void clear()
        {
            naziv.Text = pro.Text = mj.Text = search.Text = "";
            id_proizvoda = 0;
            spremi.Text = "Spremi";
            brisi.Enabled = false;
            comboBox2.ResetText();
            comboBox1.ResetText();
            
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("proizvodAddEdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_proizvoda", id_proizvoda);
                mysqlCmd.Parameters.AddWithValue("_Naziv", naziv.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_ID_proizvodaca", comboBox1.SelectedIndex+1);
                mysqlCmd.Parameters.AddWithValue("_ID_mjerne_jedinice", comboBox2.SelectedIndex+1);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string Querry = "select Puni_naziv from lista.mjerne_jedinice where ID_mjerne_jedinice = " + comboBox1.Text + ";";
                MySqlCommand sqlCmd = new MySqlCommand(Querry, mysqlCon);
                mysqlCon.Open();
                MySqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string Sname = reader.GetString("Puni_naziv");
                    mj.Text = Sname;
                    
                }
            }
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pretrazi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchProizvod", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchVal", search.Text);
                DataTable dtblProizvod = new DataTable();
                sqlDa.Fill(dtblProizvod);
                dataGridView1.DataSource = dtblProizvod;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 165;
                dataGridView1.Columns[3].Width = 200;
            }
        }

        private void pretraziSve_Click(object sender, EventArgs e)
        {
            GridFill();
            clear();
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("DeleteByIDProizvod", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_proizvoda", id_proizvoda);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                naziv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                id_proizvoda = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                spremi.Text = "Azuriraj";
                brisi.Enabled = Enabled;

            }
        }
    }
}

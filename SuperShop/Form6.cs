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
    public partial class Form6 : Form
    {
        string connectionString = "Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;";
        int id_racuna = 0;

        public Form6()
        {
            InitializeComponent();
            Fill();
            GridFill();
            clear();
            brisi.Enabled = false;
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllRacun", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblRacun = new DataTable();
                sqlDa.Fill(dtblRacun);
                dataGridView1.DataSource = dtblRacun;
                clear();
            }

        }

        void Fill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string Querry = "select * from lista.korisnik;";
                MySqlCommand sqlCmd = new MySqlCommand(Querry, mysqlCon);
                mysqlCon.Open();
                MySqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string Sname = reader.GetString("Korisnicko_ime");
                    comboBox1.Items.Add(Sname);
                }
            }
        }

        void clear()
        {
            comboBox1.ResetText();
            search.Text = label4.Text = "";
            spremi.Text = "Spremi";
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("racunAddEdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                float uk = 100;
                mysqlCmd.Parameters.AddWithValue("_ID_racuna", id_racuna);
                mysqlCmd.Parameters.AddWithValue("_Ukupno", uk);
                mysqlCmd.Parameters.AddWithValue("_korisnik_Korisnicko_ime", comboBox1.Text.ToString());
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
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
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchRacun", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchVal", search.Text);
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            brisi.Enabled = Enabled;
            id_racuna = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            spremi.Text = "Azuriraj";
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("DeleteByIDRacun", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_racuna", id_racuna);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
                brisi.Enabled = false;

            }
        }
    }
}

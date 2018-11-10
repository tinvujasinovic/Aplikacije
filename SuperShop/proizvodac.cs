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
    public partial class Proizvodac : Form
    {
        string connectionString = "Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;";
        int id_proizvodaca = 0;
        public Proizvodac()
        {
            InitializeComponent();
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllProizvodac", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblProizvodac = new DataTable();
                sqlDa.Fill(dtblProizvodac);
                dataGridView1.DataSource = dtblProizvodac;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[0].Visible = false;
            }
        }
        void clear()
        {
            naziv.Text = adresa.Text = telefon.Text = search.Text = "";
            id_proizvodaca = 0;
            spremi.Text = "Spremi";
            brisi.Enabled = false;

        }
        private void spremi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("proizvodacAddEdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_proizvodaca", id_proizvodaca);
                mysqlCmd.Parameters.AddWithValue("_Naziv", naziv.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Adresa", adresa.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Telefon", telefon.Text.Trim());
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }
        }

        private void pretraziSve_Click(object sender, EventArgs e)
        {
            GridFill();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            clear();
            GridFill();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                naziv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                adresa.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                telefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                id_proizvodaca = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                spremi.Text = "Azuriraj";
                brisi.Enabled = Enabled;

            }
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("DeleteByIDproizvodac", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_proizvodaca", id_proizvodaca);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }
        }

        private void pretrazi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchProizvodac", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchVal", search.Text);
                DataTable dtblProizvodac = new DataTable();
                sqlDa.Fill(dtblProizvodac);
                dataGridView1.DataSource = dtblProizvodac;
            }
        }
    }
}
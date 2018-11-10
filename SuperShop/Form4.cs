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
    public partial class Form4 : Form
    {
        string connectionString = "Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;";
        int id_trg = 0;

        public Form4()
        {
            InitializeComponent();
            GridFill();
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("trgAddEdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_trgovine", id_trg);
                mysqlCmd.Parameters.AddWithValue("_Naziv", naziv.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Web", web.Text.Trim());
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }
        }
        void clear()
        {
            naziv.Text = web.Text = search.Text = "";
            id_trg = 0;
            spremi.Text = "Spremi";
            brisi.Enabled = false;
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllTrg", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblTrg = new DataTable();
                sqlDa.Fill(dtblTrg);
                dataGridView1.DataSource = dtblTrg;
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void pretraziSve_Click(object sender, EventArgs e)
        {
            GridFill();
            clear();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                naziv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                web.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                id_trg = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                spremi.Text = "Azuriraj";
                brisi.Enabled = Enabled;

            }
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("DeleteByIDTrg", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_trgovine", id_trg);
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
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchTrg", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchVal", search.Text);
                DataTable dtblTrg = new DataTable();
                sqlDa.Fill(dtblTrg);
                dataGridView1.DataSource = dtblTrg;

            }
        }
    }
}

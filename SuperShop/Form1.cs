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
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;";
        int id_mjerne_jedinice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("mjerneAddEdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_mjerne_jedinice", id_mjerne_jedinice);
                mysqlCmd.Parameters.AddWithValue("_Puni_naziv", naziv.Text.Trim());
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }

        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllMjerne", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblMjerne = new DataTable();
                sqlDa.Fill(dtblMjerne);
                dataGridView1.DataSource = dtblMjerne;
                dataGridView1.Columns[1].Width = 250;
                dataGridView1.Columns[0].Width = 1;
                dataGridView1.Columns[0].Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
            GridFill();
        }

        void clear()
        {
            naziv.Text = search.Text = "";
            id_mjerne_jedinice = 0;
            spremi.Text = "Spremi";
            brisi.Enabled = false;
        
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                naziv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                id_mjerne_jedinice = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                spremi.Text = "Azuriraj";
                brisi.Enabled = Enabled;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("DeleteByIDMjerne", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_mjerne_jedinice", id_mjerne_jedinice);
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchMjerne", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchVal", search.Text);
                DataTable dtblMjerne = new DataTable();
                sqlDa.Fill(dtblMjerne);
                dataGridView1.DataSource = dtblMjerne;
                dataGridView1.Columns[1].Width = 250;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GridFill();
        }
    }
}

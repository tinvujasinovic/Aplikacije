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
    public partial class Form2 : Form
    {
        string connectionString = "Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;";
        string korisnicko;

        public Form2()
        {
            InitializeComponent();
            update.SendToBack();
            GridFill();
            clear();

            textBox2.Leave += new EventHandler(textBox2_Leave);

        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            korisnicko = textBox2.Text.ToString();
        }

        void clear()
        {
            textBox2.Text = textBox1.Text = naziv.Text = search.Text = "";
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("korisnikAdd", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_Korisnicko_ime", textBox2.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Email", naziv.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Lozinka", textBox1.Text.Trim());
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
                MySqlCommand mysqlCmd = new MySqlCommand("korisnikEdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_Korisnicko_ime", textBox2.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Email", naziv.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Lozinka", textBox1.Text.Trim());
                mysqlCmd.ExecuteNonQuery();
                spremi.Visible = true;
                clear();
                GridFill();

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            naziv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            brisi.Enabled = Enabled;

            spremi.Visible = false;
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("korisnikEdit", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_Korisnicko_ime", textBox2.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Email", naziv.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Lozinka", textBox1.Text.Trim());
                mysqlCmd.ExecuteNonQuery();
            }

        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllKorisnik", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblKorisnik = new DataTable();
                sqlDa.Fill(dtblKorisnik);
                dataGridView1.DataSource = dtblKorisnik;

            }

        }

        private void brisi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("DeleteByIDKorisnik", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_Korisnicko_ime", textBox2.Text.Trim());
                mysqlCmd.ExecuteNonQuery();
                clear();
                GridFill();
                brisi.Enabled = false;
                spremi.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchKorisnik", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchVal", search.Text);
                DataTable dtblKorisnik = new DataTable();
                sqlDa.Fill(dtblKorisnik);
                dataGridView1.DataSource = dtblKorisnik;
                clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GridFill();
            clear();
        }
    }
}

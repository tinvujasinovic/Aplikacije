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
    public partial class login : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lista;Uid=root;Pwd=qwe123qwe;");
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        public login()
        {
            InitializeComponent();
        }

        private void izadi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prijava_Click(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("Select Korisnicko_ime, Lozinka from korisnik where Korisnicko_ime='" + textBox1.Text + "' and Lozinka='" + textBox2.Text + "'", connection);
            adapter.Fill(table);

            if(table.Rows.Count <= 0)
            {
                MessageBox.Show("Pogresni podaci!");
            }
            else
            {
                this.Hide();
                main ss = new main();
                ss.Show();

            }


        }
    }
}

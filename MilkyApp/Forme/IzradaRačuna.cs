using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KreiranjeRacuna;
using System.Drawing.Printing;

namespace MilkyApp
{
    public partial class IzradaRačuna : Form
    {
        private int narudzba_ID;
        private int kupac_ID;
        private string kupac;
        private string datum;
        private double Ukupno;

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public IzradaRačuna()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Konstruktor forme koji prima podatke o kupcu i narudžbi
        /// </summary>
        public IzradaRačuna(int narudzba_ID, int kupac_ID, string kupac, string datum)
        {
            InitializeComponent();
            this.narudzba_ID = narudzba_ID;
            this.kupac_ID = kupac_ID;
            this.kupac = kupac;
            this.datum = datum;
        }
        /// <summary>
        /// Metoda koja se poziva kod Load-a forme, dohvaća sve podatke o računu (naziv proizvoda, mjernu jedinicu..) i prikazuje ih u DGV 
        /// </summary>
        private void IzradaRačuna_Load(object sender, EventArgs e)
        {
            textBox1.Text = narudzba_ID.ToString();
            textBox2.Text = kupac;
            textBox3.Text = datum;

            List<int> listaIdProizvoda = new List<int>();
            List<int> listaKolicinaProizvoda = new List<int>();

            using (var db = new MilkyAppDataBaseEntities())
            {
                var IdProizvoda = db.Database.SqlQuery<int>("Select proizvod_ID from proizvodi_na_narudzbi where narudzba_ID=" + narudzba_ID).ToList();
                foreach (var item in IdProizvoda)
                {
                    listaIdProizvoda.Add(item);
                }
            }

            using (var db = new MilkyAppDataBaseEntities())
            {
                foreach (var item in listaIdProizvoda)
                {
                    var KolicinaProizvoda = db.Database.SqlQuery<int>("Select kolicina from proizvodi_na_narudzbi where proizvod_ID=" + item).ToList();
                    listaKolicinaProizvoda.Add(KolicinaProizvoda[0]);
                }
            }

            List<string> ListaNazivaProizvoda = new List<string>();
            List<double> ListaCijenaProizvoda = new List<double>();

            foreach (var item in listaIdProizvoda)
            {
                using (var db = new MilkyAppDataBaseEntities())
                {
                    var nazivProizvoda = db.Database.SqlQuery<string>("Select naziv from proizvodi where proizvod_ID=" + item ).ToList();
                    ListaNazivaProizvoda.Add(nazivProizvoda[0]);
                    var cijenaProizvoda = db.Database.SqlQuery<double>("Select cijena from proizvodi where proizvod_ID=" + item).ToList();
                    ListaCijenaProizvoda.Add(cijenaProizvoda[0]);
                }
            }

            List<int> ListaMjernihId = new List<int>();

            foreach (var item in ListaNazivaProizvoda)
            {
                using (var db = new MilkyAppDataBaseEntities())
                {
                    var mjerneJediniceId = db.Database.SqlQuery<int>("Select mjerna_jedinica_ID from proizvodi where naziv='" + item+"'").ToList();
                    ListaMjernihId.Add(mjerneJediniceId[0]);
                }
            }

            List<string> ListaMjernihNaziv = new List<string>();

            foreach (var item in ListaMjernihId)
            {
                using (var db = new MilkyAppDataBaseEntities())
                {
                    var mjerneJediniceNaziv = db.Database.SqlQuery<string>("Select naziv from mjerne_jedinice where mjerna_jedinica_ID=" + item ).ToList();
                    ListaMjernihNaziv.Add(mjerneJediniceNaziv[0]);
                }
            }

            StavkeRacuna stavkeRacuna = new StavkeRacuna(ListaNazivaProizvoda,ListaCijenaProizvoda,listaKolicinaProizvoda,ListaMjernihNaziv);
            
            List<Stavka> datasource = stavkeRacuna.KreirajListuStavki();
            foreach (var item in datasource)
            {
                Ukupno += double.Parse(item.Suma);
            }

            textBox4.Text = Ukupno.ToString();
            dataGridView1.Height = (datasource.Count + 1) * 25;
            dataGridView1.DataSource = datasource;
            dataGridView1.Rows[0].Cells[0].Selected = false;
            dataGridView1.Columns[0].HeaderText = "Naziv proizvoda";
            dataGridView1.Columns[1].HeaderText = "Mjerna jedinica";
            dataGridView1.Columns[3].HeaderText = "Cijena";
            dataGridView1.Columns[2].HeaderText = "Količina";
            dataGridView1.Columns[4].HeaderText = "Ukupno";
            textBox4.Location = new Point(650, 200 + dataGridView1.Height);
            label8.Location = new Point(550, 200 + dataGridView1.Height);
            this.Height = dataGridView1.Height + 350;
            uiActionSpremi.Location = new Point(540, 230 + dataGridView1.Height);
            uiActionIspis.Location = new Point(670, 230 + dataGridView1.Height);
            uiActionOdustani.Location = new Point(410, 230 + dataGridView1.Height);
        }
        /// <summary>
        /// Metoda koja sprema račun u bazu podataka
        /// </summary>
        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("datum");
            using (var db = new MilkyAppDataBaseEntities())
            {
                db.racuni.Add(new racuni
                {
                    ukupan_iznos = Ukupno,
                    narudzba_ID = narudzba_ID,
                    datum_stvaranja = bytes
                });
                db.SaveChanges();
            }
            uiActionSpremi.Enabled = false;
            MessageBox.Show("Spremljeno!");
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Bitmap bitmap;
        /// <summary>
        /// Metoda koja služi za dohvat računa kako bi se mogao ispisati
        /// </summary>
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 50, 100);
        }
        /// <summary>
        /// Metoda koja prikazuje račun u prikazu za ispis i ispisuje ga
        /// </summary>
        private void uiActionIspis_Click(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = true;
            Graphics grp = this.CreateGraphics();
            Size formSize = this.Size;
            formSize.Height = formSize.Height + 135;
            formSize.Width = formSize.Width + 250;
            bitmap = new Bitmap(2000, 2000, grp);
            grp = Graphics.FromImage(bitmap);
            grp.CopyFromScreen(this.Location.X, this.Location.Y, -95,-60, formSize);
            printPreviewDialog1.Document = printDocument1;
            this.Close();
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }


    }
}

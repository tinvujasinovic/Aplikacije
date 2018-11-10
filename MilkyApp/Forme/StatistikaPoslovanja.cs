using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkyApp.Forme
{
    public partial class Statistika_poslovanja : Form
    {
        public Statistika_poslovanja()
        {
            InitializeComponent();
        }

        private void msStatistikaProizvodi_Click(object sender, EventArgs e)
        {
            StatistikaProizvoda proizvodi = new StatistikaProizvoda
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            proizvodi.Show();

            
        }

        private void msStatistikaDobavljaci_Click(object sender, EventArgs e)
        {

        }

        private void msStatistikaKupci_Click(object sender, EventArgs e)
        {
            StatistikaKupaca kupci = new StatistikaKupaca
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            kupci.Show();
        }

        private void odustaniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void msStatistikaZaposlenici_Click(object sender, EventArgs e)
        {
            StatistikaZaposlenika zaposlenici = new StatistikaZaposlenika
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            zaposlenici.Show();
        }
    }
}

using MilkyApp.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkyApp
{
    public partial class IzbornikVlasnik : Form
    {
        public IzbornikVlasnik()
        {
            InitializeComponent();
            panelVeliki.Anchor = AnchorStyles.None;
            panelVeliki.Left = (this.ClientSize.Width - panelVeliki.Width) / 2;
            panelOpcijeVlasnika.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);
            panelOpcijeZaposlenika.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);
        }

        private void uiActionEvidencija_Click(object sender, EventArgs e)
        {
            EvidencijaZaposlenika evidencija = new EvidencijaZaposlenika();
            evidencija.ShowDialog();
        }

        private void uiActionRegistracija_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }
        private void uiActionOdjava_Click(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava();
            this.Hide();
            prijava.ShowDialog();
            this.Close();

        }


        private void uiActionStatistikaPoslovanja_Click(object sender, EventArgs e)
        {
            Statistika_poslovanja statistika = new Statistika_poslovanja();
            statistika.ShowDialog();
         
        }

        private void uiActionEvidencijaKupaca_Click(object sender, EventArgs e)
        {
            EvidencijaKupaca kupci = new EvidencijaKupaca();
            kupci.ShowDialog();
        }

        private void uiActionEvidencijaDobavljača_Click(object sender, EventArgs e)
        {
            EvidencijaDobavljača dobavljaci = new EvidencijaDobavljača();
            dobavljaci.ShowDialog();
        }

        private void uiActionEvidencijaSirovina_Click(object sender, EventArgs e)
        {
            EvidencijaSirovina sirovine = new EvidencijaSirovina();
            sirovine.ShowDialog();
        }

        private void uiActionEvidencijaRačuna_Click(object sender, EventArgs e)
        {
            EvidencijaRačuna racuni = new EvidencijaRačuna();
            racuni.ShowDialog();
        }
    }
}

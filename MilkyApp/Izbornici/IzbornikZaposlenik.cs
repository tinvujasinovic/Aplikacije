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
    public partial class IzbornikZaposlenik : Form
    {

        public korisnici prijavljeniKorisnik;
        public IzbornikZaposlenik(korisnici korisnik) { 
            InitializeComponent();
            prijavljeniKorisnik = korisnik;

            panelIzbornikZaposlenik.Anchor = AnchorStyles.None;
            panelIzbornikZaposlenik.Left = (this.ClientSize.Width - panelIzbornikZaposlenik.Width) / 2;
            panelIzbornikZaposlenik.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);

        }
        private void uiActionOdjavaZaposlenika_Click(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava();
            this.Hide();
            prijava.ShowDialog();
            this.Close();
        }

        

        private void uiActionPregledProfila_Click(object sender, EventArgs e)
        {
            Profil_Zaposlenik profil_Zaposlenik = new Profil_Zaposlenik(prijavljeniKorisnik);
            profil_Zaposlenik.ShowDialog();
           
        }

        private void uiActionEvidencijaProizvoda_Click(object sender, EventArgs e)
        {

        }

        private void uiActionEvidencijaDobavljača_Click(object sender, EventArgs e)
        {
            EvidencijaDobavljača dobavljaci = new EvidencijaDobavljača();
            dobavljaci.ShowDialog();
        }

        private void uiActionEvidencijaKupaca_Click(object sender, EventArgs e)
        {
            EvidencijaKupaca kupci = new EvidencijaKupaca();
            kupci.ShowDialog();
        }

        private void uiActionStatistikaPoslovanja_Click(object sender, EventArgs e)
        {
            Statistika_poslovanja statistika = new Statistika_poslovanja();
            statistika.ShowDialog();
            
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

        private void uiActionEvidencijaNarudžbi_Click(object sender, EventArgs e)
        {

        }
    }
}

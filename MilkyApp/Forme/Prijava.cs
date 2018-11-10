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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
            pictureLogo.Anchor = AnchorStyles.None;
            dioPrijava.Anchor = AnchorStyles.None;
            pictureLogo.Left= (this.ClientSize.Width - pictureLogo.Width) / 2;
            dioPrijava.Left= (this.ClientSize.Width - dioPrijava.Width) / 2;
            dioPrijava.BackColor = System.Drawing.Color.FromArgb(50, 255,255,255);

        }

        //Provjerom unesenih podataka korisnik se prijavljuje u aplikaciju
        private void uiActionPrijava_Click(object sender, EventArgs e)
        {
            bool postojiKorisnik = false;
            
            using (var db=new MilkyAppDataBaseEntities())
            {
                foreach (korisnici korisnik in db.korisnici)
                {
                    if (korisnik.email == uiInputKorisnickoIme.Text)
                    {
                        postojiKorisnik = true;
                        if (korisnik.lozinka != uiInputLozinka.Text)
                        {
                            MessageBox.Show("Unijeli ste krivu lozinku!");
                            uiInputLozinka.Clear();
                        }
                    }
                    if(korisnik.email==uiInputKorisnickoIme.Text && korisnik.lozinka == uiInputLozinka.Text)
                    {
                        if (korisnik.vlasnik == 1)
                        {
                            IzbornikVlasnik izbornikVlasnik = new IzbornikVlasnik();
                            this.Hide();
                            izbornikVlasnik.ShowDialog();
                            Close();
                            
                        }
                        else
                        {
                            
                            IzbornikZaposlenik izbornikZaposlenik = new IzbornikZaposlenik(korisnik);
                            this.Hide();
                            izbornikZaposlenik.ShowDialog();
                            Close();
                            
                        }
                    }

                    
                }
                if (postojiKorisnik == false)
                {
                    MessageBox.Show("Korisnik ne postoji!");
                    uiInputKorisnickoIme.Clear();
                    uiInputLozinka.Clear();
                }
            }
           
            
        }

       
    }
}

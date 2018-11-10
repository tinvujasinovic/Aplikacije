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
    public partial class EvidencijaZaposlenika : Form
    {
        public EvidencijaZaposlenika()
        {
            InitializeComponent();
            PrikaziZaposlenike();

            panelEvidencija.Anchor = AnchorStyles.None;
            panelEvidencija.Left = (this.ClientSize.Width - panelEvidencija.Width) / 2;
            panelEvidencija.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);

        }

        //Prikazuje zaposlenike u DGV
        public void PrikaziZaposlenike()
        {
            BindingList<korisnici> listaZaposlenika = null;
            using (var db = new MilkyAppDataBaseEntities())
            {
                listaZaposlenika = new BindingList<korisnici>(db.korisnici.ToList());
            }
            korisniciBindingSource.DataSource = listaZaposlenika;
            
        }

        //Otvara se forma za registraciju
        private void uiActionRegistracija_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
            PrikaziZaposlenike();
            
            
        }


        //Brisanje korisnika ako nema biljeske i zadatke
        private void uiACtionObrisi_Click(object sender, EventArgs e)
        {
            korisnici oznaceniKorisnik = korisniciBindingSource.Current as korisnici;

            if (oznaceniKorisnik != null)
            {
                if(MessageBox.Show("Jeste li sigurni da želite obrisati zaposlenika " + oznaceniKorisnik.ime.ToString() + " "+ oznaceniKorisnik.prezime.ToString()+"? ", "Upozorenje",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using(var db=new MilkyAppDataBaseEntities())
                    {
                        db.korisnici.Attach(oznaceniKorisnik);
                        if (oznaceniKorisnik.biljeske.Count==0 && oznaceniKorisnik.zadaci.Count == 0) {
                        
                        db.korisnici.Remove(oznaceniKorisnik);

                        db.SaveChanges();

                            MessageBox.Show("Korisnik je obrisan!");
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati zaposlenika koji sadrži bilješke i zadatke!");
                        }
                    }

                    
                }
            }
            PrikaziZaposlenike();
        }

        //Otvara formu za pregled profila za odabranog zaposlenika
        private void uiActionPogledaj_Click(object sender, EventArgs e)
        {
            KorisničkiProfilVlasnik profil = new KorisničkiProfilVlasnik(korisniciBindingSource.Current as korisnici);
            profil.ShowDialog();
            PrikaziZaposlenike();
        }
    }

}

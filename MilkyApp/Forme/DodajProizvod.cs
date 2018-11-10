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
    public partial class DodajProizvod : Form
    {
        public DodajProizvod()
        {
            InitializeComponent();
            panelProizvodi.Anchor = AnchorStyles.None;
            panelProizvodi.Left = (this.ClientSize.Width - panelProizvodi.Width) / 2;
            panelProizvodi.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);
            PrikaziMjerneJedinice();
        }

        private void uiActionDodajProizvod_Click(object sender, EventArgs e)
        {
            using (var db = new MilkyAppDataBaseEntities())
            {
                proizvodi proizvod = new proizvodi
                {
                    naziv = uiInputNazivProizvoda.Text,
                    opis = uiInputOpisProizvoda.Text,
                    cijena = double.Parse(uiInputCijenaProizvoda.Text),
                    raspolozivo = int.Parse(uiInputKolicina.Text),
                    mjerna_jedinica_ID = int.Parse(uiSelectMjernaJedinica.SelectedValue.ToString())
                };
            }
        }

        public void PrikaziMjerneJedinice()
        {
            BindingList<mjerne_jedinice> listMjernihJedinica = null;
            using (var db = new MilkyAppDataBaseEntities())
            {
                listMjernihJedinica = new BindingList<mjerne_jedinice>(db.mjerne_jedinice.ToList());
            }
            mjernejediniceBindingSource.DataSource = listMjernihJedinica;
            
        }
    }
}

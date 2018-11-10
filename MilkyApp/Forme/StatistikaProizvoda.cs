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
    public partial class StatistikaProizvoda : Form
    {
        public StatistikaProizvoda()
        {
            InitializeComponent();

            panelProizvodi.Anchor = AnchorStyles.None;
            panelProizvodi.Left = (this.ClientSize.Width - panelProizvodi.Width) / 2;
            panelProizvodi.BackColor = System.Drawing.Color.FromArgb(70, 255, 255, 255);
        }

        private void StatistikaProizvoda_Load(object sender, EventArgs e)
        {
            using(var db= new MilkyAppDataBaseEntities()) {

                uiChartProizvodi.DataSource = db.proizvodi_na_narudzbi.ToList();
                uiChartProizvodi.Series["Proizvodi"].XValueMember = "proizvod_ID";
                uiChartProizvodi.Series["Proizvodi"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                uiChartProizvodi.Series["Proizvodi"].YValueMembers = "Broj proizvoda";
                uiChartProizvodi.Series["Proizvodi"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            }
        }
    }
}

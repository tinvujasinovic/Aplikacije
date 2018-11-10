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
    public partial class StatistikaZaposlenika : Form
    {
        public StatistikaZaposlenika()
        {
            InitializeComponent();

            panelStatistikaZaposlenika.Anchor = AnchorStyles.None;
            panelStatistikaZaposlenika.Left = (this.ClientSize.Width - panelStatistikaZaposlenika.Width) / 2;
            panelStatistikaZaposlenika.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);

            
        }

        private void StatistikaZaposlenika_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}

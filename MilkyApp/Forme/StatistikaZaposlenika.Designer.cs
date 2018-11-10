namespace MilkyApp.Forme
{
    partial class StatistikaZaposlenika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistikaZaposlenika));
            this.panelStatistikaZaposlenika = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biljeskeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelStatistikaZaposlenika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biljeskeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStatistikaZaposlenika
            // 
            this.panelStatistikaZaposlenika.BackColor = System.Drawing.Color.Transparent;
            this.panelStatistikaZaposlenika.Controls.Add(this.reportViewer1);
            this.panelStatistikaZaposlenika.Location = new System.Drawing.Point(55, 12);
            this.panelStatistikaZaposlenika.Name = "panelStatistikaZaposlenika";
            this.panelStatistikaZaposlenika.Size = new System.Drawing.Size(697, 426);
            this.panelStatistikaZaposlenika.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ZaposleniciDataSet";
            reportDataSource1.Value = this.korisniciBindingSource;
            reportDataSource2.Name = "BiljeskeDataSet";
            reportDataSource2.Value = this.biljeskeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MilkyApp.ReportZaposlenici.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 15);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(672, 395);
            this.reportViewer1.TabIndex = 0;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataSource = typeof(MilkyApp.korisnici);
            // 
            // biljeskeBindingSource
            // 
            this.biljeskeBindingSource.DataSource = typeof(MilkyApp.biljeske);
            // 
            // StatistikaZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MilkyApp.Properties.Resources.pozadinaForme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelStatistikaZaposlenika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatistikaZaposlenika";
            this.Text = "Statistika zaposlenika";
            this.Load += new System.EventHandler(this.StatistikaZaposlenika_Load);
            this.panelStatistikaZaposlenika.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biljeskeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatistikaZaposlenika;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource biljeskeBindingSource;
    }
}
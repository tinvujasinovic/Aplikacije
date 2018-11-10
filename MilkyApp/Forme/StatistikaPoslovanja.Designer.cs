namespace MilkyApp.Forme
{
    partial class Statistika_poslovanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistika_poslovanja));
            this.msStatistika = new System.Windows.Forms.MenuStrip();
            this.msStatistikaProizvodi = new System.Windows.Forms.ToolStripMenuItem();
            this.msStatistikaZaposlenici = new System.Windows.Forms.ToolStripMenuItem();
            this.msStatistikaKupci = new System.Windows.Forms.ToolStripMenuItem();
            this.odustaniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msStatistika.SuspendLayout();
            this.SuspendLayout();
            // 
            // msStatistika
            // 
            this.msStatistika.BackColor = System.Drawing.Color.GhostWhite;
            this.msStatistika.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msStatistikaProizvodi,
            this.msStatistikaZaposlenici,
            this.msStatistikaKupci,
            this.odustaniToolStripMenuItem});
            this.msStatistika.Location = new System.Drawing.Point(0, 0);
            this.msStatistika.Name = "msStatistika";
            this.msStatistika.Size = new System.Drawing.Size(800, 24);
            this.msStatistika.TabIndex = 1;
            this.msStatistika.Text = "menuStrip1";
            // 
            // msStatistikaProizvodi
            // 
            this.msStatistikaProizvodi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.msStatistikaProizvodi.Name = "msStatistikaProizvodi";
            this.msStatistikaProizvodi.Size = new System.Drawing.Size(71, 20);
            this.msStatistikaProizvodi.Text = "Proizvodi";
            this.msStatistikaProizvodi.Click += new System.EventHandler(this.msStatistikaProizvodi_Click);
            // 
            // msStatistikaZaposlenici
            // 
            this.msStatistikaZaposlenici.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.msStatistikaZaposlenici.Name = "msStatistikaZaposlenici";
            this.msStatistikaZaposlenici.Size = new System.Drawing.Size(80, 20);
            this.msStatistikaZaposlenici.Text = "Zaposlenici";
            this.msStatistikaZaposlenici.Click += new System.EventHandler(this.msStatistikaZaposlenici_Click);
            // 
            // msStatistikaKupci
            // 
            this.msStatistikaKupci.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.msStatistikaKupci.Name = "msStatistikaKupci";
            this.msStatistikaKupci.Size = new System.Drawing.Size(50, 20);
            this.msStatistikaKupci.Text = "Kupci";
            this.msStatistikaKupci.Click += new System.EventHandler(this.msStatistikaKupci_Click);
            // 
            // odustaniToolStripMenuItem
            // 
            this.odustaniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.odustaniToolStripMenuItem.Name = "odustaniToolStripMenuItem";
            this.odustaniToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.odustaniToolStripMenuItem.Text = "Odustani";
            this.odustaniToolStripMenuItem.Click += new System.EventHandler(this.odustaniToolStripMenuItem_Click);
            // 
            // Statistika_poslovanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MilkyApp.Properties.Resources.pozadinaForme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msStatistika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msStatistika;
            this.Name = "Statistika_poslovanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika poslovanja";
            this.msStatistika.ResumeLayout(false);
            this.msStatistika.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msStatistika;
        private System.Windows.Forms.ToolStripMenuItem msStatistikaProizvodi;
        private System.Windows.Forms.ToolStripMenuItem msStatistikaZaposlenici;
        private System.Windows.Forms.ToolStripMenuItem msStatistikaKupci;
        private System.Windows.Forms.ToolStripMenuItem odustaniToolStripMenuItem;
    }
}
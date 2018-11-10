namespace MilkyApp
{
    partial class EvidencijaZaposlenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaZaposlenika));
            this.prikazZaposlenika = new System.Windows.Forms.DataGridView();
            this.korisnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaikucnibrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaspremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanimanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnomjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlasnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biljeskeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zadaciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionPogledaj = new System.Windows.Forms.Button();
            this.uiACtionObrisi = new System.Windows.Forms.Button();
            this.uiOutputDatum = new System.Windows.Forms.Label();
            this.uiActionRegistracija = new System.Windows.Forms.Button();
            this.panelEvidencija = new System.Windows.Forms.Panel();
            this.helpEvidencijaZaposlenika = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.prikazZaposlenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.panelEvidencija.SuspendLayout();
            this.SuspendLayout();
            // 
            // prikazZaposlenika
            // 
            this.prikazZaposlenika.AllowUserToAddRows = false;
            this.prikazZaposlenika.AllowUserToDeleteRows = false;
            this.prikazZaposlenika.AutoGenerateColumns = false;
            this.prikazZaposlenika.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.prikazZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazZaposlenika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnikIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.datumrodenjaDataGridViewTextBoxColumn,
            this.ulicaikucnibrojDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.strucnaspremaDataGridViewTextBoxColumn,
            this.zanimanjeDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.radnomjestoDataGridViewTextBoxColumn,
            this.brojracunaDataGridViewTextBoxColumn,
            this.vlasnikDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.biljeskeDataGridViewTextBoxColumn,
            this.zadaciDataGridViewTextBoxColumn});
            this.prikazZaposlenika.DataSource = this.korisniciBindingSource;
            this.prikazZaposlenika.GridColor = System.Drawing.SystemColors.Control;
            this.prikazZaposlenika.Location = new System.Drawing.Point(18, 13);
            this.prikazZaposlenika.Name = "prikazZaposlenika";
            this.prikazZaposlenika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prikazZaposlenika.Size = new System.Drawing.Size(600, 308);
            this.prikazZaposlenika.TabIndex = 0;
            // 
            // korisnikIDDataGridViewTextBoxColumn
            // 
            this.korisnikIDDataGridViewTextBoxColumn.DataPropertyName = "korisnik_ID";
            this.korisnikIDDataGridViewTextBoxColumn.HeaderText = "ID zaposlenika";
            this.korisnikIDDataGridViewTextBoxColumn.Name = "korisnikIDDataGridViewTextBoxColumn";
            this.korisnikIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // datumrodenjaDataGridViewTextBoxColumn
            // 
            this.datumrodenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.HeaderText = "datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.Name = "datumrodenjaDataGridViewTextBoxColumn";
            this.datumrodenjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ulicaikucnibrojDataGridViewTextBoxColumn
            // 
            this.ulicaikucnibrojDataGridViewTextBoxColumn.DataPropertyName = "ulica_i_kucni_broj";
            this.ulicaikucnibrojDataGridViewTextBoxColumn.HeaderText = "ulica_i_kucni_broj";
            this.ulicaikucnibrojDataGridViewTextBoxColumn.Name = "ulicaikucnibrojDataGridViewTextBoxColumn";
            this.ulicaikucnibrojDataGridViewTextBoxColumn.Visible = false;
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.Visible = false;
            // 
            // strucnaspremaDataGridViewTextBoxColumn
            // 
            this.strucnaspremaDataGridViewTextBoxColumn.DataPropertyName = "strucna_sprema";
            this.strucnaspremaDataGridViewTextBoxColumn.HeaderText = "strucna_sprema";
            this.strucnaspremaDataGridViewTextBoxColumn.Name = "strucnaspremaDataGridViewTextBoxColumn";
            this.strucnaspremaDataGridViewTextBoxColumn.Visible = false;
            // 
            // zanimanjeDataGridViewTextBoxColumn
            // 
            this.zanimanjeDataGridViewTextBoxColumn.DataPropertyName = "zanimanje";
            this.zanimanjeDataGridViewTextBoxColumn.HeaderText = "zanimanje";
            this.zanimanjeDataGridViewTextBoxColumn.Name = "zanimanjeDataGridViewTextBoxColumn";
            this.zanimanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Visible = false;
            // 
            // radnomjestoDataGridViewTextBoxColumn
            // 
            this.radnomjestoDataGridViewTextBoxColumn.DataPropertyName = "radno_mjesto";
            this.radnomjestoDataGridViewTextBoxColumn.HeaderText = "Radno mjesto";
            this.radnomjestoDataGridViewTextBoxColumn.Name = "radnomjestoDataGridViewTextBoxColumn";
            this.radnomjestoDataGridViewTextBoxColumn.Width = 105;
            // 
            // brojracunaDataGridViewTextBoxColumn
            // 
            this.brojracunaDataGridViewTextBoxColumn.DataPropertyName = "broj_racuna";
            this.brojracunaDataGridViewTextBoxColumn.HeaderText = "broj_racuna";
            this.brojracunaDataGridViewTextBoxColumn.Name = "brojracunaDataGridViewTextBoxColumn";
            this.brojracunaDataGridViewTextBoxColumn.Visible = false;
            // 
            // vlasnikDataGridViewTextBoxColumn
            // 
            this.vlasnikDataGridViewTextBoxColumn.DataPropertyName = "vlasnik";
            this.vlasnikDataGridViewTextBoxColumn.HeaderText = "vlasnik";
            this.vlasnikDataGridViewTextBoxColumn.Name = "vlasnikDataGridViewTextBoxColumn";
            this.vlasnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // biljeskeDataGridViewTextBoxColumn
            // 
            this.biljeskeDataGridViewTextBoxColumn.DataPropertyName = "biljeske";
            this.biljeskeDataGridViewTextBoxColumn.HeaderText = "Bilješke";
            this.biljeskeDataGridViewTextBoxColumn.Name = "biljeskeDataGridViewTextBoxColumn";
            this.biljeskeDataGridViewTextBoxColumn.Visible = false;
            // 
            // zadaciDataGridViewTextBoxColumn
            // 
            this.zadaciDataGridViewTextBoxColumn.DataPropertyName = "zadaci";
            this.zadaciDataGridViewTextBoxColumn.HeaderText = "Zadaci";
            this.zadaciDataGridViewTextBoxColumn.Name = "zadaciDataGridViewTextBoxColumn";
            this.zadaciDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataSource = typeof(MilkyApp.korisnici);
            // 
            // uiActionPogledaj
            // 
            this.uiActionPogledaj.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionPogledaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPogledaj.Location = new System.Drawing.Point(481, 340);
            this.uiActionPogledaj.Name = "uiActionPogledaj";
            this.uiActionPogledaj.Size = new System.Drawing.Size(129, 41);
            this.uiActionPogledaj.TabIndex = 1;
            this.uiActionPogledaj.Text = "Pogledaj profil";
            this.uiActionPogledaj.UseVisualStyleBackColor = false;
            this.uiActionPogledaj.Click += new System.EventHandler(this.uiActionPogledaj_Click);
            // 
            // uiACtionObrisi
            // 
            this.uiACtionObrisi.BackColor = System.Drawing.Color.GhostWhite;
            this.uiACtionObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiACtionObrisi.Location = new System.Drawing.Point(346, 340);
            this.uiACtionObrisi.Name = "uiACtionObrisi";
            this.uiACtionObrisi.Size = new System.Drawing.Size(129, 41);
            this.uiACtionObrisi.TabIndex = 1;
            this.uiACtionObrisi.Text = "Obriši zaposlenika";
            this.uiACtionObrisi.UseVisualStyleBackColor = false;
            this.uiACtionObrisi.Click += new System.EventHandler(this.uiACtionObrisi_Click);
            // 
            // uiOutputDatum
            // 
            this.uiOutputDatum.AutoSize = true;
            this.uiOutputDatum.Location = new System.Drawing.Point(113, 26);
            this.uiOutputDatum.Name = "uiOutputDatum";
            this.uiOutputDatum.Size = new System.Drawing.Size(0, 13);
            this.uiOutputDatum.TabIndex = 4;
            // 
            // uiActionRegistracija
            // 
            this.uiActionRegistracija.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionRegistracija.Location = new System.Drawing.Point(18, 340);
            this.uiActionRegistracija.Name = "uiActionRegistracija";
            this.uiActionRegistracija.Size = new System.Drawing.Size(129, 41);
            this.uiActionRegistracija.TabIndex = 1;
            this.uiActionRegistracija.Text = "Registracija zaposlenika";
            this.uiActionRegistracija.UseVisualStyleBackColor = false;
            this.uiActionRegistracija.Click += new System.EventHandler(this.uiActionRegistracija_Click);
            // 
            // panelEvidencija
            // 
            this.panelEvidencija.BackColor = System.Drawing.Color.Transparent;
            this.panelEvidencija.Controls.Add(this.prikazZaposlenika);
            this.panelEvidencija.Controls.Add(this.uiActionPogledaj);
            this.panelEvidencija.Controls.Add(this.uiACtionObrisi);
            this.panelEvidencija.Controls.Add(this.uiActionRegistracija);
            this.panelEvidencija.Location = new System.Drawing.Point(119, 26);
            this.panelEvidencija.Name = "panelEvidencija";
            this.panelEvidencija.Size = new System.Drawing.Size(634, 389);
            this.panelEvidencija.TabIndex = 5;
            // 
            // helpEvidencijaZaposlenika
            // 
            this.helpEvidencijaZaposlenika.HelpNamespace = "..\\..\\Help\\3Evidencija.htm";
            // 
            // EvidencijaZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MilkyApp.Properties.Resources.pozadinaForme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.panelEvidencija);
            this.Controls.Add(this.uiOutputDatum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvidencijaZaposlenika";
            this.helpEvidencijaZaposlenika.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija zaposlenika";
            ((System.ComponentModel.ISupportInitialize)(this.prikazZaposlenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.panelEvidencija.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView prikazZaposlenika;
        private System.Windows.Forms.Button uiActionPogledaj;
        private System.Windows.Forms.Button uiACtionObrisi;
        private System.Windows.Forms.Label uiOutputDatum;
        private System.Windows.Forms.Button uiActionRegistracija;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private System.Windows.Forms.Panel panelEvidencija;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaikucnibrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaspremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanimanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnomjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlasnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biljeskeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zadaciDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider helpEvidencijaZaposlenika;
    }
}
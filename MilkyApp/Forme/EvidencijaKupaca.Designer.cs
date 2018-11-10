namespace MilkyApp
{
    partial class EvidencijaKupaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaKupaca));
            this.uiActionUrediKupca = new System.Windows.Forms.Button();
            this.PanelKupci = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uiInputPretrazivanje = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiActionObrisiKupca = new System.Windows.Forms.Button();
            this.uiActionReset = new System.Windows.Forms.Button();
            this.uiActionPretrazi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uiActionDodajKupca = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.kupacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelKupci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionUrediKupca
            // 
            this.uiActionUrediKupca.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionUrediKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionUrediKupca.Location = new System.Drawing.Point(276, 396);
            this.uiActionUrediKupca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionUrediKupca.Name = "uiActionUrediKupca";
            this.uiActionUrediKupca.Size = new System.Drawing.Size(172, 50);
            this.uiActionUrediKupca.TabIndex = 3;
            this.uiActionUrediKupca.Text = "Uredi";
            this.uiActionUrediKupca.UseVisualStyleBackColor = false;
            this.uiActionUrediKupca.Click += new System.EventHandler(this.uiActionUrediKupca_Click);
            // 
            // PanelKupci
            // 
            this.PanelKupci.BackColor = System.Drawing.Color.Transparent;
            this.PanelKupci.Controls.Add(this.label1);
            this.PanelKupci.Controls.Add(this.uiInputPretrazivanje);
            this.PanelKupci.Controls.Add(this.dataGridView1);
            this.PanelKupci.Controls.Add(this.uiActionObrisiKupca);
            this.PanelKupci.Controls.Add(this.uiActionReset);
            this.PanelKupci.Controls.Add(this.uiActionPretrazi);
            this.PanelKupci.Controls.Add(this.button1);
            this.PanelKupci.Controls.Add(this.uiActionDodajKupca);
            this.PanelKupci.Controls.Add(this.uiActionUrediKupca);
            this.PanelKupci.Location = new System.Drawing.Point(66, 66);
            this.PanelKupci.Name = "PanelKupci";
            this.PanelKupci.Size = new System.Drawing.Size(1004, 462);
            this.PanelKupci.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(700, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraživanje prema nazivu";
            // 
            // uiInputPretrazivanje
            // 
            this.uiInputPretrazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiInputPretrazivanje.Location = new System.Drawing.Point(703, 115);
            this.uiInputPretrazivanje.Name = "uiInputPretrazivanje";
            this.uiInputPretrazivanje.Size = new System.Drawing.Size(279, 30);
            this.uiInputPretrazivanje.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kupacIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.narudzbeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kupciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 354);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            // 
            // uiActionObrisiKupca
            // 
            this.uiActionObrisiKupca.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionObrisiKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionObrisiKupca.Location = new System.Drawing.Point(454, 396);
            this.uiActionObrisiKupca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionObrisiKupca.Name = "uiActionObrisiKupca";
            this.uiActionObrisiKupca.Size = new System.Drawing.Size(172, 50);
            this.uiActionObrisiKupca.TabIndex = 2;
            this.uiActionObrisiKupca.Text = "Obriši";
            this.uiActionObrisiKupca.UseVisualStyleBackColor = false;
            this.uiActionObrisiKupca.Click += new System.EventHandler(this.uiActionObrisiKupca_Click);
            // 
            // uiActionReset
            // 
            this.uiActionReset.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionReset.Location = new System.Drawing.Point(747, 165);
            this.uiActionReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionReset.Name = "uiActionReset";
            this.uiActionReset.Size = new System.Drawing.Size(111, 30);
            this.uiActionReset.TabIndex = 6;
            this.uiActionReset.Text = "Prikaži sve";
            this.uiActionReset.UseVisualStyleBackColor = false;
            this.uiActionReset.Click += new System.EventHandler(this.uiActionReset_Click);
            // 
            // uiActionPretrazi
            // 
            this.uiActionPretrazi.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPretrazi.Location = new System.Drawing.Point(871, 165);
            this.uiActionPretrazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionPretrazi.Name = "uiActionPretrazi";
            this.uiActionPretrazi.Size = new System.Drawing.Size(111, 30);
            this.uiActionPretrazi.TabIndex = 5;
            this.uiActionPretrazi.Text = "Pretraži";
            this.uiActionPretrazi.UseVisualStyleBackColor = false;
            this.uiActionPretrazi.Click += new System.EventHandler(this.uiActionPretrazi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(632, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiActionDodajKupca
            // 
            this.uiActionDodajKupca.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionDodajKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajKupca.Location = new System.Drawing.Point(810, 396);
            this.uiActionDodajKupca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionDodajKupca.Name = "uiActionDodajKupca";
            this.uiActionDodajKupca.Size = new System.Drawing.Size(172, 50);
            this.uiActionDodajKupca.TabIndex = 1;
            this.uiActionDodajKupca.Text = "Dodaj kupca";
            this.uiActionDodajKupca.UseVisualStyleBackColor = false;
            this.uiActionDodajKupca.Click += new System.EventHandler(this.DodajKupca_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\..\\Help\\6Kupci.htm";
            // 
            // kupacIDDataGridViewTextBoxColumn
            // 
            this.kupacIDDataGridViewTextBoxColumn.DataPropertyName = "kupac_ID";
            this.kupacIDDataGridViewTextBoxColumn.HeaderText = "kupac_ID";
            this.kupacIDDataGridViewTextBoxColumn.Name = "kupacIDDataGridViewTextBoxColumn";
            this.kupacIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kupacIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narudzbeDataGridViewTextBoxColumn
            // 
            this.narudzbeDataGridViewTextBoxColumn.DataPropertyName = "narudzbe";
            this.narudzbeDataGridViewTextBoxColumn.HeaderText = "narudzbe";
            this.narudzbeDataGridViewTextBoxColumn.Name = "narudzbeDataGridViewTextBoxColumn";
            this.narudzbeDataGridViewTextBoxColumn.ReadOnly = true;
            this.narudzbeDataGridViewTextBoxColumn.Visible = false;
            // 
            // kupciBindingSource
            // 
            this.kupciBindingSource.DataSource = typeof(MilkyApp.kupci);
            // 
            // narudzbeBindingSource
            // 
            this.narudzbeBindingSource.DataSource = typeof(MilkyApp.narudzbe);
            // 
            // EvidencijaKupaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MilkyApp.Properties.Resources.pozadinaForme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 554);
            this.Controls.Add(this.PanelKupci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EvidencijaKupaca";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija kupaca";
            this.PanelKupci.ResumeLayout(false);
            this.PanelKupci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiActionUrediKupca;
        private System.Windows.Forms.Panel PanelKupci;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kupciBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uiActionObrisiKupca;
        private System.Windows.Forms.Button uiActionDodajKupca;
        private System.Windows.Forms.TextBox uiInputPretrazivanje;
        private System.Windows.Forms.Button uiActionReset;
        private System.Windows.Forms.Button uiActionPretrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource narudzbeBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
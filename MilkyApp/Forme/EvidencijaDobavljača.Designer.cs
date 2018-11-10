namespace MilkyApp
{
    partial class EvidencijaDobavljača
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaDobavljača));
            this.PanelDobavljaci = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uiInputPretrazivanje = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiActionObrisiDobavljaca = new System.Windows.Forms.Button();
            this.uiActionReset = new System.Windows.Forms.Button();
            this.uiActionPretrazi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uiActionDodajDobavljaca = new System.Windows.Forms.Button();
            this.uiActionUrediDobavljaca = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.dobavljacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelDobavljaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDobavljaci
            // 
            this.PanelDobavljaci.BackColor = System.Drawing.Color.Transparent;
            this.PanelDobavljaci.Controls.Add(this.label1);
            this.PanelDobavljaci.Controls.Add(this.uiInputPretrazivanje);
            this.PanelDobavljaci.Controls.Add(this.dataGridView1);
            this.PanelDobavljaci.Controls.Add(this.uiActionObrisiDobavljaca);
            this.PanelDobavljaci.Controls.Add(this.uiActionReset);
            this.PanelDobavljaci.Controls.Add(this.uiActionPretrazi);
            this.PanelDobavljaci.Controls.Add(this.button1);
            this.PanelDobavljaci.Controls.Add(this.uiActionDodajDobavljaca);
            this.PanelDobavljaci.Controls.Add(this.uiActionUrediDobavljaca);
            this.PanelDobavljaci.Location = new System.Drawing.Point(62, 46);
            this.PanelDobavljaci.Name = "PanelDobavljaci";
            this.PanelDobavljaci.Size = new System.Drawing.Size(1004, 462);
            this.PanelDobavljaci.TabIndex = 4;
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
            this.dobavljacIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.dobavljaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dobavljaciBindingSource;
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
            // uiActionObrisiDobavljaca
            // 
            this.uiActionObrisiDobavljaca.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionObrisiDobavljaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionObrisiDobavljaca.Location = new System.Drawing.Point(454, 396);
            this.uiActionObrisiDobavljaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionObrisiDobavljaca.Name = "uiActionObrisiDobavljaca";
            this.uiActionObrisiDobavljaca.Size = new System.Drawing.Size(172, 50);
            this.uiActionObrisiDobavljaca.TabIndex = 2;
            this.uiActionObrisiDobavljaca.Text = "Obriši";
            this.uiActionObrisiDobavljaca.UseVisualStyleBackColor = false;
            this.uiActionObrisiDobavljaca.Click += new System.EventHandler(this.uiActionObrisiDobavljaca_Click);
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
            // uiActionDodajDobavljaca
            // 
            this.uiActionDodajDobavljaca.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionDodajDobavljaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajDobavljaca.Location = new System.Drawing.Point(810, 396);
            this.uiActionDodajDobavljaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionDodajDobavljaca.Name = "uiActionDodajDobavljaca";
            this.uiActionDodajDobavljaca.Size = new System.Drawing.Size(172, 50);
            this.uiActionDodajDobavljaca.TabIndex = 1;
            this.uiActionDodajDobavljaca.Text = "Dodaj dobavljača";
            this.uiActionDodajDobavljaca.UseVisualStyleBackColor = false;
            this.uiActionDodajDobavljaca.Click += new System.EventHandler(this.uiActionDodajDobavljaca_Click);
            // 
            // uiActionUrediDobavljaca
            // 
            this.uiActionUrediDobavljaca.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionUrediDobavljaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionUrediDobavljaca.Location = new System.Drawing.Point(276, 396);
            this.uiActionUrediDobavljaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionUrediDobavljaca.Name = "uiActionUrediDobavljaca";
            this.uiActionUrediDobavljaca.Size = new System.Drawing.Size(172, 50);
            this.uiActionUrediDobavljaca.TabIndex = 3;
            this.uiActionUrediDobavljaca.Text = "Uredi";
            this.uiActionUrediDobavljaca.UseVisualStyleBackColor = false;
            this.uiActionUrediDobavljaca.Click += new System.EventHandler(this.uiActionUrediDobavljaca_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\..\\Help\\5Dobavljaci.htm";
            // 
            // dobavljacIDDataGridViewTextBoxColumn
            // 
            this.dobavljacIDDataGridViewTextBoxColumn.DataPropertyName = "dobavljac_ID";
            this.dobavljacIDDataGridViewTextBoxColumn.HeaderText = "dobavljac_ID";
            this.dobavljacIDDataGridViewTextBoxColumn.Name = "dobavljacIDDataGridViewTextBoxColumn";
            this.dobavljacIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobavljacIDDataGridViewTextBoxColumn.Visible = false;
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
            // dobavljaDataGridViewTextBoxColumn
            // 
            this.dobavljaDataGridViewTextBoxColumn.DataPropertyName = "dobavlja";
            this.dobavljaDataGridViewTextBoxColumn.HeaderText = "dobavlja";
            this.dobavljaDataGridViewTextBoxColumn.Name = "dobavljaDataGridViewTextBoxColumn";
            this.dobavljaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobavljaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataSource = typeof(MilkyApp.dobavljaci);
            // 
            // EvidencijaDobavljača
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MilkyApp.Properties.Resources.pozadinaForme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 554);
            this.Controls.Add(this.PanelDobavljaci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EvidencijaDobavljača";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija dobavljača";
            this.PanelDobavljaci.ResumeLayout(false);
            this.PanelDobavljaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelDobavljaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiInputPretrazivanje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private System.Windows.Forms.Button uiActionObrisiDobavljaca;
        private System.Windows.Forms.Button uiActionReset;
        private System.Windows.Forms.Button uiActionPretrazi;
        private System.Windows.Forms.Button uiActionDodajDobavljaca;
        private System.Windows.Forms.Button uiActionUrediDobavljaca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
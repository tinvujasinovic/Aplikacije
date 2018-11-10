namespace MilkyApp
{
    partial class EvidencijaRačuna
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaRačuna));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.uiActionIzradiRacun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.narudzbaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumstvaranjaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.datumisporukeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodinanarudzbiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racuniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi kupca:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.uiActionIzradiRacun);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(136, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 450);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(372, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiActionIzradiRacun
            // 
            this.uiActionIzradiRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionIzradiRacun.Location = new System.Drawing.Point(565, 352);
            this.uiActionIzradiRacun.Name = "uiActionIzradiRacun";
            this.uiActionIzradiRacun.Size = new System.Drawing.Size(187, 56);
            this.uiActionIzradiRacun.TabIndex = 2;
            this.uiActionIzradiRacun.Text = "Izradi račun za odabranu narudžbu";
            this.uiActionIzradiRacun.UseVisualStyleBackColor = true;
            this.uiActionIzradiRacun.Click += new System.EventHandler(this.uiActionIzradiRacun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.narudzbaIDDataGridViewTextBoxColumn,
            this.datumstvaranjaDataGridViewImageColumn,
            this.datumisporukeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.kupacIDDataGridViewTextBoxColumn,
            this.kupciDataGridViewTextBoxColumn,
            this.proizvodinanarudzbiDataGridViewTextBoxColumn,
            this.racuniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narudzbeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 95);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 233);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            // 
            // narudzbaIDDataGridViewTextBoxColumn
            // 
            this.narudzbaIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.narudzbaIDDataGridViewTextBoxColumn.DataPropertyName = "narudzba_ID";
            this.narudzbaIDDataGridViewTextBoxColumn.HeaderText = "ID narudžbe";
            this.narudzbaIDDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.narudzbaIDDataGridViewTextBoxColumn.Name = "narudzbaIDDataGridViewTextBoxColumn";
            this.narudzbaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.narudzbaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumstvaranjaDataGridViewImageColumn
            // 
            this.datumstvaranjaDataGridViewImageColumn.DataPropertyName = "datum_stvaranja";
            this.datumstvaranjaDataGridViewImageColumn.HeaderText = "datum_stvaranja";
            this.datumstvaranjaDataGridViewImageColumn.Name = "datumstvaranjaDataGridViewImageColumn";
            this.datumstvaranjaDataGridViewImageColumn.ReadOnly = true;
            this.datumstvaranjaDataGridViewImageColumn.Visible = false;
            this.datumstvaranjaDataGridViewImageColumn.Width = 119;
            // 
            // datumisporukeDataGridViewTextBoxColumn
            // 
            this.datumisporukeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.datumisporukeDataGridViewTextBoxColumn.DataPropertyName = "datum_isporuke";
            this.datumisporukeDataGridViewTextBoxColumn.HeaderText = "Datum isporuke";
            this.datumisporukeDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.datumisporukeDataGridViewTextBoxColumn.Name = "datumisporukeDataGridViewTextBoxColumn";
            this.datumisporukeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumisporukeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // kupacIDDataGridViewTextBoxColumn
            // 
            this.kupacIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.kupacIDDataGridViewTextBoxColumn.DataPropertyName = "kupac_ID";
            this.kupacIDDataGridViewTextBoxColumn.HeaderText = "ID kupca";
            this.kupacIDDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.kupacIDDataGridViewTextBoxColumn.Name = "kupacIDDataGridViewTextBoxColumn";
            this.kupacIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kupacIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kupciDataGridViewTextBoxColumn
            // 
            this.kupciDataGridViewTextBoxColumn.DataPropertyName = "kupci";
            this.kupciDataGridViewTextBoxColumn.HeaderText = "kupci";
            this.kupciDataGridViewTextBoxColumn.Name = "kupciDataGridViewTextBoxColumn";
            this.kupciDataGridViewTextBoxColumn.ReadOnly = true;
            this.kupciDataGridViewTextBoxColumn.Visible = false;
            this.kupciDataGridViewTextBoxColumn.Width = 70;
            // 
            // proizvodinanarudzbiDataGridViewTextBoxColumn
            // 
            this.proizvodinanarudzbiDataGridViewTextBoxColumn.DataPropertyName = "proizvodi_na_narudzbi";
            this.proizvodinanarudzbiDataGridViewTextBoxColumn.HeaderText = "proizvodi_na_narudzbi";
            this.proizvodinanarudzbiDataGridViewTextBoxColumn.Name = "proizvodinanarudzbiDataGridViewTextBoxColumn";
            this.proizvodinanarudzbiDataGridViewTextBoxColumn.ReadOnly = true;
            this.proizvodinanarudzbiDataGridViewTextBoxColumn.Visible = false;
            this.proizvodinanarudzbiDataGridViewTextBoxColumn.Width = 181;
            // 
            // racuniDataGridViewTextBoxColumn
            // 
            this.racuniDataGridViewTextBoxColumn.DataPropertyName = "racuni";
            this.racuniDataGridViewTextBoxColumn.HeaderText = "racuni";
            this.racuniDataGridViewTextBoxColumn.Name = "racuniDataGridViewTextBoxColumn";
            this.racuniDataGridViewTextBoxColumn.ReadOnly = true;
            this.racuniDataGridViewTextBoxColumn.Visible = false;
            this.racuniDataGridViewTextBoxColumn.Width = 76;
            // 
            // narudzbeBindingSource
            // 
            this.narudzbeBindingSource.DataSource = typeof(MilkyApp.narudzbe);
            // 
            // kupciBindingSource
            // 
            this.kupciBindingSource.DataSource = typeof(MilkyApp.kupci);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\..\\Help\\8Racuni.htm";
            // 
            // EvidencijaRačuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MilkyApp.Properties.Resources.pozadinaForme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 554);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EvidencijaRačuna";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija računa";
            this.Load += new System.EventHandler(this.EvidencijaRačuna_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource kupciBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource narudzbeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn narudzbaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn datumstvaranjaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumisporukeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodinanarudzbiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racuniDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uiActionIzradiRacun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
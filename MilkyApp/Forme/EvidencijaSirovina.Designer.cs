namespace MilkyApp
{
    partial class EvidencijaSirovina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaSirovina));
            this.PanelSirovine = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sirovinaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raspolozivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirovineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionNaruci = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.PanelSirovine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSirovine
            // 
            this.PanelSirovine.BackColor = System.Drawing.Color.Transparent;
            this.PanelSirovine.Controls.Add(this.dataGridView1);
            this.PanelSirovine.Controls.Add(this.uiActionOdustani);
            this.PanelSirovine.Controls.Add(this.uiActionDodaj);
            this.PanelSirovine.Controls.Add(this.uiActionNaruci);
            this.PanelSirovine.Location = new System.Drawing.Point(62, 46);
            this.PanelSirovine.Name = "PanelSirovine";
            this.PanelSirovine.Size = new System.Drawing.Size(1038, 466);
            this.PanelSirovine.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sirovinaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.raspolozivoDataGridViewTextBoxColumn,
            this.dobavljaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sirovineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(122, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(469, 333);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            // 
            // sirovinaIDDataGridViewTextBoxColumn
            // 
            this.sirovinaIDDataGridViewTextBoxColumn.DataPropertyName = "sirovina_ID";
            this.sirovinaIDDataGridViewTextBoxColumn.HeaderText = "sirovina_ID";
            this.sirovinaIDDataGridViewTextBoxColumn.Name = "sirovinaIDDataGridViewTextBoxColumn";
            this.sirovinaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sirovinaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raspolozivoDataGridViewTextBoxColumn
            // 
            this.raspolozivoDataGridViewTextBoxColumn.DataPropertyName = "raspolozivo";
            this.raspolozivoDataGridViewTextBoxColumn.HeaderText = "Raspolozivo";
            this.raspolozivoDataGridViewTextBoxColumn.Name = "raspolozivoDataGridViewTextBoxColumn";
            this.raspolozivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobavljaDataGridViewTextBoxColumn
            // 
            this.dobavljaDataGridViewTextBoxColumn.DataPropertyName = "dobavlja";
            this.dobavljaDataGridViewTextBoxColumn.HeaderText = "dobavlja";
            this.dobavljaDataGridViewTextBoxColumn.Name = "dobavljaDataGridViewTextBoxColumn";
            this.dobavljaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobavljaDataGridViewTextBoxColumn.Visible = false;
            // 
            // sirovineBindingSource
            // 
            this.sirovineBindingSource.DataSource = typeof(MilkyApp.sirovine);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdustani.Location = new System.Drawing.Point(710, 324);
            this.uiActionOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(172, 50);
            this.uiActionOdustani.TabIndex = 3;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = false;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodaj.Location = new System.Drawing.Point(710, 154);
            this.uiActionDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(172, 50);
            this.uiActionDodaj.TabIndex = 1;
            this.uiActionDodaj.Text = "Dodaj novu sirovinu";
            this.uiActionDodaj.UseVisualStyleBackColor = false;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // uiActionNaruci
            // 
            this.uiActionNaruci.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionNaruci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNaruci.Location = new System.Drawing.Point(710, 239);
            this.uiActionNaruci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionNaruci.Name = "uiActionNaruci";
            this.uiActionNaruci.Size = new System.Drawing.Size(172, 50);
            this.uiActionNaruci.TabIndex = 2;
            this.uiActionNaruci.Text = "Naruči";
            this.uiActionNaruci.UseVisualStyleBackColor = false;
            this.uiActionNaruci.Click += new System.EventHandler(this.uiActionNaruci_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\..\\Help\\7Sirovine.htm";
            // 
            // EvidencijaSirovina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MilkyApp.Properties.Resources.pozadinaForme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 554);
            this.Controls.Add(this.PanelSirovine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EvidencijaSirovina";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija sirovina";
            this.PanelSirovine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSirovine;
        private System.Windows.Forms.Button uiActionNaruci;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.BindingSource sirovineBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirovinaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raspolozivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljaDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
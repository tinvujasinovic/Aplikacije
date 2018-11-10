namespace baze_rad
{
    partial class Form7
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
            this.cijena = new System.Windows.Forms.TextBox();
            this.pretraziSve = new System.Windows.Forms.Button();
            this.pretrazi = new System.Windows.Forms.Button();
            this.nazivunos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.odustani = new System.Windows.Forms.Button();
            this.brisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spremi = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.pro = new System.Windows.Forms.Label();
            this.trg = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cijena
            // 
            this.cijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cijena.Location = new System.Drawing.Point(249, 291);
            this.cijena.Name = "cijena";
            this.cijena.Size = new System.Drawing.Size(233, 30);
            this.cijena.TabIndex = 70;
            // 
            // pretraziSve
            // 
            this.pretraziSve.BackColor = System.Drawing.Color.Cornsilk;
            this.pretraziSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pretraziSve.Location = new System.Drawing.Point(1079, 56);
            this.pretraziSve.Name = "pretraziSve";
            this.pretraziSve.Size = new System.Drawing.Size(170, 37);
            this.pretraziSve.TabIndex = 67;
            this.pretraziSve.Text = "Prikazi sve";
            this.pretraziSve.UseVisualStyleBackColor = false;
            this.pretraziSve.Click += new System.EventHandler(this.pretraziSve_Click);
            // 
            // pretrazi
            // 
            this.pretrazi.BackColor = System.Drawing.Color.Cornsilk;
            this.pretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pretrazi.Location = new System.Drawing.Point(1079, 12);
            this.pretrazi.Name = "pretrazi";
            this.pretrazi.Size = new System.Drawing.Size(170, 44);
            this.pretrazi.TabIndex = 66;
            this.pretrazi.Text = "Pretrazi";
            this.pretrazi.UseVisualStyleBackColor = false;
            this.pretrazi.Click += new System.EventHandler(this.pretrazi_Click);
            // 
            // nazivunos
            // 
            this.nazivunos.BackColor = System.Drawing.Color.SandyBrown;
            this.nazivunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivunos.ForeColor = System.Drawing.Color.Crimson;
            this.nazivunos.Location = new System.Drawing.Point(52, 272);
            this.nazivunos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazivunos.Name = "nazivunos";
            this.nazivunos.Size = new System.Drawing.Size(177, 52);
            this.nazivunos.TabIndex = 65;
            this.nazivunos.Text = "Cijena";
            this.nazivunos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 36);
            this.label3.TabIndex = 64;
            this.label3.Text = "Unos cijene";
            // 
            // odustani
            // 
            this.odustani.BackColor = System.Drawing.Color.Cornsilk;
            this.odustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odustani.Location = new System.Drawing.Point(398, 359);
            this.odustani.Margin = new System.Windows.Forms.Padding(4);
            this.odustani.Name = "odustani";
            this.odustani.Size = new System.Drawing.Size(156, 55);
            this.odustani.TabIndex = 62;
            this.odustani.Text = "Odustani";
            this.odustani.UseVisualStyleBackColor = false;
            this.odustani.Click += new System.EventHandler(this.odustani_Click);
            // 
            // brisi
            // 
            this.brisi.BackColor = System.Drawing.Color.Cornsilk;
            this.brisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brisi.Location = new System.Drawing.Point(234, 359);
            this.brisi.Margin = new System.Windows.Forms.Padding(4);
            this.brisi.Name = "brisi";
            this.brisi.Size = new System.Drawing.Size(156, 55);
            this.brisi.TabIndex = 63;
            this.brisi.Text = "Obrisi";
            this.brisi.UseVisualStyleBackColor = false;
            this.brisi.Click += new System.EventHandler(this.brisi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.Location = new System.Drawing.Point(600, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 380);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // spremi
            // 
            this.spremi.BackColor = System.Drawing.Color.Cornsilk;
            this.spremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spremi.Location = new System.Drawing.Point(70, 359);
            this.spremi.Margin = new System.Windows.Forms.Padding(4);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(156, 55);
            this.spremi.TabIndex = 60;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = false;
            this.spremi.Click += new System.EventHandler(this.spremi_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.search.Location = new System.Drawing.Point(600, 30);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(414, 30);
            this.search.TabIndex = 59;
            // 
            // pro
            // 
            this.pro.BackColor = System.Drawing.Color.SandyBrown;
            this.pro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pro.ForeColor = System.Drawing.Color.Crimson;
            this.pro.Location = new System.Drawing.Point(334, 206);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(148, 40);
            this.pro.TabIndex = 81;
            this.pro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trg
            // 
            this.trg.BackColor = System.Drawing.Color.SandyBrown;
            this.trg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trg.ForeColor = System.Drawing.Color.Crimson;
            this.trg.Location = new System.Drawing.Point(334, 122);
            this.trg.Name = "trg";
            this.trg.Size = new System.Drawing.Size(148, 41);
            this.trg.TabIndex = 80;
            this.trg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(252, 211);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(49, 33);
            this.comboBox2.TabIndex = 79;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 33);
            this.comboBox1.TabIndex = 78;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(56, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 54);
            this.label1.TabIndex = 77;
            this.label1.Text = "ID proizvoda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(57, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 60);
            this.label2.TabIndex = 76;
            this.label2.Text = "ID trgovine";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Cornsilk;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.update.Location = new System.Drawing.Point(70, 359);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(156, 55);
            this.update.TabIndex = 82;
            this.update.Text = "Azuriraj";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1261, 548);
            this.Controls.Add(this.update);
            this.Controls.Add(this.pro);
            this.Controls.Add(this.trg);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cijena);
            this.Controls.Add(this.pretraziSve);
            this.Controls.Add(this.pretrazi);
            this.Controls.Add(this.nazivunos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odustani);
            this.Controls.Add(this.brisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cijene";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cijena;
        private System.Windows.Forms.Button pretraziSve;
        private System.Windows.Forms.Button pretrazi;
        private System.Windows.Forms.Label nazivunos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button odustani;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label pro;
        private System.Windows.Forms.Label trg;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update;
    }
}
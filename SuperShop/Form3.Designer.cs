namespace baze_rad
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.naziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pretraziSve = new System.Windows.Forms.Button();
            this.pretrazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.odustani = new System.Windows.Forms.Button();
            this.brisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spremi = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nazivunos = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mj = new System.Windows.Forms.Label();
            this.pro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 46);
            this.label2.TabIndex = 39;
            this.label2.Text = "Naziv";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // naziv
            // 
            this.naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naziv.Location = new System.Drawing.Point(221, 142);
            this.naziv.Margin = new System.Windows.Forms.Padding(4);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(333, 30);
            this.naziv.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(34, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 37;
            this.label1.Text = "Proizvodac";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pretraziSve
            // 
            this.pretraziSve.BackColor = System.Drawing.Color.Cornsilk;
            this.pretraziSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pretraziSve.Location = new System.Drawing.Point(1079, 56);
            this.pretraziSve.Name = "pretraziSve";
            this.pretraziSve.Size = new System.Drawing.Size(170, 37);
            this.pretraziSve.TabIndex = 35;
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
            this.pretrazi.TabIndex = 34;
            this.pretrazi.Text = "Pretrazi";
            this.pretrazi.UseVisualStyleBackColor = false;
            this.pretrazi.Click += new System.EventHandler(this.pretrazi_Click);
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
            this.label3.Size = new System.Drawing.Size(239, 36);
            this.label3.TabIndex = 32;
            this.label3.Text = "Unos proizvoda";
            // 
            // odustani
            // 
            this.odustani.BackColor = System.Drawing.Color.Cornsilk;
            this.odustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odustani.Location = new System.Drawing.Point(398, 359);
            this.odustani.Margin = new System.Windows.Forms.Padding(4);
            this.odustani.Name = "odustani";
            this.odustani.Size = new System.Drawing.Size(156, 55);
            this.odustani.TabIndex = 30;
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
            this.brisi.TabIndex = 31;
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
            this.dataGridView1.TabIndex = 28;
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
            this.spremi.TabIndex = 27;
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
            this.search.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(221, 265);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(49, 33);
            this.comboBox2.TabIndex = 41;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // nazivunos
            // 
            this.nazivunos.BackColor = System.Drawing.Color.SandyBrown;
            this.nazivunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivunos.ForeColor = System.Drawing.Color.Crimson;
            this.nazivunos.Location = new System.Drawing.Point(34, 185);
            this.nazivunos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazivunos.Name = "nazivunos";
            this.nazivunos.Size = new System.Drawing.Size(164, 60);
            this.nazivunos.TabIndex = 33;
            this.nazivunos.Text = "Mjerna jedinica";
            this.nazivunos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 33);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mj
            // 
            this.mj.BackColor = System.Drawing.Color.SandyBrown;
            this.mj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mj.ForeColor = System.Drawing.Color.Crimson;
            this.mj.Location = new System.Drawing.Point(303, 195);
            this.mj.Name = "mj";
            this.mj.Size = new System.Drawing.Size(148, 41);
            this.mj.TabIndex = 74;
            this.mj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pro
            // 
            this.pro.BackColor = System.Drawing.Color.SandyBrown;
            this.pro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pro.ForeColor = System.Drawing.Color.Crimson;
            this.pro.Location = new System.Drawing.Point(303, 265);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(148, 40);
            this.pro.TabIndex = 75;
            this.pro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1261, 548);
            this.Controls.Add(this.pro);
            this.Controls.Add(this.mj);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.label1);
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
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvod";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pretraziSve;
        private System.Windows.Forms.Button pretrazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button odustani;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label nazivunos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label mj;
        private System.Windows.Forms.Label pro;
    }
}
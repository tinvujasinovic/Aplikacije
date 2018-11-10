namespace baze_rad
{
    partial class Form1
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
            this.spremi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.TextBox();
            this.brisi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nazivunos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // spremi
            // 
            this.spremi.BackColor = System.Drawing.Color.Cornsilk;
            this.spremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spremi.Location = new System.Drawing.Point(33, 236);
            this.spremi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(155, 55);
            this.spremi.TabIndex = 2;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = false;
            this.spremi.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.Location = new System.Drawing.Point(566, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(564, 380);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // naziv
            // 
            this.naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naziv.Location = new System.Drawing.Point(187, 130);
            this.naziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(252, 30);
            this.naziv.TabIndex = 5;
            // 
            // brisi
            // 
            this.brisi.BackColor = System.Drawing.Color.Cornsilk;
            this.brisi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brisi.Location = new System.Drawing.Point(197, 236);
            this.brisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brisi.Name = "brisi";
            this.brisi.Size = new System.Drawing.Size(155, 55);
            this.brisi.TabIndex = 6;
            this.brisi.Text = "Obrisi";
            this.brisi.UseVisualStyleBackColor = false;
            this.brisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cornsilk;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(362, 236);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 55);
            this.button3.TabIndex = 6;
            this.button3.Text = "Odustani";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.search.Location = new System.Drawing.Point(566, 30);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(414, 30);
            this.search.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unos mjernih jedinica";
            // 
            // nazivunos
            // 
            this.nazivunos.BackColor = System.Drawing.Color.SandyBrown;
            this.nazivunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivunos.ForeColor = System.Drawing.Color.Crimson;
            this.nazivunos.Location = new System.Drawing.Point(16, 111);
            this.nazivunos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazivunos.Name = "nazivunos";
            this.nazivunos.Size = new System.Drawing.Size(132, 46);
            this.nazivunos.TabIndex = 9;
            this.nazivunos.Text = "Puni naziv";
            this.nazivunos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1046, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pretrazi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cornsilk;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(1046, 56);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 38);
            this.button4.TabIndex = 11;
            this.button4.Text = "Prikazi sve";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1261, 548);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nazivunos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.brisi);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.search);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mjerne jedinice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nazivunos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}


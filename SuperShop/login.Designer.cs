namespace baze_rad
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.prijava = new System.Windows.Forms.Button();
            this.izadi = new System.Windows.Forms.Button();
            this.korisnicko = new System.Windows.Forms.Label();
            this.lozinka = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prijava
            // 
            this.prijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijava.Location = new System.Drawing.Point(212, 283);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(139, 47);
            this.prijava.TabIndex = 0;
            this.prijava.Text = "Prijavi se";
            this.prijava.UseVisualStyleBackColor = true;
            this.prijava.Click += new System.EventHandler(this.prijava_Click);
            // 
            // izadi
            // 
            this.izadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izadi.Location = new System.Drawing.Point(398, 283);
            this.izadi.Name = "izadi";
            this.izadi.Size = new System.Drawing.Size(139, 47);
            this.izadi.TabIndex = 1;
            this.izadi.Text = "Izadi";
            this.izadi.UseVisualStyleBackColor = true;
            this.izadi.Click += new System.EventHandler(this.izadi_Click);
            // 
            // korisnicko
            // 
            this.korisnicko.AutoSize = true;
            this.korisnicko.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korisnicko.Location = new System.Drawing.Point(209, 54);
            this.korisnicko.Name = "korisnicko";
            this.korisnicko.Size = new System.Drawing.Size(244, 38);
            this.korisnicko.TabIndex = 2;
            this.korisnicko.Text = "Korisnicko ime";
            // 
            // lozinka
            // 
            this.lozinka.AutoSize = true;
            this.lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lozinka.Location = new System.Drawing.Point(209, 156);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(137, 38);
            this.lozinka.TabIndex = 3;
            this.lozinka.Text = "Lozinka";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(216, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 30);
            this.textBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(216, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(246, 30);
            this.textBox2.TabIndex = 7;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korisnicko);
            this.Controls.Add(this.izadi);
            this.Controls.Add(this.prijava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(2500, 2500);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.Button izadi;
        private System.Windows.Forms.Label korisnicko;
        private System.Windows.Forms.Label lozinka;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox textBox2;
    }
}
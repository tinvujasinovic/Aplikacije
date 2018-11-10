namespace MilkyApp
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.dioPrijava = new System.Windows.Forms.Panel();
            this.uiInputLozinka = new System.Windows.Forms.MaskedTextBox();
            this.uiActionPrijava = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiInputKorisnickoIme = new System.Windows.Forms.TextBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.helpPrijava = new System.Windows.Forms.HelpProvider();
            this.dioPrijava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dioPrijava
            // 
            this.dioPrijava.BackColor = System.Drawing.Color.Transparent;
            this.dioPrijava.Controls.Add(this.uiInputLozinka);
            this.dioPrijava.Controls.Add(this.uiActionPrijava);
            this.dioPrijava.Controls.Add(this.label2);
            this.dioPrijava.Controls.Add(this.label1);
            this.dioPrijava.Controls.Add(this.uiInputKorisnickoIme);
            this.dioPrijava.Location = new System.Drawing.Point(227, 181);
            this.dioPrijava.Name = "dioPrijava";
            this.dioPrijava.Size = new System.Drawing.Size(343, 257);
            this.dioPrijava.TabIndex = 0;
            // 
            // uiInputLozinka
            // 
            this.uiInputLozinka.BackColor = System.Drawing.Color.GhostWhite;
            this.uiInputLozinka.Location = new System.Drawing.Point(41, 129);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.PasswordChar = '•';
            this.uiInputLozinka.Size = new System.Drawing.Size(263, 20);
            this.uiInputLozinka.TabIndex = 1;
            // 
            // uiActionPrijava
            // 
            this.uiActionPrijava.BackColor = System.Drawing.Color.GhostWhite;
            this.uiActionPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionPrijava.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiActionPrijava.Location = new System.Drawing.Point(108, 183);
            this.uiActionPrijava.Name = "uiActionPrijava";
            this.uiActionPrijava.Size = new System.Drawing.Size(131, 45);
            this.uiActionPrijava.TabIndex = 2;
            this.uiActionPrijava.Text = "Prijavi se";
            this.uiActionPrijava.UseVisualStyleBackColor = false;
            this.uiActionPrijava.Click += new System.EventHandler(this.uiActionPrijava_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail:";
            // 
            // uiInputKorisnickoIme
            // 
            this.uiInputKorisnickoIme.BackColor = System.Drawing.Color.GhostWhite;
            this.uiInputKorisnickoIme.Location = new System.Drawing.Point(41, 73);
            this.uiInputKorisnickoIme.Name = "uiInputKorisnickoIme";
            this.uiInputKorisnickoIme.Size = new System.Drawing.Size(263, 20);
            this.uiInputKorisnickoIme.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = global::MilkyApp.Properties.Resources.MilkyTEXT;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogo.Location = new System.Drawing.Point(227, 23);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(343, 152);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // helpPrijava
            // 
            this.helpPrijava.HelpNamespace = "..\\..\\Help\\1Prijava.htm";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MilkyApp.Properties.Resources.pozadinaForme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.dioPrijava);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prijava";
            this.helpPrijava.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.dioPrijava.ResumeLayout(false);
            this.dioPrijava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dioPrijava;
        private System.Windows.Forms.MaskedTextBox uiInputLozinka;
        private System.Windows.Forms.Button uiActionPrijava;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiInputKorisnickoIme;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.HelpProvider helpPrijava;
    }
}


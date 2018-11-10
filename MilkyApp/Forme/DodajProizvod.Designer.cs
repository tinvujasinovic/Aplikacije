namespace MilkyApp.Forme
{
    partial class DodajProizvod
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
            this.panelProizvodi = new System.Windows.Forms.Panel();
            this.uiActionDodajProizvod = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiSelectMjernaJedinica = new System.Windows.Forms.ComboBox();
            this.mjernejediniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputKolicina = new System.Windows.Forms.TextBox();
            this.uiInputCijenaProizvoda = new System.Windows.Forms.TextBox();
            this.uiInputOpisProizvoda = new System.Windows.Forms.TextBox();
            this.uiInputNazivProizvoda = new System.Windows.Forms.TextBox();
            this.panelProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mjernejediniceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProizvodi
            // 
            this.panelProizvodi.BackColor = System.Drawing.Color.Transparent;
            this.panelProizvodi.Controls.Add(this.uiActionDodajProizvod);
            this.panelProizvodi.Controls.Add(this.uiActionOdustani);
            this.panelProizvodi.Controls.Add(this.label5);
            this.panelProizvodi.Controls.Add(this.label4);
            this.panelProizvodi.Controls.Add(this.label3);
            this.panelProizvodi.Controls.Add(this.label2);
            this.panelProizvodi.Controls.Add(this.label1);
            this.panelProizvodi.Controls.Add(this.uiSelectMjernaJedinica);
            this.panelProizvodi.Controls.Add(this.uiInputKolicina);
            this.panelProizvodi.Controls.Add(this.uiInputCijenaProizvoda);
            this.panelProizvodi.Controls.Add(this.uiInputOpisProizvoda);
            this.panelProizvodi.Controls.Add(this.uiInputNazivProizvoda);
            this.panelProizvodi.Location = new System.Drawing.Point(179, 12);
            this.panelProizvodi.Name = "panelProizvodi";
            this.panelProizvodi.Size = new System.Drawing.Size(421, 426);
            this.panelProizvodi.TabIndex = 0;
            // 
            // uiActionDodajProizvod
            // 
            this.uiActionDodajProizvod.Location = new System.Drawing.Point(230, 249);
            this.uiActionDodajProizvod.Name = "uiActionDodajProizvod";
            this.uiActionDodajProizvod.Size = new System.Drawing.Size(128, 36);
            this.uiActionDodajProizvod.TabIndex = 7;
            this.uiActionDodajProizvod.Text = "Dodaj proizvod";
            this.uiActionDodajProizvod.UseVisualStyleBackColor = true;
            this.uiActionDodajProizvod.Click += new System.EventHandler(this.uiActionDodajProizvod_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(86, 249);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(128, 36);
            this.uiActionOdustani.TabIndex = 7;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mjerna jedinica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Raspoloživa količina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cijena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis proizvoda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv proizvoda:";
            // 
            // uiSelectMjernaJedinica
            // 
            this.uiSelectMjernaJedinica.DataSource = this.mjernejediniceBindingSource;
            this.uiSelectMjernaJedinica.DisplayMember = "naziv";
            this.uiSelectMjernaJedinica.FormattingEnabled = true;
            this.uiSelectMjernaJedinica.Location = new System.Drawing.Point(169, 185);
            this.uiSelectMjernaJedinica.Name = "uiSelectMjernaJedinica";
            this.uiSelectMjernaJedinica.Size = new System.Drawing.Size(214, 21);
            this.uiSelectMjernaJedinica.TabIndex = 1;
            this.uiSelectMjernaJedinica.ValueMember = "mjerna_jedinica_ID";
            // 
            // mjernejediniceBindingSource
            // 
            this.mjernejediniceBindingSource.DataSource = typeof(MilkyApp.mjerne_jedinice);
            // 
            // uiInputKolicina
            // 
            this.uiInputKolicina.Location = new System.Drawing.Point(169, 159);
            this.uiInputKolicina.Name = "uiInputKolicina";
            this.uiInputKolicina.Size = new System.Drawing.Size(214, 20);
            this.uiInputKolicina.TabIndex = 0;
            // 
            // uiInputCijenaProizvoda
            // 
            this.uiInputCijenaProizvoda.Location = new System.Drawing.Point(169, 133);
            this.uiInputCijenaProizvoda.Name = "uiInputCijenaProizvoda";
            this.uiInputCijenaProizvoda.Size = new System.Drawing.Size(214, 20);
            this.uiInputCijenaProizvoda.TabIndex = 0;
            // 
            // uiInputOpisProizvoda
            // 
            this.uiInputOpisProizvoda.Location = new System.Drawing.Point(169, 107);
            this.uiInputOpisProizvoda.Name = "uiInputOpisProizvoda";
            this.uiInputOpisProizvoda.Size = new System.Drawing.Size(214, 20);
            this.uiInputOpisProizvoda.TabIndex = 0;
            // 
            // uiInputNazivProizvoda
            // 
            this.uiInputNazivProizvoda.Location = new System.Drawing.Point(169, 81);
            this.uiInputNazivProizvoda.Name = "uiInputNazivProizvoda";
            this.uiInputNazivProizvoda.Size = new System.Drawing.Size(214, 20);
            this.uiInputNazivProizvoda.TabIndex = 0;
            // 
            // DodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MilkyApp.Properties.Resources.pozadinaForme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelProizvodi);
            this.Name = "DodajProizvod";
            this.Text = "DodajProizvod";
            this.panelProizvodi.ResumeLayout(false);
            this.panelProizvodi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mjernejediniceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProizvodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiSelectMjernaJedinica;
        private System.Windows.Forms.TextBox uiInputKolicina;
        private System.Windows.Forms.TextBox uiInputCijenaProizvoda;
        private System.Windows.Forms.TextBox uiInputOpisProizvoda;
        private System.Windows.Forms.TextBox uiInputNazivProizvoda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uiActionDodajProizvod;
        private System.Windows.Forms.BindingSource mjernejediniceBindingSource;
    }
}
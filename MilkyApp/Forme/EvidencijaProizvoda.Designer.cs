namespace MilkyApp
{
    partial class EvidencijaProizvoda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaProizvoda));
            this.uiActionUredivanje = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.outputPrikazProizvoda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionUredivanje
            // 
            this.uiActionUredivanje.Location = new System.Drawing.Point(289, 297);
            this.uiActionUredivanje.Name = "uiActionUredivanje";
            this.uiActionUredivanje.Size = new System.Drawing.Size(123, 23);
            this.uiActionUredivanje.TabIndex = 0;
            this.uiActionUredivanje.Text = "Uredi proizvode";
            this.uiActionUredivanje.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 240);
            this.dataGridView1.TabIndex = 1;
            // 
            // outputPrikazProizvoda
            // 
            this.outputPrikazProizvoda.AutoSize = true;
            this.outputPrikazProizvoda.Location = new System.Drawing.Point(12, 23);
            this.outputPrikazProizvoda.Name = "outputPrikazProizvoda";
            this.outputPrikazProizvoda.Size = new System.Drawing.Size(92, 13);
            this.outputPrikazProizvoda.TabIndex = 2;
            this.outputPrikazProizvoda.Text = "Pregled proizvoda";
            // 
            // EvidencijaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(461, 335);
            this.Controls.Add(this.outputPrikazProizvoda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uiActionUredivanje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvidencijaProizvoda";
            this.Text = "Proizvodi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionUredivanje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label outputPrikazProizvoda;
    }
}
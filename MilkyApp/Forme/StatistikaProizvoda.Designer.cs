namespace MilkyApp.Forme
{
    partial class StatistikaProizvoda
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistikaProizvoda));
            this.panelProizvodi = new System.Windows.Forms.Panel();
            this.uiChartProizvodi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiChartProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProizvodi
            // 
            this.panelProizvodi.BackColor = System.Drawing.Color.Transparent;
            this.panelProizvodi.Controls.Add(this.uiChartProizvodi);
            this.panelProizvodi.Location = new System.Drawing.Point(117, 28);
            this.panelProizvodi.Name = "panelProizvodi";
            this.panelProizvodi.Size = new System.Drawing.Size(571, 400);
            this.panelProizvodi.TabIndex = 0;
            // 
            // uiChartProizvodi
            // 
            this.uiChartProizvodi.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.uiChartProizvodi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.uiChartProizvodi.Legends.Add(legend1);
            this.uiChartProizvodi.Location = new System.Drawing.Point(124, 54);
            this.uiChartProizvodi.Name = "uiChartProizvodi";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Proizvodi";
            this.uiChartProizvodi.Series.Add(series1);
            this.uiChartProizvodi.Size = new System.Drawing.Size(300, 300);
            this.uiChartProizvodi.TabIndex = 0;
            this.uiChartProizvodi.Text = "chart1";
            // 
            // StatistikaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MilkyApp.Properties.Resources.pozadinaForme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelProizvodi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatistikaProizvoda";
            this.Text = "StatistikaProizvoda";
            this.Load += new System.EventHandler(this.StatistikaProizvoda_Load);
            this.panelProizvodi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiChartProizvodi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProizvodi;
        private System.Windows.Forms.DataVisualization.Charting.Chart uiChartProizvodi;
    }
}
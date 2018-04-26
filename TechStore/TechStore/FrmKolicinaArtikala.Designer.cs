namespace TechStore
{
    partial class FrmKolicinaArtikala
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
            this.uiOutputGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.uiInputArtikl = new System.Windows.Forms.ComboBox();
            this.uiActionNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputGraf
            // 
            chartArea1.Name = "ChartArea1";
            this.uiOutputGraf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.uiOutputGraf.Legends.Add(legend1);
            this.uiOutputGraf.Location = new System.Drawing.Point(22, 95);
            this.uiOutputGraf.Name = "uiOutputGraf";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.uiOutputGraf.Series.Add(series1);
            this.uiOutputGraf.Size = new System.Drawing.Size(404, 316);
            this.uiOutputGraf.TabIndex = 0;
            this.uiOutputGraf.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv artikla:";
            // 
            // uiInputArtikl
            // 
            this.uiInputArtikl.FormattingEnabled = true;
            this.uiInputArtikl.Location = new System.Drawing.Point(112, 48);
            this.uiInputArtikl.Name = "uiInputArtikl";
            this.uiInputArtikl.Size = new System.Drawing.Size(160, 21);
            this.uiInputArtikl.TabIndex = 3;
            // 
            // uiActionNatrag
            // 
            this.uiActionNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNatrag.Location = new System.Drawing.Point(348, 12);
            this.uiActionNatrag.Name = "uiActionNatrag";
            this.uiActionNatrag.Size = new System.Drawing.Size(78, 28);
            this.uiActionNatrag.TabIndex = 6;
            this.uiActionNatrag.Text = "NATRAG";
            this.uiActionNatrag.UseVisualStyleBackColor = true;
            // 
            // FrmKolicinaArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 423);
            this.Controls.Add(this.uiActionNatrag);
            this.Controls.Add(this.uiInputArtikl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputGraf);
            this.Name = "FrmKolicinaArtikala";
            this.Text = "Kolicina";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputGraf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart uiOutputGraf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiInputArtikl;
        private System.Windows.Forms.Button uiActionNatrag;
    }
}
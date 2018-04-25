namespace TechStore
{
    partial class FrmKolicina
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
            this.uiOutputArtikli = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiInputArtikl = new System.Windows.Forms.ComboBox();
            this.uiInputPoslovnica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiActionNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputGraf
            // 
            chartArea1.Name = "ChartArea1";
            this.uiOutputGraf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.uiOutputGraf.Legends.Add(legend1);
            this.uiOutputGraf.Location = new System.Drawing.Point(401, 73);
            this.uiOutputGraf.Name = "uiOutputGraf";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.uiOutputGraf.Series.Add(series1);
            this.uiOutputGraf.Size = new System.Drawing.Size(315, 316);
            this.uiOutputGraf.TabIndex = 0;
            this.uiOutputGraf.Text = "chart1";
            // 
            // uiOutputArtikli
            // 
            this.uiOutputArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputArtikli.Location = new System.Drawing.Point(12, 76);
            this.uiOutputArtikli.Name = "uiOutputArtikli";
            this.uiOutputArtikli.Size = new System.Drawing.Size(383, 313);
            this.uiOutputArtikli.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(398, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv artikla:";
            // 
            // uiInputArtikl
            // 
            this.uiInputArtikl.FormattingEnabled = true;
            this.uiInputArtikl.Location = new System.Drawing.Point(486, 46);
            this.uiInputArtikl.Name = "uiInputArtikl";
            this.uiInputArtikl.Size = new System.Drawing.Size(121, 21);
            this.uiInputArtikl.TabIndex = 3;
            // 
            // uiInputPoslovnica
            // 
            this.uiInputPoslovnica.FormattingEnabled = true;
            this.uiInputPoslovnica.Location = new System.Drawing.Point(131, 49);
            this.uiInputPoslovnica.Name = "uiInputPoslovnica";
            this.uiInputPoslovnica.Size = new System.Drawing.Size(121, 21);
            this.uiInputPoslovnica.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv poslovnice:";
            // 
            // uiActionNatrag
            // 
            this.uiActionNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNatrag.Location = new System.Drawing.Point(12, 12);
            this.uiActionNatrag.Name = "uiActionNatrag";
            this.uiActionNatrag.Size = new System.Drawing.Size(78, 28);
            this.uiActionNatrag.TabIndex = 6;
            this.uiActionNatrag.Text = "NATRAG";
            this.uiActionNatrag.UseVisualStyleBackColor = true;
            // 
            // Kolicina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 401);
            this.Controls.Add(this.uiActionNatrag);
            this.Controls.Add(this.uiInputPoslovnica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiInputArtikl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputArtikli);
            this.Controls.Add(this.uiOutputGraf);
            this.Name = "Kolicina";
            this.Text = "Kolicina";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart uiOutputGraf;
        private System.Windows.Forms.DataGridView uiOutputArtikli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiInputArtikl;
        private System.Windows.Forms.ComboBox uiInputPoslovnica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiActionNatrag;
    }
}
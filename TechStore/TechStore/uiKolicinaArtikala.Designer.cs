namespace TechStore
{
    partial class uiKolicinaArtikala
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.uiOutputGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uiLabelArtikl = new System.Windows.Forms.Label();
            this.uiInputArtikl = new System.Windows.Forms.ComboBox();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
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
            series1.Name = "Kolicina";
            this.uiOutputGraf.Series.Add(series1);
            this.uiOutputGraf.Size = new System.Drawing.Size(438, 351);
            this.uiOutputGraf.TabIndex = 0;
            this.uiOutputGraf.Text = "chart1";
            // 
            // uiLabelArtikl
            // 
            this.uiLabelArtikl.AutoSize = true;
            this.uiLabelArtikl.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelArtikl.Location = new System.Drawing.Point(144, 51);
            this.uiLabelArtikl.Name = "uiLabelArtikl";
            this.uiLabelArtikl.Size = new System.Drawing.Size(82, 13);
            this.uiLabelArtikl.TabIndex = 2;
            this.uiLabelArtikl.Text = "Naziv artikla:";
            // 
            // uiInputArtikl
            // 
            this.uiInputArtikl.DataSource = this.artiklBindingSource;
            this.uiInputArtikl.DisplayMember = "Naziv";
            this.uiInputArtikl.FormattingEnabled = true;
            this.uiInputArtikl.Location = new System.Drawing.Point(232, 48);
            this.uiInputArtikl.Name = "uiInputArtikl";
            this.uiInputArtikl.Size = new System.Drawing.Size(228, 21);
            this.uiInputArtikl.TabIndex = 3;
            this.uiInputArtikl.ValueMember = "ID";
            this.uiInputArtikl.SelectedValueChanged += new System.EventHandler(this.uiInputArtikl_SelectedValueChanged);
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(TechStore.Artikl);
            // 
            // uiActionNatrag
            // 
            this.uiActionNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNatrag.Location = new System.Drawing.Point(22, 12);
            this.uiActionNatrag.Name = "uiActionNatrag";
            this.uiActionNatrag.Size = new System.Drawing.Size(78, 28);
            this.uiActionNatrag.TabIndex = 6;
            this.uiActionNatrag.Text = "NATRAG";
            this.uiActionNatrag.UseVisualStyleBackColor = true;
            this.uiActionNatrag.Click += new System.EventHandler(this.uiActionNatrag_Click);
            // 
            // uiKolicinaArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 458);
            this.Controls.Add(this.uiActionNatrag);
            this.Controls.Add(this.uiInputArtikl);
            this.Controls.Add(this.uiLabelArtikl);
            this.Controls.Add(this.uiOutputGraf);
            this.Name = "uiKolicinaArtikala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Količina artikala po poslovnicama";
            this.Load += new System.EventHandler(this.uiKolicinaArtikala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart uiOutputGraf;
        private System.Windows.Forms.Label uiLabelArtikl;
        private System.Windows.Forms.ComboBox uiInputArtikl;
        private System.Windows.Forms.Button uiActionNatrag;
        private System.Windows.Forms.BindingSource artiklBindingSource;
    }
}
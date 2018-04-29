namespace TechStore
{
    partial class FrmStanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputStanjeArtikala = new System.Windows.Forms.DataGridView();
            this.uiActionNatrag = new System.Windows.Forms.Button();
            this.uiActionNaruci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputStanjeArtikala)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stanje artikala poslovnice";
            // 
            // uiOutputStanjeArtikala
            // 
            this.uiOutputStanjeArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputStanjeArtikala.Location = new System.Drawing.Point(12, 44);
            this.uiOutputStanjeArtikala.Name = "uiOutputStanjeArtikala";
            this.uiOutputStanjeArtikala.Size = new System.Drawing.Size(478, 194);
            this.uiOutputStanjeArtikala.TabIndex = 1;
            // 
            // uiActionNatrag
            // 
            this.uiActionNatrag.Location = new System.Drawing.Point(415, 244);
            this.uiActionNatrag.Name = "uiActionNatrag";
            this.uiActionNatrag.Size = new System.Drawing.Size(75, 23);
            this.uiActionNatrag.TabIndex = 2;
            this.uiActionNatrag.Text = "Natrag";
            this.uiActionNatrag.UseVisualStyleBackColor = true;
            this.uiActionNatrag.Click += new System.EventHandler(this.UiActionNatrag_Click);
            // 
            // uiActionNaruci
            // 
            this.uiActionNaruci.Location = new System.Drawing.Point(206, 244);
            this.uiActionNaruci.Name = "uiActionNaruci";
            this.uiActionNaruci.Size = new System.Drawing.Size(75, 23);
            this.uiActionNaruci.TabIndex = 3;
            this.uiActionNaruci.Text = "Naruči";
            this.uiActionNaruci.UseVisualStyleBackColor = true;
            this.uiActionNaruci.Click += new System.EventHandler(this.UiActionNaruci_Click);
            // 
            // FrmStanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 277);
            this.Controls.Add(this.uiActionNaruci);
            this.Controls.Add(this.uiActionNatrag);
            this.Controls.Add(this.uiOutputStanjeArtikala);
            this.Controls.Add(this.label1);
            this.Name = "FrmStanje";
            this.Text = "FrmStanje";
            this.Load += new System.EventHandler(this.FrmStanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputStanjeArtikala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputStanjeArtikala;
        private System.Windows.Forms.Button uiActionNatrag;
        private System.Windows.Forms.Button uiActionNaruci;
    }
}
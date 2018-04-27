namespace TechStore
{
    partial class FrmArtikl
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
            this.uiActionDodajArtikl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputPodaciArtikli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPodaciArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionDodajArtikl
            // 
            this.uiActionDodajArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajArtikl.Location = new System.Drawing.Point(184, 232);
            this.uiActionDodajArtikl.Name = "uiActionDodajArtikl";
            this.uiActionDodajArtikl.Size = new System.Drawing.Size(157, 34);
            this.uiActionDodajArtikl.TabIndex = 5;
            this.uiActionDodajArtikl.Text = "DODAJ ARTIKL";
            this.uiActionDodajArtikl.UseVisualStyleBackColor = true;
            this.uiActionDodajArtikl.Click += new System.EventHandler(this.UiActionDodajArtikl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Podaci o artiklima:";
            // 
            // uiOutputPodaciArtikli
            // 
            this.uiOutputPodaciArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPodaciArtikli.Location = new System.Drawing.Point(28, 29);
            this.uiOutputPodaciArtikli.Name = "uiOutputPodaciArtikli";
            this.uiOutputPodaciArtikli.Size = new System.Drawing.Size(450, 183);
            this.uiOutputPodaciArtikli.TabIndex = 3;
            // 
            // FrmArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 277);
            this.Controls.Add(this.uiActionDodajArtikl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputPodaciArtikli);
            this.Name = "FrmArtikl";
            this.Text = "FrmArtikl";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPodaciArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionDodajArtikl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputPodaciArtikli;
    }
}
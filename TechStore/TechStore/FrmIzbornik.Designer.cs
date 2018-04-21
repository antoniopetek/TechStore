namespace TechStore
{
    partial class FrmIzbornik
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
            this.uiActionDodajZaposlenika = new System.Windows.Forms.Button();
            this.uiActionDodajPoslovnicu = new System.Windows.Forms.Button();
            this.uiActionIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiActionDodajArtikl
            // 
            this.uiActionDodajArtikl.Location = new System.Drawing.Point(12, 23);
            this.uiActionDodajArtikl.Name = "uiActionDodajArtikl";
            this.uiActionDodajArtikl.Size = new System.Drawing.Size(75, 23);
            this.uiActionDodajArtikl.TabIndex = 0;
            this.uiActionDodajArtikl.Text = "Dodaj artikl";
            this.uiActionDodajArtikl.UseVisualStyleBackColor = true;
            // 
            // uiActionDodajZaposlenika
            // 
            this.uiActionDodajZaposlenika.Location = new System.Drawing.Point(107, 14);
            this.uiActionDodajZaposlenika.Name = "uiActionDodajZaposlenika";
            this.uiActionDodajZaposlenika.Size = new System.Drawing.Size(92, 41);
            this.uiActionDodajZaposlenika.TabIndex = 1;
            this.uiActionDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.uiActionDodajZaposlenika.UseVisualStyleBackColor = true;
            // 
            // uiActionDodajPoslovnicu
            // 
            this.uiActionDodajPoslovnicu.Location = new System.Drawing.Point(240, 23);
            this.uiActionDodajPoslovnicu.Name = "uiActionDodajPoslovnicu";
            this.uiActionDodajPoslovnicu.Size = new System.Drawing.Size(92, 41);
            this.uiActionDodajPoslovnicu.TabIndex = 2;
            this.uiActionDodajPoslovnicu.Text = "Dodaj poslovnicu";
            this.uiActionDodajPoslovnicu.UseVisualStyleBackColor = true;
            // 
            // uiActionIzlaz
            // 
            this.uiActionIzlaz.Location = new System.Drawing.Point(326, 205);
            this.uiActionIzlaz.Name = "uiActionIzlaz";
            this.uiActionIzlaz.Size = new System.Drawing.Size(92, 41);
            this.uiActionIzlaz.TabIndex = 3;
            this.uiActionIzlaz.Text = "Izlaz";
            this.uiActionIzlaz.UseVisualStyleBackColor = true;
            this.uiActionIzlaz.Click += new System.EventHandler(this.UiActionIzlaz_Click);
            // 
            // FrmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 258);
            this.Controls.Add(this.uiActionIzlaz);
            this.Controls.Add(this.uiActionDodajPoslovnicu);
            this.Controls.Add(this.uiActionDodajZaposlenika);
            this.Controls.Add(this.uiActionDodajArtikl);
            this.Name = "FrmIzbornik";
            this.Text = "Izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiActionDodajArtikl;
        private System.Windows.Forms.Button uiActionDodajZaposlenika;
        private System.Windows.Forms.Button uiActionDodajPoslovnicu;
        private System.Windows.Forms.Button uiActionIzlaz;
    }
}
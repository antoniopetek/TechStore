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
            this.uiActionZaposlenici = new System.Windows.Forms.Button();
            this.uiActionPoslovnice = new System.Windows.Forms.Button();
            this.uiActionIzlaz = new System.Windows.Forms.Button();
            this.uiActionPregledArtikala = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiActionDodajArtikl
            // 
            this.uiActionDodajArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajArtikl.Location = new System.Drawing.Point(12, 84);
            this.uiActionDodajArtikl.Name = "uiActionDodajArtikl";
            this.uiActionDodajArtikl.Size = new System.Drawing.Size(103, 53);
            this.uiActionDodajArtikl.TabIndex = 0;
            this.uiActionDodajArtikl.Text = "Artikli";
            this.uiActionDodajArtikl.UseVisualStyleBackColor = true;
            this.uiActionDodajArtikl.Click += new System.EventHandler(this.UiActionDodajArtikl_Click);
            // 
            // uiActionZaposlenici
            // 
            this.uiActionZaposlenici.BackColor = System.Drawing.Color.Transparent;
            this.uiActionZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionZaposlenici.Location = new System.Drawing.Point(12, 25);
            this.uiActionZaposlenici.Name = "uiActionZaposlenici";
            this.uiActionZaposlenici.Size = new System.Drawing.Size(103, 53);
            this.uiActionZaposlenici.TabIndex = 1;
            this.uiActionZaposlenici.Text = "Zaposlenici";
            this.uiActionZaposlenici.UseVisualStyleBackColor = false;
            this.uiActionZaposlenici.Click += new System.EventHandler(this.UiActionZaposlenici_Click);
            // 
            // uiActionPoslovnice
            // 
            this.uiActionPoslovnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPoslovnice.Location = new System.Drawing.Point(121, 25);
            this.uiActionPoslovnice.Name = "uiActionPoslovnice";
            this.uiActionPoslovnice.Size = new System.Drawing.Size(103, 53);
            this.uiActionPoslovnice.TabIndex = 2;
            this.uiActionPoslovnice.Text = "Poslovnice";
            this.uiActionPoslovnice.UseVisualStyleBackColor = true;
            this.uiActionPoslovnice.Click += new System.EventHandler(this.UiActionDodajPoslovnicu_Click);
            // 
            // uiActionIzlaz
            // 
            this.uiActionIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionIzlaz.Location = new System.Drawing.Point(343, 225);
            this.uiActionIzlaz.Name = "uiActionIzlaz";
            this.uiActionIzlaz.Size = new System.Drawing.Size(103, 53);
            this.uiActionIzlaz.TabIndex = 3;
            this.uiActionIzlaz.Text = "Izlaz";
            this.uiActionIzlaz.UseVisualStyleBackColor = true;
            this.uiActionIzlaz.Click += new System.EventHandler(this.UiActionIzlaz_Click);
            // 
            // uiActionPregledArtikala
            // 
            this.uiActionPregledArtikala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPregledArtikala.Location = new System.Drawing.Point(230, 25);
            this.uiActionPregledArtikala.Name = "uiActionPregledArtikala";
            this.uiActionPregledArtikala.Size = new System.Drawing.Size(103, 53);
            this.uiActionPregledArtikala.TabIndex = 4;
            this.uiActionPregledArtikala.Text = "Pregled artikala po poslovnicama";
            this.uiActionPregledArtikala.UseVisualStyleBackColor = true;
            this.uiActionPregledArtikala.Click += new System.EventHandler(this.UiActionPregledArtikala_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(343, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Izrada konfiguracije";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prijavljeni ste kao:";
            // 
            // FrmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uiActionPregledArtikala);
            this.Controls.Add(this.uiActionIzlaz);
            this.Controls.Add(this.uiActionPoslovnice);
            this.Controls.Add(this.uiActionZaposlenici);
            this.Controls.Add(this.uiActionDodajArtikl);
            this.Name = "FrmIzbornik";
            this.Text = "Izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionDodajArtikl;
        private System.Windows.Forms.Button uiActionZaposlenici;
        private System.Windows.Forms.Button uiActionPoslovnice;
        private System.Windows.Forms.Button uiActionIzlaz;
        private System.Windows.Forms.Button uiActionPregledArtikala;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
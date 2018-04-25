namespace TechStore
{
    partial class FrmZaposlenici
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
            this.uiOutputPodaciOZaposlenima = new System.Windows.Forms.Label();
            this.uiOutputPopisZaposlenika = new System.Windows.Forms.DataGridView();
            this.uiActionDodajZaposlenika = new System.Windows.Forms.Button();
            this.uiOutputAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiOutputZanimanje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiOutputTipZaposlenika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiOutputKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uiOutputLozinka = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisZaposlenika)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputPodaciOZaposlenima
            // 
            this.uiOutputPodaciOZaposlenima.AutoSize = true;
            this.uiOutputPodaciOZaposlenima.BackColor = System.Drawing.Color.Transparent;
            this.uiOutputPodaciOZaposlenima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiOutputPodaciOZaposlenima.Location = new System.Drawing.Point(9, 14);
            this.uiOutputPodaciOZaposlenima.Name = "uiOutputPodaciOZaposlenima";
            this.uiOutputPodaciOZaposlenima.Size = new System.Drawing.Size(153, 15);
            this.uiOutputPodaciOZaposlenima.TabIndex = 0;
            this.uiOutputPodaciOZaposlenima.Text = "Podaci o zaposlenima:";
            // 
            // uiOutputPopisZaposlenika
            // 
            this.uiOutputPopisZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPopisZaposlenika.Location = new System.Drawing.Point(12, 32);
            this.uiOutputPopisZaposlenika.Name = "uiOutputPopisZaposlenika";
            this.uiOutputPopisZaposlenika.Size = new System.Drawing.Size(507, 179);
            this.uiOutputPopisZaposlenika.TabIndex = 1;
            // 
            // uiActionDodajZaposlenika
            // 
            this.uiActionDodajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajZaposlenika.Location = new System.Drawing.Point(545, 97);
            this.uiActionDodajZaposlenika.Name = "uiActionDodajZaposlenika";
            this.uiActionDodajZaposlenika.Size = new System.Drawing.Size(73, 48);
            this.uiActionDodajZaposlenika.TabIndex = 2;
            this.uiActionDodajZaposlenika.Text = "DODAJ";
            this.uiActionDodajZaposlenika.UseVisualStyleBackColor = true;
            this.uiActionDodajZaposlenika.Click += new System.EventHandler(this.uiActionDodajZaposlenika_Click);
            // 
            // uiOutputAdresa
            // 
            this.uiOutputAdresa.Location = new System.Drawing.Point(12, 255);
            this.uiOutputAdresa.Name = "uiOutputAdresa";
            this.uiOutputAdresa.Size = new System.Drawing.Size(182, 20);
            this.uiOutputAdresa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Poslovnica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zanimanje:";
            // 
            // uiOutputZanimanje
            // 
            this.uiOutputZanimanje.Location = new System.Drawing.Point(15, 351);
            this.uiOutputZanimanje.Name = "uiOutputZanimanje";
            this.uiOutputZanimanje.Size = new System.Drawing.Size(179, 20);
            this.uiOutputZanimanje.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(340, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tip zaposlenika:";
            // 
            // uiOutputTipZaposlenika
            // 
            this.uiOutputTipZaposlenika.Location = new System.Drawing.Point(340, 255);
            this.uiOutputTipZaposlenika.Name = "uiOutputTipZaposlenika";
            this.uiOutputTipZaposlenika.Size = new System.Drawing.Size(179, 20);
            this.uiOutputTipZaposlenika.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(340, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Korisničko ime:";
            // 
            // uiOutputKorisnickoIme
            // 
            this.uiOutputKorisnickoIme.Location = new System.Drawing.Point(340, 302);
            this.uiOutputKorisnickoIme.Name = "uiOutputKorisnickoIme";
            this.uiOutputKorisnickoIme.Size = new System.Drawing.Size(179, 20);
            this.uiOutputKorisnickoIme.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(340, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lozinka:";
            // 
            // uiOutputLozinka
            // 
            this.uiOutputLozinka.Location = new System.Drawing.Point(340, 351);
            this.uiOutputLozinka.Name = "uiOutputLozinka";
            this.uiOutputLozinka.Size = new System.Drawing.Size(179, 20);
            this.uiOutputLozinka.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 302);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // FrmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 383);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiOutputLozinka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiOutputKorisnickoIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiOutputTipZaposlenika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiOutputZanimanje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputAdresa);
            this.Controls.Add(this.uiActionDodajZaposlenika);
            this.Controls.Add(this.uiOutputPopisZaposlenika);
            this.Controls.Add(this.uiOutputPodaciOZaposlenima);
            this.Name = "FrmZaposlenici";
            this.Text = "Zaposlenici";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisZaposlenika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiOutputPodaciOZaposlenima;
        private System.Windows.Forms.DataGridView uiOutputPopisZaposlenika;
        private System.Windows.Forms.Button uiActionDodajZaposlenika;
        private System.Windows.Forms.TextBox uiOutputAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiOutputZanimanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiOutputTipZaposlenika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiOutputKorisnickoIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uiOutputLozinka;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
﻿namespace TechStore
{
    partial class FrmNoviArtikl
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
            this.uiInputCijena = new System.Windows.Forms.TextBox();
            this.uiInputSpecifikacije = new System.Windows.Forms.TextBox();
            this.uiInputKratkiOpis = new System.Windows.Forms.TextBox();
            this.uiInputNaziv = new System.Windows.Forms.TextBox();
            this.uiInputID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiInputVrstaArtikla = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uiActionDodajArtikl
            // 
            this.uiActionDodajArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajArtikl.Location = new System.Drawing.Point(235, 230);
            this.uiActionDodajArtikl.Name = "uiActionDodajArtikl";
            this.uiActionDodajArtikl.Size = new System.Drawing.Size(137, 41);
            this.uiActionDodajArtikl.TabIndex = 25;
            this.uiActionDodajArtikl.Text = "Dodaj artikl";
            this.uiActionDodajArtikl.UseVisualStyleBackColor = true;
            // 
            // uiInputCijena
            // 
            this.uiInputCijena.Location = new System.Drawing.Point(235, 168);
            this.uiInputCijena.Name = "uiInputCijena";
            this.uiInputCijena.Size = new System.Drawing.Size(137, 20);
            this.uiInputCijena.TabIndex = 23;
            // 
            // uiInputSpecifikacije
            // 
            this.uiInputSpecifikacije.Location = new System.Drawing.Point(235, 140);
            this.uiInputSpecifikacije.Name = "uiInputSpecifikacije";
            this.uiInputSpecifikacije.Size = new System.Drawing.Size(137, 20);
            this.uiInputSpecifikacije.TabIndex = 22;
            // 
            // uiInputKratkiOpis
            // 
            this.uiInputKratkiOpis.Location = new System.Drawing.Point(235, 75);
            this.uiInputKratkiOpis.Multiline = true;
            this.uiInputKratkiOpis.Name = "uiInputKratkiOpis";
            this.uiInputKratkiOpis.Size = new System.Drawing.Size(137, 59);
            this.uiInputKratkiOpis.TabIndex = 21;
            // 
            // uiInputNaziv
            // 
            this.uiInputNaziv.Location = new System.Drawing.Point(235, 49);
            this.uiInputNaziv.Name = "uiInputNaziv";
            this.uiInputNaziv.Size = new System.Drawing.Size(137, 20);
            this.uiInputNaziv.TabIndex = 20;
            // 
            // uiInputID
            // 
            this.uiInputID.Enabled = false;
            this.uiInputID.Location = new System.Drawing.Point(235, 23);
            this.uiInputID.Name = "uiInputID";
            this.uiInputID.Size = new System.Drawing.Size(137, 20);
            this.uiInputID.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(140, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vrsta artikla:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(174, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cijena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(140, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Specifikacije";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(149, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kratki opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(177, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(157, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID artikla:";
            // 
            // uiInputVrstaArtikla
            // 
            this.uiInputVrstaArtikla.FormattingEnabled = true;
            this.uiInputVrstaArtikla.Location = new System.Drawing.Point(235, 194);
            this.uiInputVrstaArtikla.Name = "uiInputVrstaArtikla";
            this.uiInputVrstaArtikla.Size = new System.Drawing.Size(137, 21);
            this.uiInputVrstaArtikla.TabIndex = 26;
            // 
            // FrmNoviArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 277);
            this.Controls.Add(this.uiInputVrstaArtikla);
            this.Controls.Add(this.uiActionDodajArtikl);
            this.Controls.Add(this.uiInputCijena);
            this.Controls.Add(this.uiInputSpecifikacije);
            this.Controls.Add(this.uiInputKratkiOpis);
            this.Controls.Add(this.uiInputNaziv);
            this.Controls.Add(this.uiInputID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNoviArtikl";
            this.Text = "FrmNoviArtikl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionDodajArtikl;
        private System.Windows.Forms.TextBox uiInputCijena;
        private System.Windows.Forms.TextBox uiInputSpecifikacije;
        private System.Windows.Forms.TextBox uiInputKratkiOpis;
        private System.Windows.Forms.TextBox uiInputNaziv;
        private System.Windows.Forms.TextBox uiInputID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiInputVrstaArtikla;
    }
}
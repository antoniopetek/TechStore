﻿namespace TechStore
{
    partial class frmPrijava
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
            this.uiInputKorisnickoIme = new System.Windows.Forms.TextBox();
            this.uiInputLozinka = new System.Windows.Forms.TextBox();
            this.uiLabelKorisnickoIme = new System.Windows.Forms.Label();
            this.uiLabelLozinka = new System.Windows.Forms.Label();
            this.uiActionPrijaviSe = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiInputKorisnickoIme
            // 
            this.uiInputKorisnickoIme.Location = new System.Drawing.Point(113, 91);
            this.uiInputKorisnickoIme.Name = "uiInputKorisnickoIme";
            this.uiInputKorisnickoIme.Size = new System.Drawing.Size(166, 20);
            this.uiInputKorisnickoIme.TabIndex = 0;
            // 
            // uiInputLozinka
            // 
            this.uiInputLozinka.Location = new System.Drawing.Point(113, 143);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.PasswordChar = '*';
            this.uiInputLozinka.Size = new System.Drawing.Size(166, 20);
            this.uiInputLozinka.TabIndex = 1;
            // 
            // uiLabelKorisnickoIme
            // 
            this.uiLabelKorisnickoIme.AutoSize = true;
            this.uiLabelKorisnickoIme.Location = new System.Drawing.Point(110, 75);
            this.uiLabelKorisnickoIme.Name = "uiLabelKorisnickoIme";
            this.uiLabelKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            this.uiLabelKorisnickoIme.TabIndex = 2;
            this.uiLabelKorisnickoIme.Text = "Korisničko ime:";
            // 
            // uiLabelLozinka
            // 
            this.uiLabelLozinka.AutoSize = true;
            this.uiLabelLozinka.Location = new System.Drawing.Point(110, 127);
            this.uiLabelLozinka.Name = "uiLabelLozinka";
            this.uiLabelLozinka.Size = new System.Drawing.Size(47, 13);
            this.uiLabelLozinka.TabIndex = 3;
            this.uiLabelLozinka.Text = "Lozinka:";
            // 
            // uiActionPrijaviSe
            // 
            this.uiActionPrijaviSe.Location = new System.Drawing.Point(113, 202);
            this.uiActionPrijaviSe.Name = "uiActionPrijaviSe";
            this.uiActionPrijaviSe.Size = new System.Drawing.Size(75, 29);
            this.uiActionPrijaviSe.TabIndex = 4;
            this.uiActionPrijaviSe.Text = "PRIJAVI SE";
            this.uiActionPrijaviSe.UseVisualStyleBackColor = true;
            this.uiActionPrijaviSe.Click += new System.EventHandler(this.UiActionPrijaviSe_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(204, 202);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 29);
            this.uiActionOdustani.TabIndex = 5;
            this.uiActionOdustani.Text = "ODUSTANI";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 323);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionPrijaviSe);
            this.Controls.Add(this.uiLabelLozinka);
            this.Controls.Add(this.uiLabelKorisnickoIme);
            this.Controls.Add(this.uiInputLozinka);
            this.Controls.Add(this.uiInputKorisnickoIme);
            this.Name = "frmPrijava";
            this.Text = "PRIJAVA";
            this.Load += new System.EventHandler(this.FrmPrijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiInputKorisnickoIme;
        private System.Windows.Forms.TextBox uiInputLozinka;
        private System.Windows.Forms.Label uiLabelKorisnickoIme;
        private System.Windows.Forms.Label uiLabelLozinka;
        private System.Windows.Forms.Button uiActionPrijaviSe;
        private System.Windows.Forms.Button uiActionOdustani;
    }
}


namespace TechStore
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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lozinka:";
            // 
            // uiActionPrijaviSe
            // 
            this.uiActionPrijaviSe.Location = new System.Drawing.Point(113, 202);
            this.uiActionPrijaviSe.Name = "uiActionPrijaviSe";
            this.uiActionPrijaviSe.Size = new System.Drawing.Size(75, 29);
            this.uiActionPrijaviSe.TabIndex = 4;
            this.uiActionPrijaviSe.Text = "PRIJAVI SE";
            this.uiActionPrijaviSe.UseVisualStyleBackColor = true;
            this.uiActionPrijaviSe.Click += new System.EventHandler(this.uiActionPrijaviSe_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(204, 202);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 29);
            this.uiActionOdustani.TabIndex = 5;
            this.uiActionOdustani.Text = "ODUSTANI";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 323);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionPrijaviSe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiLabelKorisnickoIme);
            this.Controls.Add(this.uiInputLozinka);
            this.Controls.Add(this.uiInputKorisnickoIme);
            this.Name = "frmPrijava";
            this.Text = "PRIJAVA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiInputKorisnickoIme;
        private System.Windows.Forms.TextBox uiInputLozinka;
        private System.Windows.Forms.Label uiLabelKorisnickoIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionPrijaviSe;
        private System.Windows.Forms.Button uiActionOdustani;
    }
}


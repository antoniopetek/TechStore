namespace TechStore
{
    partial class uiPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiPrijava));
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
            this.uiInputKorisnickoIme.Location = new System.Drawing.Point(96, 141);
            this.uiInputKorisnickoIme.Name = "uiInputKorisnickoIme";
            this.uiInputKorisnickoIme.Size = new System.Drawing.Size(191, 20);
            this.uiInputKorisnickoIme.TabIndex = 0;
            // 
            // uiInputLozinka
            // 
            this.uiInputLozinka.Location = new System.Drawing.Point(96, 193);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.PasswordChar = '*';
            this.uiInputLozinka.Size = new System.Drawing.Size(191, 20);
            this.uiInputLozinka.TabIndex = 1;
            // 
            // uiLabelKorisnickoIme
            // 
            this.uiLabelKorisnickoIme.AutoSize = true;
            this.uiLabelKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.uiLabelKorisnickoIme.Location = new System.Drawing.Point(93, 125);
            this.uiLabelKorisnickoIme.Name = "uiLabelKorisnickoIme";
            this.uiLabelKorisnickoIme.Size = new System.Drawing.Size(106, 15);
            this.uiLabelKorisnickoIme.TabIndex = 2;
            this.uiLabelKorisnickoIme.Text = "Korisničko ime:";
            // 
            // uiLabelLozinka
            // 
            this.uiLabelLozinka.AutoSize = true;
            this.uiLabelLozinka.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelLozinka.ForeColor = System.Drawing.Color.White;
            this.uiLabelLozinka.Location = new System.Drawing.Point(93, 177);
            this.uiLabelLozinka.Name = "uiLabelLozinka";
            this.uiLabelLozinka.Size = new System.Drawing.Size(61, 15);
            this.uiLabelLozinka.TabIndex = 3;
            this.uiLabelLozinka.Text = "Lozinka:";
            // 
            // uiActionPrijaviSe
            // 
            this.uiActionPrijaviSe.BackColor = System.Drawing.Color.Maroon;
            this.uiActionPrijaviSe.FlatAppearance.BorderSize = 0;
            this.uiActionPrijaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionPrijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPrijaviSe.ForeColor = System.Drawing.Color.White;
            this.uiActionPrijaviSe.Location = new System.Drawing.Point(96, 233);
            this.uiActionPrijaviSe.Name = "uiActionPrijaviSe";
            this.uiActionPrijaviSe.Size = new System.Drawing.Size(90, 33);
            this.uiActionPrijaviSe.TabIndex = 4;
            this.uiActionPrijaviSe.Text = "PRIJAVI SE";
            this.uiActionPrijaviSe.UseVisualStyleBackColor = false;
            this.uiActionPrijaviSe.Click += new System.EventHandler(this.UiActionPrijaviSe_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.BackColor = System.Drawing.Color.Maroon;
            this.uiActionOdustani.FlatAppearance.BorderSize = 0;
            this.uiActionOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdustani.ForeColor = System.Drawing.Color.White;
            this.uiActionOdustani.Location = new System.Drawing.Point(202, 233);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(85, 33);
            this.uiActionOdustani.TabIndex = 5;
            this.uiActionOdustani.Text = "ODUSTANI";
            this.uiActionOdustani.UseVisualStyleBackColor = false;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // uiPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 288);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionPrijaviSe);
            this.Controls.Add(this.uiLabelLozinka);
            this.Controls.Add(this.uiLabelKorisnickoIme);
            this.Controls.Add(this.uiInputLozinka);
            this.Controls.Add(this.uiInputKorisnickoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uiPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.UiPrijava_Load);
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


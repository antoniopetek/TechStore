namespace TechStore
{
    partial class uiDodavanjeZaposlenika
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
            this.uiInputID = new System.Windows.Forms.TextBox();
            this.uiInputIme = new System.Windows.Forms.TextBox();
            this.uiInputPrezime = new System.Windows.Forms.TextBox();
            this.uiInputEmail = new System.Windows.Forms.TextBox();
            this.uiInputKontakt = new System.Windows.Forms.TextBox();
            this.uiLabelID = new System.Windows.Forms.Label();
            this.uiLabelIme = new System.Windows.Forms.Label();
            this.uiLabelPrezime = new System.Windows.Forms.Label();
            this.uiLabelEmail = new System.Windows.Forms.Label();
            this.uiLabelKontakt = new System.Windows.Forms.Label();
            this.uiLabelPoslovnica = new System.Windows.Forms.Label();
            this.uiLabelTipZaposlenika = new System.Windows.Forms.Label();
            this.uiLabelBroj = new System.Windows.Forms.Label();
            this.uiLabelUlica = new System.Windows.Forms.Label();
            this.uiLabelGrad = new System.Windows.Forms.Label();
            this.uiLabelDrzava = new System.Windows.Forms.Label();
            this.uiInputBroj = new System.Windows.Forms.TextBox();
            this.uiInputUlica = new System.Windows.Forms.TextBox();
            this.uiInputGrad = new System.Windows.Forms.TextBox();
            this.uiInputDrzava = new System.Windows.Forms.TextBox();
            this.uiLabelLozinka = new System.Windows.Forms.Label();
            this.uiLabelKorisnickoIme = new System.Windows.Forms.Label();
            this.uiInputLozinka = new System.Windows.Forms.TextBox();
            this.uiInputKorisnickoIme = new System.Windows.Forms.TextBox();
            this.uiActionDodajZaposlenika = new System.Windows.Forms.Button();
            this.uiInputPoslovnica = new System.Windows.Forms.ComboBox();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputTipZaposlenika = new System.Windows.Forms.ComboBox();
            this.tipZaposlenikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipZaposlenikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiInputID
            // 
            this.uiInputID.Enabled = false;
            this.uiInputID.Location = new System.Drawing.Point(298, 20);
            this.uiInputID.Name = "uiInputID";
            this.uiInputID.Size = new System.Drawing.Size(100, 20);
            this.uiInputID.TabIndex = 0;
            // 
            // uiInputIme
            // 
            this.uiInputIme.Location = new System.Drawing.Point(113, 60);
            this.uiInputIme.Name = "uiInputIme";
            this.uiInputIme.Size = new System.Drawing.Size(129, 20);
            this.uiInputIme.TabIndex = 1;
            // 
            // uiInputPrezime
            // 
            this.uiInputPrezime.Location = new System.Drawing.Point(113, 86);
            this.uiInputPrezime.Name = "uiInputPrezime";
            this.uiInputPrezime.Size = new System.Drawing.Size(129, 20);
            this.uiInputPrezime.TabIndex = 2;
            // 
            // uiInputEmail
            // 
            this.uiInputEmail.Location = new System.Drawing.Point(113, 112);
            this.uiInputEmail.Name = "uiInputEmail";
            this.uiInputEmail.Size = new System.Drawing.Size(129, 20);
            this.uiInputEmail.TabIndex = 3;
            // 
            // uiInputKontakt
            // 
            this.uiInputKontakt.Location = new System.Drawing.Point(113, 138);
            this.uiInputKontakt.Name = "uiInputKontakt";
            this.uiInputKontakt.Size = new System.Drawing.Size(129, 20);
            this.uiInputKontakt.TabIndex = 4;
            // 
            // uiLabelID
            // 
            this.uiLabelID.AutoSize = true;
            this.uiLabelID.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelID.Location = new System.Drawing.Point(197, 23);
            this.uiLabelID.Name = "uiLabelID";
            this.uiLabelID.Size = new System.Drawing.Size(95, 13);
            this.uiLabelID.TabIndex = 7;
            this.uiLabelID.Text = "ID zaposlenika:";
            // 
            // uiLabelIme
            // 
            this.uiLabelIme.AutoSize = true;
            this.uiLabelIme.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelIme.Location = new System.Drawing.Point(76, 63);
            this.uiLabelIme.Name = "uiLabelIme";
            this.uiLabelIme.Size = new System.Drawing.Size(31, 13);
            this.uiLabelIme.TabIndex = 8;
            this.uiLabelIme.Text = "Ime:";
            // 
            // uiLabelPrezime
            // 
            this.uiLabelPrezime.AutoSize = true;
            this.uiLabelPrezime.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelPrezime.Location = new System.Drawing.Point(52, 89);
            this.uiLabelPrezime.Name = "uiLabelPrezime";
            this.uiLabelPrezime.Size = new System.Drawing.Size(55, 13);
            this.uiLabelPrezime.TabIndex = 9;
            this.uiLabelPrezime.Text = "Prezime:";
            // 
            // uiLabelEmail
            // 
            this.uiLabelEmail.AutoSize = true;
            this.uiLabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelEmail.Location = new System.Drawing.Point(62, 115);
            this.uiLabelEmail.Name = "uiLabelEmail";
            this.uiLabelEmail.Size = new System.Drawing.Size(45, 13);
            this.uiLabelEmail.TabIndex = 10;
            this.uiLabelEmail.Text = "E-mail:";
            // 
            // uiLabelKontakt
            // 
            this.uiLabelKontakt.AutoSize = true;
            this.uiLabelKontakt.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelKontakt.Location = new System.Drawing.Point(52, 141);
            this.uiLabelKontakt.Name = "uiLabelKontakt";
            this.uiLabelKontakt.Size = new System.Drawing.Size(55, 13);
            this.uiLabelKontakt.TabIndex = 11;
            this.uiLabelKontakt.Text = "Kontakt:";
            // 
            // uiLabelPoslovnica
            // 
            this.uiLabelPoslovnica.AutoSize = true;
            this.uiLabelPoslovnica.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelPoslovnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelPoslovnica.Location = new System.Drawing.Point(34, 167);
            this.uiLabelPoslovnica.Name = "uiLabelPoslovnica";
            this.uiLabelPoslovnica.Size = new System.Drawing.Size(73, 13);
            this.uiLabelPoslovnica.TabIndex = 12;
            this.uiLabelPoslovnica.Text = "Poslovnica:";
            // 
            // uiLabelTipZaposlenika
            // 
            this.uiLabelTipZaposlenika.AutoSize = true;
            this.uiLabelTipZaposlenika.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelTipZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelTipZaposlenika.Location = new System.Drawing.Point(7, 193);
            this.uiLabelTipZaposlenika.Name = "uiLabelTipZaposlenika";
            this.uiLabelTipZaposlenika.Size = new System.Drawing.Size(100, 13);
            this.uiLabelTipZaposlenika.TabIndex = 13;
            this.uiLabelTipZaposlenika.Text = "Tip zaposlenika:";
            // 
            // uiLabelBroj
            // 
            this.uiLabelBroj.AutoSize = true;
            this.uiLabelBroj.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelBroj.Location = new System.Drawing.Point(342, 141);
            this.uiLabelBroj.Name = "uiLabelBroj";
            this.uiLabelBroj.Size = new System.Drawing.Size(33, 13);
            this.uiLabelBroj.TabIndex = 21;
            this.uiLabelBroj.Text = "Broj:";
            // 
            // uiLabelUlica
            // 
            this.uiLabelUlica.AutoSize = true;
            this.uiLabelUlica.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelUlica.Location = new System.Drawing.Point(335, 115);
            this.uiLabelUlica.Name = "uiLabelUlica";
            this.uiLabelUlica.Size = new System.Drawing.Size(40, 13);
            this.uiLabelUlica.TabIndex = 20;
            this.uiLabelUlica.Text = "Ulica:";
            // 
            // uiLabelGrad
            // 
            this.uiLabelGrad.AutoSize = true;
            this.uiLabelGrad.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelGrad.Location = new System.Drawing.Point(337, 89);
            this.uiLabelGrad.Name = "uiLabelGrad";
            this.uiLabelGrad.Size = new System.Drawing.Size(38, 13);
            this.uiLabelGrad.TabIndex = 19;
            this.uiLabelGrad.Text = "Grad:";
            // 
            // uiLabelDrzava
            // 
            this.uiLabelDrzava.AutoSize = true;
            this.uiLabelDrzava.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelDrzava.Location = new System.Drawing.Point(324, 63);
            this.uiLabelDrzava.Name = "uiLabelDrzava";
            this.uiLabelDrzava.Size = new System.Drawing.Size(51, 13);
            this.uiLabelDrzava.TabIndex = 18;
            this.uiLabelDrzava.Text = "Država:";
            // 
            // uiInputBroj
            // 
            this.uiInputBroj.Location = new System.Drawing.Point(381, 138);
            this.uiInputBroj.Name = "uiInputBroj";
            this.uiInputBroj.Size = new System.Drawing.Size(129, 20);
            this.uiInputBroj.TabIndex = 17;
            // 
            // uiInputUlica
            // 
            this.uiInputUlica.Location = new System.Drawing.Point(381, 112);
            this.uiInputUlica.Name = "uiInputUlica";
            this.uiInputUlica.Size = new System.Drawing.Size(129, 20);
            this.uiInputUlica.TabIndex = 16;
            // 
            // uiInputGrad
            // 
            this.uiInputGrad.Location = new System.Drawing.Point(381, 86);
            this.uiInputGrad.Name = "uiInputGrad";
            this.uiInputGrad.Size = new System.Drawing.Size(129, 20);
            this.uiInputGrad.TabIndex = 15;
            // 
            // uiInputDrzava
            // 
            this.uiInputDrzava.Location = new System.Drawing.Point(381, 60);
            this.uiInputDrzava.Name = "uiInputDrzava";
            this.uiInputDrzava.Size = new System.Drawing.Size(129, 20);
            this.uiInputDrzava.TabIndex = 14;
            // 
            // uiLabelLozinka
            // 
            this.uiLabelLozinka.AutoSize = true;
            this.uiLabelLozinka.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelLozinka.Location = new System.Drawing.Point(320, 193);
            this.uiLabelLozinka.Name = "uiLabelLozinka";
            this.uiLabelLozinka.Size = new System.Drawing.Size(55, 13);
            this.uiLabelLozinka.TabIndex = 25;
            this.uiLabelLozinka.Text = "Lozinka:";
            // 
            // uiLabelKorisnickoIme
            // 
            this.uiLabelKorisnickoIme.AutoSize = true;
            this.uiLabelKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelKorisnickoIme.Location = new System.Drawing.Point(282, 167);
            this.uiLabelKorisnickoIme.Name = "uiLabelKorisnickoIme";
            this.uiLabelKorisnickoIme.Size = new System.Drawing.Size(93, 13);
            this.uiLabelKorisnickoIme.TabIndex = 24;
            this.uiLabelKorisnickoIme.Text = "Korisničko ime:";
            // 
            // uiInputLozinka
            // 
            this.uiInputLozinka.Location = new System.Drawing.Point(381, 190);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.Size = new System.Drawing.Size(129, 20);
            this.uiInputLozinka.TabIndex = 23;
            // 
            // uiInputKorisnickoIme
            // 
            this.uiInputKorisnickoIme.Location = new System.Drawing.Point(381, 164);
            this.uiInputKorisnickoIme.Name = "uiInputKorisnickoIme";
            this.uiInputKorisnickoIme.Size = new System.Drawing.Size(129, 20);
            this.uiInputKorisnickoIme.TabIndex = 22;
            // 
            // uiActionDodajZaposlenika
            // 
            this.uiActionDodajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajZaposlenika.Location = new System.Drawing.Point(113, 234);
            this.uiActionDodajZaposlenika.Name = "uiActionDodajZaposlenika";
            this.uiActionDodajZaposlenika.Size = new System.Drawing.Size(198, 37);
            this.uiActionDodajZaposlenika.TabIndex = 26;
            this.uiActionDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.uiActionDodajZaposlenika.UseVisualStyleBackColor = true;
            this.uiActionDodajZaposlenika.Click += new System.EventHandler(this.UiActionDodajZaposlenika_Click);
            // 
            // uiInputPoslovnica
            // 
            this.uiInputPoslovnica.DataSource = this.poslovnicaBindingSource;
            this.uiInputPoslovnica.DisplayMember = "Naziv";
            this.uiInputPoslovnica.FormattingEnabled = true;
            this.uiInputPoslovnica.Location = new System.Drawing.Point(113, 164);
            this.uiInputPoslovnica.Name = "uiInputPoslovnica";
            this.uiInputPoslovnica.Size = new System.Drawing.Size(129, 21);
            this.uiInputPoslovnica.TabIndex = 27;
            this.uiInputPoslovnica.ValueMember = "ID";
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataSource = typeof(TechStore.Poslovnica);
            // 
            // uiInputTipZaposlenika
            // 
            this.uiInputTipZaposlenika.DataSource = this.tipZaposlenikaBindingSource;
            this.uiInputTipZaposlenika.DisplayMember = "Naziv";
            this.uiInputTipZaposlenika.FormattingEnabled = true;
            this.uiInputTipZaposlenika.Location = new System.Drawing.Point(113, 190);
            this.uiInputTipZaposlenika.Name = "uiInputTipZaposlenika";
            this.uiInputTipZaposlenika.Size = new System.Drawing.Size(129, 21);
            this.uiInputTipZaposlenika.TabIndex = 28;
            this.uiInputTipZaposlenika.ValueMember = "ID";
            // 
            // tipZaposlenikaBindingSource
            // 
            this.tipZaposlenikaBindingSource.DataSource = typeof(TechStore.TipZaposlenika);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdustani.Location = new System.Drawing.Point(418, 233);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(92, 38);
            this.uiActionOdustani.TabIndex = 29;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // uiDodavanjeZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 284);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiInputTipZaposlenika);
            this.Controls.Add(this.uiInputPoslovnica);
            this.Controls.Add(this.uiActionDodajZaposlenika);
            this.Controls.Add(this.uiLabelLozinka);
            this.Controls.Add(this.uiLabelKorisnickoIme);
            this.Controls.Add(this.uiInputLozinka);
            this.Controls.Add(this.uiInputKorisnickoIme);
            this.Controls.Add(this.uiLabelBroj);
            this.Controls.Add(this.uiLabelUlica);
            this.Controls.Add(this.uiLabelGrad);
            this.Controls.Add(this.uiLabelDrzava);
            this.Controls.Add(this.uiInputBroj);
            this.Controls.Add(this.uiInputUlica);
            this.Controls.Add(this.uiInputGrad);
            this.Controls.Add(this.uiInputDrzava);
            this.Controls.Add(this.uiLabelTipZaposlenika);
            this.Controls.Add(this.uiLabelPoslovnica);
            this.Controls.Add(this.uiLabelKontakt);
            this.Controls.Add(this.uiLabelEmail);
            this.Controls.Add(this.uiLabelPrezime);
            this.Controls.Add(this.uiLabelIme);
            this.Controls.Add(this.uiLabelID);
            this.Controls.Add(this.uiInputKontakt);
            this.Controls.Add(this.uiInputEmail);
            this.Controls.Add(this.uiInputPrezime);
            this.Controls.Add(this.uiInputIme);
            this.Controls.Add(this.uiInputID);
            this.Name = "uiDodavanjeZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje zaposlenika";
            this.Load += new System.EventHandler(this.UiDodavanjeZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipZaposlenikaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiInputID;
        private System.Windows.Forms.TextBox uiInputIme;
        private System.Windows.Forms.TextBox uiInputPrezime;
        private System.Windows.Forms.TextBox uiInputEmail;
        private System.Windows.Forms.TextBox uiInputKontakt;
        private System.Windows.Forms.Label uiLabelID;
        private System.Windows.Forms.Label uiLabelIme;
        private System.Windows.Forms.Label uiLabelPrezime;
        private System.Windows.Forms.Label uiLabelEmail;
        private System.Windows.Forms.Label uiLabelKontakt;
        private System.Windows.Forms.Label uiLabelPoslovnica;
        private System.Windows.Forms.Label uiLabelTipZaposlenika;
        private System.Windows.Forms.Label uiLabelBroj;
        private System.Windows.Forms.Label uiLabelUlica;
        private System.Windows.Forms.Label uiLabelGrad;
        private System.Windows.Forms.Label uiLabelDrzava;
        private System.Windows.Forms.TextBox uiInputBroj;
        private System.Windows.Forms.TextBox uiInputUlica;
        private System.Windows.Forms.TextBox uiInputGrad;
        private System.Windows.Forms.TextBox uiInputDrzava;
        private System.Windows.Forms.Label uiLabelLozinka;
        private System.Windows.Forms.Label uiLabelKorisnickoIme;
        private System.Windows.Forms.TextBox uiInputLozinka;
        private System.Windows.Forms.TextBox uiInputKorisnickoIme;
        private System.Windows.Forms.Button uiActionDodajZaposlenika;
        private System.Windows.Forms.ComboBox uiInputPoslovnica;
        private System.Windows.Forms.ComboBox uiInputTipZaposlenika;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private System.Windows.Forms.BindingSource tipZaposlenikaBindingSource;
        private System.Windows.Forms.Button uiActionOdustani;
    }
}
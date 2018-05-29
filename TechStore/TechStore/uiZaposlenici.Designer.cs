namespace TechStore
{
    partial class uiZaposlenici
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
            this.uiOutputPodaciOZaposlenima = new System.Windows.Forms.Label();
            this.uiOutputPopisZaposlenika = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipZaposlenikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnicaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipZaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionDodajZaposlenika = new System.Windows.Forms.Button();
            this.uiOutputAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiOutputEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiOutputKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uiOutputLozinka = new System.Windows.Forms.TextBox();
            this.uiOutputKontakt = new System.Windows.Forms.TextBox();
            this.uiActionNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisZaposlenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipZaposlenikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
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
            this.uiOutputPopisZaposlenika.AllowUserToAddRows = false;
            this.uiOutputPopisZaposlenika.AutoGenerateColumns = false;
            this.uiOutputPopisZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPopisZaposlenika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.brojDataGridViewTextBoxColumn,
            this.tipIDDataGridViewTextBoxColumn,
            this.poslovnicaIDDataGridViewTextBoxColumn,
            this.poslovnicaDataGridViewTextBoxColumn,
            this.stanjeDokumentaDataGridViewTextBoxColumn,
            this.tipZaposlenikaDataGridViewTextBoxColumn});
            this.uiOutputPopisZaposlenika.DataSource = this.zaposlenikBindingSource;
            this.uiOutputPopisZaposlenika.Location = new System.Drawing.Point(12, 32);
            this.uiOutputPopisZaposlenika.MultiSelect = false;
            this.uiOutputPopisZaposlenika.Name = "uiOutputPopisZaposlenika";
            this.uiOutputPopisZaposlenika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputPopisZaposlenika.Size = new System.Drawing.Size(565, 179);
            this.uiOutputPopisZaposlenika.TabIndex = 1;
            this.uiOutputPopisZaposlenika.SelectionChanged += new System.EventHandler(this.uiOutputPopisZaposlenika_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 104;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 105;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.Width = 104;
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "Korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            this.korisnickoimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnickoimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lozinkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            this.kontaktDataGridViewTextBoxColumn.ReadOnly = true;
            this.kontaktDataGridViewTextBoxColumn.Visible = false;
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            this.drzavaDataGridViewTextBoxColumn.ReadOnly = true;
            this.drzavaDataGridViewTextBoxColumn.Visible = false;
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "Grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradDataGridViewTextBoxColumn.Visible = false;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ulicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // brojDataGridViewTextBoxColumn
            // 
            this.brojDataGridViewTextBoxColumn.DataPropertyName = "Broj";
            this.brojDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.brojDataGridViewTextBoxColumn.Name = "brojDataGridViewTextBoxColumn";
            this.brojDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipIDDataGridViewTextBoxColumn
            // 
            this.tipIDDataGridViewTextBoxColumn.DataPropertyName = "Tip_ID";
            this.tipIDDataGridViewTextBoxColumn.DataSource = this.tipZaposlenikaBindingSource;
            this.tipIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.tipIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tipIDDataGridViewTextBoxColumn.HeaderText = "Tip zaposlenika";
            this.tipIDDataGridViewTextBoxColumn.Name = "tipIDDataGridViewTextBoxColumn";
            this.tipIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.tipIDDataGridViewTextBoxColumn.Width = 105;
            // 
            // tipZaposlenikaBindingSource
            // 
            this.tipZaposlenikaBindingSource.DataSource = typeof(TechStore.TipZaposlenika);
            // 
            // poslovnicaIDDataGridViewTextBoxColumn
            // 
            this.poslovnicaIDDataGridViewTextBoxColumn.DataPropertyName = "Poslovnica_ID";
            this.poslovnicaIDDataGridViewTextBoxColumn.DataSource = this.poslovnicaBindingSource;
            this.poslovnicaIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.poslovnicaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.poslovnicaIDDataGridViewTextBoxColumn.HeaderText = "Poslovnica";
            this.poslovnicaIDDataGridViewTextBoxColumn.Name = "poslovnicaIDDataGridViewTextBoxColumn";
            this.poslovnicaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.poslovnicaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.poslovnicaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.poslovnicaIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.poslovnicaIDDataGridViewTextBoxColumn.Width = 104;
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataSource = typeof(TechStore.Poslovnica);
            // 
            // poslovnicaDataGridViewTextBoxColumn
            // 
            this.poslovnicaDataGridViewTextBoxColumn.DataPropertyName = "Poslovnica";
            this.poslovnicaDataGridViewTextBoxColumn.HeaderText = "Poslovnica";
            this.poslovnicaDataGridViewTextBoxColumn.Name = "poslovnicaDataGridViewTextBoxColumn";
            this.poslovnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.poslovnicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stanjeDokumentaDataGridViewTextBoxColumn
            // 
            this.stanjeDokumentaDataGridViewTextBoxColumn.DataPropertyName = "StanjeDokumenta";
            this.stanjeDokumentaDataGridViewTextBoxColumn.HeaderText = "StanjeDokumenta";
            this.stanjeDokumentaDataGridViewTextBoxColumn.Name = "stanjeDokumentaDataGridViewTextBoxColumn";
            this.stanjeDokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanjeDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipZaposlenikaDataGridViewTextBoxColumn
            // 
            this.tipZaposlenikaDataGridViewTextBoxColumn.DataPropertyName = "TipZaposlenika";
            this.tipZaposlenikaDataGridViewTextBoxColumn.HeaderText = "TipZaposlenika";
            this.tipZaposlenikaDataGridViewTextBoxColumn.Name = "tipZaposlenikaDataGridViewTextBoxColumn";
            this.tipZaposlenikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipZaposlenikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(TechStore.Zaposlenik);
            // 
            // uiActionDodajZaposlenika
            // 
            this.uiActionDodajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajZaposlenika.Location = new System.Drawing.Point(599, 96);
            this.uiActionDodajZaposlenika.Name = "uiActionDodajZaposlenika";
            this.uiActionDodajZaposlenika.Size = new System.Drawing.Size(84, 48);
            this.uiActionDodajZaposlenika.TabIndex = 2;
            this.uiActionDodajZaposlenika.Text = "DODAJ";
            this.uiActionDodajZaposlenika.UseVisualStyleBackColor = true;
            this.uiActionDodajZaposlenika.Click += new System.EventHandler(this.uiActionDodajZaposlenika_Click);
            // 
            // uiOutputAdresa
            // 
            this.uiOutputAdresa.Location = new System.Drawing.Point(15, 255);
            this.uiOutputAdresa.Name = "uiOutputAdresa";
            this.uiOutputAdresa.Size = new System.Drawing.Size(251, 20);
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
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kontakt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // uiOutputEmail
            // 
            this.uiOutputEmail.Location = new System.Drawing.Point(15, 351);
            this.uiOutputEmail.Name = "uiOutputEmail";
            this.uiOutputEmail.Size = new System.Drawing.Size(179, 20);
            this.uiOutputEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(398, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Korisničko ime:";
            // 
            // uiOutputKorisnickoIme
            // 
            this.uiOutputKorisnickoIme.Location = new System.Drawing.Point(398, 255);
            this.uiOutputKorisnickoIme.Name = "uiOutputKorisnickoIme";
            this.uiOutputKorisnickoIme.Size = new System.Drawing.Size(179, 20);
            this.uiOutputKorisnickoIme.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(398, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lozinka:";
            // 
            // uiOutputLozinka
            // 
            this.uiOutputLozinka.Location = new System.Drawing.Point(398, 302);
            this.uiOutputLozinka.Name = "uiOutputLozinka";
            this.uiOutputLozinka.Size = new System.Drawing.Size(179, 20);
            this.uiOutputLozinka.TabIndex = 13;
            // 
            // uiOutputKontakt
            // 
            this.uiOutputKontakt.Location = new System.Drawing.Point(15, 302);
            this.uiOutputKontakt.Name = "uiOutputKontakt";
            this.uiOutputKontakt.Size = new System.Drawing.Size(179, 20);
            this.uiOutputKontakt.TabIndex = 15;
            // 
            // uiActionNatrag
            // 
            this.uiActionNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNatrag.Location = new System.Drawing.Point(599, 32);
            this.uiActionNatrag.Name = "uiActionNatrag";
            this.uiActionNatrag.Size = new System.Drawing.Size(84, 28);
            this.uiActionNatrag.TabIndex = 16;
            this.uiActionNatrag.Text = "NATRAG";
            this.uiActionNatrag.UseVisualStyleBackColor = true;
            this.uiActionNatrag.Click += new System.EventHandler(this.uiActionNatrag_Click);
            // 
            // uiZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 383);
            this.Controls.Add(this.uiActionNatrag);
            this.Controls.Add(this.uiOutputKontakt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiOutputLozinka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiOutputKorisnickoIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiOutputEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputAdresa);
            this.Controls.Add(this.uiActionDodajZaposlenika);
            this.Controls.Add(this.uiOutputPopisZaposlenika);
            this.Controls.Add(this.uiOutputPodaciOZaposlenima);
            this.Name = "uiZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.FrmZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisZaposlenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipZaposlenikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiOutputEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiOutputKorisnickoIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uiOutputLozinka;
        private System.Windows.Forms.TextBox uiOutputKontakt;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource tipZaposlenikaBindingSource;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn poslovnicaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poslovnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipZaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uiActionNatrag;
    }
}
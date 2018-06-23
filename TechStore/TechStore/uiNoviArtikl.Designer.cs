namespace TechStore
{
    partial class uiNoviArtikl
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
            this.uiActionDodajArtikl = new System.Windows.Forms.Button();
            this.uiInputCijena = new System.Windows.Forms.TextBox();
            this.uiInputSpecifikacije = new System.Windows.Forms.TextBox();
            this.uiInputKratkiOpis = new System.Windows.Forms.TextBox();
            this.uiInputNaziv = new System.Windows.Forms.TextBox();
            this.uiInputID = new System.Windows.Forms.TextBox();
            this.uiLabelVrstaArtikla = new System.Windows.Forms.Label();
            this.uiLabelCijena = new System.Windows.Forms.Label();
            this.uiLabelSpecifikacija = new System.Windows.Forms.Label();
            this.uiLabelKratkiOpis = new System.Windows.Forms.Label();
            this.uiLabelNaziv = new System.Windows.Forms.Label();
            this.uiLabelId = new System.Windows.Forms.Label();
            this.uiInputVrstaArtikla = new System.Windows.Forms.ComboBox();
            this.vrstaArtiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionDodajArtikl
            // 
            this.uiActionDodajArtikl.BackColor = System.Drawing.Color.Maroon;
            this.uiActionDodajArtikl.FlatAppearance.BorderSize = 0;
            this.uiActionDodajArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionDodajArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajArtikl.ForeColor = System.Drawing.Color.White;
            this.uiActionDodajArtikl.Location = new System.Drawing.Point(79, 372);
            this.uiActionDodajArtikl.Name = "uiActionDodajArtikl";
            this.uiActionDodajArtikl.Size = new System.Drawing.Size(137, 39);
            this.uiActionDodajArtikl.TabIndex = 25;
            this.uiActionDodajArtikl.Text = "Dodaj artikl";
            this.uiActionDodajArtikl.UseVisualStyleBackColor = false;
            this.uiActionDodajArtikl.Click += new System.EventHandler(this.UiActionDodajArtikl_Click);
            // 
            // uiInputCijena
            // 
            this.uiInputCijena.Location = new System.Drawing.Point(117, 319);
            this.uiInputCijena.Name = "uiInputCijena";
            this.uiInputCijena.Size = new System.Drawing.Size(215, 20);
            this.uiInputCijena.TabIndex = 23;
            // 
            // uiInputSpecifikacije
            // 
            this.uiInputSpecifikacije.Location = new System.Drawing.Point(117, 187);
            this.uiInputSpecifikacije.Multiline = true;
            this.uiInputSpecifikacije.Name = "uiInputSpecifikacije";
            this.uiInputSpecifikacije.Size = new System.Drawing.Size(215, 126);
            this.uiInputSpecifikacije.TabIndex = 22;
            // 
            // uiInputKratkiOpis
            // 
            this.uiInputKratkiOpis.Location = new System.Drawing.Point(117, 63);
            this.uiInputKratkiOpis.Multiline = true;
            this.uiInputKratkiOpis.Name = "uiInputKratkiOpis";
            this.uiInputKratkiOpis.Size = new System.Drawing.Size(215, 118);
            this.uiInputKratkiOpis.TabIndex = 21;
            // 
            // uiInputNaziv
            // 
            this.uiInputNaziv.Location = new System.Drawing.Point(117, 37);
            this.uiInputNaziv.Name = "uiInputNaziv";
            this.uiInputNaziv.Size = new System.Drawing.Size(215, 20);
            this.uiInputNaziv.TabIndex = 20;
            // 
            // uiInputID
            // 
            this.uiInputID.Enabled = false;
            this.uiInputID.Location = new System.Drawing.Point(117, 11);
            this.uiInputID.Name = "uiInputID";
            this.uiInputID.Size = new System.Drawing.Size(215, 20);
            this.uiInputID.TabIndex = 19;
            // 
            // uiLabelVrstaArtikla
            // 
            this.uiLabelVrstaArtikla.AutoSize = true;
            this.uiLabelVrstaArtikla.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelVrstaArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelVrstaArtikla.ForeColor = System.Drawing.Color.White;
            this.uiLabelVrstaArtikla.Location = new System.Drawing.Point(22, 348);
            this.uiLabelVrstaArtikla.Name = "uiLabelVrstaArtikla";
            this.uiLabelVrstaArtikla.Size = new System.Drawing.Size(87, 15);
            this.uiLabelVrstaArtikla.TabIndex = 18;
            this.uiLabelVrstaArtikla.Text = "Vrsta artikla:";
            // 
            // uiLabelCijena
            // 
            this.uiLabelCijena.AutoSize = true;
            this.uiLabelCijena.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelCijena.ForeColor = System.Drawing.Color.White;
            this.uiLabelCijena.Location = new System.Drawing.Point(56, 322);
            this.uiLabelCijena.Name = "uiLabelCijena";
            this.uiLabelCijena.Size = new System.Drawing.Size(52, 15);
            this.uiLabelCijena.TabIndex = 17;
            this.uiLabelCijena.Text = "Cijena:";
            // 
            // uiLabelSpecifikacija
            // 
            this.uiLabelSpecifikacija.AutoSize = true;
            this.uiLabelSpecifikacija.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelSpecifikacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelSpecifikacija.ForeColor = System.Drawing.Color.White;
            this.uiLabelSpecifikacija.Location = new System.Drawing.Point(15, 188);
            this.uiLabelSpecifikacija.Name = "uiLabelSpecifikacija";
            this.uiLabelSpecifikacija.Size = new System.Drawing.Size(93, 15);
            this.uiLabelSpecifikacija.TabIndex = 16;
            this.uiLabelSpecifikacija.Text = "Specifikacije:";
            // 
            // uiLabelKratkiOpis
            // 
            this.uiLabelKratkiOpis.AutoSize = true;
            this.uiLabelKratkiOpis.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelKratkiOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelKratkiOpis.ForeColor = System.Drawing.Color.White;
            this.uiLabelKratkiOpis.Location = new System.Drawing.Point(31, 66);
            this.uiLabelKratkiOpis.Name = "uiLabelKratkiOpis";
            this.uiLabelKratkiOpis.Size = new System.Drawing.Size(79, 15);
            this.uiLabelKratkiOpis.TabIndex = 15;
            this.uiLabelKratkiOpis.Text = "Kratki opis:";
            // 
            // uiLabelNaziv
            // 
            this.uiLabelNaziv.AutoSize = true;
            this.uiLabelNaziv.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelNaziv.ForeColor = System.Drawing.Color.White;
            this.uiLabelNaziv.Location = new System.Drawing.Point(63, 38);
            this.uiLabelNaziv.Name = "uiLabelNaziv";
            this.uiLabelNaziv.Size = new System.Drawing.Size(46, 15);
            this.uiLabelNaziv.TabIndex = 14;
            this.uiLabelNaziv.Text = "Naziv:";
            // 
            // uiLabelId
            // 
            this.uiLabelId.AutoSize = true;
            this.uiLabelId.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelId.ForeColor = System.Drawing.Color.White;
            this.uiLabelId.Location = new System.Drawing.Point(39, 12);
            this.uiLabelId.Name = "uiLabelId";
            this.uiLabelId.Size = new System.Drawing.Size(69, 15);
            this.uiLabelId.TabIndex = 13;
            this.uiLabelId.Text = "ID artikla:";
            // 
            // uiInputVrstaArtikla
            // 
            this.uiInputVrstaArtikla.DataSource = this.vrstaArtiklaBindingSource;
            this.uiInputVrstaArtikla.DisplayMember = "Naziv";
            this.uiInputVrstaArtikla.FormattingEnabled = true;
            this.uiInputVrstaArtikla.Location = new System.Drawing.Point(117, 345);
            this.uiInputVrstaArtikla.Name = "uiInputVrstaArtikla";
            this.uiInputVrstaArtikla.Size = new System.Drawing.Size(215, 21);
            this.uiInputVrstaArtikla.TabIndex = 26;
            this.uiInputVrstaArtikla.ValueMember = "ID";
            // 
            // vrstaArtiklaBindingSource
            // 
            this.vrstaArtiklaBindingSource.DataSource = typeof(TechStore.VrstaArtikla);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.BackColor = System.Drawing.Color.Maroon;
            this.uiActionOdustani.FlatAppearance.BorderSize = 0;
            this.uiActionOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdustani.ForeColor = System.Drawing.Color.White;
            this.uiActionOdustani.Location = new System.Drawing.Point(231, 372);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(137, 39);
            this.uiActionOdustani.TabIndex = 27;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = false;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // uiNoviArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina_nova;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 423);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiInputVrstaArtikla);
            this.Controls.Add(this.uiActionDodajArtikl);
            this.Controls.Add(this.uiInputCijena);
            this.Controls.Add(this.uiInputSpecifikacije);
            this.Controls.Add(this.uiInputKratkiOpis);
            this.Controls.Add(this.uiInputNaziv);
            this.Controls.Add(this.uiInputID);
            this.Controls.Add(this.uiLabelVrstaArtikla);
            this.Controls.Add(this.uiLabelCijena);
            this.Controls.Add(this.uiLabelSpecifikacija);
            this.Controls.Add(this.uiLabelKratkiOpis);
            this.Controls.Add(this.uiLabelNaziv);
            this.Controls.Add(this.uiLabelId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uiNoviArtikl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos artikla";
            this.Load += new System.EventHandler(this.FrmNoviArtikl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).EndInit();
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
        private System.Windows.Forms.Label uiLabelVrstaArtikla;
        private System.Windows.Forms.Label uiLabelCijena;
        private System.Windows.Forms.Label uiLabelSpecifikacija;
        private System.Windows.Forms.Label uiLabelKratkiOpis;
        private System.Windows.Forms.Label uiLabelNaziv;
        private System.Windows.Forms.Label uiLabelId;
        private System.Windows.Forms.ComboBox uiInputVrstaArtikla;
        private System.Windows.Forms.BindingSource vrstaArtiklaBindingSource;
        private System.Windows.Forms.Button uiActionOdustani;
    }
}
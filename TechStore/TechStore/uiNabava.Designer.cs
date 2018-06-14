namespace TechStore
{
    partial class UiNabava
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
            this.uiInputPoslovnica = new System.Windows.Forms.ComboBox();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputArtikl = new System.Windows.Forms.ComboBox();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputKolicina = new System.Windows.Forms.TextBox();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiOutputPopisArtikala = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kratkiopisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specifikacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaArtiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kompatibilnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kompatibilnost1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisArtikala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiInputPoslovnica
            // 
            this.uiInputPoslovnica.DataSource = this.poslovnicaBindingSource;
            this.uiInputPoslovnica.DisplayMember = "Naziv";
            this.uiInputPoslovnica.FormattingEnabled = true;
            this.uiInputPoslovnica.Location = new System.Drawing.Point(12, 25);
            this.uiInputPoslovnica.Name = "uiInputPoslovnica";
            this.uiInputPoslovnica.Size = new System.Drawing.Size(121, 21);
            this.uiInputPoslovnica.TabIndex = 0;
            this.uiInputPoslovnica.ValueMember = "ID";
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataSource = typeof(TechStore.Poslovnica);
            // 
            // uiInputArtikl
            // 
            this.uiInputArtikl.DataSource = this.artiklBindingSource;
            this.uiInputArtikl.DisplayMember = "Naziv";
            this.uiInputArtikl.FormattingEnabled = true;
            this.uiInputArtikl.Location = new System.Drawing.Point(12, 52);
            this.uiInputArtikl.Name = "uiInputArtikl";
            this.uiInputArtikl.Size = new System.Drawing.Size(121, 21);
            this.uiInputArtikl.TabIndex = 1;
            this.uiInputArtikl.ValueMember = "ID";
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(TechStore.Artikl);
            // 
            // uiInputKolicina
            // 
            this.uiInputKolicina.Location = new System.Drawing.Point(12, 79);
            this.uiInputKolicina.Name = "uiInputKolicina";
            this.uiInputKolicina.Size = new System.Drawing.Size(121, 20);
            this.uiInputKolicina.TabIndex = 2;
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Location = new System.Drawing.Point(488, 285);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(75, 23);
            this.uiActionSpremi.TabIndex = 3;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.UiActionSpremi_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(569, 285);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdustani.TabIndex = 4;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(155, 50);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(75, 23);
            this.uiActionDodaj.TabIndex = 6;
            this.uiActionDodaj.Text = ">";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.UiActionDodaj_Click);
            // 
            // uiOutputPopisArtikala
            // 
            this.uiOutputPopisArtikala.AllowUserToAddRows = false;
            this.uiOutputPopisArtikala.AllowUserToDeleteRows = false;
            this.uiOutputPopisArtikala.AutoGenerateColumns = false;
            this.uiOutputPopisArtikala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiOutputPopisArtikala.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uiOutputPopisArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPopisArtikala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kratkiopisDataGridViewTextBoxColumn,
            this.specifikacijaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.vrstaIDDataGridViewTextBoxColumn,
            this.vrstaArtiklaDataGridViewTextBoxColumn,
            this.dostupnostDataGridViewTextBoxColumn,
            this.kompatibilnostDataGridViewTextBoxColumn,
            this.kompatibilnost1DataGridViewTextBoxColumn,
            this.stavkaDokumentaDataGridViewTextBoxColumn,
            this.Kolicina});
            this.uiOutputPopisArtikala.DataSource = this.artiklBindingSource1;
            this.uiOutputPopisArtikala.Location = new System.Drawing.Point(236, 12);
            this.uiOutputPopisArtikala.MultiSelect = false;
            this.uiOutputPopisArtikala.Name = "uiOutputPopisArtikala";
            this.uiOutputPopisArtikala.ReadOnly = true;
            this.uiOutputPopisArtikala.Size = new System.Drawing.Size(486, 157);
            this.uiOutputPopisArtikala.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kratkiopisDataGridViewTextBoxColumn
            // 
            this.kratkiopisDataGridViewTextBoxColumn.DataPropertyName = "Kratki_opis";
            this.kratkiopisDataGridViewTextBoxColumn.HeaderText = "Kratki_opis";
            this.kratkiopisDataGridViewTextBoxColumn.Name = "kratkiopisDataGridViewTextBoxColumn";
            this.kratkiopisDataGridViewTextBoxColumn.ReadOnly = true;
            this.kratkiopisDataGridViewTextBoxColumn.Visible = false;
            // 
            // specifikacijaDataGridViewTextBoxColumn
            // 
            this.specifikacijaDataGridViewTextBoxColumn.DataPropertyName = "Specifikacija";
            this.specifikacijaDataGridViewTextBoxColumn.HeaderText = "Specifikacija";
            this.specifikacijaDataGridViewTextBoxColumn.Name = "specifikacijaDataGridViewTextBoxColumn";
            this.specifikacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.specifikacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaIDDataGridViewTextBoxColumn
            // 
            this.vrstaIDDataGridViewTextBoxColumn.DataPropertyName = "Vrsta_ID";
            this.vrstaIDDataGridViewTextBoxColumn.HeaderText = "Vrsta_ID";
            this.vrstaIDDataGridViewTextBoxColumn.Name = "vrstaIDDataGridViewTextBoxColumn";
            this.vrstaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vrstaArtiklaDataGridViewTextBoxColumn
            // 
            this.vrstaArtiklaDataGridViewTextBoxColumn.DataPropertyName = "VrstaArtikla";
            this.vrstaArtiklaDataGridViewTextBoxColumn.HeaderText = "VrstaArtikla";
            this.vrstaArtiklaDataGridViewTextBoxColumn.Name = "vrstaArtiklaDataGridViewTextBoxColumn";
            this.vrstaArtiklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaArtiklaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dostupnostDataGridViewTextBoxColumn
            // 
            this.dostupnostDataGridViewTextBoxColumn.DataPropertyName = "Dostupnost";
            this.dostupnostDataGridViewTextBoxColumn.HeaderText = "Dostupnost";
            this.dostupnostDataGridViewTextBoxColumn.Name = "dostupnostDataGridViewTextBoxColumn";
            this.dostupnostDataGridViewTextBoxColumn.ReadOnly = true;
            this.dostupnostDataGridViewTextBoxColumn.Visible = false;
            // 
            // kompatibilnostDataGridViewTextBoxColumn
            // 
            this.kompatibilnostDataGridViewTextBoxColumn.DataPropertyName = "Kompatibilnost";
            this.kompatibilnostDataGridViewTextBoxColumn.HeaderText = "Kompatibilnost";
            this.kompatibilnostDataGridViewTextBoxColumn.Name = "kompatibilnostDataGridViewTextBoxColumn";
            this.kompatibilnostDataGridViewTextBoxColumn.ReadOnly = true;
            this.kompatibilnostDataGridViewTextBoxColumn.Visible = false;
            // 
            // kompatibilnost1DataGridViewTextBoxColumn
            // 
            this.kompatibilnost1DataGridViewTextBoxColumn.DataPropertyName = "Kompatibilnost1";
            this.kompatibilnost1DataGridViewTextBoxColumn.HeaderText = "Kompatibilnost1";
            this.kompatibilnost1DataGridViewTextBoxColumn.Name = "kompatibilnost1DataGridViewTextBoxColumn";
            this.kompatibilnost1DataGridViewTextBoxColumn.ReadOnly = true;
            this.kompatibilnost1DataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkaDokumentaDataGridViewTextBoxColumn
            // 
            this.stavkaDokumentaDataGridViewTextBoxColumn.DataPropertyName = "StavkaDokumenta";
            this.stavkaDokumentaDataGridViewTextBoxColumn.HeaderText = "StavkaDokumenta";
            this.stavkaDokumentaDataGridViewTextBoxColumn.Name = "stavkaDokumentaDataGridViewTextBoxColumn";
            this.stavkaDokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkaDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // artiklBindingSource1
            // 
            this.artiklBindingSource1.DataSource = typeof(TechStore.Artikl);
            // 
            // UiNabava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 407);
            this.Controls.Add(this.uiOutputPopisArtikala);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiInputKolicina);
            this.Controls.Add(this.uiInputArtikl);
            this.Controls.Add(this.uiInputPoslovnica);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UiNabava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nabava";
            this.Load += new System.EventHandler(this.FrmNabava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisArtikala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiInputPoslovnica;
        private System.Windows.Forms.ComboBox uiInputArtikl;
        private System.Windows.Forms.TextBox uiInputKolicina;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.DataGridView uiOutputPopisArtikala;
        private System.Windows.Forms.BindingSource artiklBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kratkiopisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specifikacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaArtiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kompatibilnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kompatibilnost1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
    }
}
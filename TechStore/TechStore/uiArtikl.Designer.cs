namespace TechStore
{
    partial class UiArtikl
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
            this.uiLabelPodaci = new System.Windows.Forms.Label();
            this.uiOutputPodaciArtikli = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kratkiopisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specifikacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vrstaArtiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaArtiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kompatibilnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kompatibilnost1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionObrisiArtikl = new System.Windows.Forms.Button();
            this.uiActionAzurirajArtikl = new System.Windows.Forms.Button();
            this.uiActionNatrag = new System.Windows.Forms.Button();
            this.uiInputPretraga = new System.Windows.Forms.TextBox();
            this.uiLabelPretraga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPodaciArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionDodajArtikl
            // 
            this.uiActionDodajArtikl.BackColor = System.Drawing.Color.DarkRed;
            this.uiActionDodajArtikl.FlatAppearance.BorderSize = 0;
            this.uiActionDodajArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionDodajArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajArtikl.ForeColor = System.Drawing.Color.White;
            this.uiActionDodajArtikl.Location = new System.Drawing.Point(943, 347);
            this.uiActionDodajArtikl.Name = "uiActionDodajArtikl";
            this.uiActionDodajArtikl.Size = new System.Drawing.Size(75, 26);
            this.uiActionDodajArtikl.TabIndex = 5;
            this.uiActionDodajArtikl.Text = "Dodaj";
            this.uiActionDodajArtikl.UseVisualStyleBackColor = false;
            this.uiActionDodajArtikl.Click += new System.EventHandler(this.UiActionDodajArtikl_Click);
            // 
            // uiLabelPodaci
            // 
            this.uiLabelPodaci.AutoSize = true;
            this.uiLabelPodaci.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelPodaci.ForeColor = System.Drawing.Color.White;
            this.uiLabelPodaci.Location = new System.Drawing.Point(12, 10);
            this.uiLabelPodaci.Name = "uiLabelPodaci";
            this.uiLabelPodaci.Size = new System.Drawing.Size(127, 15);
            this.uiLabelPodaci.TabIndex = 4;
            this.uiLabelPodaci.Text = "Podaci o artiklima:";
            // 
            // uiOutputPodaciArtikli
            // 
            this.uiOutputPodaciArtikli.AllowUserToAddRows = false;
            this.uiOutputPodaciArtikli.AllowUserToDeleteRows = false;
            this.uiOutputPodaciArtikli.AutoGenerateColumns = false;
            this.uiOutputPodaciArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiOutputPodaciArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPodaciArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.stavkaDokumentaDataGridViewTextBoxColumn});
            this.uiOutputPodaciArtikli.DataSource = this.artiklBindingSource;
            this.uiOutputPodaciArtikli.Location = new System.Drawing.Point(12, 28);
            this.uiOutputPodaciArtikli.MultiSelect = false;
            this.uiOutputPodaciArtikli.Name = "uiOutputPodaciArtikli";
            this.uiOutputPodaciArtikli.ReadOnly = true;
            this.uiOutputPodaciArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputPodaciArtikli.Size = new System.Drawing.Size(1006, 313);
            this.uiOutputPodaciArtikli.TabIndex = 3;
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
            // 
            // specifikacijaDataGridViewTextBoxColumn
            // 
            this.specifikacijaDataGridViewTextBoxColumn.DataPropertyName = "Specifikacija";
            this.specifikacijaDataGridViewTextBoxColumn.HeaderText = "Specifikacija";
            this.specifikacijaDataGridViewTextBoxColumn.Name = "specifikacijaDataGridViewTextBoxColumn";
            this.specifikacijaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.vrstaIDDataGridViewTextBoxColumn.DataSource = this.vrstaArtiklaBindingSource;
            this.vrstaIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.vrstaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vrstaIDDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.vrstaIDDataGridViewTextBoxColumn.HeaderText = "Vrsta artikla";
            this.vrstaIDDataGridViewTextBoxColumn.Name = "vrstaIDDataGridViewTextBoxColumn";
            this.vrstaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vrstaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vrstaIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // vrstaArtiklaBindingSource
            // 
            this.vrstaArtiklaBindingSource.DataSource = typeof(TechStore.VrstaArtikla);
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
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(TechStore.Artikl);
            // 
            // uiActionObrisiArtikl
            // 
            this.uiActionObrisiArtikl.BackColor = System.Drawing.Color.DarkRed;
            this.uiActionObrisiArtikl.FlatAppearance.BorderSize = 0;
            this.uiActionObrisiArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionObrisiArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionObrisiArtikl.ForeColor = System.Drawing.Color.White;
            this.uiActionObrisiArtikl.Location = new System.Drawing.Point(862, 349);
            this.uiActionObrisiArtikl.Name = "uiActionObrisiArtikl";
            this.uiActionObrisiArtikl.Size = new System.Drawing.Size(75, 23);
            this.uiActionObrisiArtikl.TabIndex = 6;
            this.uiActionObrisiArtikl.Text = "Obriši";
            this.uiActionObrisiArtikl.UseVisualStyleBackColor = false;
            this.uiActionObrisiArtikl.Click += new System.EventHandler(this.Button1_Click);
            // 
            // uiActionAzurirajArtikl
            // 
            this.uiActionAzurirajArtikl.BackColor = System.Drawing.Color.DarkRed;
            this.uiActionAzurirajArtikl.FlatAppearance.BorderSize = 0;
            this.uiActionAzurirajArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionAzurirajArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionAzurirajArtikl.ForeColor = System.Drawing.Color.White;
            this.uiActionAzurirajArtikl.Location = new System.Drawing.Point(781, 349);
            this.uiActionAzurirajArtikl.Name = "uiActionAzurirajArtikl";
            this.uiActionAzurirajArtikl.Size = new System.Drawing.Size(75, 23);
            this.uiActionAzurirajArtikl.TabIndex = 7;
            this.uiActionAzurirajArtikl.Text = "Ažuriraj";
            this.uiActionAzurirajArtikl.UseVisualStyleBackColor = false;
            this.uiActionAzurirajArtikl.Click += new System.EventHandler(this.UiActionAzurirajArtikl_Click);
            // 
            // uiActionNatrag
            // 
            this.uiActionNatrag.BackColor = System.Drawing.Color.DarkRed;
            this.uiActionNatrag.FlatAppearance.BorderSize = 0;
            this.uiActionNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNatrag.ForeColor = System.Drawing.Color.White;
            this.uiActionNatrag.Location = new System.Drawing.Point(12, 354);
            this.uiActionNatrag.Name = "uiActionNatrag";
            this.uiActionNatrag.Size = new System.Drawing.Size(75, 23);
            this.uiActionNatrag.TabIndex = 8;
            this.uiActionNatrag.Text = "Natrag";
            this.uiActionNatrag.UseVisualStyleBackColor = false;
            this.uiActionNatrag.Click += new System.EventHandler(this.UiActionNatrag_Click);
            // 
            // uiInputPretraga
            // 
            this.uiInputPretraga.Location = new System.Drawing.Point(884, 5);
            this.uiInputPretraga.Name = "uiInputPretraga";
            this.uiInputPretraga.Size = new System.Drawing.Size(134, 20);
            this.uiInputPretraga.TabIndex = 9;
            this.uiInputPretraga.TextChanged += new System.EventHandler(this.UiInputPretraga_TextChanged);
            // 
            // uiLabelPretraga
            // 
            this.uiLabelPretraga.AutoSize = true;
            this.uiLabelPretraga.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelPretraga.ForeColor = System.Drawing.Color.White;
            this.uiLabelPretraga.Location = new System.Drawing.Point(752, 6);
            this.uiLabelPretraga.Name = "uiLabelPretraga";
            this.uiLabelPretraga.Size = new System.Drawing.Size(126, 15);
            this.uiLabelPretraga.TabIndex = 10;
            this.uiLabelPretraga.Text = "Pretraži po nazivu:";
            // 
            // UiArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina_nova;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 389);
            this.Controls.Add(this.uiLabelPretraga);
            this.Controls.Add(this.uiInputPretraga);
            this.Controls.Add(this.uiActionNatrag);
            this.Controls.Add(this.uiActionAzurirajArtikl);
            this.Controls.Add(this.uiActionObrisiArtikl);
            this.Controls.Add(this.uiActionDodajArtikl);
            this.Controls.Add(this.uiLabelPodaci);
            this.Controls.Add(this.uiOutputPodaciArtikli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UiArtikl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.FrmArtikl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPodaciArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionDodajArtikl;
        private System.Windows.Forms.Label uiLabelPodaci;
        private System.Windows.Forms.DataGridView uiOutputPodaciArtikli;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kratkiopisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specifikacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vrstaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vrstaArtiklaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaArtiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kompatibilnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kompatibilnost1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uiActionObrisiArtikl;
        private System.Windows.Forms.Button uiActionAzurirajArtikl;
        private System.Windows.Forms.Button uiActionNatrag;
        private System.Windows.Forms.TextBox uiInputPretraga;
        private System.Windows.Forms.Label uiLabelPretraga;
    }
}
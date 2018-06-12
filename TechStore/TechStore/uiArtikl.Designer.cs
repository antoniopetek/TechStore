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
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPodaciArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionDodajArtikl
            // 
            this.uiActionDodajArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajArtikl.Location = new System.Drawing.Point(498, 217);
            this.uiActionDodajArtikl.Name = "uiActionDodajArtikl";
            this.uiActionDodajArtikl.Size = new System.Drawing.Size(157, 34);
            this.uiActionDodajArtikl.TabIndex = 5;
            this.uiActionDodajArtikl.Text = "DODAJ ARTIKL";
            this.uiActionDodajArtikl.UseVisualStyleBackColor = true;
            this.uiActionDodajArtikl.Click += new System.EventHandler(this.UiActionDodajArtikl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Podaci o artiklima:";
            // 
            // uiOutputPodaciArtikli
            // 
            this.uiOutputPodaciArtikli.AutoGenerateColumns = false;
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
            this.uiOutputPodaciArtikli.Name = "uiOutputPodaciArtikli";
            this.uiOutputPodaciArtikli.Size = new System.Drawing.Size(643, 183);
            this.uiOutputPodaciArtikli.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // kratkiopisDataGridViewTextBoxColumn
            // 
            this.kratkiopisDataGridViewTextBoxColumn.DataPropertyName = "Kratki_opis";
            this.kratkiopisDataGridViewTextBoxColumn.HeaderText = "Kratki_opis";
            this.kratkiopisDataGridViewTextBoxColumn.Name = "kratkiopisDataGridViewTextBoxColumn";
            // 
            // specifikacijaDataGridViewTextBoxColumn
            // 
            this.specifikacijaDataGridViewTextBoxColumn.DataPropertyName = "Specifikacija";
            this.specifikacijaDataGridViewTextBoxColumn.HeaderText = "Specifikacija";
            this.specifikacijaDataGridViewTextBoxColumn.Name = "specifikacijaDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
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
            this.vrstaArtiklaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dostupnostDataGridViewTextBoxColumn
            // 
            this.dostupnostDataGridViewTextBoxColumn.DataPropertyName = "Dostupnost";
            this.dostupnostDataGridViewTextBoxColumn.HeaderText = "Dostupnost";
            this.dostupnostDataGridViewTextBoxColumn.Name = "dostupnostDataGridViewTextBoxColumn";
            this.dostupnostDataGridViewTextBoxColumn.Visible = false;
            // 
            // kompatibilnostDataGridViewTextBoxColumn
            // 
            this.kompatibilnostDataGridViewTextBoxColumn.DataPropertyName = "Kompatibilnost";
            this.kompatibilnostDataGridViewTextBoxColumn.HeaderText = "Kompatibilnost";
            this.kompatibilnostDataGridViewTextBoxColumn.Name = "kompatibilnostDataGridViewTextBoxColumn";
            this.kompatibilnostDataGridViewTextBoxColumn.Visible = false;
            // 
            // kompatibilnost1DataGridViewTextBoxColumn
            // 
            this.kompatibilnost1DataGridViewTextBoxColumn.DataPropertyName = "Kompatibilnost1";
            this.kompatibilnost1DataGridViewTextBoxColumn.HeaderText = "Kompatibilnost1";
            this.kompatibilnost1DataGridViewTextBoxColumn.Name = "kompatibilnost1DataGridViewTextBoxColumn";
            this.kompatibilnost1DataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkaDokumentaDataGridViewTextBoxColumn
            // 
            this.stavkaDokumentaDataGridViewTextBoxColumn.DataPropertyName = "StavkaDokumenta";
            this.stavkaDokumentaDataGridViewTextBoxColumn.HeaderText = "StavkaDokumenta";
            this.stavkaDokumentaDataGridViewTextBoxColumn.Name = "stavkaDokumentaDataGridViewTextBoxColumn";
            this.stavkaDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(TechStore.Artikl);
            // 
            // uiActionObrisiArtikl
            // 
            this.uiActionObrisiArtikl.Location = new System.Drawing.Point(417, 224);
            this.uiActionObrisiArtikl.Name = "uiActionObrisiArtikl";
            this.uiActionObrisiArtikl.Size = new System.Drawing.Size(75, 23);
            this.uiActionObrisiArtikl.TabIndex = 6;
            this.uiActionObrisiArtikl.Text = "Obriši";
            this.uiActionObrisiArtikl.UseVisualStyleBackColor = true;
            this.uiActionObrisiArtikl.Click += new System.EventHandler(this.Button1_Click);
            // 
            // uiActionAzurirajArtikl
            // 
            this.uiActionAzurirajArtikl.Location = new System.Drawing.Point(336, 224);
            this.uiActionAzurirajArtikl.Name = "uiActionAzurirajArtikl";
            this.uiActionAzurirajArtikl.Size = new System.Drawing.Size(75, 23);
            this.uiActionAzurirajArtikl.TabIndex = 7;
            this.uiActionAzurirajArtikl.Text = "Ažuriraj";
            this.uiActionAzurirajArtikl.UseVisualStyleBackColor = true;
            // 
            // UiArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 277);
            this.Controls.Add(this.uiActionAzurirajArtikl);
            this.Controls.Add(this.uiActionObrisiArtikl);
            this.Controls.Add(this.uiActionDodajArtikl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputPodaciArtikli);
            this.Name = "UiArtikl";
            this.Text = "FrmArtikl";
            this.Load += new System.EventHandler(this.FrmArtikl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPodaciArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionDodajArtikl;
        private System.Windows.Forms.Label label1;
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
    }
}
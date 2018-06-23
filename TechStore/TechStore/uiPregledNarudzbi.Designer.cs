namespace TechStore
{
    partial class UiPregledNarudzbi
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
            this.uiOutputNarudzbe = new System.Windows.Forms.DataGridView();
            this.uiOutputStavkeNarudzbe = new System.Windows.Forms.DataGridView();
            this.uiLabelNarudzbe = new System.Windows.Forms.Label();
            this.uiLabelStavke = new System.Windows.Forms.Label();
            this.uiActionNatrag = new System.Windows.Forms.Button();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeizdavanjaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.vrstaDokumentaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vrstaDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dokumentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputStavkeNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaDokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputNarudzbe
            // 
            this.uiOutputNarudzbe.AllowUserToAddRows = false;
            this.uiOutputNarudzbe.AllowUserToDeleteRows = false;
            this.uiOutputNarudzbe.AutoGenerateColumns = false;
            this.uiOutputNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiOutputNarudzbe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uiOutputNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vrijemeizdavanjaDataGridViewImageColumn,
            this.vrstaDokumentaIDDataGridViewTextBoxColumn,
            this.vrstaDokumentaDataGridViewTextBoxColumn,
            this.stanjeDokumentaDataGridViewTextBoxColumn,
            this.stavkaDokumentaDataGridViewTextBoxColumn});
            this.uiOutputNarudzbe.DataSource = this.dokumentBindingSource;
            this.uiOutputNarudzbe.Location = new System.Drawing.Point(12, 25);
            this.uiOutputNarudzbe.MultiSelect = false;
            this.uiOutputNarudzbe.Name = "uiOutputNarudzbe";
            this.uiOutputNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputNarudzbe.Size = new System.Drawing.Size(776, 180);
            this.uiOutputNarudzbe.TabIndex = 0;
            this.uiOutputNarudzbe.SelectionChanged += new System.EventHandler(this.UiOutputNarudzbe_SelectionChanged);
            // 
            // uiOutputStavkeNarudzbe
            // 
            this.uiOutputStavkeNarudzbe.AllowUserToAddRows = false;
            this.uiOutputStavkeNarudzbe.AllowUserToDeleteRows = false;
            this.uiOutputStavkeNarudzbe.AutoGenerateColumns = false;
            this.uiOutputStavkeNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiOutputStavkeNarudzbe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uiOutputStavkeNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputStavkeNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artiklIDDataGridViewTextBoxColumn,
            this.dokumentIDDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.artiklDataGridViewTextBoxColumn,
            this.dokumentDataGridViewTextBoxColumn});
            this.uiOutputStavkeNarudzbe.DataSource = this.stavkaDokumentaBindingSource;
            this.uiOutputStavkeNarudzbe.Location = new System.Drawing.Point(12, 240);
            this.uiOutputStavkeNarudzbe.MultiSelect = false;
            this.uiOutputStavkeNarudzbe.Name = "uiOutputStavkeNarudzbe";
            this.uiOutputStavkeNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputStavkeNarudzbe.Size = new System.Drawing.Size(776, 180);
            this.uiOutputStavkeNarudzbe.TabIndex = 1;
            // 
            // uiLabelNarudzbe
            // 
            this.uiLabelNarudzbe.AutoSize = true;
            this.uiLabelNarudzbe.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelNarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelNarudzbe.ForeColor = System.Drawing.Color.White;
            this.uiLabelNarudzbe.Location = new System.Drawing.Point(12, 9);
            this.uiLabelNarudzbe.Name = "uiLabelNarudzbe";
            this.uiLabelNarudzbe.Size = new System.Drawing.Size(73, 15);
            this.uiLabelNarudzbe.TabIndex = 2;
            this.uiLabelNarudzbe.Text = "Narudžbe:";
            // 
            // uiLabelStavke
            // 
            this.uiLabelStavke.AutoSize = true;
            this.uiLabelStavke.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelStavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelStavke.ForeColor = System.Drawing.Color.White;
            this.uiLabelStavke.Location = new System.Drawing.Point(12, 214);
            this.uiLabelStavke.Name = "uiLabelStavke";
            this.uiLabelStavke.Size = new System.Drawing.Size(117, 15);
            this.uiLabelStavke.TabIndex = 3;
            this.uiLabelStavke.Text = "Stavke narudžbe:";
            // 
            // uiActionNatrag
            // 
            this.uiActionNatrag.BackColor = System.Drawing.Color.Maroon;
            this.uiActionNatrag.FlatAppearance.BorderSize = 0;
            this.uiActionNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNatrag.ForeColor = System.Drawing.Color.White;
            this.uiActionNatrag.Location = new System.Drawing.Point(12, 431);
            this.uiActionNatrag.Name = "uiActionNatrag";
            this.uiActionNatrag.Size = new System.Drawing.Size(75, 23);
            this.uiActionNatrag.TabIndex = 4;
            this.uiActionNatrag.Text = "Natrag";
            this.uiActionNatrag.UseVisualStyleBackColor = false;
            this.uiActionNatrag.Click += new System.EventHandler(this.UiActionNatrag_Click);
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(TechStore.Artikl);
            // 
            // stavkaDokumentaBindingSource
            // 
            this.stavkaDokumentaBindingSource.DataSource = typeof(TechStore.StavkaDokumenta);
            // 
            // vrstaDokumentaBindingSource
            // 
            this.vrstaDokumentaBindingSource.DataSource = typeof(TechStore.VrstaDokumenta);
            // 
            // dokumentBindingSource
            // 
            this.dokumentBindingSource.DataSource = typeof(TechStore.Dokument);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // vrijemeizdavanjaDataGridViewImageColumn
            // 
            this.vrijemeizdavanjaDataGridViewImageColumn.DataPropertyName = "Vrijeme_izdavanja";
            this.vrijemeizdavanjaDataGridViewImageColumn.HeaderText = "Vrijeme_izdavanja";
            this.vrijemeizdavanjaDataGridViewImageColumn.Name = "vrijemeizdavanjaDataGridViewImageColumn";
            this.vrijemeizdavanjaDataGridViewImageColumn.Visible = false;
            // 
            // vrstaDokumentaIDDataGridViewTextBoxColumn
            // 
            this.vrstaDokumentaIDDataGridViewTextBoxColumn.DataPropertyName = "VrstaDokumenta_ID";
            this.vrstaDokumentaIDDataGridViewTextBoxColumn.DataSource = this.vrstaDokumentaBindingSource;
            this.vrstaDokumentaIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.vrstaDokumentaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vrstaDokumentaIDDataGridViewTextBoxColumn.HeaderText = "Naziv dokumenta";
            this.vrstaDokumentaIDDataGridViewTextBoxColumn.Name = "vrstaDokumentaIDDataGridViewTextBoxColumn";
            this.vrstaDokumentaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vrstaDokumentaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vrstaDokumentaIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // vrstaDokumentaDataGridViewTextBoxColumn
            // 
            this.vrstaDokumentaDataGridViewTextBoxColumn.DataPropertyName = "VrstaDokumenta";
            this.vrstaDokumentaDataGridViewTextBoxColumn.HeaderText = "VrstaDokumenta";
            this.vrstaDokumentaDataGridViewTextBoxColumn.Name = "vrstaDokumentaDataGridViewTextBoxColumn";
            this.vrstaDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stanjeDokumentaDataGridViewTextBoxColumn
            // 
            this.stanjeDokumentaDataGridViewTextBoxColumn.DataPropertyName = "StanjeDokumenta";
            this.stanjeDokumentaDataGridViewTextBoxColumn.HeaderText = "StanjeDokumenta";
            this.stanjeDokumentaDataGridViewTextBoxColumn.Name = "stanjeDokumentaDataGridViewTextBoxColumn";
            this.stanjeDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkaDokumentaDataGridViewTextBoxColumn
            // 
            this.stavkaDokumentaDataGridViewTextBoxColumn.DataPropertyName = "StavkaDokumenta";
            this.stavkaDokumentaDataGridViewTextBoxColumn.HeaderText = "StavkaDokumenta";
            this.stavkaDokumentaDataGridViewTextBoxColumn.Name = "stavkaDokumentaDataGridViewTextBoxColumn";
            this.stavkaDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // artiklIDDataGridViewTextBoxColumn
            // 
            this.artiklIDDataGridViewTextBoxColumn.DataPropertyName = "Artikl_ID";
            this.artiklIDDataGridViewTextBoxColumn.DataSource = this.artiklBindingSource;
            this.artiklIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.artiklIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.artiklIDDataGridViewTextBoxColumn.HeaderText = "Naziv artikla";
            this.artiklIDDataGridViewTextBoxColumn.Name = "artiklIDDataGridViewTextBoxColumn";
            this.artiklIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.artiklIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.artiklIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // dokumentIDDataGridViewTextBoxColumn
            // 
            this.dokumentIDDataGridViewTextBoxColumn.DataPropertyName = "Dokument_ID";
            this.dokumentIDDataGridViewTextBoxColumn.HeaderText = "Dokument_ID";
            this.dokumentIDDataGridViewTextBoxColumn.Name = "dokumentIDDataGridViewTextBoxColumn";
            this.dokumentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // artiklDataGridViewTextBoxColumn
            // 
            this.artiklDataGridViewTextBoxColumn.DataPropertyName = "Artikl";
            this.artiklDataGridViewTextBoxColumn.HeaderText = "Artikl";
            this.artiklDataGridViewTextBoxColumn.Name = "artiklDataGridViewTextBoxColumn";
            this.artiklDataGridViewTextBoxColumn.Visible = false;
            // 
            // dokumentDataGridViewTextBoxColumn
            // 
            this.dokumentDataGridViewTextBoxColumn.DataPropertyName = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.HeaderText = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.Name = "dokumentDataGridViewTextBoxColumn";
            this.dokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // UiPregledNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina_nova;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 466);
            this.Controls.Add(this.uiActionNatrag);
            this.Controls.Add(this.uiLabelStavke);
            this.Controls.Add(this.uiLabelNarudzbe);
            this.Controls.Add(this.uiOutputStavkeNarudzbe);
            this.Controls.Add(this.uiOutputNarudzbe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UiPregledNarudzbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled narudžbi";
            this.Load += new System.EventHandler(this.UiPregledNarudzbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputStavkeNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaDokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputNarudzbe;
        private System.Windows.Forms.DataGridView uiOutputStavkeNarudzbe;
        private System.Windows.Forms.Label uiLabelNarudzbe;
        private System.Windows.Forms.Label uiLabelStavke;
        private System.Windows.Forms.Button uiActionNatrag;
        private System.Windows.Forms.BindingSource dokumentBindingSource;
        private System.Windows.Forms.BindingSource stavkaDokumentaBindingSource;
        private System.Windows.Forms.BindingSource vrstaDokumentaBindingSource;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn vrijemeizdavanjaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vrstaDokumentaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn artiklIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn;
    }
}
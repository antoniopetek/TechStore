namespace TechStore
{
    partial class UiStanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputPoslovnice = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionNatrag = new System.Windows.Forms.Button();
            this.uiActionNaruci = new System.Windows.Forms.Button();
            this.uiOutputStanjeArtikala = new System.Windows.Forms.DataGridView();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPoslovnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputStanjeArtikala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poslovnice:";
            // 
            // uiOutputPoslovnice
            // 
            this.uiOutputPoslovnice.AutoGenerateColumns = false;
            this.uiOutputPoslovnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiOutputPoslovnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPoslovnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.brojDataGridViewTextBoxColumn,
            this.dostupnostDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn});
            this.uiOutputPoslovnice.DataSource = this.poslovnicaBindingSource;
            this.uiOutputPoslovnice.Location = new System.Drawing.Point(12, 25);
            this.uiOutputPoslovnice.MultiSelect = false;
            this.uiOutputPoslovnice.Name = "uiOutputPoslovnice";
            this.uiOutputPoslovnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputPoslovnice.Size = new System.Drawing.Size(875, 194);
            this.uiOutputPoslovnice.TabIndex = 1;
            this.uiOutputPoslovnice.SelectionChanged += new System.EventHandler(this.UiOutputStanjeArtikala_SelectionChanged);
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
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "Grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            // 
            // brojDataGridViewTextBoxColumn
            // 
            this.brojDataGridViewTextBoxColumn.DataPropertyName = "Broj";
            this.brojDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.brojDataGridViewTextBoxColumn.Name = "brojDataGridViewTextBoxColumn";
            // 
            // dostupnostDataGridViewTextBoxColumn
            // 
            this.dostupnostDataGridViewTextBoxColumn.DataPropertyName = "Dostupnost";
            this.dostupnostDataGridViewTextBoxColumn.HeaderText = "Dostupnost";
            this.dostupnostDataGridViewTextBoxColumn.Name = "dostupnostDataGridViewTextBoxColumn";
            this.dostupnostDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataSource = typeof(TechStore.Poslovnica);
            // 
            // uiActionNatrag
            // 
            this.uiActionNatrag.Location = new System.Drawing.Point(632, 438);
            this.uiActionNatrag.Name = "uiActionNatrag";
            this.uiActionNatrag.Size = new System.Drawing.Size(75, 23);
            this.uiActionNatrag.TabIndex = 2;
            this.uiActionNatrag.Text = "Natrag";
            this.uiActionNatrag.UseVisualStyleBackColor = true;
            this.uiActionNatrag.Click += new System.EventHandler(this.UiActionNatrag_Click);
            // 
            // uiActionNaruci
            // 
            this.uiActionNaruci.Location = new System.Drawing.Point(812, 438);
            this.uiActionNaruci.Name = "uiActionNaruci";
            this.uiActionNaruci.Size = new System.Drawing.Size(75, 23);
            this.uiActionNaruci.TabIndex = 3;
            this.uiActionNaruci.Text = "Naruči";
            this.uiActionNaruci.UseVisualStyleBackColor = true;
            this.uiActionNaruci.Click += new System.EventHandler(this.UiActionNaruci_Click);
            // 
            // uiOutputStanjeArtikala
            // 
            this.uiOutputStanjeArtikala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiOutputStanjeArtikala.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uiOutputStanjeArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputStanjeArtikala.Location = new System.Drawing.Point(12, 238);
            this.uiOutputStanjeArtikala.MultiSelect = false;
            this.uiOutputStanjeArtikala.Name = "uiOutputStanjeArtikala";
            this.uiOutputStanjeArtikala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputStanjeArtikala.Size = new System.Drawing.Size(875, 194);
            this.uiOutputStanjeArtikala.TabIndex = 4;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(TechStore.Artikl);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Artikli:";
            // 
            // UiStanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiOutputStanjeArtikala);
            this.Controls.Add(this.uiActionNaruci);
            this.Controls.Add(this.uiActionNatrag);
            this.Controls.Add(this.uiOutputPoslovnice);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UiStanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStanje";
            this.Load += new System.EventHandler(this.FrmStanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPoslovnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputStanjeArtikala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputPoslovnice;
        private System.Windows.Forms.Button uiActionNatrag;
        private System.Windows.Forms.Button uiActionNaruci;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private System.Windows.Forms.DataGridView uiOutputStanjeArtikala;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.Label label2;
    }
}
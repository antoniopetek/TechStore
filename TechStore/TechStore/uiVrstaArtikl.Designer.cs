namespace TechStore
{
    partial class UiVrstaArtikl
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
            this.uiOutputVrsteArtikla = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaArtiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionObrisi = new System.Windows.Forms.Button();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.uiActionNatrag = new System.Windows.Forms.Button();
            this.uiLabelPretraga = new System.Windows.Forms.Label();
            this.uiInputPretraga = new System.Windows.Forms.TextBox();
            this.uiLabelPodaci = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputVrsteArtikla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputVrsteArtikla
            // 
            this.uiOutputVrsteArtikla.AllowUserToAddRows = false;
            this.uiOutputVrsteArtikla.AllowUserToDeleteRows = false;
            this.uiOutputVrsteArtikla.AutoGenerateColumns = false;
            this.uiOutputVrsteArtikla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiOutputVrsteArtikla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uiOutputVrsteArtikla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputVrsteArtikla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.artiklDataGridViewTextBoxColumn});
            this.uiOutputVrsteArtikla.DataSource = this.vrstaArtiklaBindingSource;
            this.uiOutputVrsteArtikla.Location = new System.Drawing.Point(22, 40);
            this.uiOutputVrsteArtikla.MultiSelect = false;
            this.uiOutputVrsteArtikla.Name = "uiOutputVrsteArtikla";
            this.uiOutputVrsteArtikla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputVrsteArtikla.Size = new System.Drawing.Size(719, 205);
            this.uiOutputVrsteArtikla.TabIndex = 0;
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
            // artiklDataGridViewTextBoxColumn
            // 
            this.artiklDataGridViewTextBoxColumn.DataPropertyName = "Artikl";
            this.artiklDataGridViewTextBoxColumn.HeaderText = "Artikl";
            this.artiklDataGridViewTextBoxColumn.Name = "artiklDataGridViewTextBoxColumn";
            this.artiklDataGridViewTextBoxColumn.Visible = false;
            // 
            // vrstaArtiklaBindingSource
            // 
            this.vrstaArtiklaBindingSource.DataSource = typeof(TechStore.VrstaArtikla);
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.BackColor = System.Drawing.Color.Maroon;
            this.uiActionDodaj.FlatAppearance.BorderSize = 0;
            this.uiActionDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodaj.ForeColor = System.Drawing.Color.White;
            this.uiActionDodaj.Location = new System.Drawing.Point(666, 251);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(75, 23);
            this.uiActionDodaj.TabIndex = 1;
            this.uiActionDodaj.Text = "Dodaj";
            this.uiActionDodaj.UseVisualStyleBackColor = false;
            this.uiActionDodaj.Click += new System.EventHandler(this.UiActionDodaj_Click);
            // 
            // uiActionObrisi
            // 
            this.uiActionObrisi.BackColor = System.Drawing.Color.Maroon;
            this.uiActionObrisi.FlatAppearance.BorderSize = 0;
            this.uiActionObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionObrisi.ForeColor = System.Drawing.Color.White;
            this.uiActionObrisi.Location = new System.Drawing.Point(585, 251);
            this.uiActionObrisi.Name = "uiActionObrisi";
            this.uiActionObrisi.Size = new System.Drawing.Size(75, 23);
            this.uiActionObrisi.TabIndex = 2;
            this.uiActionObrisi.Text = "Obriši";
            this.uiActionObrisi.UseVisualStyleBackColor = false;
            this.uiActionObrisi.Click += new System.EventHandler(this.UiActionObrisi_Click);
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.BackColor = System.Drawing.Color.Maroon;
            this.uiActionAzuriraj.FlatAppearance.BorderSize = 0;
            this.uiActionAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionAzuriraj.ForeColor = System.Drawing.Color.White;
            this.uiActionAzuriraj.Location = new System.Drawing.Point(504, 251);
            this.uiActionAzuriraj.Name = "uiActionAzuriraj";
            this.uiActionAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.uiActionAzuriraj.TabIndex = 3;
            this.uiActionAzuriraj.Text = "Ažuriraj";
            this.uiActionAzuriraj.UseVisualStyleBackColor = false;
            this.uiActionAzuriraj.Click += new System.EventHandler(this.UiActionAzuriraj_Click);
            // 
            // uiActionNatrag
            // 
            this.uiActionNatrag.BackColor = System.Drawing.Color.Maroon;
            this.uiActionNatrag.FlatAppearance.BorderSize = 0;
            this.uiActionNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNatrag.ForeColor = System.Drawing.Color.White;
            this.uiActionNatrag.Location = new System.Drawing.Point(22, 251);
            this.uiActionNatrag.Name = "uiActionNatrag";
            this.uiActionNatrag.Size = new System.Drawing.Size(75, 23);
            this.uiActionNatrag.TabIndex = 4;
            this.uiActionNatrag.Text = "Natrag";
            this.uiActionNatrag.UseVisualStyleBackColor = false;
            this.uiActionNatrag.Click += new System.EventHandler(this.UiActionNatrag_Click);
            // 
            // uiLabelPretraga
            // 
            this.uiLabelPretraga.AutoSize = true;
            this.uiLabelPretraga.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelPretraga.ForeColor = System.Drawing.Color.White;
            this.uiLabelPretraga.Location = new System.Drawing.Point(475, 13);
            this.uiLabelPretraga.Name = "uiLabelPretraga";
            this.uiLabelPretraga.Size = new System.Drawing.Size(126, 15);
            this.uiLabelPretraga.TabIndex = 12;
            this.uiLabelPretraga.Text = "Pretraži po nazivu:";
            // 
            // uiInputPretraga
            // 
            this.uiInputPretraga.Location = new System.Drawing.Point(607, 12);
            this.uiInputPretraga.Name = "uiInputPretraga";
            this.uiInputPretraga.Size = new System.Drawing.Size(134, 20);
            this.uiInputPretraga.TabIndex = 11;
            this.uiInputPretraga.TextChanged += new System.EventHandler(this.UiInputPretraga_TextChanged);
            // 
            // uiLabelPodaci
            // 
            this.uiLabelPodaci.AutoSize = true;
            this.uiLabelPodaci.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelPodaci.ForeColor = System.Drawing.Color.White;
            this.uiLabelPodaci.Location = new System.Drawing.Point(19, 13);
            this.uiLabelPodaci.Name = "uiLabelPodaci";
            this.uiLabelPodaci.Size = new System.Drawing.Size(165, 15);
            this.uiLabelPodaci.TabIndex = 13;
            this.uiLabelPodaci.Text = "Podaci o vrstama artikla:";
            // 
            // UiVrstaArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina_nova;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 282);
            this.Controls.Add(this.uiLabelPodaci);
            this.Controls.Add(this.uiLabelPretraga);
            this.Controls.Add(this.uiInputPretraga);
            this.Controls.Add(this.uiActionNatrag);
            this.Controls.Add(this.uiActionAzuriraj);
            this.Controls.Add(this.uiActionObrisi);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.uiOutputVrsteArtikla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UiVrstaArtikl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiVrstaArtikl";
            this.Load += new System.EventHandler(this.UiVrstaArtikl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputVrsteArtikla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputVrsteArtikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vrstaArtiklaBindingSource;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Button uiActionObrisi;
        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.Button uiActionNatrag;
        private System.Windows.Forms.Label uiLabelPretraga;
        private System.Windows.Forms.TextBox uiInputPretraga;
        private System.Windows.Forms.Label uiLabelPodaci;
    }
}
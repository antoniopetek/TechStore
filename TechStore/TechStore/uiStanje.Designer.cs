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
            this.uiLabelPoslovnice = new System.Windows.Forms.Label();
            this.uiActionNatrag = new System.Windows.Forms.Button();
            this.uiActionNaruci = new System.Windows.Forms.Button();
            this.uiOutputStanjeArtikala = new System.Windows.Forms.DataGridView();
            this.uiLabelArtikli = new System.Windows.Forms.Label();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputStanjeArtikala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabelPoslovnice
            // 
            this.uiLabelPoslovnice.AutoSize = true;
            this.uiLabelPoslovnice.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelPoslovnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelPoslovnice.ForeColor = System.Drawing.Color.Transparent;
            this.uiLabelPoslovnice.Location = new System.Drawing.Point(9, 9);
            this.uiLabelPoslovnice.Name = "uiLabelPoslovnice";
            this.uiLabelPoslovnice.Size = new System.Drawing.Size(80, 15);
            this.uiLabelPoslovnice.TabIndex = 0;
            this.uiLabelPoslovnice.Text = "Poslovnice:";
            // 
            // uiActionNatrag
            // 
            this.uiActionNatrag.BackColor = System.Drawing.Color.Maroon;
            this.uiActionNatrag.FlatAppearance.BorderSize = 0;
            this.uiActionNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNatrag.ForeColor = System.Drawing.Color.White;
            this.uiActionNatrag.Location = new System.Drawing.Point(12, 291);
            this.uiActionNatrag.Name = "uiActionNatrag";
            this.uiActionNatrag.Size = new System.Drawing.Size(75, 23);
            this.uiActionNatrag.TabIndex = 2;
            this.uiActionNatrag.Text = "Natrag";
            this.uiActionNatrag.UseVisualStyleBackColor = false;
            this.uiActionNatrag.Click += new System.EventHandler(this.UiActionNatrag_Click);
            // 
            // uiActionNaruci
            // 
            this.uiActionNaruci.BackColor = System.Drawing.Color.Maroon;
            this.uiActionNaruci.FlatAppearance.BorderSize = 0;
            this.uiActionNaruci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionNaruci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNaruci.ForeColor = System.Drawing.Color.White;
            this.uiActionNaruci.Location = new System.Drawing.Point(812, 291);
            this.uiActionNaruci.Name = "uiActionNaruci";
            this.uiActionNaruci.Size = new System.Drawing.Size(75, 23);
            this.uiActionNaruci.TabIndex = 3;
            this.uiActionNaruci.Text = "Naruči";
            this.uiActionNaruci.UseVisualStyleBackColor = false;
            this.uiActionNaruci.Click += new System.EventHandler(this.UiActionNaruci_Click);
            // 
            // uiOutputStanjeArtikala
            // 
            this.uiOutputStanjeArtikala.AllowUserToAddRows = false;
            this.uiOutputStanjeArtikala.AllowUserToDeleteRows = false;
            this.uiOutputStanjeArtikala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiOutputStanjeArtikala.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uiOutputStanjeArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputStanjeArtikala.Location = new System.Drawing.Point(12, 55);
            this.uiOutputStanjeArtikala.MultiSelect = false;
            this.uiOutputStanjeArtikala.Name = "uiOutputStanjeArtikala";
            this.uiOutputStanjeArtikala.RowHeadersVisible = false;
            this.uiOutputStanjeArtikala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputStanjeArtikala.Size = new System.Drawing.Size(875, 230);
            this.uiOutputStanjeArtikala.TabIndex = 4;
            // 
            // uiLabelArtikli
            // 
            this.uiLabelArtikli.AutoSize = true;
            this.uiLabelArtikli.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelArtikli.ForeColor = System.Drawing.Color.Transparent;
            this.uiLabelArtikli.Location = new System.Drawing.Point(12, 37);
            this.uiLabelArtikli.Name = "uiLabelArtikli";
            this.uiLabelArtikli.Size = new System.Drawing.Size(47, 15);
            this.uiLabelArtikli.TabIndex = 6;
            this.uiLabelArtikli.Text = "Artikli:";
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(TechStore.Artikl);
            // 
            // UiStanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina_nova;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 331);
            this.Controls.Add(this.uiLabelArtikli);
            this.Controls.Add(this.uiOutputStanjeArtikala);
            this.Controls.Add(this.uiActionNaruci);
            this.Controls.Add(this.uiActionNatrag);
            this.Controls.Add(this.uiLabelPoslovnice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UiStanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStanje";
            this.Load += new System.EventHandler(this.FrmStanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputStanjeArtikala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiLabelPoslovnice;
        private System.Windows.Forms.Button uiActionNatrag;
        private System.Windows.Forms.Button uiActionNaruci;
        private System.Windows.Forms.DataGridView uiOutputStanjeArtikala;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.Label uiLabelArtikli;
    }
}
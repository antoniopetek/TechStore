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
            this.uiInputArtikl = new System.Windows.Forms.ComboBox();
            this.uiInputKolicina = new System.Windows.Forms.TextBox();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiInputPoslovnica
            // 
            this.uiInputPoslovnica.DataSource = this.poslovnicaBindingSource;
            this.uiInputPoslovnica.DisplayMember = "Naziv";
            this.uiInputPoslovnica.FormattingEnabled = true;
            this.uiInputPoslovnica.Location = new System.Drawing.Point(92, 33);
            this.uiInputPoslovnica.Name = "uiInputPoslovnica";
            this.uiInputPoslovnica.Size = new System.Drawing.Size(121, 21);
            this.uiInputPoslovnica.TabIndex = 0;
            this.uiInputPoslovnica.ValueMember = "ID";
            // 
            // uiInputArtikl
            // 
            this.uiInputArtikl.DataSource = this.artiklBindingSource;
            this.uiInputArtikl.DisplayMember = "Naziv";
            this.uiInputArtikl.FormattingEnabled = true;
            this.uiInputArtikl.Location = new System.Drawing.Point(92, 60);
            this.uiInputArtikl.Name = "uiInputArtikl";
            this.uiInputArtikl.Size = new System.Drawing.Size(121, 21);
            this.uiInputArtikl.TabIndex = 1;
            this.uiInputArtikl.ValueMember = "ID";
            // 
            // uiInputKolicina
            // 
            this.uiInputKolicina.Location = new System.Drawing.Point(92, 87);
            this.uiInputKolicina.Name = "uiInputKolicina";
            this.uiInputKolicina.Size = new System.Drawing.Size(121, 20);
            this.uiInputKolicina.TabIndex = 2;
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Location = new System.Drawing.Point(75, 113);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(75, 23);
            this.uiActionSpremi.TabIndex = 3;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.UiActionSpremi_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(156, 113);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdustani.TabIndex = 4;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataSource = typeof(TechStore.Poslovnica);
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(TechStore.Artikl);
            // 
            // UiNabava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 168);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiInputKolicina);
            this.Controls.Add(this.uiInputArtikl);
            this.Controls.Add(this.uiInputPoslovnica);
            this.Name = "UiNabava";
            this.Text = "FrmNabava";
            this.Load += new System.EventHandler(this.FrmNabava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
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
    }
}
namespace TechStore
{
    partial class uiDodavanjeVrsteArtikla
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
            this.uiInputNaziv = new System.Windows.Forms.TextBox();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.uiLabelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiInputNaziv
            // 
            this.uiInputNaziv.Location = new System.Drawing.Point(185, 60);
            this.uiInputNaziv.Name = "uiInputNaziv";
            this.uiInputNaziv.Size = new System.Drawing.Size(100, 20);
            this.uiInputNaziv.TabIndex = 1;
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.BackColor = System.Drawing.Color.DarkRed;
            this.uiActionOdustani.FlatAppearance.BorderSize = 0;
            this.uiActionOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdustani.ForeColor = System.Drawing.Color.White;
            this.uiActionOdustani.Location = new System.Drawing.Point(241, 106);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdustani.TabIndex = 2;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = false;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.BackColor = System.Drawing.Color.DarkRed;
            this.uiActionSpremi.FlatAppearance.BorderSize = 0;
            this.uiActionSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiActionSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionSpremi.ForeColor = System.Drawing.Color.White;
            this.uiActionSpremi.Location = new System.Drawing.Point(147, 106);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(75, 23);
            this.uiActionSpremi.TabIndex = 3;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = false;
            this.uiActionSpremi.Click += new System.EventHandler(this.UiActionSpremi_Click);
            // 
            // uiLabelID
            // 
            this.uiLabelID.AutoSize = true;
            this.uiLabelID.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelID.ForeColor = System.Drawing.Color.White;
            this.uiLabelID.Location = new System.Drawing.Point(136, 63);
            this.uiLabelID.Name = "uiLabelID";
            this.uiLabelID.Size = new System.Drawing.Size(46, 15);
            this.uiLabelID.TabIndex = 4;
            this.uiLabelID.Text = "Naziv:";
            // 
            // uiDodavanjeVrsteArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina_nova;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 183);
            this.Controls.Add(this.uiLabelID);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiInputNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uiDodavanjeVrsteArtikla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj vrstu artikla";
            this.Load += new System.EventHandler(this.UiDodavanjeVrsteArtikla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uiInputNaziv;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.Label uiLabelID;
    }
}
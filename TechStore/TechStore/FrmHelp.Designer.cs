namespace TechStore
{
    partial class FrmHelp
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
            this.uiActionIzlaz = new System.Windows.Forms.Button();
            this.uiOutputPrikazPomoci = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // uiActionIzlaz
            // 
            this.uiActionIzlaz.Location = new System.Drawing.Point(713, 415);
            this.uiActionIzlaz.Name = "uiActionIzlaz";
            this.uiActionIzlaz.Size = new System.Drawing.Size(75, 23);
            this.uiActionIzlaz.TabIndex = 0;
            this.uiActionIzlaz.Text = "Izlaz";
            this.uiActionIzlaz.UseVisualStyleBackColor = true;
            this.uiActionIzlaz.Click += new System.EventHandler(this.UiActionIzlaz_Click);
            // 
            // uiOutputPrikazPomoci
            // 
            this.uiOutputPrikazPomoci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiOutputPrikazPomoci.Location = new System.Drawing.Point(54, 12);
            this.uiOutputPrikazPomoci.Name = "uiOutputPrikazPomoci";
            this.uiOutputPrikazPomoci.Size = new System.Drawing.Size(650, 395);
            this.uiOutputPrikazPomoci.TabIndex = 1;
            this.uiOutputPrikazPomoci.Text = "";
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiOutputPrikazPomoci);
            this.Controls.Add(this.uiActionIzlaz);
            this.Name = "FrmHelp";
            this.Text = "Pomoć";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiActionIzlaz;
        private System.Windows.Forms.RichTextBox uiOutputPrikazPomoci;
    }
}
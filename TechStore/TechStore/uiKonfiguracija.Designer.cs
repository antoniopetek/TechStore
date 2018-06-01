namespace TechStore
{
    partial class uiKonfiguracija
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uiActionIzdajRacun = new System.Windows.Forms.Button();
            this.uiInputMaticna = new System.Windows.Forms.ComboBox();
            this.uiInputGraficka = new System.Windows.Forms.ComboBox();
            this.uiInputProcesor = new System.Windows.Forms.ComboBox();
            this.uiInputRam = new System.Windows.Forms.ComboBox();
            this.uiInputSsd = new System.Windows.Forms.ComboBox();
            this.uiInputHdd = new System.Windows.Forms.ComboBox();
            this.uiInputNapajanje = new System.Windows.Forms.ComboBox();
            this.uiInputHladnjak = new System.Windows.Forms.ComboBox();
            this.uiInputZvucna = new System.Windows.Forms.ComboBox();
            this.uiInputKuciste = new System.Windows.Forms.ComboBox();
            this.uiOutputKonfiguracija = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputKonfiguracija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matična ploča:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grafička kartica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(33, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RAM memorija:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(33, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Procesor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(33, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SSD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(334, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Kučište:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(334, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Zvučna kartica:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(334, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hladnjak:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(334, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Napajanje:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(334, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "HDD:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(716, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ukupan iznos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(777, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Iznos";
            // 
            // uiActionIzdajRacun
            // 
            this.uiActionIzdajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionIzdajRacun.Location = new System.Drawing.Point(928, 302);
            this.uiActionIzdajRacun.Name = "uiActionIzdajRacun";
            this.uiActionIzdajRacun.Size = new System.Drawing.Size(116, 44);
            this.uiActionIzdajRacun.TabIndex = 22;
            this.uiActionIzdajRacun.Text = "IZDAJ RAČUN";
            this.uiActionIzdajRacun.UseVisualStyleBackColor = true;
            this.uiActionIzdajRacun.Click += new System.EventHandler(this.UiActionIzdajRacun_Click);
            // 
            // uiInputMaticna
            // 
            this.uiInputMaticna.FormattingEnabled = true;
            this.uiInputMaticna.Location = new System.Drawing.Point(36, 54);
            this.uiInputMaticna.Name = "uiInputMaticna";
            this.uiInputMaticna.Size = new System.Drawing.Size(236, 21);
            this.uiInputMaticna.TabIndex = 23;
            this.uiInputMaticna.SelectedIndexChanged += new System.EventHandler(this.uiInputMaticna_SelectedIndexChanged);
            // 
            // uiInputGraficka
            // 
            this.uiInputGraficka.Enabled = false;
            this.uiInputGraficka.FormattingEnabled = true;
            this.uiInputGraficka.Location = new System.Drawing.Point(36, 122);
            this.uiInputGraficka.Name = "uiInputGraficka";
            this.uiInputGraficka.Size = new System.Drawing.Size(236, 21);
            this.uiInputGraficka.TabIndex = 24;
            this.uiInputGraficka.SelectedIndexChanged += new System.EventHandler(this.uiInputGraficka_SelectedIndexChanged);
            // 
            // uiInputProcesor
            // 
            this.uiInputProcesor.Enabled = false;
            this.uiInputProcesor.FormattingEnabled = true;
            this.uiInputProcesor.Location = new System.Drawing.Point(36, 182);
            this.uiInputProcesor.Name = "uiInputProcesor";
            this.uiInputProcesor.Size = new System.Drawing.Size(236, 21);
            this.uiInputProcesor.TabIndex = 25;
            // 
            // uiInputRam
            // 
            this.uiInputRam.Enabled = false;
            this.uiInputRam.FormattingEnabled = true;
            this.uiInputRam.Location = new System.Drawing.Point(36, 254);
            this.uiInputRam.Name = "uiInputRam";
            this.uiInputRam.Size = new System.Drawing.Size(236, 21);
            this.uiInputRam.TabIndex = 26;
            // 
            // uiInputSsd
            // 
            this.uiInputSsd.Enabled = false;
            this.uiInputSsd.FormattingEnabled = true;
            this.uiInputSsd.Location = new System.Drawing.Point(36, 325);
            this.uiInputSsd.Name = "uiInputSsd";
            this.uiInputSsd.Size = new System.Drawing.Size(236, 21);
            this.uiInputSsd.TabIndex = 27;
            // 
            // uiInputHdd
            // 
            this.uiInputHdd.Enabled = false;
            this.uiInputHdd.FormattingEnabled = true;
            this.uiInputHdd.Location = new System.Drawing.Point(337, 54);
            this.uiInputHdd.Name = "uiInputHdd";
            this.uiInputHdd.Size = new System.Drawing.Size(236, 21);
            this.uiInputHdd.TabIndex = 28;
            // 
            // uiInputNapajanje
            // 
            this.uiInputNapajanje.Enabled = false;
            this.uiInputNapajanje.FormattingEnabled = true;
            this.uiInputNapajanje.Location = new System.Drawing.Point(337, 121);
            this.uiInputNapajanje.Name = "uiInputNapajanje";
            this.uiInputNapajanje.Size = new System.Drawing.Size(236, 21);
            this.uiInputNapajanje.TabIndex = 29;
            // 
            // uiInputHladnjak
            // 
            this.uiInputHladnjak.Enabled = false;
            this.uiInputHladnjak.FormattingEnabled = true;
            this.uiInputHladnjak.Location = new System.Drawing.Point(337, 181);
            this.uiInputHladnjak.Name = "uiInputHladnjak";
            this.uiInputHladnjak.Size = new System.Drawing.Size(236, 21);
            this.uiInputHladnjak.TabIndex = 30;
            // 
            // uiInputZvucna
            // 
            this.uiInputZvucna.Enabled = false;
            this.uiInputZvucna.FormattingEnabled = true;
            this.uiInputZvucna.Location = new System.Drawing.Point(337, 254);
            this.uiInputZvucna.Name = "uiInputZvucna";
            this.uiInputZvucna.Size = new System.Drawing.Size(236, 21);
            this.uiInputZvucna.TabIndex = 31;
            // 
            // uiInputKuciste
            // 
            this.uiInputKuciste.Enabled = false;
            this.uiInputKuciste.FormattingEnabled = true;
            this.uiInputKuciste.Location = new System.Drawing.Point(337, 325);
            this.uiInputKuciste.Name = "uiInputKuciste";
            this.uiInputKuciste.Size = new System.Drawing.Size(236, 21);
            this.uiInputKuciste.TabIndex = 32;
            // 
            // uiOutputKonfiguracija
            // 
            this.uiOutputKonfiguracija.AllowUserToAddRows = false;
            this.uiOutputKonfiguracija.AutoGenerateColumns = false;
            this.uiOutputKonfiguracija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.uiOutputKonfiguracija.DataSource = this.artiklBindingSource;
            this.uiOutputKonfiguracija.Location = new System.Drawing.Point(621, 28);
            this.uiOutputKonfiguracija.MultiSelect = false;
            this.uiOutputKonfiguracija.Name = "uiOutputKonfiguracija";
            this.uiOutputKonfiguracija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputKonfiguracija.Size = new System.Drawing.Size(585, 247);
            this.uiOutputKonfiguracija.TabIndex = 33;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // kratkiopisDataGridViewTextBoxColumn
            // 
            this.kratkiopisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kratkiopisDataGridViewTextBoxColumn.DataPropertyName = "Kratki_opis";
            this.kratkiopisDataGridViewTextBoxColumn.HeaderText = "Kratki opis";
            this.kratkiopisDataGridViewTextBoxColumn.Name = "kratkiopisDataGridViewTextBoxColumn";
            // 
            // specifikacijaDataGridViewTextBoxColumn
            // 
            this.specifikacijaDataGridViewTextBoxColumn.DataPropertyName = "Specifikacija";
            this.specifikacijaDataGridViewTextBoxColumn.HeaderText = "Specifikacija";
            this.specifikacijaDataGridViewTextBoxColumn.Name = "specifikacijaDataGridViewTextBoxColumn";
            this.specifikacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.FillWeight = 35F;
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // vrstaIDDataGridViewTextBoxColumn
            // 
            this.vrstaIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrstaIDDataGridViewTextBoxColumn.DataPropertyName = "Vrsta_ID";
            this.vrstaIDDataGridViewTextBoxColumn.DataSource = this.vrstaArtiklaBindingSource;
            this.vrstaIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.vrstaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vrstaIDDataGridViewTextBoxColumn.FillWeight = 45F;
            this.vrstaIDDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaIDDataGridViewTextBoxColumn.Name = "vrstaIDDataGridViewTextBoxColumn";
            this.vrstaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vrstaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vrstaIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // vrstaArtiklaBindingSource
            // 
            this.vrstaArtiklaBindingSource.DataSource = typeof(TechStore.TipZaposlenika);
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
            // uiKonfiguracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechStore.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1235, 369);
            this.Controls.Add(this.uiOutputKonfiguracija);
            this.Controls.Add(this.uiInputKuciste);
            this.Controls.Add(this.uiInputZvucna);
            this.Controls.Add(this.uiInputHladnjak);
            this.Controls.Add(this.uiInputNapajanje);
            this.Controls.Add(this.uiInputHdd);
            this.Controls.Add(this.uiInputSsd);
            this.Controls.Add(this.uiInputRam);
            this.Controls.Add(this.uiInputProcesor);
            this.Controls.Add(this.uiInputGraficka);
            this.Controls.Add(this.uiInputMaticna);
            this.Controls.Add(this.uiActionIzdajRacun);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uiKonfiguracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKonfiguracija";
            this.Load += new System.EventHandler(this.FrmKonfiguracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputKonfiguracija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button uiActionIzdajRacun;
        private System.Windows.Forms.ComboBox uiInputMaticna;
        private System.Windows.Forms.ComboBox uiInputGraficka;
        private System.Windows.Forms.ComboBox uiInputProcesor;
        private System.Windows.Forms.ComboBox uiInputRam;
        private System.Windows.Forms.ComboBox uiInputSsd;
        private System.Windows.Forms.ComboBox uiInputHdd;
        private System.Windows.Forms.ComboBox uiInputNapajanje;
        private System.Windows.Forms.ComboBox uiInputHladnjak;
        private System.Windows.Forms.ComboBox uiInputZvucna;
        private System.Windows.Forms.ComboBox uiInputKuciste;
        private System.Windows.Forms.DataGridView uiOutputKonfiguracija;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.BindingSource vrstaArtiklaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kratkiopisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specifikacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vrstaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaArtiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kompatibilnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kompatibilnost1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaDokumentaDataGridViewTextBoxColumn;
    }
}
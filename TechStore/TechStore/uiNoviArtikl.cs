using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStore
{
    public partial class uiNoviArtikl : Form
    {
        /// <summary>
        /// Konstruktor forme uiNoviArtikl
        /// </summary>
        public uiNoviArtikl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom
        /// učitavanja forme uiNoviArtikl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNoviArtikl_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmNoviArtikl_KeyDown;
            vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na tipku F11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNoviArtikl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Dodavanje artikla.";
                frmHelp.Show();

            }
        }
    }
}

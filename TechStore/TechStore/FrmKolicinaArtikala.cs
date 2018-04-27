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
    public partial class FrmKolicinaArtikala : Form
    {
        public FrmKolicinaArtikala()
        {
            InitializeComponent();
        }

        private void FrmKolicinaArtikala_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmKolicinaArtikala_KeyDown;
        }

        private void FrmKolicinaArtikala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Poslovnica.";
                frmHelp.Show();

            }
        }
    }
}

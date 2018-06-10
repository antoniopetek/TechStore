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
    public partial class uiArtikl : Form
    {
        public uiArtikl()
        {
            InitializeComponent();
        }

        private void UiActionDodajArtikl_Click(object sender, EventArgs e)
        {
            uiNoviArtikl noviArtikl = new uiNoviArtikl();
            noviArtikl.Show();
        }

        private void FrmArtikl_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmArtikl_KeyDown;
        }

        private void FrmArtikl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Artikl.";
                frmHelp.Show();

            }
        }
    }
}

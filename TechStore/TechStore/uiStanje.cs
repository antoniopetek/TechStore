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
    public partial class uiStanje : Form
    {
        public uiStanje()
        {
            InitializeComponent();
        }

        private void FrmStanje_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmStanje_KeyDown;
        }

        private void FrmStanje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Izbornik. Na formi Izbornik možete vidjeti";
                frmHelp.Show();

            }
        }

        private void UiActionNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UiActionNaruci_Click(object sender, EventArgs e)
        {
            uiNabava formaNabava = new uiNabava();
            formaNabava.Show();
        }
    }
}

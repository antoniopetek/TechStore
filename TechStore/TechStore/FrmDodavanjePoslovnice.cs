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
    public partial class FrmDodavanjePoslovnice : Form
    {
        public FrmDodavanjePoslovnice()
        {
            InitializeComponent();
        }

        private void UiActionDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste dodali poslovnicu!", "POSLOVNICA DODANA", MessageBoxButtons.OK, MessageBoxIcon.None);
            Close();
        }

        private void FrmDodavanjePoslovnice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmDodavanjePoslovnice_KeyDown;
        }

        private void FrmDodavanjePoslovnice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Dodaj poslovnicu.";
                frmHelp.Show();

            }
        }
    }
}

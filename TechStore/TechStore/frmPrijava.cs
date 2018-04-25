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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UiActionPrijaviSe_Click(object sender, EventArgs e)
        {
            Form frmIzbornik = new FrmIzbornik();
            frmIzbornik.Show();
            Hide();
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmPrijava_KeyDown;
        }

        private void FrmPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString()=="F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Prijava. Na formi Prijava možete vidjeti unos korisničkog imena i lozinke te dva gumbića." +
                    " Ukoliko unesete dobro korisničko ime i lozinku i pritisnete na gumbić PRIJAVI SE aplikacija vas vodi do glavnog izbornika aplikacije. Ukoliko unesete" +
                    "pogrešno korisničko ime i lozinku aplikacija ispisuje grešku. Pritiskom na gumbić ODUSTANI aplikacija se zatvara. ";
                frmHelp.Show();
                
            }
        }
    }
}

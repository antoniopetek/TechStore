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
    public partial class uiPrijava : Form
    {
        public uiPrijava()
        {
            InitializeComponent();
        }

        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UiActionPrijaviSe_Click(object sender, EventArgs e)
        {
            if (uiInputKorisnickoIme.Text != "" && uiInputLozinka.Text != "")
            {
                Zaposlenik.PrijavljeniZaposlenik = Zaposlenik.DohvatiZaposlenika(uiInputKorisnickoIme.Text, uiInputLozinka.Text);
                if (Zaposlenik.PrijavljeniZaposlenik != null)
                {
                    uiIzbornik izbornik = new uiIzbornik();
                    Hide();
                    izbornik.ShowDialog();
                    Show();
                    uiInputKorisnickoIme.Clear();
                    uiInputLozinka.Clear();
                }
                else
                {
                    MessageBox.Show("Unijeli ste krivo korisničko ime ili lozinku. Pokušajte ponovno.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                richTextBox.Text = "TechStore Help Center\n\n";
                richTextBox.Text += "Trenutno ste pritisnuli F1 na formi Prijava.\n\nNa formi Prijava možete vidjeti dva tekstualna polja za unos korisničkog imena i lozinke te dvije tipke." +
                    " Ukoliko unesete dobro korisničko ime i lozinku i pritisnete na tipku ''PRIJAVI SE'' aplikacija vas vodi do glavnog izbornika aplikacije. Ukoliko unesete" +
                    "pogrešno korisničko ime i lozinku aplikacija ispisuje grešku. Pritiskom na tipku ''ODUSTANI'' aplikacija se zatvara. ";
                frmHelp.Show();     
            }
        }
    }
}

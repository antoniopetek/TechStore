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
    public partial class uiZaposlenici : Form
    {
        public uiZaposlenici()
        {
            InitializeComponent();
        }

        private void uiActionDodajZaposlenika_Click(object sender, EventArgs e)
        {
            uiDodavanjeZaposlenika formaDodavanjeZaposlenika = new uiDodavanjeZaposlenika();
            formaDodavanjeZaposlenika.ShowDialog();

            OsvjeziZaposlenike();
        }

        private void FrmZaposlenici_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmZaposlenici_KeyDown;
            OsvjeziZaposlenike();   
        }

        private void FrmZaposlenici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Zaposleici.";
                frmHelp.Show();

            }
        }

        private void OsvjeziZaposlenike()
        {
            zaposlenikBindingSource.DataSource = Zaposlenik.DohvatiSveZaposlenike();
            tipZaposlenikaBindingSource.DataSource = TipZaposlenika.DohvatiTipoveZaposlenika();
            poslovnicaBindingSource.DataSource = Poslovnica.DohvatiPoslovnice();
            
        }

        private void uiOutputPopisZaposlenika_SelectionChanged(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik = zaposlenikBindingSource.Current as Zaposlenik;

            if (zaposlenik != null)
            {
                uiOutputAdresa.Text = zaposlenik.Ulica.ToString() + " " + zaposlenik.Broj.ToString() + ", " + zaposlenik.Grad.ToString() + ", " + zaposlenik.Drzava.ToString();
                uiOutputKontakt.Text = zaposlenik.Kontakt.ToString();
                uiOutputEmail.Text = zaposlenik.Email.ToString();
                uiOutputKorisnickoIme.Text = zaposlenik.Korisnicko_ime.ToString();
                uiOutputLozinka.Text = zaposlenik.Lozinka.ToString();
            }
        }
    }
}

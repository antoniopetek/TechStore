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
    public partial class uiDodavanjeZaposlenika : Form
    {
        public uiDodavanjeZaposlenika()
        {
            InitializeComponent();
        }

        private void UiActionDodajZaposlenika_Click(object sender, EventArgs e)
        {
            if (uiInputIme.Text == "" || uiInputPrezime.Text == "" || uiInputEmail.Text == "" || uiInputKontakt.Text == "" || uiInputDrzava.Text == "" || uiInputGrad.Text == "" || uiInputUlica.Text == "" || uiInputBroj.Text == "" || uiInputKorisnickoIme.Text == "" || uiInputLozinka.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                using (TechStoreEntities db = new TechStoreEntities())
                {
                    Zaposlenik zaposlenik = new Zaposlenik
                    {
                        Ime = uiInputIme.Text,
                        Prezime = uiInputPrezime.Text,
                        Email = uiInputEmail.Text,
                        Kontakt = uiInputKontakt.Text,
                        Drzava = uiInputDrzava.Text,
                        Grad = uiInputGrad.Text,
                        Ulica = uiInputUlica.Text,
                        Broj = uiInputBroj.Text,
                        Korisnicko_ime = uiInputKorisnickoIme.Text,
                        Lozinka = uiInputLozinka.Text,
                        Poslovnica_ID = int.Parse(uiInputPoslovnica.SelectedValue.ToString()),
                        Tip_ID = int.Parse(uiInputTipZaposlenika.SelectedValue.ToString())
                    };

                    db.Zaposlenik.Add(zaposlenik);
                    db.SaveChanges();
                    Close();
                }
            }    
        }

        private void FrmDodavanjeZaposlenika_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmDodavanjeZaposlenika_KeyDown;

            poslovnicaBindingSource.DataSource = Poslovnica.DohvatiPoslovnice();
            tipZaposlenikaBindingSource.DataSource = TipZaposlenika.DohvatiTipoveZaposlenika();
        }

        private void FrmDodavanjeZaposlenika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Dodavanje zaposlenika.";
                frmHelp.Show();

            }
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

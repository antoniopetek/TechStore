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
        /// <summary>
        /// Konstruktor forme uiDodavanjeZaposlenika.
        /// </summary>
        public uiDodavanjeZaposlenika()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rukuje događajem klika na tipku uiActionDodajZaposlenika. Provjerava ako
        /// su uneseni svi podaci. Ako nisu, ispisuje odgovarajuću poruku. Ako jesu,
        /// kreira novi objekt klase Zaposlenik i popunjava ga s podacima s forme te ga
        /// dodaje u bazu pomoću statičke metode DodajZaposlenika, ispisuje odgovarajuću 
        /// poruku i zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionDodajZaposlenika_Click(object sender, EventArgs e)
        {
            if (uiInputIme.Text == "" || uiInputPrezime.Text == "" || uiInputEmail.Text == "" || uiInputKontakt.Text == "" || uiInputDrzava.Text == "" || uiInputGrad.Text == "" || uiInputUlica.Text == "" || uiInputBroj.Text == "" || uiInputKorisnickoIme.Text == "" || uiInputLozinka.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

                Zaposlenik.DodajZaposlenika(zaposlenik);
                MessageBox.Show("Zaposlenik uspješno dodan.", "ZAPOSLENIK DODAN", MessageBoxButtons.OK);
                Close();
            }
        }

        /// <summary>
        /// Rukuje događajem pokretanja forme. Dohvaća sve poslovnice i tipove
        /// zaposlenika i prikazuje ih u odgovarajućim ComboBox kontrolama.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiDodavanjeZaposlenika_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += uiDodavanjeZaposlenika_KeyDown;

            poslovnicaBindingSource.DataSource = Poslovnica.DohvatiPoslovnice();
            tipZaposlenikaBindingSource.DataSource = TipZaposlenika.DohvatiTipoveZaposlenika();
        }

        /// <summary>
        /// Rukuje događajem pritiska tipke na tipkovnici. Ako je na tipkovnici
        /// pritisnuta tipka "F1" otvara formu uiHelp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiDodavanjeZaposlenika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Dodavanje zaposlenika.\n\nForma Dodavanje zaposlenika služi za dodavanje zaposlenika u bazu. Kako bi se zaposlenik " +
                    "dodao, potrebno je popuniti tekstualna polja i kliknuti na tipku ''Dodaj zaposlenika''. \nKlikom na tipku ''Dodaj zaposlenika'', zaposlenik se, ukoliko su podaci ispravni, " +
                    "dodaje te se forma zatvara. U slučaju neispravnog unosa, ispisuje se poruka o neuspješnom unosu te korisnik ima mogućnost ispravka unesenih podataka.\n" +
                    "Klikom na tipku ''Odustani'', vraćate se na formu za pregled zaposlenika.";
                frmHelp.Show();

            }
        }

        /// <summary>
        /// Rukuje događajem klika na tipku uiActionOdustani. Zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

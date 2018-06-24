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
    /// <summary>
    /// Forma za pregled zaposlenika.
    /// </summary>
    public partial class uiZaposlenici : Form
    {
        /// <summary>
        /// Konstruktor forme uiZaposlenici.
        /// </summary>
        public uiZaposlenici()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rukuje događajem klika na tipku uiActionDodajZaposlenika. Otvara formu
        /// uiDodavanjeZaposlenika, a nakon zatvaranja forme osvježava prikaz zaposlenika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionDodajZaposlenika_Click(object sender, EventArgs e)
        {
            uiDodavanjeZaposlenika formaDodavanjeZaposlenika = new uiDodavanjeZaposlenika();
            formaDodavanjeZaposlenika.ShowDialog();
            OsvjeziZaposlenike();
        }

        /// <summary>
        /// Rukuje događajem pokretanja forme. Prikazuje sve zaposlenike u DataGridView
        /// kontroli.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiZaposlenici_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += UiZaposlenici_KeyDown;
            OsvjeziZaposlenike();   
        }

        /// <summary>
        /// Rukuje događajem pritiska tipke na tipkovnici. Ako je na tipkovnici
        /// pritisnuta tipka "F1" otvara formu uiHelp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiZaposlenici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Zaposlenici.\n\nNa formi ''Zaposlenici'' možete vidjeti popis svih zaposlenika. Klikom na željenog zaposlenika " +
                    "prikazuju se svi njegovi podaci.\n\nKlikom na tipku ''DODAJ'' otvara se forma za dodavanje zaposlenika.\n\nKlikom na tipku ''NATRAG'' vraćate se na glavni izbornik.";
                frmHelp.Show();

            }
        }

        /// <summary>
        /// Puni zaposlenikBindingSource s listom zaposlenika uz pomoć statičke metode DohvatiSveZaposlenike. 
        /// Puni tipZaposlenikaBindingSource uz pomoć statičke metode
        /// DohvatiTipoveZaposlenika i puni poslovnicaBindingSource uz pomoć statičke metode DohvatiPoslovnice.
        /// </summary>
        private void OsvjeziZaposlenike()
        {
            try
            {
                zaposlenikBindingSource.DataSource = Zaposlenik.DohvatiSveZaposlenike();
                tipZaposlenikaBindingSource.DataSource = TipZaposlenika.DohvatiTipoveZaposlenika();
                poslovnicaBindingSource.DataSource = Poslovnica.DohvatiPoslovnice();
            }
            catch (Exception)
            {
                MessageBox.Show("Došlo je do pogreške.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                   
        }

        /// <summary>
        /// Rukuje događajem promjene selektiranog retka u DataGridView kontroli.
        /// Podatke o selektiranom zaposleniku prikazuje u TextBox kontrolama.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiOutputPopisZaposlenika_SelectionChanged(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik = null;
            try
            {
                zaposlenik = zaposlenikBindingSource.Current as Zaposlenik;
            } 
            catch (Exception)
            {
                MessageBox.Show("Došlo je do pogreške.", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (zaposlenik != null)
            {
                uiOutputAdresa.Text = zaposlenik.Ulica.ToString() + " " + zaposlenik.Broj.ToString() + ", " + zaposlenik.Grad.ToString() + ", " + zaposlenik.Drzava.ToString();
                uiOutputKontakt.Text = zaposlenik.Kontakt.ToString();
                uiOutputEmail.Text = zaposlenik.Email.ToString();
                uiOutputKorisnickoIme.Text = zaposlenik.Korisnicko_ime.ToString();
                uiOutputLozinka.Text = zaposlenik.Lozinka.ToString();
            }
        }

        /// <summary>
        /// Rukuje događajem klika na tipku uiActionNatrag. Zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

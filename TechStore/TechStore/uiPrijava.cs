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
        /// <summary>
        /// Konstruktor forme uiPrijava.
        /// </summary>
        public uiPrijava()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Rukuje događajem klika na tipku uiActionOdustani. Zatvara aplikaciju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Rukuje događajem klika na tipku uiActionPrijaviSe. Dohvaća zaposlenika
        /// iz baze prema upisanom korisničkom imenu i lozinki. Ukoliko zaposlenik
        /// s unesenim korisničkim imenom i lozinkom postoji, otvara uiIzbornik. U
        /// suprotnom, ispisuje poruku o neuspjehu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Rukuje događajem pokretanja forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiPrijava_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += uiPrijava_KeyDown;
        }
        /// <summary>
        /// Rukuje događajem pritiska tipke na tipkovnici. Ako je na tipkovnici
        /// pritisnuta tipka "F1" otvara formu uiHelp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString()=="F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\n\n";
                richTextBox.Text += "Trenutno ste pritisnuli F1 na formi Prijava.\n\nNa formi Prijava možete vidjeti dva tekstualna polja za unos korisničkog imena i lozinke te dvije tipke." +
                    " Ukoliko unesete dobro korisničko ime i lozinku i pritisnete na tipku ''PRIJAVI SE'' aplikacija vas vodi do glavnog izbornika aplikacije. Ukoliko unesete" +
                    "pogrešno korisničko ime i lozinku aplikacija ispisuje grešku. Pritiskom na tipku ''ODUSTANI'' aplikacija se zatvara. " +
                    "\n\nPodaci za prijavu: \n\nADMINISTRATOR \nKorisničko ime: apetek \nLozinka: password \n\nKORISNIK \n" +
                    "Korisničko ime: mposavec \nLozinka: martin123";
                frmHelp.Show();     
            }
        }
    }
}

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
    public partial class uiDodavanjePoslovnica : Form
    {
        /// <summary>
        /// Konstruktor forme uiDodavanjePoslovnica.
        /// </summary>
        public uiDodavanjePoslovnica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rukuje događajem klika na tipku uiActionDodajPoslovnicu. Provjerava ako
        /// su uneseni podaci ispravni. Ako nisu, ispisuje odgovarajuću poruku. Ako 
        /// jesu, kreira novi objekt klase Poslovnica i popunjava ga s podacima s 
        /// forme te ga dodaje u bazu pomoću statičke metode DodajPoslovnicu, ispisuje 
        /// odgovarajuću poruku i zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            if (uiInputNaziv.Text == "" || uiInputDrzava.Text == "" || uiInputGrad.Text == "" || uiInputUlica.Text == "" || uiInputBroj.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Poslovnica poslovnica = new Poslovnica
                {
                    Naziv = uiInputNaziv.Text,
                    Drzava = uiInputDrzava.Text,
                    Grad = uiInputGrad.Text,
                    Ulica = uiInputUlica.Text,
                    Broj = uiInputBroj.Text
                };

                Poslovnica.DodajPoslovnicu(poslovnica);
                MessageBox.Show("Poslovnica uspješno dodana.", "POSLOVNICA DODANA", MessageBoxButtons.OK);
                Close();
            }
        }

        /// <summary>
        /// Rukuje događajem pokretanja forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiDodavanjePoslovnice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += UiDodavanjePoslovnice_KeyDown;
        }

        /// <summary>
        /// Rukuje događajem pritiska tipke na tipkovnici. Ako je na tipkovnici
        /// pritisnuta tipka "F1" otvara formu uiHelp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiDodavanjePoslovnice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Dodavanje poslovnice.\n\nForma Dodavanje poslovnice služi za dodavanje poslovnice u bazu. Kako bi se poslovnica " +
                    "dodala, potrebno je popuniti tekstualna polja i kliknuti na tipku ''Dodaj poslovnicu''. \n\nKlikom na tipku ''Dodaj poslovnicu'', poslovnica se, ukoliko su podaci ispravni, " +
                    "dodaje te se forma zatvara. U slučaju neispravnog unosa, ispisuje se poruka o neuspješnom unosu te korisnik ima mogućnost ispravka unesenih podataka.\n\n" +
                    "Klikom na tipku ''Odustani'', vraćate se na formu za pregled poslovnica.";
                frmHelp.Show();

            }
        }

        /// <summary>
        /// Rukuje događajem klika na tipku uiActionOdustani. Zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

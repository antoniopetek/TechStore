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
        public uiDodavanjePoslovnica()
        {
            InitializeComponent();
        }

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
                richTextBox.Text = "TechStore Help Center\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Dodavanje poslovnice.\n\nForma Dodavanje poslovnice služi za dodavanje poslovnice u bazu. Kako bi se poslovnica " +
                    "dodala, potrebno je popuniti tekstualna polja i kliknuti na tipku ''Dodaj poslovnicu''. \nKlikom na tipku ''Dodaj poslovnicu'', poslovnica se, ukoliko su podaci ispravni, " +
                    "dodaje te se forma zatvara. U slučaju neispravnog unosa, ispisuje se poruka o neuspješnom unosu te korisnik ima mogućnost ispravka unesenih podataka.\n" +
                    "Klikom na tipku ''Odustani'', vraćate se na formu za pregled poslovnica.";
                frmHelp.Show();

            }
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

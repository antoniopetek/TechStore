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
    public partial class uiPoslovnice : Form
    {
        /// <summary>
        /// Konstruktor forme uiPoslovnice.
        /// </summary>
        public uiPoslovnice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rukuje događajem pokretanja forme. Prikazuje sve poslovnice u 
        /// DataGridView kontroli.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiPoslovnice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += UiPoslovnica_KeyDown;
            OsvjeziPoslovnice();
        }

        /// <summary>
        /// Rukuje događajem pritiska tipke na tipkovnici. Ako je na tipkovnici
        /// pritisnuta tipka "F1" otvara formu uiHelp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiPoslovnica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Poslovnice.\n\nNa formi ''Poslovnice'' možete vidjeti popis svih poslovnica." +
                    "\nKlikom na tipku ''DODAJ POSLOVNICU'' otvara se forma za dodavanje poslovnice. \nKlikom na tipku ''NATRAG'' vraćate se na glavni izbornik.";
                frmHelp.Show();

            }
        }

        /// <summary>
        /// Rukuje događajem klika na tipku uiActionDodajPoslovnicu. Otvara formu
        /// uiDodavanjePoslovnice, a nakon zatvaranja forme osvježava prikaz poslovnica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            uiDodavanjePoslovnica formaDodavanjePoslovnice = new uiDodavanjePoslovnica();
            formaDodavanjePoslovnice.ShowDialog();

            OsvjeziPoslovnice();
        }

        /// <summary>
        /// Dohvaća sve poslovnice uz pomoć statičke metode DohvatiPoslovnice.
        /// </summary>
        private void OsvjeziPoslovnice()
        {
            poslovnicaBindingSource.DataSource = Poslovnica.DohvatiPoslovnice();
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

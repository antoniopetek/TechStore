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
    public partial class uiKolicinaArtikala : Form
    {
        /// <summary>
        /// Konstruktor forme uiKolicinaArtikala.
        /// </summary>
        public uiKolicinaArtikala()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rukuje događajem pokretanja forme. Popunjava ComboBox sa svim artiklima
        /// uz pomoć statičke metode DohvatiSve artikle. Na Chart kontroli uklanja
        /// horizontalne crte radi preglednosti grafa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiKolicinaArtikala_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += UiKolicinaArtikala_KeyDown;
            artiklBindingSource.DataSource = Artikl.DohvatiSveArtikle();
            uiOutputGraf.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }

        /// <summary>
        /// Rukuje događajem pritiska tipke na tipkovnici. Ako je na tipkovnici
        /// pritisnuta tipka "F1" otvara formu uiHelp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiKolicinaArtikala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Pregled količina artikala po poslovnicama.\n\nOdabirom artikla iz padajućeg izbornika, " +
                    "na stupičastom grafu ispod, prikazuje se količina odabranog artikla po poslovnicama.\nKlikom na tipku ''NATRAG'' vraćate se na glavni izbornik.";
                frmHelp.Show();

            }
        }

        /// <summary>
        /// Rukuje događajem promjene vrijednosti u ComboBox kontroli. Briše sve
        /// sa Chart kontrole. Dohvaća sve dostupnosti odabranog artikla pomoću
        /// statičke metode DohvatiDostupnost. Crta graf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiInputArtikl_SelectedValueChanged(object sender, EventArgs e)
        {
            uiOutputGraf.Series["Kolicina"].Points.Clear();

            if (uiInputArtikl.SelectedItem != null)
            {
                List<Dostupnost> dostupnost = Dostupnost.DohvatiDostupnost(int.Parse(uiInputArtikl.SelectedValue.ToString()));
                CrtajGraf(dostupnost);
            }
        }

        /// <summary>
        /// Na grafu crta stupce s podacima koje dobiva iz liste "dostupnost".
        /// </summary>
        /// <param name="dostupnost">Lista dostupnosti odabranog artikla.</param>
        private void CrtajGraf(List<Dostupnost> dostupnost)
        {
            int brojac = 0;
            foreach (Dostupnost d in dostupnost)
            {
                Poslovnica poslovnica = Poslovnica.DohvatiPoslovnicu(d.Poslovnica_ID);

                uiOutputGraf.Series["Kolicina"].Points.AddXY(poslovnica.Naziv, d.Kolicina);
                uiOutputGraf.Series["Kolicina"].Points[brojac].Label = d.Kolicina.ToString();
                brojac++;

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

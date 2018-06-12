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
    public partial class UiVrstaArtikl : Form
    {
        /// <summary>
        /// Konstruktor forme uiVrstaArtikl
        /// </summary>
        public UiVrstaArtikl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja
        /// forme uiVrstaArtikl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiVrstaArtikl_Load(object sender, EventArgs e)
        {
            vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na gumbić uiActionDodaj.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionDodaj_Click(object sender, EventArgs e)
        {
            uiDodavanjeVrsteArtikla dodavanjeVrsteArtikla = new uiDodavanjeVrsteArtikla();
            dodavanjeVrsteArtikla.ShowDialog();
            vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na gumbić uiActionObrisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionObrisi_Click(object sender, EventArgs e)
        {
            VrstaArtikla vrstaArtiklaZaBrisanje = (VrstaArtikla)vrstaArtiklaBindingSource.Current;
            if (MessageBox.Show("Sigurno želite obrisati vrstu artikla " + vrstaArtiklaZaBrisanje.Naziv.ToString() + " ?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VrstaArtikla.ObrisiVrstuArtikla(vrstaArtiklaZaBrisanje);
            }
            vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na gumbić uiActionAzuriraj.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionAzuriraj_Click(object sender, EventArgs e)
        {
            VrstaArtikla vrstaArtiklaZaIzmjenu = (VrstaArtikla)vrstaArtiklaBindingSource.Current;
            uiDodavanjeVrsteArtikla formaDodavanjeVrsteArtikla = new uiDodavanjeVrsteArtikla(vrstaArtiklaZaIzmjenu);
            formaDodavanjeVrsteArtikla.ShowDialog();
            vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
        }
    }
}

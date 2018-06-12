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
        /// Metoda koja se poziva prilikom pritiska na gumbić Dodaj.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionDodaj_Click(object sender, EventArgs e)
        {
            vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
        }
    }
}

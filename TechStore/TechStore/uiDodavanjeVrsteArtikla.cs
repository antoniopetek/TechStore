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
    public partial class uiDodavanjeVrsteArtikla : Form
    {
        public VrstaArtikla VrstaArtiklaZaIzmjenu;
        /// <summary>
        /// Konstruktor forme uiDodavanjeVrsteArtikla
        /// </summary>
        public uiDodavanjeVrsteArtikla()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor forme uiDodavanjeVrsteArtikla koji kao argument
        /// prima vrstu artikla koju korisnik želi izmijeniti. U konstruktoru
        /// se izjednačava svojstvo VrstaArtiklaZaIzmjenu s proslijeđenim
        /// timom.
        /// </summary>
        /// <param name="zaIzmjenu"></param>
        public uiDodavanjeVrsteArtikla(VrstaArtikla zaIzmjenu)
        {
            InitializeComponent();
            VrstaArtiklaZaIzmjenu = zaIzmjenu;
            uiInputNaziv.Text = VrstaArtiklaZaIzmjenu.Naziv;
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska
        /// na gumbić uiActionOdustani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska
        /// na gumbić uiActionSpremi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionSpremi_Click(object sender, EventArgs e)
        {
            if (VrstaArtiklaZaIzmjenu == null)
            {
                if (uiInputNaziv.Text != "")
                {
                    VrstaArtikla novaVrstaArtikla = new VrstaArtikla
                    {
                        Naziv = uiInputNaziv.Text
                    };
                    VrstaArtikla.DodajVrstuArtikla(novaVrstaArtikla);
                    MessageBox.Show("Vrsta artikla uspješno dodana.", "Vrsta artikla dodana!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Niste unijeli sve podatke", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (uiInputNaziv.Text != "")
                {
                    VrstaArtikla.IzmjenaVrsteArtikla(VrstaArtiklaZaIzmjenu, uiInputNaziv.Text);
                    MessageBox.Show("Vrsta artikla usješno ažurirana", "Vrsta artikla ažurirana!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Unesi naziv vrste artikla!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            this.Close();

        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja 
        /// forme uiDodavanjeVrsteArtikla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiDodavanjeVrsteArtikla_Load(object sender, EventArgs e)
        {

        }
    }
}

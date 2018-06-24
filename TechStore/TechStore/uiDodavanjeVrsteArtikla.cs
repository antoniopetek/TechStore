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
    /// Parcijalna klasa uiDodavanjeVrsteArtikla
    /// </summary>
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
            try
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
            catch (Exception)
            {
                MessageBox.Show("Pogreška!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja 
        /// forme uiDodavanjeVrsteArtikla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiDodavanjeVrsteArtikla_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += UiDodavanjeVrsteArtikla_KeyDown;
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na tipku F11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiDodavanjeVrsteArtikla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi uiDodavanjeVrsteArtikla. Na formi možete vidjeti dva gumbića: Spremi i odustani te polje naziv";
                richTextBox.Text += " Ukoliko je korisnik na prijašnjoj formi pritisnuo gumbić Ažuriraj, na ovoj formi je naziv popunjen s nazivom vrste artikla koju želi ažurirati. Ukoliko ";
                richTextBox.Text += " je korisnik pritisnuo Dodaj onda je polje prazno i korisnik unosi sam naziv. Pritiskom na Spremi dodaje / ažurira vrstu artikla ako su podaci ispravno uneseni.";
                richTextBox.Text += " Pritiskom na gumbić Odustani korisnik odustaje od ažuriranja / dodavanja vrste oglasa te se ova forma gasi.";
                frmHelp.Show();

            }
        }
    }
}

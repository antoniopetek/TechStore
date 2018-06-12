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
    public partial class uiNoviArtikl : Form
    {
        
        private Artikl ArtiklZaIzmjenu;

        /// <summary>
        /// Konstruktor forme uiNoviArtikl. Kao parametar 
        /// prima artikl.
        /// </summary>
        /// <param name="proslijedeniArtikl"></param>
        public uiNoviArtikl(Artikl proslijedeniArtikl)
        {
            InitializeComponent();
            ArtiklZaIzmjenu = proslijedeniArtikl;
            uiInputID.Text = ArtiklZaIzmjenu.ID.ToString();
            uiInputNaziv.Text = ArtiklZaIzmjenu.Naziv;
            uiInputKratkiOpis.Text = ArtiklZaIzmjenu.Kratki_opis;
            uiInputSpecifikacije.Text = ArtiklZaIzmjenu.Specifikacija;
            uiInputCijena.Text = ArtiklZaIzmjenu.Cijena.ToString();
            
        }
        /// <summary>
        /// Konstruktor forme uiNoviArtikl
        /// </summary>
        public uiNoviArtikl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom
        /// učitavanja forme uiNoviArtikl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNoviArtikl_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmNoviArtikl_KeyDown;
            vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na tipku F11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNoviArtikl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Dodavanje artikla. Na formi možete vidjeti polje ID artikla koje je blokirano i jedino je popunjeno ukoliko je ";
                richTextBox.Text += "korinik pritisnuo Ažuriraj na formi uiArtikl. Ukoliko je korisnik pritisnuo Ažuriraj, sva ostala polja na ovoj formi su popunjena s podacima ";
                richTextBox.Text += "artikla kojeg želi ažurirati. Ako je korisnik pritisnuo Dodaj na prijašnjoj formi sva polja su prazna te korisnik unosi nove podatke za novi artikl.";
                richTextBox.Text += " Na formi se nalaze dva gumbića: Dodaj i Odustani. Pritiskom na odustani korisnik odbija dodati / ažurirati artikl te se forma gasi te se korisnik ";
                richTextBox.Text += "preusmjerava na prijašnju formu. Ukoliko je korisnik pritisnuo gumbić Dodaj te je unio pravilno sve podatke tada će biti dodan novi artikl u bazu podataka.";
                frmHelp.Show();

            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na gumbić Dodaj artikl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionDodajArtikl_Click(object sender, EventArgs e)
        {
            if (ArtiklZaIzmjenu==null)
            {
                if (uiInputNaziv.Text!="" && uiInputKratkiOpis.Text!="" && uiInputSpecifikacije.Text!="" && int.TryParse(uiInputCijena.Text,out int cijena) && uiInputVrstaArtikla.SelectedValue.ToString()!="")
                {
                    Artikl noviArtikl = new Artikl
                    {
                        Naziv = uiInputNaziv.Text,
                        Kratki_opis = uiInputKratkiOpis.Text,
                        Specifikacija = uiInputSpecifikacije.Text,
                        Cijena = cijena,
                        Vrsta_ID = int.Parse(uiInputVrstaArtikla.SelectedValue.ToString())
                    };
                    //Artikl.DodajArtikl(noviArtikl);
                    MessageBox.Show("Artikl je uspješno dodan.", "Artikl dodan!", MessageBoxButtons.OK);
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nisu uneseni svi podaci!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (uiInputNaziv.Text != "" && uiInputKratkiOpis.Text != "" && uiInputSpecifikacije.Text != "" && int.TryParse(uiInputCijena.Text, out int cijena) && uiInputVrstaArtikla.SelectedValue.ToString() != "")
                {
                    //Artikl.AzurirajArtikl(ArtiklZaIzmjenu, uiInputNaziv.Text, uiInputKratkiOpis.Text, uiInputSpecifikacije.Text, cijena,int.Parse(uiInputVrstaArtikla.SelectedValue.ToString()));
                    MessageBox.Show("Artikl je uspješno ažuriran.", "Artikl ažuriran!", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nisu uneseni svi podaci!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na gumbić Odustani.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

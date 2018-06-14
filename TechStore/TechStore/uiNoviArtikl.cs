using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
            if (ArtiklZaIzmjenu == null)
            {
                if (uiInputNaziv.Text != "" && uiInputKratkiOpis.Text != "" && uiInputSpecifikacije.Text != "" && int.TryParse(uiInputCijena.Text, out int cijena) && uiInputVrstaArtikla.SelectedValue.ToString() != "")
                {
                    Artikl noviArtikl = new Artikl
                    {
                        Naziv = uiInputNaziv.Text,
                        Kratki_opis = uiInputKratkiOpis.Text,
                        Specifikacija = uiInputSpecifikacije.Text,
                        Cijena = cijena,
                        Vrsta_ID = int.Parse(uiInputVrstaArtikla.SelectedValue.ToString())
                    };
                    if (noviArtikl.Vrsta_ID == 1)
                    {
                        var listaArtikala = Artikl.DohvatiKomponente("SELECT * FROM Artikl");
                    }
                    if (noviArtikl.Vrsta_ID == 2)
                    {
                        var listaArtikala = Artikl.DohvatiKomponente("SELECT * FROM Artikl WHERE Vrsta_ID !=2");
                    }
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

        /// <summary>
        /// Metoda koja kao parametar prima listu artikala te novi artikl.
        /// Za svaki artikl dodaje kompatibilnost s novim artiklom ako je 
        /// novi artikl kategorije Ostalo.
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <param name="noviArtikl"></param>
        public void OstaloKompatibilnost(List<Artikl> listaArtikala, Artikl noviArtikl)
        {
            foreach (var artikl in listaArtikala)
            {
                //DodajKompatibilnostPomoc(artikl, noviArtikl, true);
            }
        }

        /// <summary>
        /// Metoda koja kao parametar prima listu artikala te novi artikl.
        /// Dodaje kompatibilnost za svaki proizvod ako je novi objekt
        /// matična ploča.
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <param name="noviArtikl"></param>
        public void MaticnaPlocaKompatibilnost(List<Artikl> listaArtikala, Artikl noviArtikl)
        {
            double visinaNoviArtikl = 0;
            double sirinaNoviArtikl = 0;
            double duljinaNoviArtikl = 0;
            List<string> listaSpecifikacijaNovogArtikla = noviArtikl.Specifikacija.Split(',').ToList();
            visinaNoviArtikl = DohvatiVisinu(listaSpecifikacijaNovogArtikla);
            sirinaNoviArtikl = DohvatiSirinu(listaSpecifikacijaNovogArtikla);
            duljinaNoviArtikl = DohvatiSirinu(listaSpecifikacijaNovogArtikla);
            if (visinaNoviArtikl==-1)
            {
                MessageBox.Show("Novi artikl nema unesenu visinu!");
                return;
            }
            if (sirinaNoviArtikl==-1)
            {
                MessageBox.Show("Novi artikl nema unesenu širinu!");
                return;
            }
            if (sirinaNoviArtikl == -1)
            {
                MessageBox.Show("Novi artikl nema unesenu širinu!");
                return;
            }
            foreach (var trenutniArtikl in listaArtikala)
            {
                if (trenutniArtikl.Vrsta_ID == 1)
                {
                    //DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
                }
                else if (trenutniArtikl.Vrsta_ID == 11)
                {
                    double visinaTrenutniArtikl = 0;
                    double sirinaTrenutniArtikl = 0;
                    double duljinaTrenutniArtikl = 0;
                    List<string> listaSpecifikacijaTrenutnogArtikla = trenutniArtikl.Specifikacija.Split(',').ToList();
                    visinaTrenutniArtikl = DohvatiVisinu(listaSpecifikacijaTrenutnogArtikla);
                    sirinaNoviArtikl = DohvatiSirinu(listaSpecifikacijaTrenutnogArtikla);
                    duljinaNoviArtikl = DohvatiDuljinu(listaSpecifikacijaTrenutnogArtikla);
                    if ( sirinaNoviArtikl < sirinaTrenutniArtikl && visinaNoviArtikl < visinaTrenutniArtikl && duljinaNoviArtikl < duljinaTrenutniArtikl)
                    {
                        DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
                    }
                    else
                    {
                        DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, false);
                    }

                }
                else
                {
                    ProvjeraPoSvimSpecifikacijama(trenutniArtikl, noviArtikl, listaSpecifikacijaNovogArtikla);
                }
            }
        }

        /// <summary>
        /// Metoda koja kao parametar prima listu artikala te novi artikl.
        /// Dodaje kompatibilnost novog proizvoda s ostalim proizvodima ako je
        /// novi proizvod grafička kartica.
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <param name="noviArtikl"></param>
        public void GrafickaKarticaKompatibilnost(List<Artikl> listaArtikala, Artikl noviArtikl)
        {
            List<string> listaSpecifikacijaNovogArtikla = noviArtikl.Specifikacija.Split(',').ToList();
            foreach (var trenutniArtikl in listaArtikala)
            {
                if (trenutniArtikl.Vrsta_ID == 2 || trenutniArtikl.Vrsta_ID == 8)
                {
                    ProvjeraPoSvimSpecifikacijama(trenutniArtikl, noviArtikl, listaSpecifikacijaNovogArtikla);
                }
                else
                {
                    DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
                }
            }
        }

        /// <summary>
        /// Metoda koja kao parametar prima listu artikala te novi artikl.
        /// Dodaje kompatibilnost novog proizvoda s ostalim proizvodima ako je 
        /// novi proizvod procesor.
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <param name="noviArtikl"></param>
        public void ProcesorKompatibilnost(List<Artikl> listaArtikala, Artikl noviArtikl)
        {
            List<string> listaSpecifikacijaNovogArtikla = noviArtikl.Specifikacija.Split(',').ToList();
            foreach (var trenutniArtikl in listaArtikala)
            {
                if (trenutniArtikl.Vrsta_ID==2)
                {
                    ProvjeraPoSvimSpecifikacijama(trenutniArtikl, noviArtikl, listaSpecifikacijaNovogArtikla);
                }
                else
                {
                    DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
                }
            }
        }

        /// <summary>
        /// Metoda koja kao parametar prima listu artikala te novi artikl.
        /// Dodaje kompatibilnost novog proizvoda s ostalim proizvodima ako je 
        /// novi proizvod RAM.
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <param name="noviArtikl"></param>
        public void RAMKompatibilnost(List<Artikl> listaArtikala, Artikl noviArtikl) {
            List<string> listaSpecifikacijaNovogArtikla = noviArtikl.Specifikacija.Split(',').ToList();
            foreach (var trenutniArtikl in listaArtikala)
            {
                if (trenutniArtikl.Vrsta_ID==2)
                {
                    ProvjeraPoSvimSpecifikacijama(trenutniArtikl, noviArtikl, listaSpecifikacijaNovogArtikla);
                }
                else
                {
                    DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
                }
            }
        }

        /// <summary>
        /// Metoda koja kao parametar prima listu artikala te novi artikl.
        /// Dodaje kompatibilnost novog proizvoda s ostalim proizvodima ako je 
        /// novi proizvod SSD.
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <param name="noviArtikl"></param>
        public void SSDKompatibilnost(List<Artikl> listaArtikala, Artikl noviArtikl) {
            List<string> listaSpecifikacijaNovogArtikla = noviArtikl.Specifikacija.Split(',').ToList();
            foreach (var trenutniArtikl in listaArtikala)
            {
                if (trenutniArtikl.Vrsta_ID==2)
                {
                    ProvjeraPoSvimSpecifikacijama(trenutniArtikl, noviArtikl, listaSpecifikacijaNovogArtikla);
                }
                else
                {
                    DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
                }
            }
        }

        /// <summary>
        /// Metoda koja kao parametar prima listu artikala te novi artikl.
        /// Dodaje kompatibilnost novog proizvoda s ostalim proizvodima ako je 
        /// novi proizvod HDD.
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <param name="noviArtikl"></param>
        public void HDDKompatibilnost(List<Artikl> listaArtikala, Artikl noviArtikl) {
            List<string> listaSpecifikacijaNovogArtikla = noviArtikl.Specifikacija.Split(',').ToList();
            foreach (var trenutniArtikl in listaArtikala)
            {
                if (trenutniArtikl.Vrsta_ID==2)
                {
                    ProvjeraPoSvimSpecifikacijama(trenutniArtikl, noviArtikl, listaSpecifikacijaNovogArtikla);
                }
                else
                {
                    DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
                }
            }
        }

        /// <summary>
        /// Metoda koja kao parametar prima listu artikala te novi artikl.
        /// Dodaje kompatibilnost novog proizvoda s ostalim proizvodima ako je 
        /// novi proizvod napajanje.
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <param name="noviArtikl"></param>
        public void NapajanjeKompatibilnost(List<Artikl> listaArtikala, Artikl noviArtikl) {
            List<string> listaSpecifikacijaNovogArtikla = noviArtikl.Specifikacija.Split(',').ToList();
            foreach (var trenutniArtikl in listaArtikala)
            {
                if (trenutniArtikl.Vrsta_ID==4 || trenutniArtikl.Vrsta_ID==2 || trenutniArtikl.Vrsta_ID==3)
                {
                    ProvjeraPoSvimSpecifikacijama(trenutniArtikl, noviArtikl, listaSpecifikacijaNovogArtikla);
                }
                else if (trenutniArtikl.Vrsta_ID==11)
                {

                }
                else
                {
                    DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
                }
            }
        }

        /// <summary>
        /// Metoda koja kao parametar prima listu artikala te novi artikl.
        /// Dodaje kompatibilnost novog proizvoda s ostalim proizvodima ako je 
        /// novi proizvod hladnjak.
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <param name="noviArtikl"></param>
        public void HladnjakKompatibilnost(List<Artikl> listaArtikala, Artikl noviArtikl) {
            List<string> listaSpecifikacijaNovogArtikla = noviArtikl.Specifikacija.Split(',').ToList();
            foreach (var trenutniArtikl in listaArtikala)
            {
                if (trenutniArtikl.Vrsta_ID==4 || trenutniArtikl.Vrsta_ID==2)
                {
                    ProvjeraPoSvimSpecifikacijama(trenutniArtikl, noviArtikl, listaSpecifikacijaNovogArtikla);
                }
                else
                {
                    DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
                }

            }
        }

        /// <summary>
        /// Metoda koja kao parametar prima listu artikala te novi artikl.
        /// Dodaje kompatibilnost novog proizvoda s ostalim proizvodima ako je 
        /// novi proizvod zvučna kartica.
        /// </summary>
        /// <param name="listaArtikala"></param>
        /// <param name="noviArtikl"></param>
        public void ZvucnaKarticaKompatibilnost(List<Artikl> listaArtikala,Artikl noviArtikl)
        {
            List<string> listaSpecifikacijaNovogArtikla = noviArtikl.Specifikacija.Split(',').ToList();
            foreach (var trenutniArtikl in listaArtikala)
            {
                if (trenutniArtikl.Vrsta_ID==2)
                {
                    ProvjeraPoSvimSpecifikacijama(trenutniArtikl, noviArtikl, listaSpecifikacijaNovogArtikla);
                }
                else
                {
                    DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
                }
            }
        }

        /// <summary>
        /// Metoda koja služi za pozivanje metode DodajKompatibilnost u klasi Kompatibilnost.
        /// </summary>
        /// <param name="trenutniArtikl"></param>
        /// <param name="noviArtikl"></param>
        /// <param name="kompatibilni"></param>
        public void DodajKompatibilnostPomoc(Artikl trenutniArtikl, Artikl noviArtikl, bool kompatibilni)
        {
            Kompatibilnost kompatibilnost = new Kompatibilnost
            {
                Komponenta1 = noviArtikl.ID,
                Komponenta2 = trenutniArtikl.ID,
                Kompatibilni = true
            };
            Kompatibilnost.DodajKompatibilnost(kompatibilnost);
        }

        /// <summary>
        /// Metoda koja provjerava postoji li kompatibilnost između artikala.
        /// </summary>
        /// <param name="trenutniArtikl"></param>
        /// <param name="noviArtikl"></param>
        /// <param name="listaSpecifikacijaNovogArtikla"></param>
        public void ProvjeraPoSvimSpecifikacijama(Artikl trenutniArtikl, Artikl noviArtikl, List<string> listaSpecifikacijaNovogArtikla)
        {
            List<string> listaSpecifikacijaTrenutnogArtikla = trenutniArtikl.Specifikacija.Split(',').ToList();
            if (listaSpecifikacijaNovogArtikla.Intersect(listaSpecifikacijaTrenutnogArtikla).Any())
            {
                DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, true);
            }
            else
            {
                DodajKompatibilnostPomoc(trenutniArtikl, noviArtikl, false);
            }
        }


        /// <summary>
        /// Pomoćna metoda koja vraća visinu komponenta ako postoji.
        /// Ako visina komponente ne postoji vraća -1.
        /// </summary>
        /// <param name="listaStringova">Lista stringova </param>
        /// <returns></returns>
        public double DohvatiVisinu(List<string> listaStringova) {
            double visina = 0;
            bool nadeno = false;
            foreach (var specifikacija in listaStringova)
            {
                if (specifikacija.Contains("Visina"))
                {
                    visina= double.Parse(specifikacija.Substring(specifikacija.LastIndexOf(':') + 1), CultureInfo.InvariantCulture);
                    nadeno = true;
                }

            }
            if (nadeno)
            {
                return visina;
            }
            return -1;
        }

   
        /// <summary>
        /// Pomoćna metoda koja vraća širinu komponente ako postoji.
        /// Ako širina komponente ne postoji vraća -1.
        /// </summary>
        /// <param name="listaStringova"></param>
        /// <returns></returns>
        public double DohvatiSirinu(List<string> listaStringova) {
            double sirina = 0;
            bool nadeno = false;
            foreach (var spec in listaStringova)
            {
                if (spec.Contains("Sirina:"))
                {
                    sirina= double.Parse(spec.Substring(spec.LastIndexOf(':') + 1), CultureInfo.InvariantCulture);
                    nadeno = true;
                }
            }
            if (nadeno)
            {
                return sirina;
            }
            return -1;
        }

        /// <summary>
        /// Pomoćna metoda koja vraća duljinu komponenta ako postoji.
        /// Ako duljina komponente ne postoji vraća -1.
        /// </summary>
        /// <param name="listaStringova"></param>
        /// <returns></returns>
        public double DohvatiDuljinu(List<string> listaStringova) {
            double duljina = 0;
            bool nadeno = false;
            foreach (var spec in listaStringova)
            {
                if (spec.Contains("Duljina:"))
                {
                    duljina = double.Parse(spec.Substring(spec.LastIndexOf(':') + 1), CultureInfo.InvariantCulture);
                    nadeno = true;
                }
            }
            if (nadeno)
            {
                return duljina;
            }
            return -1;
        }
    }
}

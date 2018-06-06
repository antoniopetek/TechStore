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
    public partial class uiKonfiguracija : Form
    {
        #region Svojstva
        public List<Artikl> izabraneKomponente = new List<Artikl>();
        double odabranaCijena { get; set; }
        double najvisaCijena { get; set; }
        #endregion

        #region KonstruktorILoad
        /// <summary>
        /// Konstruktor forme uiKonfiguracija.
        /// </summary>
        public uiKonfiguracija()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rukuje događajem pokretanja forme. Puni vrstaArtiklaBindingSource koji se
        /// koristi u DataGridView kontroli. U listu izradeneKomponente tipa Artikl 
        /// 10 elemenata postavljena na null. Kod DataGridView kontrole za izvor podataka postavlja
        /// listu. Osvježava matične ploče u ComboBox kontroli.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiKonfiguracija_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyDown += uiNoviArtikl_KeyDown;
            vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
            PripremiListu();
            artiklBindingSource.DataSource = izabraneKomponente;
            OsvjeziMaticne();
        }
        #endregion

        #region PomocneMetode
        /// <summary>
        /// Rukuje događajem klika na tipku uiActionIspisi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionIspisi_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Rukuje događajem pritiska tipke na tipkovnici. Ako je na tipkovnici
        /// pritisnuta tipka "F1" otvara formu uiHelp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiNoviArtikl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Izrada konfiguracije.\n\nOdabirom komponenata iz padajućih izbornika, korisnik aplikacije može izrađivati konfiguraciju " +
                    "računala. Odabirom svake komponente, u polju za ispis prikazuju mu se osnovne informacije o odabranim komponentama (ID, Naziv, Kratki opis, Cijena i Vrsta). Istovremeno " +
                    "prikazuje se ukupna cijena odabranih komponenata.";
                frmHelp.Show();

            }
        }

        /// <summary>
        /// Dohvaća sve ComboBox kontrole na formi te na temelju proslijeđenog broja
        /// koji predstavlja indeks, čisti sve ComboBox kontrole do tog indeksa
        /// i onemogućuje ih.
        /// </summary>
        /// <param name="broj">Broj koji predstavlja indeks ComboBox kontrole.</param>
        private void PripremiComboBoxeve(int broj)
        {
            List<ComboBox> comboBoxevi = Controls.OfType<ComboBox>().Reverse().ToList();
            int brojac = 0;
            foreach (var combo in comboBoxevi)
            {
                if (brojac > broj)
                {
                    combo.Text = "";
                    combo.Items.Clear();
                    combo.Enabled = false;
                }
                brojac++;
            }
            for (int i = broj + 1; i < izabraneKomponente.Count; i++)
            {
                izabraneKomponente[i] = null;
            }
        }

        /// <summary>
        /// Na temelju cijene odabrane komponente računa preporuke. Iterira kroz
        /// proslijeđenu listu tipa artikl te ako se artikl nalazi u intervalu
        /// +- 20% od najvise cijene, sprema ga u listu "preporuke", a u suprotnom
        /// ga sprema u listu "ostale". U proslijeđenu ComboBox kontrolu ispisuje
        /// prvo artikle iz liste preporuke, a zatim iz liste "ostale".
        /// </summary>
        /// <param name="artikli">Lista artikala koju treba ispisati u ComboBox kontroli prema preporuci.</param>
        /// <param name="comboBox">ComboBox kontrola u koju treba ispisati listu artikala.</param>
        private void RacunajPreporuke(List<Artikl> artikli, ComboBox comboBox)
        {
            List<Artikl> preporuke = new List<Artikl>();
            List<Artikl> ostale = new List<Artikl>();
            odabranaCijena = izabraneKomponente[0].Cijena;
            double postotak = odabranaCijena / najvisaCijena;

            comboBox.Items.Clear();
            foreach (Artikl artikl in artikli)
            {
                double interval = artikl.Cijena / artikli.Max(x => x.Cijena);
                if ((interval >= postotak - 0.2) && (interval <= postotak + 0.2))
                {
                    preporuke.Insert(0, artikl);
                }
                else
                {
                    ostale.Insert(0, artikl);
                }
            }

            foreach (Artikl artikl in preporuke.OrderByDescending(x => x.Cijena))
            {
                comboBox.Items.Add(artikl);
            }
            foreach (Artikl artikl in ostale.OrderByDescending(x => x.Cijena))
            {
                comboBox.Items.Add(artikl);
            }
        }

        /// <summary>
        /// U listi izrabraneKomponente dodaje 10 elemenata i postavlja ih na null.
        /// </summary>
        private void PripremiListu()
        {
            for (int i = 0; i < 10; i++)
            {
                izabraneKomponente.Add(null);
            }
        }

        /// <summary>
        /// Osvježava DataGridView kontrolu.
        /// </summary>
        private void OsvjeziDataGrid()
        {
            uiOutputKonfiguracija.Refresh();
        }

        /// <summary>
        /// Racuna ukupan iznos odabranih komponenata koji se nalaze u
        /// listi "izabraneKomponente" i taj ukupan iznos ispisuje u label kontroli.
        /// </summary>
        /// <param name="indeks"></param>
        private void RacunajIznos(int indeks)
        {
            double iznos = 0;
            for (int i = 0; i <= indeks; i++)
            {
                iznos += izabraneKomponente[i].Cijena;
            }
            uiOutputIznos.Text = "Ukupan iznos: " + iznos.ToString() + " kn";
        }

        /// <summary>
        /// Rukuje događajem klika na tipku uiActionNatrag. Zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region OsvjezavanjeComboBox-eva
        /// <summary>
        /// Dohvaća matične ploče uz pomoć statičke metode DohvatiKomponente,
        /// te ih prikazuje u ComboBox kontroli.
        /// </summary>
        private void OsvjeziMaticne()
        {
            string upit = "SELECT * FROM Artikl a WHERE a.Vrsta_ID = 2";
            List<Artikl> maticnePloce = Artikl.DohvatiKomponente(upit);

            foreach (Artikl maticna in maticnePloce.OrderBy(x => x.Cijena))
            {
                uiInputMaticna.Items.Add(maticna);
            }

            najvisaCijena = maticnePloce.Max(x => x.Cijena);
        }

        /// <summary>
        /// Dohvaća grafičke kartice uz pomoć statičke metode DohvatiKomponente,
        /// te ih prikazuje u ComboBox kontroli.
        /// </summary>
        private void OsvjeziGraficke()
        {
            string upit = "SELECT* From Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 3 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + " )) AND k.Kompatibilni = 1";
            List<Artikl> grafickeKartice = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(grafickeKartice, uiInputGraficka);
        }

        /// <summary>
        /// Dohvaća procesore uz pomoć statičke metode DohvatiKomponente,
        /// te ih prikazuje u ComboBox kontroli.
        /// </summary>
        private void OsvjeziProcesore()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 4 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT  SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 4 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> procesori = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(procesori, uiInputProcesor);
        }

        /// <summary>
        /// Dohvaća RAM uz pomoć statičke metode DohvatiKomponente,
        /// te ih prikazuje u ComboBox kontroli.
        /// </summary>
        private void OsvjeziRAM()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 5 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 5 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 5 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[2].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[2].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> ram = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(ram, uiInputRam);
        }

        /// <summary>
        /// Dohvaća SSD diskove uz pomoć statičke metode DohvatiKomponente,
        /// te ih prikazuje u ComboBox kontroli.
        /// </summary>
        private void OsvjeziSSD()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 6 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 6 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 6 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[2].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[2].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 6 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[3].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[3].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> ssd = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(ssd, uiInputSsd);
        }

        /// <summary>
        /// Dohvaća HDD diskove uz pomoć statičke metode DohvatiKomponente,
        /// te ih prikazuje u ComboBox kontroli.
        /// </summary>
        private void OsvjeziHDD()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 7 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 7 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 7 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[2].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[2].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 7 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[3].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[3].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 7 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[4].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[4].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> hdd = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(hdd, uiInputHdd);
        }

        /// <summary>
        /// Dohvaća napajanja uz pomoć statičke metode DohvatiKomponente,
        /// te ih prikazuje u ComboBox kontroli.
        /// </summary>
        private void OsvjeziNapajanje()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 8 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 8 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 8 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[2].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[2].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 8 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[3].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[3].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 8 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[4].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[4].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 8 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[5].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[5].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> napajanje = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(napajanje, uiInputNapajanje);
        }

        /// <summary>
        /// Dohvaća hladnjake uz pomoć statičke metode DohvatiKomponente,
        /// te ih prikazuje u ComboBox kontroli.
        /// </summary>
        private void OsvjeziHladnjak()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 9 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 9 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 9 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[2].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[2].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 9 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[3].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[3].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 9 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[4].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[4].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 9 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[5].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[5].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 9 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[6].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[6].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> hladnjak = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(hladnjak, uiInputHladnjak);
        }

        /// <summary>
        /// Dohvaća zvučne kartice uz pomoć statičke metode DohvatiKomponente,
        /// te ih prikazuje u ComboBox kontroli.
        /// </summary>
        private void OsvjeziZvucneKartice()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 10 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 10 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 10 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[2].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[2].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 10 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[3].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[3].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 10 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[4].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[4].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 10 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[5].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[5].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 10 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[6].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[6].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 10 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[7].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[7].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> zvucnaKartica = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(zvucnaKartica, uiInputZvucna);
        }

        /// <summary>
        /// Dohvaća kućišta uz pomoć statičke metode DohvatiKomponente,
        /// te ih prikazuje u ComboBox kontroli.
        /// </summary>
        private void OsvjeziKucista()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 11 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 11 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 11 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[2].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[2].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 11 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[3].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[3].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 11 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[4].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[4].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 11 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[5].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[5].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 11 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[6].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[6].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 11 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[7].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[7].ID + ")) AND k.Kompatibilni = 1" +
               "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 11 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[8].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[8].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> kuciste = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(kuciste, uiInputKuciste);
        }
        #endregion

        #region SelectedIndexChanged eventi
        /// <summary>
        /// U listu "izabraneKomponente" stavlja izabranu matičnu ploču. Osvježava
        /// DataGridView kontrolu. Omogućuje uiInputGraficka ComboBox kontrolu i 
        /// popunjava ju s grafičkim karticama. Računa ukupan iznos izabranih komponenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiInputMaticna_SelectedIndexChanged(object sender, EventArgs e)
        {      
            izabraneKomponente[0] = uiInputMaticna.SelectedItem as Artikl;
            PripremiComboBoxeve(0);
            OsvjeziDataGrid(); 
            uiInputGraficka.Enabled = true;
            OsvjeziGraficke();
            RacunajIznos(0);
        }

        /// <summary>
        /// U listu "izabraneKomponente" stavlja izabranu grafičku karticu. Osvježava
        /// DataGridView kontrolu. Omogućuje uiInputProcesor ComboBox kontrolu i 
        /// popunjava ju s procesorima. Računa ukupan iznos izabranih komponenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiInputGraficka_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[1] = uiInputGraficka.SelectedItem as Artikl;
            PripremiComboBoxeve(1);
            OsvjeziDataGrid();
            uiInputProcesor.Enabled = true;
            OsvjeziProcesore();
            RacunajIznos(1);
        }

        /// <summary>
        /// U listu "izabraneKomponente" stavlja izabran procesor. Osvježava
        /// DataGridView kontrolu. Omogućuje uiInputRam ComboBox kontrolu i 
        /// popunjava ju s RAM. Računa ukupan iznos izabranih komponenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiInputProcesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[2] = uiInputProcesor.SelectedItem as Artikl;
            PripremiComboBoxeve(2);
            OsvjeziDataGrid();
            uiInputRam.Enabled = true;
            OsvjeziRAM();
            RacunajIznos(2);
        }

        /// <summary>
        /// U listu "izabraneKomponente" stavlja izabranu RAM. Osvježava
        /// DataGridView kontrolu. Omogućuje uiInputSsd ComboBox kontrolu i 
        /// popunjava ju s SSD diskovima. Računa ukupan iznos izabranih komponenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiInputRam_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[3] = uiInputRam.SelectedItem as Artikl;
            PripremiComboBoxeve(3);
            OsvjeziDataGrid();
            uiInputSsd.Enabled = true;
            OsvjeziSSD();
            RacunajIznos(3);
        }

        /// <summary>
        /// U listu "izabraneKomponente" stavlja izabran SSD disk. Osvježava
        /// DataGridView kontrolu. Omogućuje uiInputHdd ComboBox kontrolu i 
        /// popunjava ju s HDD diskovima. Računa ukupan iznos izabranih komponenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiInputSsd_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[4] = uiInputSsd.SelectedItem as Artikl;
            PripremiComboBoxeve(4);
            OsvjeziDataGrid();
            uiInputHdd.Enabled = true;
            OsvjeziHDD();
            RacunajIznos(4);
        }

        /// <summary>
        /// U listu "izabraneKomponente" stavlja izabran HDD disk. Osvježava
        /// DataGridView kontrolu. Omogućuje uiInputNapajanje ComboBox kontrolu i 
        /// popunjava ju s napajanjima. Računa ukupan iznos izabranih komponenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiInputHdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[5] = uiInputHdd.SelectedItem as Artikl;
            PripremiComboBoxeve(5);
            OsvjeziDataGrid();
            uiInputNapajanje.Enabled = true;
            OsvjeziNapajanje();
            RacunajIznos(5);
        }

        /// <summary>
        /// U listu "izabraneKomponente" stavlja izabrano napajanje. Osvježava
        /// DataGridView kontrolu. Omogućuje uiInputHladnjak ComboBox kontrolu i 
        /// popunjava ju s hladnjacima. Računa ukupan iznos izabranih komponenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiInputNapajanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[6] = uiInputNapajanje.SelectedItem as Artikl;
            PripremiComboBoxeve(6);
            OsvjeziDataGrid();
            uiInputHladnjak.Enabled = true;
            OsvjeziHladnjak();
            RacunajIznos(6);
        }

        /// <summary>
        /// U listu "izabraneKomponente" stavlja izabran hladnjak. Osvježava
        /// DataGridView kontrolu. Omogućuje uiInputZvucna ComboBox kontrolu i 
        /// popunjava ju sa zvučnim karticama. Računa ukupan iznos izabranih komponenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiInputHladnjak_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[7] = uiInputHladnjak.SelectedItem as Artikl;
            PripremiComboBoxeve(7);
            OsvjeziDataGrid();
            uiInputZvucna.Enabled = true;
            OsvjeziZvucneKartice();
            RacunajIznos(7);
        }

        /// <summary>
        /// U listu "izabraneKomponente" stavlja izabranu zvučnu karticu. Osvježava
        /// DataGridView kontrolu. Omogućuje uiInputKuciste ComboBox kontrolu i 
        /// popunjava ju s kućištima. Računa ukupan iznos izabranih komponenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiInputZvucna_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[8] = uiInputZvucna.SelectedItem as Artikl;
            PripremiComboBoxeve(8);
            OsvjeziDataGrid();
            uiInputKuciste.Enabled = true;
            OsvjeziKucista();
            RacunajIznos(8);
        }

        /// <summary>
        /// U listu "izabraneKomponente" stavlja izabrano kućište. Osvježava
        /// DataGridView kontrolu. Računa ukupan iznos izabranih komponenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiInputKuciste_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[9] = uiInputKuciste.SelectedItem as Artikl;
            OsvjeziDataGrid();
            RacunajIznos(9);
        }
        #endregion
    
    }
    
}

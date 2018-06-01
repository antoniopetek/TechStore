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
        public uiKonfiguracija()
        {
            InitializeComponent();
        }
        private void FrmKonfiguracija_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyDown += FrmNoviArtikl_KeyDown;
            vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
            PripremiListu();
            artiklBindingSource.DataSource = izabraneKomponente;
            OsvjeziMaticne();
        }
        #endregion

        #region PomocneMetode
        private void UiActionIzdajRacun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Račun uspješno izdan.", "IZDANO", MessageBoxButtons.OK);
        }
        private void FrmNoviArtikl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Dodavanje artikla.";
                frmHelp.Show();

            }
        }
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
                if ((interval >= postotak - 0.15) && (interval <= postotak + 0.15))
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
        private void PripremiListu()
        {
            for (int i = 0; i < 10; i++)
            {
                izabraneKomponente.Add(null);
            }
        }
        private void OsvjeziDataGrid()
        {
            uiOutputKonfiguracija.Refresh();
        }
        private void RacunajIznos(int indeks)
        {
            double iznos = 0;
            for (int i = 0; i <= indeks; i++)
            {
                iznos += izabraneKomponente[i].Cijena;
            }
            uiOutputIznos.Text = "Ukupan iznos: " + iznos.ToString() + " kn";
        }
        #endregion

        #region OsvjezavanjeComboBox-eva
        private void OsvjeziMaticne()
        {
            List<Artikl> maticnePloce = null;
            using(TechStoreEntities db = new TechStoreEntities())
            {
                maticnePloce = (from a in db.Artikl where a.Vrsta_ID == 2 select a).ToList();
            }

            foreach (Artikl maticna in maticnePloce.OrderBy(x => x.Cijena))
            {
                uiInputMaticna.Items.Add(maticna);
            }

            najvisaCijena = maticnePloce.Max(x => x.Cijena);
        }
        private void OsvjeziGraficke()
        {
            string upit = "SELECT* From Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 3 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + " )) AND k.Kompatibilni = 1";
            List<Artikl> grafickeKartice = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(grafickeKartice, uiInputGraficka);
        }
        private void OsvjeziProcesore()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 4 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT  SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 4 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> procesori = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(procesori, uiInputProcesor);
        }
        private void OsvjeziRAM()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 5 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 5 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 5 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[2].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[2].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> ram = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(ram, uiInputRam);
        }
        private void OsvjeziSSD()
        {
            string upit = "SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 6 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[0].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[0].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.Vrsta_ID = 6 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[1].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[1].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 6 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[2].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[2].ID + ")) AND k.Kompatibilni = 1" +
                "INTERSECT SELECT a.ID, a.Naziv, a.Kratki_opis, a.Specifikacija, a.Cijena, a.Vrsta_ID FROM Artikl a, Kompatibilnost k WHERE a.VRSTA_ID = 6 AND ((a.ID = k.Komponenta2 AND k.Komponenta1 = " + izabraneKomponente[3].ID + ") OR (a.ID = k.Komponenta1 AND k.Komponenta2 = " + izabraneKomponente[3].ID + ")) AND k.Kompatibilni = 1";
            List<Artikl> ssd = Artikl.DohvatiKomponente(upit);
            RacunajPreporuke(ssd, uiInputSsd);
        }
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
        private void uiInputMaticna_SelectedIndexChanged(object sender, EventArgs e)
        {      
            izabraneKomponente[0] = uiInputMaticna.SelectedItem as Artikl;
            PripremiComboBoxeve(0);
            OsvjeziDataGrid(); 
            uiInputGraficka.Enabled = true;
            OsvjeziGraficke();
            RacunajIznos(0);
        }
        private void uiInputGraficka_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[1] = uiInputGraficka.SelectedItem as Artikl;
            PripremiComboBoxeve(1);
            OsvjeziDataGrid();
            uiInputProcesor.Enabled = true;
            OsvjeziProcesore();
            RacunajIznos(1);
        }
        private void uiInputProcesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[2] = uiInputProcesor.SelectedItem as Artikl;
            PripremiComboBoxeve(2);
            OsvjeziDataGrid();
            uiInputRam.Enabled = true;
            OsvjeziRAM();
            RacunajIznos(2);
        }
        private void uiInputRam_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[3] = uiInputRam.SelectedItem as Artikl;
            PripremiComboBoxeve(3);
            OsvjeziDataGrid();
            uiInputSsd.Enabled = true;
            OsvjeziSSD();
            RacunajIznos(3);
        }
        private void uiInputSsd_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[4] = uiInputSsd.SelectedItem as Artikl;
            PripremiComboBoxeve(4);
            OsvjeziDataGrid();
            uiInputHdd.Enabled = true;
            OsvjeziHDD();
            RacunajIznos(4);
        }
        private void uiInputHdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[5] = uiInputHdd.SelectedItem as Artikl;
            PripremiComboBoxeve(5);
            OsvjeziDataGrid();
            uiInputNapajanje.Enabled = true;
            OsvjeziNapajanje();
            RacunajIznos(5);
        }
        private void uiInputNapajanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[6] = uiInputNapajanje.SelectedItem as Artikl;
            PripremiComboBoxeve(6);
            OsvjeziDataGrid();
            uiInputHladnjak.Enabled = true;
            OsvjeziHladnjak();
            RacunajIznos(6);
        }
        private void uiInputHladnjak_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[7] = uiInputHladnjak.SelectedItem as Artikl;
            PripremiComboBoxeve(7);
            OsvjeziDataGrid();
            uiInputZvucna.Enabled = true;
            OsvjeziZvucneKartice();
            RacunajIznos(7);
        }
        private void uiInputZvucna_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[8] = uiInputZvucna.SelectedItem as Artikl;
            PripremiComboBoxeve(8);
            OsvjeziDataGrid();
            uiInputKuciste.Enabled = true;
            OsvjeziKucista();
            RacunajIznos(8);
        }
        private void uiInputKuciste_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[9] = uiInputKuciste.SelectedItem as Artikl;
            OsvjeziDataGrid();
            RacunajIznos(9);
        }
        #endregion       
    }
    
}

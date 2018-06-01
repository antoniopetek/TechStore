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
        public List<Artikl> izabraneKomponente = new List<Artikl>();
        double odabranaCijena { get; set; }
        double najvisaCijena { get; set; }

        public uiKonfiguracija()
        {
            InitializeComponent();
        }

        private void UiActionIzdajRacun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Račun uspješno izdan.", "IZDANO", MessageBoxButtons.OK);
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

        private void uiInputMaticna_SelectedIndexChanged(object sender, EventArgs e)
        {      
            izabraneKomponente[0] = uiInputMaticna.SelectedItem as Artikl;
            PripremiComboBoxeve(0);
            OsvjeziDataGrid(); 
            uiInputGraficka.Enabled = true;
            OsvjeziGraficke();
            
        }

        private void uiInputGraficka_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraneKomponente[1] = uiInputGraficka.SelectedItem as Artikl;
            OsvjeziDataGrid();
            uiInputProcesor.Enabled = true;
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

            uiInputGraficka.Items.Clear();
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
    }
    
}

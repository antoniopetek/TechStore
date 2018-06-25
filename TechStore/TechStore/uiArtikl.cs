using Komponente;
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
    /// Parcijalna klasa uiArtikl.
    /// </summary>
    public partial class UiArtikl : Form
    {
        Pretraga pretraga = new Pretraga();
        /// <summary>
        /// Konstruktor forme uiArtikl
        /// </summary>
        public UiArtikl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja se poziva na klik gumbića
        /// uiActionDodajArtikl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionDodajArtikl_Click(object sender, EventArgs e)
        {
            uiNoviArtikl noviArtikl = new uiNoviArtikl();
            noviArtikl.ShowDialog();
            try
            {
                artiklBindingSource.DataSource = Artikl.DohvatiSveArtikle();
                vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
            }
            catch (Exception)
            {
                MessageBox.Show("Pogreška!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja
        /// forme uiArtikl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmArtikl_Load(object sender, EventArgs e)
        {
            if (Zaposlenik.PrijavljeniZaposlenik.Tip_ID !=1)
            {
                uiActionAzurirajArtikl.Enabled = false;
                uiActionDodajArtikl.Enabled = false;
                uiActionObrisiArtikl.Enabled = false;
            }
            this.KeyPreview = true;
            this.KeyDown += FrmArtikl_KeyDown;
            OsvjeziPrikaze();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na tipku F11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmArtikl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Artikl. Na formi možete vidjeti tri gumbića: Ažuriraj, Obriši i Dodaj te popis svih artikala.";
                richTextBox.Text += "Pritiskom na gumbić Dodaj korisniku se otvara nova forma. Ukoliko pritisne na gumbić Ažuriraj korisniku se otvara nova forma s već popunjenim podacima";
                richTextBox.Text += "Pritiskom na gumbić Obriši korisnik može obrisati odabrani artikl.";
                frmHelp.Show();

            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na gumbić Obriši
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Artikl artiklZaBrisanje = null;
            try
            {
                artiklZaBrisanje = (Artikl)artiklBindingSource.Current;
            }
            catch (Exception)
            {
                MessageBox.Show("Pogreška!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (MessageBox.Show("Sigurno želite obrisati artikl " + artiklZaBrisanje.Naziv + " i sve stavke, kompatibilnosti i dostupnosti vezane uz artikl?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var listaKompatibilnosti = Kompatibilnost.DohvatiKompatibilnosti("SELECT * FROM Kompatibilnost WHERE Komponenta1=" + artiklZaBrisanje.ID+ " OR Komponenta2=" + artiklZaBrisanje.ID);
                    foreach (var kompatibilnost in listaKompatibilnosti)
                    {
                        Kompatibilnost.ObrisiKompatibilnost(kompatibilnost);
                    }
                    Artikl.ObrisiArtikl(artiklZaBrisanje);
                }
                catch (Exception)
                {
                    MessageBox.Show("Pogreška!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                MessageBox.Show("Artikl je uspješno obrisan!", "Artikl obrisan", MessageBoxButtons.OK);
                OsvjeziPrikaze();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na gumbić Ažuriraj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionAzurirajArtikl_Click(object sender, EventArgs e)
        {
            try
            {
                Artikl artiklZaAzuriranje = (Artikl)artiklBindingSource.Current;
                uiNoviArtikl formaNoviArtikl = new uiNoviArtikl(artiklZaAzuriranje);
                formaNoviArtikl.ShowDialog();
            }
            catch (Exception)
            {
                
            }
            OsvjeziPrikaze();
        }

        /// <summary>
        /// Metoda koja služi za osvježavanje prikaza na datagridview - u.
        /// </summary>
        private void OsvjeziPrikaze()
        {
            try
            {
                artiklBindingSource.DataSource = Artikl.DohvatiSveArtikle();
                vrstaArtiklaBindingSource.DataSource = VrstaArtikla.DohvatiVrsteArtikala();
            }
            catch (Exception)
            {
                MessageBox.Show("Pogreška!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Metoda koja se poziva kod pritiska na gumbić Natrag.
        /// Metoda zatvara formu uiArtikl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom promjene sadržaja polja uiInputPretraga.
        /// Metoda osvježava prikaz dataGridView - a te se pretražuje datagridView
        /// prema unesenom tekstu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiInputPretraga_TextChanged(object sender, EventArgs e)
        {
            OsvjeziPrikaze();
            pretraga.Pretrazi(uiOutputPodaciArtikli, uiInputPretraga.Text, 1);
        }
    }
}

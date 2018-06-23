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
    /// Parcijalna klasa UiPregledNarudzbi.
    /// </summary>
    public partial class UiPregledNarudzbi : Form
    {
        /// <summary>
        /// Konstruktor forme uiPregledNarudzbi
        /// </summary>
        public UiPregledNarudzbi()
        {
            InitializeComponent();
            artiklBindingSource.DataSource = Artikl.DohvatiSveArtikle();
            vrstaDokumentaBindingSource.DataSource = VrstaDokumenta.DohvatiVrsteDokumenta();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritisna na gumbić Natrag.
        /// Metoda zatvra formu uiPregledNarudzbi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme uiPregledNarudzbi.
        /// Metoda poziva prikaz dokumenata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiPregledNarudzbi_Load(object sender, EventArgs e)
        {
            dokumentBindingSource.DataSource = Dokument.DohvatiDokumente();
            this.KeyPreview = true;
            this.KeyDown += UiPregledNarudzbi_KeyDown;
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska na tipku F11.
        /// Metoda prikazuje formu uiHelp s detaljnim uputama o radu
        /// forme na kojoj je pritisnuta tipka F1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiPregledNarudzbi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Na formi Pregled narudžbi možete vidjeti popis narudžbi. Može se vidjeti ID narudžbe te odabirom neke narudžbe možete vidjeti sve stavke te narudžbe.";
                richTextBox.Text += "Svaka stavka narudžbe sadrži naziv artikla te naručenu količinu tog artikla. Pritiskom na gumbić Natrag vraćate se na glavni izbornik aplikacije";
                frmHelp.Show();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom promjene dokumenta u datagridview - u
        /// uiOutputNaruzdbe. Metoda prikazuje stavke dokumenta odabranog
        /// dokumenta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiOutputNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            Dokument trenutniDokument = (Dokument)dokumentBindingSource.Current;
            if (trenutniDokument!=null)
            {
                stavkaDokumentaBindingSource.DataSource = StavkaDokumenta.DohvatiStavkeDokumenta(trenutniDokument);
            }
        }
    }
}

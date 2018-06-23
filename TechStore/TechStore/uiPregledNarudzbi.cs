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

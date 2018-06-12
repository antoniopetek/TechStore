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
    public partial class UiNabava : Form
    {
        private int artiklNabavaId;
        private Poslovnica poslovnicaNabava;
        private string artiklNabavaNaziv;

        /// <summary>
        /// Konstruktor forme uiNabava
        /// </summary>
        public UiNabava()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Konstruktor forme uiNabava. Kao argumente prima artikl
        /// koji želimo naručiti te poslovnicu za koju želimo naručiti
        /// artikl.
        /// </summary>
        public UiNabava(int artikl, Poslovnica poslovnica, string artiklNaziv)
        {
            InitializeComponent();
            artiklNabavaId = artikl;
            poslovnicaNabava = poslovnica;
            artiklNabavaNaziv = artiklNaziv;
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme uiNabava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNabava_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmNabava_KeyDown;
            if (poslovnicaNabava == null || artiklNabavaId == 0 || artiklNabavaNaziv == "")
            {
                artiklBindingSource.DataSource = Artikl.DohvatiSveArtikle();
                poslovnicaBindingSource.DataSource = Poslovnica.DohvatiPoslovnice();
            }
            else
            {
                uiInputArtikl.Text = artiklNabavaNaziv.ToString();
                uiInputPoslovnica.Text = poslovnicaNabava.Naziv;
                uiInputArtikl.Enabled = false;
                uiInputPoslovnica.Enabled = false;
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom pritiska tipke F11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNabava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                uiHelp frmHelp = new uiHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Nabava. Na formi Nabava možete vidjeti";
                frmHelp.Show();

            }
        }

        /// <summary>
        /// Metoda koja se poziva kod pritiska na gumbić Odustani.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda koja se poziva kod pristika na gumbić Spremi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionSpremi_Click(object sender, EventArgs e)
        {
            if (poslovnicaNabava == null || artiklNabavaId == 0 || artiklNabavaNaziv == "")
            {
                if (IspravnostKolicine())
                {
                    Poslovnica poslovnicaIzComboBoxa = (Poslovnica)poslovnicaBindingSource.Current;
                    Dostupnost postojeca = Dostupnost.DohvatiDostupnost(poslovnicaIzComboBoxa, int.Parse(uiInputArtikl.SelectedValue.ToString()));
                    if (postojeca==null)
                    {
                        Dostupnost novaDostupnost = new Dostupnost
                        {
                            Artikl_ID = int.Parse(uiInputArtikl.SelectedValue.ToString()),
                            Poslovnica_ID = int.Parse(uiInputPoslovnica.SelectedValue.ToString()),
                            Kolicina = int.Parse(uiInputKolicina.Text)
                        };
                        Dostupnost.DodajDostupnost(novaDostupnost);
                        MessageBox.Show("Uspješno je naručen proizvod za poslovnicu !", "Naručen artikl!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Dostupnost.IzmjenaDostupnosti(postojeca, int.Parse(uiInputKolicina.Text));
                        MessageBox.Show("Uspješno je naručen proizvod za poslovnicu !", "Naručen artikl!", MessageBoxButtons.OK);
                    }
                    
                    this.Close();
                }
                else
                {
                    
                    MessageBox.Show("Unesite pozitivan broj za količinu", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (IspravnostKolicine())
                {
                    Dostupnost dostupnost = Dostupnost.DohvatiDostupnost(poslovnicaNabava, artiklNabavaId);
                    Dostupnost.IzmjenaDostupnosti(dostupnost, int.Parse(uiInputKolicina.Text));
                    MessageBox.Show("Uspješno je naručen proizvod " + artiklNabavaNaziv + " za poslovnicu " + poslovnicaNabava.Naziv + "!", "Naručen artikl!", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unesite pozitivan broj za količinu", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        /// <summary>
        /// Metoda koja provjerava ispravnost unesene količine.
        /// </summary>
        /// <returns></returns>
        private bool IspravnostKolicine()
        {
            if (int.TryParse(uiInputKolicina.Text, out int kolicina))
            {
                if (kolicina > 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}

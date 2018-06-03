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
    public partial class uiIzbornik : Form
    {
        public uiIzbornik()
        {
            InitializeComponent();
        }

        private void UiActionIzlaz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste se odjavili.", "ODJAVA", MessageBoxButtons.OK);
            Close();
        }

        private void UiActionZaposlenici_Click(object sender, EventArgs e)
        {
            uiZaposlenici formaZaposlenici = new uiZaposlenici();
            Hide();
            formaZaposlenici.ShowDialog();
            Show();
        }

        private void UiActionDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            uiPoslovnice formaPoslovnica = new uiPoslovnice();
            Hide();
            formaPoslovnica.ShowDialog();
            Show();
        }

        private void UiActionPregledArtikala_Click(object sender, EventArgs e)
        {
            uiKolicinaArtikala formaKolicina = new uiKolicinaArtikala();
            Hide();
            formaKolicina.ShowDialog();   
            Show();
        }

        private void UiActionDodajArtikl_Click(object sender, EventArgs e)
        {
            FrmArtikl formaArtikli = new FrmArtikl();
            formaArtikli.Show();
        }

        private void FrmIzbornik_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmIzbornik_KeyDown;
            PripremiFunkcionalnosti();
        }

        private void FrmIzbornik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Izbornik.\n\nNa formi Izbornik možete vidjeti 7 tipki: ''Zaposlenici'', ''Poslovnice'', ''Pregled artikala po poslovnicama'' " +
                    ", ''Izrada konfiguracije'', ''Artikli'', ''Nabava artikala'' i ''Odjava''.\n\nPritiskom na tipku ''Zaposlenici'' otvara se forma za pregled svih zaposlenika i dodavanje novih zaposlenika.\nPritiskom " +
                    "na tipku ''Poslovnice'' otvara se forma za pregled svih poslovnica i dodavanje novih poslovnice.\nPritiskom na tipku ''Pregled artikala po poslovnicama'' otvara se forma na kojoj je moguće provjeriti " +
                    "stanje artikala po poslovnicama.\nPritiskom na tipku ''Izrada konfiguracije'' otvara se forma za izradu konfiguracije po želji korisnika. \nPritiskom na tipku ''Odjava'' korisnika se odjavljuje iz aplikacije.";
                frmHelp.Show();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            uiKonfiguracija formaKonfiguracija = new uiKonfiguracija();
            formaKonfiguracija.ShowDialog();
        }

        private void UiActionNabavaArtikala_Click(object sender, EventArgs e)
        {
            FrmStanje formaStanje = new FrmStanje();
            formaStanje.Show();
        }

        private void PripremiFunkcionalnosti()
        {
            if (Zaposlenik.PrijavljeniZaposlenik.Tip_ID == 1)
            {
                uiOutputIspis.Text = "Prijavljeni ste kao administrator.";
            }
            else
            {
                uiOutputIspis.Text = "Prijavljeni ste kao korisnik.";
                uiActionZaposlenici.Enabled = false;
                uiActionPoslovnice.Enabled = false;
            }
        }
    }
}

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
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Izbornik. Na formi Izbornik možete vidjeti";
                frmHelp.Show();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmKonfiguracija formaKonfiguracija = new FrmKonfiguracija();
            formaKonfiguracija.Show();
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

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
    public partial class FrmIzbornik : Form
    {
        public FrmIzbornik()
        {
            InitializeComponent();
        }

        private void UiActionIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UiActionZaposlenici_Click(object sender, EventArgs e)
        {
            uiZaposlenici formaZaposlenici = new uiZaposlenici();
            formaZaposlenici.Show();
        }

        private void UiActionDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            uiPoslovnice formaPoslovnica = new uiPoslovnice();
            formaPoslovnica.Show();
        }

        private void UiActionPregledArtikala_Click(object sender, EventArgs e)
        {
            FrmKolicinaArtikala formaKolicina = new FrmKolicinaArtikala();
            formaKolicina.Show();
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
    }
}

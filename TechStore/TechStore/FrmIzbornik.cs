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
            FrmZaposlenici formaZaposlenici = new FrmZaposlenici();
            formaZaposlenici.Show();
        }

        private void UiActionDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            FrmPoslovnica formaPoslovnica = new FrmPoslovnica();
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
    }
}

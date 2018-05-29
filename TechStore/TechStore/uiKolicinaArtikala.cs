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
    public partial class uiKolicinaArtikala : Form
    {
        public uiKolicinaArtikala()
        {
            InitializeComponent();
        }

        private void FrmKolicinaArtikala_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmKolicinaArtikala_KeyDown;
            artiklBindingSource.DataSource = Artikl.DohvatiSveArtikle();
            uiOutputGraf.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }

        private void FrmKolicinaArtikala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FrmHelp frmHelp = new FrmHelp();
                RichTextBox richTextBox = (RichTextBox)frmHelp.Controls.Find("uiOutputPrikazPomoci", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "TechStore Help Center\nViše informacija možete pronaći na sljedećem linku:\nhttps://github.com/foivz/r18038/wiki/3.-Korisni%C4%8Dka-dokumentacija\n\n";
                richTextBox.Text += "Trenutno ste stisnuli F1 na formi Poslovnica.";
                frmHelp.Show();

            }
        }


        private void uiInputArtikl_SelectedValueChanged(object sender, EventArgs e)
        {
            
            uiOutputGraf.Series["Kolicina"].Points.Clear();
            
            if (uiInputArtikl.SelectedItem != null)
            {
                List<Dostupnost> dostupnost = Dostupnost.DohvatiDostupnost(int.Parse(uiInputArtikl.SelectedValue.ToString()));
                CrtajGraf(dostupnost);              
            }
        }

        private void CrtajGraf(List<Dostupnost> dostupnost)
        {
            int brojac = 0;
            foreach (Dostupnost d in dostupnost)
            {
                Poslovnica poslovnica = Poslovnica.DohvatiPoslovnicu(d.Poslovnica_ID);

                uiOutputGraf.Series["Kolicina"].Points.AddXY(poslovnica.Naziv, d.Kolicina);
                uiOutputGraf.Series["Kolicina"].Points[brojac].Label = d.Kolicina.ToString();
                brojac++;

            }
        }

        private void uiActionNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class FrmArtikl : Form
    {
        public FrmArtikl()
        {
            InitializeComponent();
        }

        private void UiActionDodajArtikl_Click(object sender, EventArgs e)
        {
            FrmNoviArtikl noviArtikl = new FrmNoviArtikl();
            noviArtikl.Show();
        }
    }
}

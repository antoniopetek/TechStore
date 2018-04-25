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
    public partial class FrmDodavanjeZaposlenika : Form
    {
        public FrmDodavanjeZaposlenika()
        {
            InitializeComponent();
        }

        private void uiActionDodajZaposlenika_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste dodali zaposlenika!", "ZAPOSLENIK DODAN", MessageBoxButtons.OK, MessageBoxIcon.None);
            Close();
        }
    }
}

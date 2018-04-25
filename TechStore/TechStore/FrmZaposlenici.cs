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
    public partial class FrmZaposlenici : Form
    {
        public FrmZaposlenici()
        {
            InitializeComponent();
        }

        private void uiActionDodajZaposlenika_Click(object sender, EventArgs e)
        {
            FrmDodavanjeZaposlenika formaDodavanjeZaposlenika = new FrmDodavanjeZaposlenika();
            formaDodavanjeZaposlenika.Show();
        }

    }
}

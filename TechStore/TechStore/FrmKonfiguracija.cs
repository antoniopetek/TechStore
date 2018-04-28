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
    public partial class FrmKonfiguracija : Form
    {
        public FrmKonfiguracija()
        {
            InitializeComponent();
        }

        private void uiActionIzdajRacun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Račun uspješno izdan.", "IZDANO", MessageBoxButtons.OK);
        }
    }
}

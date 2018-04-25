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
    public partial class FrmDodavanjePoslovnice : Form
    {
        public FrmDodavanjePoslovnice()
        {
            InitializeComponent();
        }

        private void uiActionDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste dodali poslovnicu!", "POSLOVNICA DODANA", MessageBoxButtons.OK, MessageBoxIcon.None);
            Close();
        }
    }
}

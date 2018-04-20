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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiActionPrijaviSe_Click(object sender, EventArgs e)
        {
            Form frmIzbornik = new Form();
            frmIzbornik.Show();
            Hide();
        }
    }
}

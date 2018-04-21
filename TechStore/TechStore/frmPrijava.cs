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

        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UiActionPrijaviSe_Click(object sender, EventArgs e)
        {
            Form frmIzbornik = new FrmIzbornik();
            frmIzbornik.Show();
            Hide();
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmPrijava_KeyDown;
        }

        private void FrmPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString()=="F1")
            {
                MessageBox.Show("Popup prozor!");
            }
        }
    }
}

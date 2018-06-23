using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komponente
{
    public class Pretraga
    {
        public static void Pretrazi(DataGridView dgv, string tekst, int kolona)
        {
            foreach (DataGridViewRow red in dgv.Rows)
            {
                if (red.Cells[kolona].Value.ToString().ToLower().Contains(tekst))
                {
                    red.Visible = true;
                }
                else
                {
                    CurrencyManager currencyManager = (CurrencyManager)dgv.BindingContext[dgv.DataSource];
                    currencyManager.SuspendBinding();
                    red.Visible = false;
                    currencyManager.ResumeBinding();
                }
            }
        }
    }
}

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
        /// <summary>
        /// Metoda koja kao parametre prima datagridView, tekst koji se pretražuje
        /// te broj kolone po kojoj se pretražuju podaci. Metoda provjerava redak
        /// datagridviewa te ako ćelija na proslijeđenoj poziciji sadrži tekst 
        /// koji je proslijeđen prikazuje taj redak, inače ga skriva.
        /// </summary>
        /// <param name="dgv">DataGridView</param>
        /// <param name="tekst">Tekst pretrage</param>
        /// <param name="kolona">Broj stupca</param>
        public void Pretrazi(DataGridView dgv, string tekst, int kolona)
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

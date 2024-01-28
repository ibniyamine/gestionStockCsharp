using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppMenu.Model1;

namespace AppMenu.Utils
{
    internal class alerte
    {
        public static void  alerteColor(DataGridViewRowCollection dg) {
            foreach (DataGridViewRow row in dg)
            {
                int qteRestantValue = Convert.ToInt32(row.Cells["QteRestant"].Value);

                if (qteRestantValue <= 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White; // Changer la couleur du texte si nécessaire
                }
            }
        }
    }
}

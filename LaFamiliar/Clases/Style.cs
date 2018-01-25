using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Familiar.Clases
{
    static class Style
    {

// ######################################################################################
// ##########      Cambiar el color de fondo de los rows de un data grid     ############
// ######################################################################################

        public static void dataGridMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView tbl = sender as DataGridView;
            int index = e.RowIndex;
            if (tbl.RowCount > index && index >= 0)
            {
                DataGridViewRow row = tbl.Rows[index];
                row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        public static void dataGridMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView tbl = sender as DataGridView;
            int index = e.RowIndex;
            if (tbl.RowCount > index && index >= 0)
            {
                DataGridViewRow row = tbl.Rows[index];
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

// ######################################################################################
// ##################      Métodos extendidos a algunas clases     ######################
// ######################################################################################

        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);

            dgv.ClearSelection();
        }

        public static void change(this Label label, bool enable)
        {
            if (enable) label.ForeColor = Color.Red;
        }

        public static bool changed(this Label label)
        {
            return label.ForeColor == Color.Red;
        }

        public static void unchangeLabels(Control container)
        {
            foreach (Control control in container.Controls)
            {
                unchangeLabel(control);
            }
        }

        private static void unchangeLabel(Control control)
        {
            if (control is Label) control.ForeColor = Color.Black;

            else foreach (Control child in control.Controls)
                {
                    unchangeLabel(child);
                }
        }

        public static int monthsSince(this DateTime date, DateTime sinceDate)
        {
            int m = date.Month - sinceDate.Month;
            int y = date.Year - sinceDate.Year;

            if (m < 0)
            {
                m += 12;
                y--;
            }

            m += 12 * y;

            return m;
        }

        public static string fechaLarga(this DateTime fecha)
        {
            string fechaStr = fecha.ToLongDateString();
            int i = fechaStr.IndexOf(',');
            return fechaStr.Substring(i + 2);
        }

        public static string fechaLargaTexto(this DateTime fecha)
        {
            string r = Numalet.ToCardinal(fecha.Day);
            r = (fecha.Day > 1) ? r + " días" : "un día";

            r += " del mes de ";
            r += Reportes.mes(fecha.Month);

            r += " del año ";
            r += Numalet.ToCardinal(fecha.Year);

            return r;
        }
    }    
}

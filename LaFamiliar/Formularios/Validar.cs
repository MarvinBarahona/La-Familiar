using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Familiar.Clases
{
    class Validar
    {
        public static bool textBoxs(List<TextBox> textBoxs)
        {
            bool r = true;
            foreach (TextBox tb in textBoxs)
            {
                if (tb.TextLength == 0)
                {
                    r = false;
                    break;
                }
            }

            return r;
        }

        public static bool camposEstadoCivil(ComboBox cmbEstado, TextBox txtCNombre, TextBox txtCTrabajo)        
        {
            return cmbEstado.SelectedIndex != -1 && (

                cmbEstado.SelectedItem.ToString().Equals("Casado") &&
                    txtCNombre.Text.Length != 0 && txtCTrabajo.Text.Length != 0

                || !cmbEstado.SelectedItem.ToString().Equals("Casado")
            );
        }

        public static void nit(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            TextBox tb = sender as TextBox;
            int cant = tb.Text.Length;

            if (char.IsNumber(e.KeyChar) && cant < 17)
            {
                cant++;
                tb.Text += e.KeyChar;
                if (cant == 4 || cant == 11 || cant == 15)
                {
                    cant++;
                    tb.Text += '-';
                }
            }
            if (e.KeyChar == '\b' && cant != 0)
            {
                cant--;
                if (cant == 4 || cant == 11 || cant == 15)
                {
                    cant--;
                }
                tb.Text = tb.Text.Remove(cant);
            }

            tb.SelectionStart = cant;
        }

        public static void dui(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            TextBox tb = sender as TextBox;
            int cant = tb.Text.Length;

            if (char.IsNumber(e.KeyChar) && cant < 10)
            {
                cant++;
                tb.Text += e.KeyChar;
                if (cant == 8)
                {
                    cant++;
                    tb.Text += '-';
                }
            }
            if (e.KeyChar == '\b' && cant != 0)
            {
                cant--;
                if (cant == 8)
                {
                    cant--;
                }
                tb.Text = tb.Text.Remove(cant);
            }

            tb.SelectionStart = cant;
        }

        public static void soloLetrasyEspacios(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ') e.Handled = true;
        }

        public static void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') e.Handled = true;
        }

        public static void btnEliminarDataGrid(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    senderGrid.Rows.RemoveAt(e.RowIndex);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("No se ha agregado beneficiario en esa fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

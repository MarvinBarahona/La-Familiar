using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using La_Familiar.ClasesEntidad;
using La_Familiar.Clases;

namespace La_Familiar.Formularios
{
    public partial class FormAhorroBeneficiario : Form
    {
        Ahorro ahorro;

        int nombreIndex;
        int parentescoIndex;
        int edadIndex;
        int porcentajeIndex;
        int direccionIndex;

        Form formParent;

        public FormAhorroBeneficiario(Ahorro ahorro, Form parent)
        {
            this.ahorro = ahorro;
            InitializeComponent();
            setIndexes();
            formParent = parent;
            if (ahorro.beneficiarios != null)
            {
                foreach (Beneficiario beneficiario in ahorro.beneficiarios)
                {
                    int index = dgvBeneficiarios.Rows.Add();
                    DataGridViewRow row = dgvBeneficiarios.Rows[index];

                    row.Cells[nombreIndex].Value = beneficiario.nombre;
                    row.Cells[parentescoIndex].Value = beneficiario.parentesco;
                    row.Cells[edadIndex].Value = beneficiario.edad;
                    row.Cells[porcentajeIndex].Value = beneficiario.porcentaje;
                }
            }
        }

        private void setIndexes()
        {
            // Obtiene el index de cada columna editable en la tabla. 
            nombreIndex = dgvBeneficiarios.Columns.IndexOf(dgvBeneficiarios.Columns["nombre"]);
            parentescoIndex = dgvBeneficiarios.Columns.IndexOf(dgvBeneficiarios.Columns["parentesco"]);
            edadIndex = dgvBeneficiarios.Columns.IndexOf(dgvBeneficiarios.Columns["edad"]);
            porcentajeIndex = dgvBeneficiarios.Columns.IndexOf(dgvBeneficiarios.Columns["porcentaje"]);
            direccionIndex = dgvBeneficiarios.Columns.IndexOf(dgvBeneficiarios.Columns["direccion"]);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<Beneficiario> beneficiarios;
            int cantRows = dgvBeneficiarios.Rows.Count;

            if (cantRows > 1)
            {
                beneficiarios = new List<Beneficiario>();
                bool valido = true;
                Beneficiario beneficiario;
                int sumaPorcentajes = 0;

                for (int i = 0; i < cantRows - 1; i++)
                {
                    DataGridViewRow row = dgvBeneficiarios.Rows[i];

                    //Por cada row, intenta almacenar el valor de cada celda en una variable String. 
                    //Si la celda está vacía, produce la excepción "NullReferenceException"
                    try
                    {
                        String nombre = row.Cells[nombreIndex].Value.ToString();
                        String parentesco = row.Cells[parentescoIndex].Value.ToString();
                        String edad = row.Cells[edadIndex].Value.ToString();
                        String porcentaje = row.Cells[porcentajeIndex].Value.ToString();

                        beneficiario = new Beneficiario(nombre, parentesco, int.Parse(edad), int.Parse(porcentaje), "");
                        beneficiarios.Add(beneficiario);

                        sumaPorcentajes += beneficiario.porcentaje;     //Para validar que la suma sea 100. 
                    }
                    catch (NullReferenceException ex)
                    {
                        valido = false;
                        break;
                    }
                }

                if (valido)
                {
                    //Validar que la suma de los porcentajes sea igual a 100. 
                    if (sumaPorcentajes == 100)
                    {
                        ahorro.beneficiarios = beneficiarios;
                        Control btnTrabajo = formParent.Controls.Find("btnBeneficiarios", true)[0];
                        btnTrabajo.ForeColor = Color.Red;
                        this.Close();
                    }
                    else
                    {
                        String mensaje = "La suma de los porcentajes debe ser 100, actualmente la suma es " + sumaPorcentajes.ToString() + ".";
                        MessageBox.Show(mensaje, "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Existen beneficiarios con campos sin ingresar", "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese por lo menos un beneficiario", "No hay beneficiarios ingresados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvBeneficiarios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Validar.soloLetrasyEspacios);
            e.Control.KeyPress -= new KeyPressEventHandler(Validar.soloNumeros);

            int currentIndex = dgvBeneficiarios.CurrentCell.ColumnIndex;   //Index de la columna a la que se le dió click.

            if (currentIndex == edadIndex || currentIndex == porcentajeIndex)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Validar.soloNumeros);
                }
            }

            if (currentIndex == nombreIndex || currentIndex == parentescoIndex)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Validar.soloLetrasyEspacios);
                }
            }
        }

        private void dgvBeneficiarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    dgvBeneficiarios.Rows.RemoveAt(e.RowIndex);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("No se ha agregado beneficiario en esa fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

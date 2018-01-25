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

namespace La_Familiar.Formularios{

    public partial class FormAsociadoBeneficiarios : Form
    {
        Asociado asociado;

        int nombreIndex;
        int parentescoIndex;
        int edadIndex;
        int porcentajeIndex;
        int direccionIndex;

        Form formParent;    //Form padre (para la creación de un asociado)
        bool nuevo;                     //Para diferenciar entre creación y modificación de asociado. 

// #####################################################################################################
// ##################################             Constructores              ###########################
// #####################################################################################################

        public FormAsociadoBeneficiarios(Asociado asociado, Form parent = null)
        {
            InitializeComponent();

            dgvBeneficiarios.CellContentClick += new DataGridViewCellEventHandler(Validar.btnEliminarDataGrid);
            setIndexes();
            this.asociado = asociado;
            nuevo = parent != null;
            if (nuevo) formParent = parent;

            if (asociado.beneficiarios != null)
            {
                foreach (Beneficiario beneficiario in asociado.beneficiarios)
                {
                    int index = dgvBeneficiarios.Rows.Add();
                    DataGridViewRow row = dgvBeneficiarios.Rows[index];

                    row.Cells[nombreIndex].Value = beneficiario.nombre;
                    row.Cells[parentescoIndex].Value = beneficiario.parentesco;
                    row.Cells[edadIndex].Value = beneficiario.edad;
                    row.Cells[porcentajeIndex].Value = beneficiario.porcentaje;
                    row.Cells[direccionIndex].Value = beneficiario.direccion;
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

// #####################################################################################################
// ######################        Guardar los beneficiarios en variable del padre        ################
// #####################################################################################################
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
                        String direccion = row.Cells[direccionIndex].Value.ToString();

                        beneficiario = new Beneficiario(nombre, parentesco, int.Parse(edad), int.Parse(porcentaje), direccion);
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
                        asociado.beneficiarios = beneficiarios;
                        if (nuevo)
                        {
                            if (formParent is FormAsociadoNuevo)
                            {
                                Control btnTrabajo = formParent.Controls.Find("btnBeneficiarios", true)[0];
                                btnTrabajo.BackColor = Color.PaleGreen;
                            }

                            if (formParent is FormAsociado)
                            {
                                Control btnTrabajo = formParent.Controls.Find("btnBeneficiarios", true)[0];
                                btnTrabajo.ForeColor = Color.Red;
                            }
                        }

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

// #####################################################################################################
// ###################        Al cancelar, cerrar la ventana y no guardar nada.      ###################
// #####################################################################################################

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

// #####################################################################################################
// ###############         Solo texto o solo números en las columnas de la tabla       #################
// #####################################################################################################

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

// #####################################################################################################
// #######################         Eventos de la tabla de beneficiarios        #########################
// #####################################################################################################

        // Cuando se agrega una nueva columna, se coloca la dirección del asociado. 
        private void dgvBeneficiarios_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (asociado.infoPersonal != null && !String.IsNullOrEmpty(asociado.infoPersonal.direccion) && e.RowIndex > 0)
            {
                dgvBeneficiarios.Rows[e.RowIndex - 1].Cells["direccion"].Value = asociado.infoPersonal.direccion;
            }
        }
    }
}
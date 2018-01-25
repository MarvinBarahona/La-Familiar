using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using La_Familiar.Clases;
using La_Familiar.ClasesEntidad;
using La_Familiar.ClasesServicio;

namespace La_Familiar.Formularios
{
    public partial class FormAsociadoTrabajo : Form
    {
        Asociado asociado;
        Form formParent;
        bool nuevo;
        bool nuevoLugar;

// ##################################################################################################
// ################################        Constructor y load form      #############################
// ##################################################################################################

        public FormAsociadoTrabajo(Asociado asociado, Form parent = null)
        {
            InitializeComponent();
            txtLugarTelefono.KeyPress += new KeyPressEventHandler(Validar.soloNumeros);

            LugarTrabajoServicio.fillComboBox(cmbNombre);
            this.asociado = asociado;
            nuevo = parent != null;
            if (nuevo) formParent = parent;

            
        }

        private void FormAsociadoTrabajo_Load(object sender, EventArgs e)
        {
            if (asociado.trabajo != null)
            {
                cmbNombre.Text = asociado.trabajo.lugar.nombre;

                txtCargo.Text = asociado.trabajo.cargo;
                txtTiempo.Text = asociado.trabajo.tiempoServicio;
            }
        }

        

// ###################################################################################
// ##############       Guardar los datos ingresados.     ############################
// ###################################################################################

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<TextBox> tbs = new List<TextBox>()
            {
                txtLugarDireccion, txtLugarTelefono, txtCargo, txtTiempo
            };

            if (!String.IsNullOrEmpty(cmbNombre.Text) && Validar.textBoxs(tbs))
            {
                int id = obtenerIdLugar();
                LugarTrabajo lugarTrabajo = new LugarTrabajo(id, cmbNombre.Text, txtLugarDireccion.Text, txtLugarTelefono.Text);
                asociado.trabajo = new AsociadoTrabajo(lugarTrabajo, txtCargo.Text, txtTiempo.Text);

                if (nuevo)
                {
                    if (formParent is FormAsociadoNuevo)
                    {
                        Control btnTrabajo = formParent.Controls.Find("btnTrabajo", true)[0];
                        btnTrabajo.BackColor = Color.PaleGreen;
                    }

                    if (formParent is FormAsociado)
                    {
                        Control btnTrabajo = formParent.Controls.Find("btnTrabajo", true)[0];
                        btnTrabajo.ForeColor = Color.Red;
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos.", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int obtenerIdLugar()
        {
            int id;

            if (nuevoLugar)
            {
                id = LugarTrabajoServicio.insert(cmbNombre.Text, txtLugarDireccion.Text, txtLugarTelefono.Text);
            }
            else
            {
                LugarTrabajo lugar = (LugarTrabajo)(cmbNombre.SelectedItem as ComboBoxItem).Value;

                lugar.direccion = txtLugarDireccion.Text;
                lugar.telefono = txtLugarTelefono.Text;

                lugar.update();

                id = lugar.id;
            }

            return id;
        }

// ###################################################################################
// ##############       Cerrar la ventana y no guardar nada    #######################
// ###################################################################################

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

// ###################################################################################
// ##############         Llenar los campos con el combobox      #####################
// ###################################################################################

        private void cmbNombre_TextChanged(object sender, EventArgs e)
        {
            nuevoLugar = true;
            foreach (ComboBoxItem item in cmbNombre.Items)
            {
                if ((item.Value as LugarTrabajo).nombre == cmbNombre.Text)
                {
                    LugarTrabajo lugar = item.Value as LugarTrabajo;
                    txtLugarDireccion.Text = lugar.direccion.ToString();
                    txtLugarTelefono.Text = lugar.telefono.ToString();

                    nuevoLugar = false;
                    break;
                }
            }
            if (nuevoLugar)
            {
                txtLugarDireccion.Text = "";
                txtLugarTelefono.Text = "";
            }
        }
    }
}

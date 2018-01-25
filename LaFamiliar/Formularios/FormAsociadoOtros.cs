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
    public partial class FormAsociadoOtros : Form
    {
        Asociado asociado; 

        Form formParent;
        private bool casado;

        public FormAsociadoOtros(Asociado asociado, Form parent = null)
        {
            InitializeComponent();
            this.asociado = asociado;
            if (parent != null) formParent = parent;

            txtNit.KeyPress += new KeyPressEventHandler(Validar.nit);
            txtTelefono.KeyPress += new KeyPressEventHandler(Validar.soloNumeros);
            txtConyugeNombre.KeyPress += new KeyPressEventHandler(Validar.soloLetrasyEspacios);
        }

        private void FormAsociadoOtros_Load(object sender, EventArgs e)
        {
            if (asociado.dependencias != null)
            {
                txtNit.Text = asociado.infoPersonal.nit;
                txtTelefono.Text = asociado.infoPersonal.telefono;
                cmbEstado.Text = asociado.infoPersonal.estadoCivil;

                numIngresos.Value = asociado.infoPersonal.ingresos;
                numIngresosOtros.Value = asociado.infoPersonal.ingresosOtros;

                numDepenTotal.Value = asociado.dependencias.total;
                numDepenParcial.Value = asociado.dependencias.parcial;

                if (asociado.conyuge != null)
                {
                    txtConyugeNombre.Text = asociado.conyuge.nombre;
                    txtConyugeTrabajo.Text = asociado.conyuge.lugarTrabajo;
                }

            }
        }

// ###############################################################################################
// ###################           Guardar los datos ingresados              #######################
// ###############################################################################################
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Validar.textBoxs(new List<TextBox>(){txtNit, txtTelefono}) 
                || !Validar.camposEstadoCivil(cmbEstado, txtConyugeNombre, txtConyugeTrabajo))
            {
                MessageBox.Show("Ingrese todos los campos!", "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                asociado.dependencias = new AsociadoDependencia();

                //Guardar los datos en el objeto asociado
                asociado.infoPersonal.nit = txtNit.Text;
                asociado.infoPersonal.telefono = txtTelefono.Text;
                asociado.infoPersonal.estadoCivil = cmbEstado.Text;

                asociado.infoPersonal.ingresos = numIngresos.Value;
                asociado.infoPersonal.ingresosOtros = numIngresosOtros.Value;

                asociado.dependencias.total = (byte) numDepenTotal.Value;
                asociado.dependencias.parcial = (byte)numDepenParcial.Value;

                if (casado)
                {
                    asociado.conyuge = new AsociadoConyuge(txtConyugeNombre.Text, txtConyugeTrabajo.Text);
                }
                else
                {
                    asociado.conyuge = null;
                }

                Control btnOtros = formParent.Controls.Find("btnOtros", true)[0];
                btnOtros.BackColor = Color.PaleGreen;

                this.Close();
            }
        }

// ###############################################################################################
// ####################      Cerrar la ventana (no guardar nada)         #########################
// ###############################################################################################
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

// ###############################################################################################
// ###########################           Habilitar conyuge           #############################
// ###############################################################################################

        //Habilitar los campos del conyuge cuando el asociado es casado. 
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            casado = grbConyuge.Enabled = cmbEstado.SelectedItem.ToString().Equals("Casado");
        }
    }
}

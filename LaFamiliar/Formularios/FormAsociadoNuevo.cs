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

namespace La_Familiar.Formularios
{
    public partial class FormAsociadoNuevo : Form
    {
        private Asociado asociado;

// ##################################################################################################
// ################################        Constructor y load form      #############################
// ##################################################################################################
        public FormAsociadoNuevo()
        {
            InitializeComponent();

            txtNum.KeyPress += new KeyPressEventHandler(Validar.soloNumeros);
            txtNombre.KeyPress += new KeyPressEventHandler(Validar.soloLetrasyEspacios);
            txtApellido.KeyPress += new KeyPressEventHandler(Validar.soloLetrasyEspacios);
            txtDui.KeyPress += new KeyPressEventHandler(Validar.dui);

            asociado = new Asociado();
            asociado.infoPersonal = new AsociadoInfoPersonal();
        }

        private void NuevoAsociado_Load(object sender, EventArgs e)
        {
            dtpIngreso.Value = DateTime.Today;
            asociado.id = TiposCorrelativo.Asociado.getCorrelativo();   
            txtNum.Text = asociado.ToString();
        }

// ###################################################################################################
// #####################           Guardar el nuevo asociado.             ############################
// ###################################################################################################  

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<TextBox> tbs = new List<TextBox>()
            {
                txtNum, txtDui, txtLugarDui, txtLugarNacimiento, txtNombre, txtApellido, txtDireccion, txtMunicipio, txtDepartamento
            };

            if (!Validar.textBoxs(tbs))
            {
                MessageBox.Show("Ingrese todos los campos!", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (asociado.infoPersonal == null || asociado.trabajo == null || asociado.beneficiarios == null)
            {
                MessageBox.Show(
                    "Los botones rojos indican que esos datos no se han ingresado todavia, por favor dé click en cada uno de ellos para ingresar los datos faltantes.",
                    "Existen datos sin ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
            else
            {
                string numDui = txtDui.Text;
                asociado.dui = new Dui(numDui, txtLugarDui.Text, dtpDui.Value);

                asociado.id = int.Parse(txtNum.Text);
                asociado.nombre = txtNombre.Text;
                asociado.apellido = txtApellido.Text;
                asociado.infoPersonal.direccion = txtDireccion.Text;
                asociado.infoPersonal.municipio = txtMunicipio.Text;
                asociado.infoPersonal.departamento = txtDepartamento.Text;

                asociado.nacimiento = new AsociadoNacimiento(dtpNacimiento.Value, txtLugarNacimiento.Text);

                asociado.fechaIngreso = dtpIngreso.Value;

                Queries.transactionBegin();
                try
                {
                    asociado.insert();
                    TiposCorrelativo.Asociado.update();

                    Queries.transactionCommit();
                    this.Close();
                }
                catch(Exception ex)
                {
                    Queries.transactionRollback();
                    MessageBox.Show(ex.InnerException.Message);
                    MessageBox.Show(ex.InnerException.StackTrace.ToString());                    
                }
            }           
        }

// ###################################################################################################
// ######################        Cancelar el ingreso de un asociado.          ########################
// ###################################################################################################  

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

// ###################################################################################################
// #################        Botones para las interfaces adicionales de datos        ##################
// ###################################################################################################
        private void btnOtros_Click(object sender, EventArgs e)
        {
            Form form = new FormAsociadoOtros(asociado, this);
            form.ShowDialog();
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            Form form = new FormAsociadoTrabajo(asociado, this);
            form.ShowDialog();
        }

        private void btnBeneficiarios_Click(object sender, EventArgs e)
        {
            asociado.infoPersonal.direccion = txtDireccion.Text;
            Form form = new FormAsociadoBeneficiarios(asociado, this);
            form.ShowDialog();
        }
    }
}

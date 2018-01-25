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
    public partial class FormAportacionNueva : Form
    {

// ########################################################################################
// #######################        Constructor y load        ###############################
// ########################################################################################

        public FormAportacionNueva()
        {
            InitializeComponent();
            AsociadoServicio.fillComboBox(cmbAsociados);
        }

        public FormAportacionNueva(String nombre)
        {
            InitializeComponent();
            AsociadoServicio.fillComboBox(cmbAsociados);

            cmbAsociados.Text = nombre;
            cmbAsociados.Enabled = false;
        }

// ########################################################################################
// ##########################           Cancelar           ################################
// ########################################################################################

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

// ########################################################################################
// #################           Guardar la nueva aportación         ########################
// ########################################################################################

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cmbAsociados.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un asociado", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numMonto.Value <= 0)
            {
                MessageBox.Show("El monto de la aportación debe ser mayor que 0", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form formEspera = new FormEspera();
                formEspera.Show();
                try
                {
                    Queries.transactionBegin();

                    Asociado asociado = (Asociado)(cmbAsociados.SelectedItem as ComboBoxItem).Value;
                    AportacionDetalle detalle = new AportacionDetalle(asociado, "Abono personal", dtpFecha.Value, numMonto.Value);
                    detalle.insert();

                    Reportes.comprobanteAportacion(asociado, detalle);
                    formEspera.Close();
                    Reportes.abrirCarpeta();
                    

                    Queries.transactionCommit();
                    this.Close();
                }
                catch (Exception ex)
                {
                    formEspera.Close();
                    Queries.transactionRollback();
                }
            }
        }
    }
}

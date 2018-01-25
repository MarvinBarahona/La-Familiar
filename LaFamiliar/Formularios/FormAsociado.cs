using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using La_Familiar.Clases;
using La_Familiar.ClasesEntidad;
using La_Familiar.ClasesServicio;
using System.Data.SqlClient;

namespace La_Familiar.Formularios
{
    public partial class FormAsociado : Form
    {
        Asociado asociado;
        bool enableChange;

// ###############################################################################################
// #############################          Constructor y load            ##########################
// ###############################################################################################

        public FormAsociado(int idAsociado)
        {
            InitializeComponent();

            //Validación de campos. 
            txtNit.KeyPress += new KeyPressEventHandler(Validar.nit);
            txtNombre.KeyPress += new KeyPressEventHandler(Validar.soloLetrasyEspacios);
            txtApellido.KeyPress += new KeyPressEventHandler(Validar.soloLetrasyEspacios);
            txtConyugeNombre.KeyPress += new KeyPressEventHandler(Validar.soloLetrasyEspacios);
            txtTelefono.KeyPress += new KeyPressEventHandler(Validar.soloNumeros);

            //Cambiar de color las filas de la tabla. 
            tblAportaciones.CellMouseEnter += new DataGridViewCellEventHandler(Style.dataGridMouseEnter);
            tblAportaciones.CellMouseLeave += new DataGridViewCellEventHandler(Style.dataGridMouseLeave);

            this.asociado = AsociadoServicio.select(idAsociado);
            enableChange = false;

            btnMembresia.Visible = !asociado.abonoInicial;
        }

        private void Asociado_Load(object sender, EventArgs e)
        {
            llenarCampos();
            enableChange = true;
        }

        private void AsociadoDetalle_Activated(object sender, EventArgs e)
        {
            decimal aportacion = AportacionServicio.fillTable(tblAportaciones, asociado.id);
            lblAportacionT.Text = aportacion.ToString();

            CreditoServicio.fillTable(tblCreditos, asociado.id);
            AhorroServicio.fillTable(dgvAhorros, asociado.id);
        }

// ###############################################################################################
// ##############      Ventanas emergentes al dar doble click en cada tabla       ################
// ###############################################################################################

        //Abre una nueva ventana de ahorro cuando se da doble click a una fila de tblCreditosAsociado.
        private void tblCreditos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = (int)tblCreditos.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FormCredito(id);
                form.ShowDialog();
            }
        }

        //Abre una nueva ventana de créditos cuando se da doble click a una fila de tblAhorrosAsociado.
        private void tblAhorrosAsociado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = (int)dgvAhorros.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FormAhorro(id);
                form.ShowDialog();
            }
        }

// ###############################################################################################
// #############        Abrir las ventanas con la información complementaria        ##############
// ###############################################################################################

        private void btnBeneficiarios_Click(object sender, EventArgs e)
        {
            Form form = new FormAsociadoBeneficiarios(asociado, this);
            form.ShowDialog();
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            Form form = new FormAsociadoTrabajo(asociado, this);      
            form.ShowDialog();
        }

// ###############################################################################################
// ###################      Cerrar programa o retornar a menú principal       ####################
// ###############################################################################################

        //Al cerrar la ventana, se cierra el programa completo. 
        private void Asociado_FormClosing(object sender, FormClosingEventArgs e)
        {            
            Provider.formMain.Show();
        }

        //Retornar al menú principal. 
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Provider.formMain.Show();
            this.Close();
        }

// ###############################################################################################
// ###############################        Botón de guardar        ################################
// ###############################################################################################

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            // ############################ Validación #####################
            List<TextBox> tbs = new List<TextBox>()
            {
                txtNit, txtNombre, txtTelefono, txtApellido, txtDireccion, txtLugarDui, txtDui, txtLugarNacimiento
            };

            if ( !Validar.textBoxs(tbs) || !Validar.camposEstadoCivil(cmbEstado, txtConyugeNombre, txtConyugeTrabajo))
            {
                MessageBox.Show("Ingrese todos los campos!", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ############################ Actualización #####################
                try
                {
                    //Asignar el conyuge y actualizar. 
                    asociado.conyuge = new AsociadoConyuge(txtConyugeNombre.Text, txtConyugeTrabajo.Text);
                    asociado.update();

                    lblNombreT.Text = asociado.nombre + " " + asociado.apellido;
                    lblIngresoT.Text = asociado.fechaIngreso.ToShortDateString();
                    lblDuiT.Text = asociado.dui.numero;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                    MessageBox.Show(ex.InnerException.StackTrace.Last().ToString());
                }

                //Poner los labelsy botones en negreo nuevamente.
                Style.unchangeLabels(tabAsociado);
                btnBeneficiarios.ForeColor = Color.Black;
                btnTrabajo.ForeColor = Color.Black;
            }
        }

// ###############################################################################################
// #####################        Botones para nueva transacción           #########################
// ###############################################################################################

        private void btnAportacion_Click(object sender, EventArgs e)
        {
            Form form = new FormAportacionNueva(asociado.nombre + " " + asociado.apellido);
            form.ShowDialog();
        }

        private void btnNuevoCredito_Click(object sender, EventArgs e)
        {
            Form form = new FormCreditoNuevo(asociado.nombre + " " + asociado.apellido);
            form.ShowDialog();
        }

        private void btnNuevoAhorro_Click(object sender, EventArgs e)
        {
            Form form = new FormAhorroNuevo(asociado.nombre + " " + asociado.apellido);
            form.ShowDialog();
        }

// ###############################################################################################
// ################           Llenar los campos con la información actual         ################
// ###############################################################################################

        private void llenarCampos()
        {
            txtNum.Text = lblNumT.Text = asociado.ToString();
            txtDui.Text = lblDuiT.Text = asociado.dui.numero;

            txtNombre.Text = asociado.nombre;
            txtApellido.Text = asociado.apellido;
            lblNombreT.Text = asociado.nombre + " " + asociado.apellido;

            lblIngresoT.Text = asociado.fechaIngreso.ToShortDateString();
            dtpIngreso.Value = asociado.fechaIngreso;

            txtNit.Text = asociado.infoPersonal.nit;
            txtTelefono.Text = asociado.infoPersonal.telefono;
            txtDireccion.Text = asociado.infoPersonal.direccion;
            txtMunicipio.Text = asociado.infoPersonal.municipio;
            txtDepartamento.Text = asociado.infoPersonal.departamento;

            numIngresos.Value = asociado.infoPersonal.ingresos;
            numIngresosOtros.Value = asociado.infoPersonal.ingresosOtros;
            numDepenTotal.Value = asociado.dependencias.total;
            numDepenParcial.Value = asociado.dependencias.parcial;

            txtLugarNacimiento.Text = asociado.nacimiento.lugar;
            dtpNacimiento.Value = asociado.nacimiento.fecha;
            txtLugarDui.Text = asociado.dui.lugarEmision;
            dtpDui.Value = asociado.dui.fechaEmision;                       
            txtEdad.Text = asociado.nacimiento.edad.ToString();

            cmbEstado.Text = asociado.infoPersonal.estadoCivil;
            if (cmbEstado.Text == "Casado")
            {
                txtConyugeNombre.Text = asociado.conyuge.nombre;
                txtConyugeTrabajo.Text = asociado.conyuge.lugarTrabajo;
            }
        }

// ###############################################################################################
// #################              Al cambiar alguno de los campos             ####################
// ###############################################################################################

        private void txtDui_TextChanged(object sender, EventArgs e)
        {
            lblDui.change(enableChange);
            asociado.dui.numero = txtDui.Text;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblNombre.change(enableChange);
            asociado.nombre = txtNombre.Text;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            lblApellido.change(enableChange);
            asociado.apellido = txtApellido.Text;
        }

        private void dtpIngreso_ValueChanged(object sender, EventArgs e)
        {
            lblIngreso.change(enableChange);
            asociado.fechaIngreso = dtpIngreso.Value;
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {
            lblNit.change(enableChange);
            asociado.infoPersonal.nit = txtNit.Text;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            lblTelefono.change(enableChange);
            asociado.infoPersonal.telefono = txtTelefono.Text;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            lblDireccion.change(enableChange);
            asociado.infoPersonal.direccion = txtDireccion.Text;
        }

        private void numIngresos_ValueChanged(object sender, EventArgs e)
        {
            lblIngresos.change(enableChange);
            asociado.infoPersonal.ingresos = numIngresos.Value;
        }

        private void numIngresosOtros_ValueChanged(object sender, EventArgs e)
        {
            lblIngresosOtros.change(enableChange);
            asociado.infoPersonal.ingresosOtros = numIngresosOtros.Value;
        }

        private void numDepenTotal_ValueChanged(object sender, EventArgs e)
        {
            lblDepenTotal.change(enableChange);
            asociado.dependencias.total = (byte)numDepenTotal.Value;
        }

        private void numDepenParcial_ValueChanged(object sender, EventArgs e)
        {
            lblDepenParcial.change(enableChange);
            asociado.dependencias.parcial = (byte)numDepenParcial.Value;
        }

        private void txtLugarDui_TextChanged(object sender, EventArgs e)
        {
            lblDuiLugar.change(enableChange);
            asociado.dui.lugarEmision = txtLugarDui.Text;
        }

        private void dtpDui_ValueChanged(object sender, EventArgs e)
        {
            lblDuiFecha.change(enableChange);
            asociado.dui.fechaEmision = dtpDui.Value;
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            lblNacimientoFecha.change(enableChange);
            asociado.nacimiento.fecha = dtpNacimiento.Value;
            txtEdad.Text = asociado.nacimiento.edad.ToString();
        }

        private void txtLugarNacimiento_TextChanged(object sender, EventArgs e)
        {
            lblNacimientoLugar.change(enableChange);
            asociado.nacimiento.lugar = txtLugarNacimiento.Text;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConyugeNombre.Enabled = txtConyugeTrabajo.Enabled = cmbEstado.SelectedItem.ToString().Equals("Casado");
            lblEstado.change(enableChange);
            asociado.infoPersonal.estadoCivil = cmbEstado.Text;
        }

        private void txtConyugeNombre_TextChanged(object sender, EventArgs e)
        {
            lblConyugeNombre.change(enableChange);
        }

        private void txtConyugeTrabajo_TextChanged(object sender, EventArgs e)
        {
            lblConyugeTrabajo.change(enableChange);
        }

        private void txtMunicipio_TextChanged(object sender, EventArgs e)
        {
            lblDireccion.change(enableChange);
            asociado.infoPersonal.municipio = txtMunicipio.Text;
        }

        private void txtDepartamento_TextChanged(object sender, EventArgs e)
        {
            lblDireccion.change(enableChange);
            asociado.infoPersonal.departamento = txtDepartamento.Text;
        }

        private void tabTransacciones_Click(object sender, EventArgs e)
        {

        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();
            try
            {
                Queries.transactionBegin();

                AportacionDetalle detalle = new AportacionDetalle(asociado, "Abono inicial", asociado.fechaIngreso, 10);
                detalle.insert();

                Reportes.comprobanteAportacion(asociado, detalle);
                formEspera.Close();
                Reportes.abrirCarpeta();


                Queries.transactionCommit();
            }
            catch (Exception ex)
            {
                formEspera.Close();
                Queries.transactionRollback();
            }
        }            
    }
}

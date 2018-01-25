using La_Familiar.ClasesEntidad;
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
using La_Familiar.ClasesServicio;

namespace La_Familiar.Formularios
{
    public partial class FormCreditoAgregarGarantias : Form
    {
        private Credito credito;

// #########################################################################################################
// ##########################                  Constructor y load                ###########################
// #########################################################################################################

        public FormCreditoAgregarGarantias(Credito credito)
        {
            InitializeComponent();
            this.credito = credito;
            if (string.Equals(credito.tipo, "Sobre deposito a plazo"))
            {
                tabControl1.SelectedTab = tabDepositos;
            }

            //Para fiadores. 
            txtFiadorDui.KeyPress += new KeyPressEventHandler(Validar.dui);
            txtFiadorNit.KeyPress += new KeyPressEventHandler(Validar.nit);
            txtFiadorTel.KeyPress += new KeyPressEventHandler(Validar.soloNumeros);
            txtFiadorNombres.KeyPress += new KeyPressEventHandler(Validar.soloLetrasyEspacios);
            txtFiadorApellidos.KeyPress += new KeyPressEventHandler(Validar.soloLetrasyEspacios);
            dgvFiadores.CellContentClick += new DataGridViewCellEventHandler(Validar.btnEliminarDataGrid);
            
            //Para hipotecario. 
            dgvHipotecarias.CellContentClick += new DataGridViewCellEventHandler(Validar.btnEliminarDataGrid);

            //Para prendaria. 
            dgvPrendarias.CellContentClick += new DataGridViewCellEventHandler(Validar.btnEliminarDataGrid);

            //Para sobre depósito
            dgvDepositos.CellContentClick += new DataGridViewCellEventHandler(Validar.btnEliminarDataGrid);
        }

        private void FormCreditoGarantias_Load(object sender, EventArgs e)
        {
            if (credito.fiadores != null)
                foreach (GarantiaFiador fiador in credito.fiadores)
                    agregarFiadorADataGrid(fiador);

            if (credito.hipotecarias != null)
                foreach (GarantiaHipotecaria hipotecaria in credito.hipotecarias)
                    agregarHipotecariaADataGrid(hipotecaria);

            if (credito.prendarias != null)
                foreach (GarantiaPrendaria prendaria in credito.prendarias)
                    agregarPrendariaADataGrid(prendaria);
            if (credito.depositos != null)
                foreach (int idAhorro in credito.depositos)
                    agregarDepositoADataGrid(idAhorro);
        }

// #########################################################################################################
// #########################             Aceptar y cancelar del form           #############################
// #########################################################################################################

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            credito.fiadores = new List<GarantiaFiador>();
            foreach (DataGridViewRow row in dgvFiadores.Rows)
            {
                GarantiaFiador fiador = row.Cells["fiadorObjeto"].Value as GarantiaFiador;
                credito.fiadores.Add(fiador);
            }

            credito.hipotecarias = new List<GarantiaHipotecaria>();
            foreach (DataGridViewRow row in dgvHipotecarias.Rows)
            {
                GarantiaHipotecaria hipotecaria = row.Cells["hipoObjeto"].Value as GarantiaHipotecaria;
                credito.hipotecarias.Add(hipotecaria);
            }

            credito.prendarias = new List<GarantiaPrendaria>();
            foreach (DataGridViewRow row in dgvPrendarias.Rows)
            {
                GarantiaPrendaria prendaria = row.Cells["prenObjeto"].Value as GarantiaPrendaria;
                credito.prendarias.Add(prendaria);
            }

            credito.depositos = new List<int>();
            foreach (DataGridViewRow row in dgvDepositos.Rows)
            {
                int idAhorro = (int)row.Cells["depositoObjeto"].Value;
                credito.depositos.Add(idAhorro);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

// #########################################################################################################
// ###########################               Tab index changed               ###############################
// #########################################################################################################

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validación del tipo de crédito. 
            if (string.Equals(credito.tipo, "Sobre deposito a plazo"))
            {
                if (tabControl1.SelectedTab == tabFiador || tabControl1.SelectedTab == tabHipotecaria || tabControl1.SelectedTab == tabPrendaria)
                {
                    MessageBox.Show("Para prestamos sobre deposito solamente se permiten garantias 'Deposito a plazo'", "Pestaña inaccesible",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectedTab = tabDepositos;
                }   
            }

            //Cargar en el comboBox los posibles propietarios. 
            if (tabControl1.SelectedTab == tabHipotecaria)
            {
                cmbHipotecarioPropietario.Items.Clear();
                ComboBoxItem item = new ComboBoxItem();
                item.Text = "Deudor";
                item.Value = 0;

                cmbHipotecarioPropietario.Items.Add(item);
                cmbHipotecarioPropietario.SelectedItem = item;

                foreach (DataGridViewRow row in dgvFiadores.Rows)
                {
                    GarantiaFiador fiador = row.Cells["fiadorObjeto"].Value as GarantiaFiador;
                    item = new ComboBoxItem();
                    item.Text = fiador.nombres + " " + fiador.apellidos;
                    item.Value = fiador;
                    cmbHipotecarioPropietario.Items.Add(item);
                }
            }

            //Cargar en el comboBox los posibles propietarios. 
            if (tabControl1.SelectedTab == tabPrendaria)
            {
                cmbPredariaPropietario.Items.Clear();
                ComboBoxItem item = new ComboBoxItem();
                item.Text = "Deudor";

                cmbPredariaPropietario.Items.Add(item);
                cmbPredariaPropietario.SelectedItem = item;

                foreach (DataGridViewRow row in dgvFiadores.Rows)
                {
                    GarantiaFiador fiador = row.Cells["fiadorObjeto"].Value as GarantiaFiador;
                    item = new ComboBoxItem();
                    item.Text = fiador.nombres + " " + fiador.apellidos;
                    item.Value = fiador;
                    cmbPredariaPropietario.Items.Add(item);
                }
            }

            if(tabControl1.SelectedTab ==  tabDepositos)
            {
                AhorroServicio.fillComboBoxDepositos(cmbDepositos, credito.idAsociado);
            }
        }

// #########################################################################################################
// ###########################                  Para fiadores                ###############################
// #########################################################################################################


        //Botón 'Agregar'
        private void btnFiadorAgregar_Click(object sender, EventArgs e)
        {           
            List<TextBox> tbs = new List<TextBox>
            {
                txtFiadorNombres, txtFiadorApellidos, txtFiadorDui, txtFiadorNit, txtFiadorDir, txtFiadorTel
            };

            if (Validar.textBoxs(tbs))
            {
                GarantiaFiador fiador;

                if (btnFiadorAgregar.Text == "Agregar")
                {
                    fiador = new GarantiaFiador(txtFiadorDui.Text, txtFiadorApellidos.Text,
                    txtFiadorNombres.Text, txtFiadorDir.Text, txtFiadorTel.Text, txtFiadorNit.Text);

                    agregarFiadorADataGrid(fiador);
                }
                else
                {
                    fiador = dgvFiadores.SelectedRows[0].Cells["fiadorObjeto"].Value as GarantiaFiador;
                    int index = dgvFiadores.SelectedRows[0].Index;

                    dgvFiadores.Rows[index].Cells["nombres"].Value = fiador.nombres = txtFiadorNombres.Text;
                    dgvFiadores.Rows[index].Cells["apellidos"].Value = fiador.apellidos = txtFiadorApellidos.Text;
                    dgvFiadores.Rows[index].Cells["dui"].Value = fiador.dui = txtFiadorDui.Text;
                    dgvFiadores.Rows[index].Cells["tel"].Value = fiador.telefono = txtFiadorTel.Text;
                    fiador.direccion = txtFiadorDir.Text;
                    fiador.nit = txtFiadorNit.Text;
                }                               

                limpiarControlesFiador();
            }

            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Click en la tabla de fiadores. 
        private void dgvFiadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dgvFiadores.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && e.RowIndex >= 0)
            {
                GarantiaFiador fiador = dgvFiadores.Rows[e.RowIndex].Cells["fiadorObjeto"].Value as GarantiaFiador;

                txtFiadorNombres.Text = fiador.nombres;
                txtFiadorApellidos.Text = fiador.apellidos;
                txtFiadorDui.Text = fiador.dui;
                txtFiadorNit.Text = fiador.nit;
                txtFiadorDir.Text = fiador.direccion;
                txtFiadorTel.Text = fiador.telefono;

                btnFiadorAgregar.Text = "Modificar";
            }
            else
            {
                limpiarControlesFiador();
            }
        }

        //Botón 'Cancelar'. 
        private void btnFiadorCancelar_Click(object sender, EventArgs e)
        {
            limpiarControlesFiador();
        }

        //Método para agregar un fiador a la tabla de fiadores. 
        private void agregarFiadorADataGrid(GarantiaFiador fiador)
        {
            int index = dgvFiadores.Rows.Add();

            dgvFiadores.Rows[index].Cells["fiadorObjeto"].Value = fiador;

            dgvFiadores.Rows[index].Cells["nombres"].Value = fiador.nombres;
            dgvFiadores.Rows[index].Cells["apellidos"].Value = fiador.apellidos;
            dgvFiadores.Rows[index].Cells["dui"].Value = fiador.dui;
            dgvFiadores.Rows[index].Cells["tel"].Value = fiador.telefono;
        }


        //Método para limpiar el formulario de fiador. 
        private void limpiarControlesFiador()
        {
            txtFiadorNombres.Text = "";
            txtFiadorApellidos.Text = "";
            txtFiadorDui.Text = "";
            txtFiadorNit.Text = "";
            txtFiadorDir.Text = "";
            txtFiadorTel.Text = "";

            btnFiadorAgregar.Text = "Agregar";
        }

// #########################################################################################################
// #########################                  Para hipotecarias                #############################
// #########################################################################################################

        //Botón 'Agregar'
        private void btnHipotecariaAgregar_Click(object sender, EventArgs e)
        {
            List<TextBox> tbs = new List<TextBox>
            {
                txtHipotecarioDir, txtHipotecarioMedida, txtHipotecarioMatricula
            };

            if (Validar.textBoxs(tbs))
            {
                GarantiaHipotecaria hipotecaria;

                if (btnHipotecariaAgregar.Text == "Agregar")
                {
                    hipotecaria = new GarantiaHipotecaria(txtHipotecarioDir.Text, txtHipotecarioMatricula.Text,
                        txtHipotecarioMedida.Text);

                    if (cmbHipotecarioPropietario.Text != "Deudor")
                    {
                        hipotecaria.fiador = (GarantiaFiador)(cmbHipotecarioPropietario.SelectedItem as ComboBoxItem).Value;
                    }

                    agregarHipotecariaADataGrid(hipotecaria);
                }
                else
                {
                    hipotecaria = dgvHipotecarias.SelectedRows[0].Cells["hipoObjeto"].Value as GarantiaHipotecaria;
                    int index = dgvHipotecarias.SelectedRows[0].Index;

                    if (cmbHipotecarioPropietario.Text == "Deudor")
                    {
                        hipotecaria.fiador = null;
                    }
                    else
                    {
                        hipotecaria.fiador = (GarantiaFiador)(cmbHipotecarioPropietario.SelectedItem as ComboBoxItem).Value;
                    }

                    dgvHipotecarias.Rows[index].Cells["propietario"].Value = cmbHipotecarioPropietario.Text;
                    dgvHipotecarias.Rows[index].Cells["matricula"].Value = hipotecaria.matricula = txtHipotecarioMatricula.Text;
                    dgvHipotecarias.Rows[index].Cells["medida"].Value = hipotecaria.medidas = txtHipotecarioMedida.Text;
                    dgvHipotecarias.Rows[index].Cells["hipoDir"].Value = hipotecaria.direccion = txtHipotecarioDir.Text;
                }

                limpiarControlesHipotecaria();
            }

            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botón 'Cancelar'
        private void btnHipotecariaCancelar_Click(object sender, EventArgs e)
        {
            limpiarControlesHipotecaria();
        }

        //Al dar click en la celda.
        private void dgvHipotecarias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dgvHipotecarias.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && e.RowIndex >= 0)
            {
                GarantiaHipotecaria hipotecaria = dgvHipotecarias.Rows[e.RowIndex].Cells["hipoObjeto"].Value as GarantiaHipotecaria;

                cmbHipotecarioPropietario.Text = dgvHipotecarias.Rows[e.RowIndex].Cells["propietario"].Value.ToString();
                txtHipotecarioMatricula.Text = hipotecaria.matricula;
                txtHipotecarioMedida.Text = hipotecaria.medidas;
                txtHipotecarioDir.Text = hipotecaria.direccion;

                btnHipotecariaAgregar.Text = "Modificar";
            }
            else
            {
                limpiarControlesHipotecaria();
            }
        }

        //Agregar un nuevo row a hipotecaria. 
        private void agregarHipotecariaADataGrid(GarantiaHipotecaria hipotecaria)
        {
            int index = dgvHipotecarias.Rows.Add();

            dgvHipotecarias.Rows[index].Cells["hipoObjeto"].Value = hipotecaria;

            if (hipotecaria.fiador != null)
            {
                dgvHipotecarias.Rows[index].Cells["propietario"].Value = hipotecaria.fiador.nombres + " " + hipotecaria.fiador.apellidos;
            }
            else
            {
                dgvHipotecarias.Rows[index].Cells["propietario"].Value = "Deudor";
            }

            dgvHipotecarias.Rows[index].Cells["matricula"].Value = hipotecaria.matricula;
            dgvHipotecarias.Rows[index].Cells["medida"].Value = hipotecaria.medidas;
            dgvHipotecarias.Rows[index].Cells["hipoDir"].Value = hipotecaria.direccion;
        }

        //Limpiar los controles del tab de créditos hipotecarios. 
        private void limpiarControlesHipotecaria()
        {
            cmbHipotecarioPropietario.Text = "Deudor";
            txtHipotecarioMatricula.Text = "";
            txtHipotecarioMedida.Text = "";
            txtHipotecarioDir.Text = "";

            btnHipotecariaAgregar.Text = "Agregar";
        }

// #########################################################################################################
// ###########################                  Para prendarias                #############################
// #########################################################################################################

        //Botón 'Agregar'
        private void btnPrendariaAgregar_Click(object sender, EventArgs e)
        {
            List<TextBox> tbs = new List<TextBox>
            {
                txtPrendariaDescripcion, txtPrendariaNombre
            };

            if (Validar.textBoxs(tbs))
            {
                GarantiaPrendaria prendaria;

                if (btnPrendariaAgregar.Text == "Agregar")
                {
                    prendaria = new GarantiaPrendaria(txtPrendariaNombre.Text, txtPrendariaDescripcion.Text);

                    if (cmbPredariaPropietario.Text != "Deudor")
                    {
                        prendaria.fiador = (GarantiaFiador)(cmbPredariaPropietario.SelectedItem as ComboBoxItem).Value;
                    }

                    agregarPrendariaADataGrid(prendaria);
                }
                else
                {
                    prendaria = dgvPrendarias.SelectedRows[0].Cells["prenObjeto"].Value as GarantiaPrendaria;
                    int index = dgvPrendarias.SelectedRows[0].Index;

                    if (cmbPredariaPropietario.Text == "Deudor")
                    {
                        prendaria.fiador = null;
                    }
                    else
                    {
                        prendaria.fiador = (GarantiaFiador)(cmbPredariaPropietario.SelectedItem as ComboBoxItem).Value;
                    }

                    dgvPrendarias.Rows[index].Cells["prenPropietario"].Value = cmbPredariaPropietario.Text;
                    dgvPrendarias.Rows[index].Cells["bien"].Value = prendaria.bien = txtPrendariaNombre.Text;
                    dgvPrendarias.Rows[index].Cells["prenDesc"].Value = prendaria.descripcion = txtPrendariaDescripcion.Text;
                }

                limpiarControlesPrendaria();
            }

            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botón 'Cancelar'
        private void btnPrendariaCancelar_Click(object sender, EventArgs e)
        {
            limpiarControlesPrendaria();
        }

        //Click en la tabla de prendarias. 
        private void dgvPrendarias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dgvPrendarias.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && e.RowIndex >= 0)
            {
                GarantiaPrendaria prendaria = dgvPrendarias.Rows[e.RowIndex].Cells["prenObjeto"].Value as GarantiaPrendaria;

                cmbPredariaPropietario.Text = dgvPrendarias.Rows[e.RowIndex].Cells["prenPropietario"].Value.ToString();
                txtPrendariaNombre.Text = prendaria.bien;
                txtPrendariaDescripcion.Text = prendaria.descripcion;

                btnPrendariaAgregar.Text = "Modificar";
            }
            else
            {
                limpiarControlesPrendaria();
            }
        }

        //Agregar un objeto GarantiaPrendaria al DataGrid. 
        private void agregarPrendariaADataGrid(GarantiaPrendaria prendaria)
        {
            int index = dgvPrendarias.Rows.Add();

            dgvPrendarias.Rows[index].Cells["prenObjeto"].Value = prendaria;

            if (prendaria.fiador != null)
            {
                dgvPrendarias.Rows[index].Cells["prenPropietario"].Value = prendaria.fiador.nombres + " " + prendaria.fiador.apellidos;
            }
            else
            {
                dgvPrendarias.Rows[index].Cells["prenPropietario"].Value = "Deudor";
            }

            dgvPrendarias.Rows[index].Cells["bien"].Value = prendaria.bien;
            dgvPrendarias.Rows[index].Cells["prenDesc"].Value = prendaria.descripcion;
        }

        //Limpiar los controles vinculados a las garantias prendarias. 
        private void limpiarControlesPrendaria()
        {
            cmbPredariaPropietario.Text = "Deudor";
            txtPrendariaNombre.Text = "";
            txtPrendariaDescripcion.Text = "";

            btnPrendariaAgregar.Text = "Agregar";
        }

        private void btnDepositosAgregar_Click(object sender, EventArgs e)
        {
            if (cmbDepositos.SelectedIndex != -1)
            {
                ComboBoxItem item = (ComboBoxItem)cmbDepositos.SelectedItem;
                agregarDepositoADataGrid((int)item.Value);
            }
            else
            {
                MessageBox.Show("Seleccione una cuenta de ahorro", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarDepositoADataGrid(int id)
        {
            ComboBoxItem item = null;
            foreach (ComboBoxItem i in cmbDepositos.Items)
            {
                if ((int)i.Value == id)
                {
                    item = i;
                }
            }

            int index = dgvDepositos.Rows.Add();
            dgvDepositos.Rows[index].Cells["depositoObjeto"].Value = item.Value;
            dgvDepositos.Rows[index].Cells["codigo"].Value = item.Text;
        }
    }
}

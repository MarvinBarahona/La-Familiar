using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using La_Familiar.ClasesServicio;
using La_Familiar.Clases;
using La_Familiar.ClasesEntidad;

namespace La_Familiar.Formularios
{
    public partial class FormCreditoNuevo : Form
    {
        private Credito credito;
        private bool bandera = true;

        public FormCreditoNuevo()
        {
            InitializeComponent();
            AsociadoServicio.fillComboBox(cmbAsociado);

            valoresIniciales();
        }

        public FormCreditoNuevo(string nombre)
        {
            InitializeComponent();
            AsociadoServicio.fillComboBox(cmbAsociado);           

            valoresIniciales();

            cmbAsociado.Text = nombre;
            cmbAsociado.Enabled = false;
        }

        private void valoresIniciales()
        {
            credito = new Credito();
            credito.creditoDescuento = new CreditoDescuento();

            //Datos iniciales del crédito. 
            credito.interes = (byte)nudTasa.Value;
            credito.monto = nudMonto.Value;
            credito.plazo = (byte)nudPlazo.Value;
            credito.aportacion = nudAportacion.Value;
            credito.cuota_social = 1.25M;
            credito.creditoDescuento.cuota_ingreso = 0;

            calcularCuotaEstimada();
        }

        #region Manejo de cuota estimada

        //Método para calcular la cuota estimada del crédito. 
        void calcularCuotaEstimada()
        {
            decimal previa = 0;

            double tasaR = Convert.ToDouble((double)credito.interes / 1200);
            double montoD = Convert.ToDouble(credito.monto);
            double plazo = Convert.ToDouble(nudPlazo.Value);

            previa = Math.Truncate(Convert.ToDecimal((montoD * tasaR * Math.Pow(1 + tasaR, plazo) / (Math.Pow(1 + tasaR, plazo) - 1)) + Convert.ToDouble(credito.aportacion) + Convert.ToDouble(credito.cuota_social)) * 100);
            previa = ++previa / 100;

            bandera = false;
            nudCuota.Value = previa;
            bandera = true;
            lblCuota.Text = " $" + previa;
        }

        //Selección del tipo del crédito. 
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            credito.tipo = cmbTipo.SelectedItem.ToString();
            calcularCuotaEstimada();

            switch (credito.tipo) { 
                case ("Consumo"):
                    credito.codigo = TiposCorrelativo.CreditoConsumo.generarCodigo();
                    lblCodigo.Text = credito.codigo;
                    credito.codigo = TiposCorrelativo.CreditoConsumo.getCorrelativo().ToString();
                    montoLimite(true);
                break;
                case ("Comercio"):
                    credito.codigo = TiposCorrelativo.CreditoComercio.generarCodigo();
                    lblCodigo.Text = credito.codigo;
                    credito.codigo = TiposCorrelativo.CreditoComercio.getCorrelativo().ToString();
                    montoLimite(true);
                break;
                case ("Servicio"):
                    credito.codigo = TiposCorrelativo.CreditoServicio.generarCodigo();
                    lblCodigo.Text = credito.codigo;
                    credito.codigo = TiposCorrelativo.CreditoServicio.getCorrelativo().ToString();
                    montoLimite(true);
                break;
                case ("Vivienda"):
                    credito.codigo = TiposCorrelativo.CreditoVivienda.generarCodigo();
                    lblCodigo.Text = credito.codigo;
                    credito.codigo = TiposCorrelativo.CreditoVivienda.getCorrelativo().ToString();
                    montoLimite(true);
                break;
                case ("Sobre deposito a plazo"):
                    credito.codigo = TiposCorrelativo.CreditoDeposito.generarCodigo();
                    lblCodigo.Text = credito.codigo;
                    credito.codigo = TiposCorrelativo.CreditoDeposito.getCorrelativo().ToString();
                    montoLimite(true);
                break;
                case ("Liquidez o rotativo"):
                    credito.codigo = TiposCorrelativo.CreditoRotativo.generarCodigo();
                    lblCodigo.Text = credito.codigo;
                    credito.codigo = TiposCorrelativo.CreditoRotativo.getCorrelativo().ToString();
                    montoLimite(true);
                break;
                case("Sobre aportación"):
                    credito.codigo = TiposCorrelativo.CreditoAportacion.generarCodigo();
                    lblCodigo.Text = credito.codigo;
                    credito.codigo = TiposCorrelativo.CreditoAportacion.getCorrelativo().ToString();
                    montoLimite(false);
                    break;
            }
        }

        //Selección de la tasa. 
        private void nudTasa_ValueChanged(object sender, EventArgs e)
        {
            credito.interes = (byte)nudTasa.Value;
            calcularCuotaEstimada();
        }

        //Selección del monto. 
        private void nudMonto_ValueChanged(object sender, EventArgs e)
        {
            credito.monto = nudMonto.Value;
            calcularCuotaEstimada();
        }

        //Selección del plazo
        private void nudPlazo_ValueChanged(object sender, EventArgs e)
        {
            credito.plazo = (byte)nudPlazo.Value;
            if(bandera)
                calcularCuotaEstimada();
        }

        //Selección de la aportación. 
        private void nudAportacion_ValueChanged(object sender, EventArgs e)
        {
            credito.aportacion = nudAportacion.Value;
            calcularCuotaEstimada();
        }

        //Selección de la comisión social. 
        private void ckbComisionSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbComisionSocial.Checked) 
                credito.cuota_social = 1.25M;
            else 
                credito.cuota_social = 0;

            calcularCuotaEstimada();
        }
        #endregion

        #region Botones

        //BtnGarantías: abre el form para la asignación de garantías. 
        private void btnGarantias_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(credito.tipo))
                MessageBox.Show("Seleccione un tipo de crédito", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Form form = new FormCreditoAgregarGarantias(credito);
                form.ShowDialog();
            }
        }
        
        //Guardar el crédito. 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbAsociado.SelectedIndex == -1)
                MessageBox.Show("Seleccione un asociado", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(credito.tipo))
                MessageBox.Show("Seleccione un tipo de crédito", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if(String.IsNullOrEmpty(credito.forma_pago))
                MessageBox.Show("Seleccione una forma de pago", "Error en la entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                //Asociado. 
                Asociado asociado = (Asociado)(cmbAsociado.SelectedItem as ComboBoxItem).Value;
                credito.idAsociado = asociado.id;

                //Descuentos del crédito. 
                credito.creditoDescuento.escrituracion = credito.monto * 0.01M;
                if (credito.creditoDescuento.escrituracion < 10)
                    credito.creditoDescuento.escrituracion = 10;

                int mult = (int)Math.Ceiling(credito.monto / 800);
                credito.creditoDescuento.seguro = 12 * mult;

                credito.creditoDescuento.papeleria = credito.monto * 0.03M;

                //Otros datos del crédito (no asignados todavia). 
                credito.cuota = nudCuota.Value;
                credito.fecha = dtpFecha.Value;
                credito.garantia_aportacion = ckbGarantiaAportacion.Checked;

                Form formEspera = new FormEspera();
                formEspera.Show();
                try
                {
                    Queries.transactionBegin();

                    credito.insert();

                    if (ckbCuotaIngreso.Checked)
                    {
                        AportacionDetalle detalle = new AportacionDetalle(asociado, "Abono inicial", credito.fecha, 10);
                        detalle.insert();
                    }

                    switch (credito.tipo)
                    {
                        case ("Consumo"):
                            TiposCorrelativo.CreditoConsumo.update();
                            break;
                        case ("Comercio"):
                            TiposCorrelativo.CreditoComercio.update();
                            break;
                        case ("Servicio"):
                            TiposCorrelativo.CreditoServicio.update();
                            break;
                        case ("Vivienda"):
                            TiposCorrelativo.CreditoVivienda.update();
                            break;
                        case ("Sobre deposito a plazo"):
                            TiposCorrelativo.CreditoDeposito.update();
                            break;
                        case ("Liquidez o rotativo"):
                            TiposCorrelativo.CreditoRotativo.update();
                            break;
                        default:
                            MessageBox.Show("1");
                            break;
                    }

                    // #### Creación de reportes del crédito ####
                    credito.asociado = AsociadoServicio.selectParcial(credito.idAsociado);
                    
                    //Reportes.cartaAprobacion(credito.asociado, credito);
                    //Reportes.hojaLiquidacion(credito.asociado, credito);
                    //Reportes.mutuo(credito.asociado, credito);
                    //if (credito.forma_pago == "Orden de descuento")
                    //    Reportes.ordenDescuento(credito.asociado, credito);
                    //Reportes.proyeccionPagos(credito.asociado, credito);

                    Queries.transactionCommit();

                    formEspera.Close();
                    //Reportes.abrirCarpeta();
                    this.Close();
                }
                catch (Exception ex)
                {
                    formEspera.Close();
                    Queries.transactionRollback();

                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);                    
                }
            }            
        }

        //Cancelar. 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Otros controles

        //¿Agregar la cuota de ingreso al crédito?
        private void ckbCuotaIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCuotaIngreso.Checked){
                credito.creditoDescuento.cuota_ingreso = 25;
            }
            else {
                credito.creditoDescuento.cuota_ingreso = 0;
            }
        }

        //¿La aportación del asociado es garantía de la aportación?
        private void ckbGarantiaAportacion_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGarantiaAportacion.Checked)
            {
                credito.garantia_aportacion = true;
            }
            else 
            {
                credito.garantia_aportacion = false;
            }
        }

        //Asignar la forma de pago al crédito. 
        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            credito.forma_pago = cmbFormaPago.SelectedItem.ToString();
        }

        //Modificar limites de monto posible.
        private void montoLimite(bool tipo) {
            if (tipo)
            {
                nudMonto.Maximum = 75000;
                nudMonto.Value = 100;
            }
            else {
                try
                {
                    Asociado asociado = (Asociado)(cmbAsociado.SelectedItem as ComboBoxItem).Value;
                    nudMonto.Maximum = asociado.aportacion * 1.5M;
                    nudMonto.Value = asociado.aportacion;
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Seleccione un asociado", "Asociado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cmbAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(credito.tipo) && credito.tipo == "Sobre aportación")
                montoLimite(false);
            Asociado asociado = (cmbAsociado.SelectedItem as ComboBoxItem).Value as Asociado;
            credito.idAsociado = asociado.id;

            ckbCuotaIngreso.Visible = !asociado.abonoInicial;
        }
        #endregion        

        private void nudCuota_ValueChanged(object sender, EventArgs e)
        {
            if (bandera)
            {
                double cuota = Convert.ToDouble(nudCuota.Value - credito.cuota_social - credito.aportacion);
                double monto = Convert.ToDouble(nudMonto.Value);
                double i = Convert.ToDouble(nudTasa.Value / 1200);
                bandera = false;
                nudPlazo.Value = Convert.ToDecimal(Math.Ceiling((Math.Log(cuota) - Math.Log(cuota - monto * i)) / Math.Log(1 + i)));
                bandera = true;
            }
        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void FormCreditoNuevo_Load(object sender, EventArgs e)
        {

        }
    }    
}

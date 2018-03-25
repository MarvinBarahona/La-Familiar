using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

using La_Familiar.ClasesEntidad;
using La_Familiar.ClasesServicio;
using La_Familiar.Clases;

namespace La_Familiar.Formularios
{
    public partial class FormAhorroNuevo : Form
    {
        Ahorro ahorro;

        public FormAhorroNuevo()
        {            
            InitializeComponent();
            AsociadoServicio.fillComboBox(cmbAsociados);

            nudPlazo.Enabled = false;
            nudTasa.Enabled = false;
            nudMonto.Enabled = false;
            cmbFormaPago.Enabled = false;

            ahorro = new Ahorro();
        }

        public FormAhorroNuevo(string nombre)
        {
            InitializeComponent();
            AsociadoServicio.fillComboBox(cmbAsociados);

            nudPlazo.Enabled = false;
            nudTasa.Enabled = false;
            nudMonto.Enabled = false;
            cmbFormaPago.Enabled = false;

            ahorro = new Ahorro();

            cmbAsociados.Text = nombre;
            cmbAsociados.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbAsociados.SelectedIndex != -1 && cmbPlan.SelectedIndex != -1 && ahorro.beneficiarios != null && (!cmbFormaPago.Enabled || cmbFormaPago.SelectedIndex != -1))
            {
                Form formEspera = new FormEspera();
                formEspera.Show();

                try
                {   
                    Queries.transactionBegin();

                    Asociado asociado = (Asociado)(cmbAsociados.SelectedItem as ComboBoxItem).Value;
                    asociado = AsociadoServicio.selectParcial(asociado.id);

                    ahorro.idAsociado = asociado.id;
                    ahorro.fecha = dtpFecha.Value;
                    ahorro.interes = (byte)nudTasa.Value;

                    if (ahorro.tipo == "Depósito a plazo")
                    {
                        AhorroPlazo ahorroPlazo = new AhorroPlazo();

                        ahorroPlazo.montoInicial = nudMonto.Value;
                        ahorroPlazo.plazo = (byte)nudPlazo.Value;
                        ahorroPlazo.extendido = 1;
                        ahorroPlazo.codigoCuenta = cmbFormaPago.SelectedItem.ToString();

                        ahorro.ahorroPlazo = ahorroPlazo;
                    }

                    if (ahorro.tipo == "Programado")
                    {
                        AhorroProgramado ahorroProgramado = new AhorroProgramado();

                        ahorroProgramado.cuota = nudMonto.Value;
                        ahorroProgramado.formaPago = cmbFormaPago.SelectedItem.ToString();
                        ahorroProgramado.plazo = (byte)nudPlazo.Value;
                        ahorroProgramado.extendido = 1;

                        ahorro.ahorroProgramado = ahorroProgramado;
                    }

                    ahorro.insert();

                    switch (ahorro.tipo)
                    {
                        case "Corriente":
                            TiposCorrelativo.AhorroCorriente.update();
                            Reportes.contratoAhorroCorriente(asociado, ahorro);
                            break;
                        case "Depósito a plazo":
                            TiposCorrelativo.AhorroPlazo.update();
                            Reportes.certificado(asociado, ahorro);
                            break;
                        case "Programado":
                            TiposCorrelativo.AhorroProgramado.update();
                            Reportes.contratoAhorroProgramado(asociado, ahorro);
                            if (ahorro.ahorroProgramado.formaPago == "Orden de descuento")
                                Reportes.ordenDescuento(asociado, ahorro);
                            break;
                    }

                    Queries.transactionCommit();

                    formEspera.Close();

                    Reportes.abrirCarpeta();
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
            else
            {
                MessageBox.Show("Debe completar los datos");
            }
        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ahorro.tipo = cmbPlan.SelectedItem.ToString();

            switch (ahorro.tipo)
            {
                case "Corriente":
                    nudPlazo.Enabled = false;
                    nudTasa.Enabled = true;
                    nudMonto.Enabled = false;
                    cmbFormaPago.Enabled = false;

                    cmbFormaPago.Text = "";

                    nudPlazo.Minimum = 0;
                    nudPlazo.Value = 0;                    
                    nudTasa.Value = 2;

                    ahorro.codigo = TiposCorrelativo.AhorroCorriente.generarCodigo();
                    lblCodigo.Text = "Código:   " + ahorro.codigo;
                    ahorro.codigo = TiposCorrelativo.AhorroCorriente.getCorrelativo().ToString();
                    break;
                case "Depósito a plazo":
                    nudPlazo.Enabled = true;
                    nudTasa.Enabled = true;
                    nudMonto.Enabled = true;
                    cmbFormaPago.Enabled = true;

                    nudPlazo.Minimum = 12;
                    nudPlazo.Maximum = 60;
                    nudPlazo.Value = 12;
                    nudTasa.Value = 7;
                    nudMonto.Minimum = 100;
                    lblMonto.Text = "Monto: ";

                    
                    AhorroServicio.fillComboBoxCuentasAhorro(cmbFormaPago,ahorro.idAsociado);
                    lblPago.Text = "Cuena de ahorro: ";

                    ahorro.codigo = TiposCorrelativo.AhorroPlazo.generarCodigo();
                    lblCodigo.Text = "Código:   " + ahorro.codigo;
                    ahorro.codigo = TiposCorrelativo.AhorroPlazo.getCorrelativo().ToString();
                    break;
                case "Programado":
                    nudPlazo.Enabled = true;
                    cmbFormaPago.Enabled = true;
                    nudMonto.Enabled = true;
                    nudTasa.Enabled = true;
                    cmbFormaPago.Text = "";
                    nudPlazo.Minimum = 3;
                    nudPlazo.Maximum = 24;
                    nudPlazo.Value = 6;
                    nudTasa.Value = 5;
                    nudMonto.Minimum = 25;

                    lblMonto.Text = "Cuota: ";
                    lblPago.Text = "Forma de pago: ";

                    cmbFormaPago.Items.Clear();
                    cmbFormaPago.Items.Add("Personal");
                    cmbFormaPago.Items.Add("Orden de descuento");

                    ahorro.codigo = TiposCorrelativo.AhorroProgramado.generarCodigo();
                    lblCodigo.Text = "Código:   " + ahorro.codigo;
                    ahorro.codigo = TiposCorrelativo.AhorroProgramado.getCorrelativo().ToString();
                    break;
            }

            
        }

        private void btnBeneficiarios_Click(object sender, EventArgs e)
        {
            Form form = new FormAhorroBeneficiario(ahorro, this);
            form.ShowDialog();
        }

        private void cmbAsociados_SelectedIndexChanged(object sender, EventArgs e)
        {
            ahorro.idAsociado = ((Asociado)(cmbAsociados.SelectedItem as ComboBoxItem).Value).id;
        }
    }
}

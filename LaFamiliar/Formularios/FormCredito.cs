using La_Familiar.ClasesEntidad;
using La_Familiar.ClasesServicio;
using La_Familiar.Clases;
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

namespace La_Familiar.Formularios
{
    public partial class FormCredito : Form
    {
        Credito credito; 

        public FormCredito(int id)
        {
            InitializeComponent();
            this.credito = CreditoServicio.select(id);

            lblAsociado.Text += credito.asociado.nombre + " " + credito.asociado.apellido;
            lblNumPrestamo.Text += credito.codigo;
            lblMonto.Text += "$" + credito.monto;
            lblCuota.Text += "$" + credito.cuota;
            lblPlazo.Text += credito.plazo + " meses";
            lblFecha.Text += credito.fecha.ToShortDateString();
            lblAportacion.Text += "$" + credito.aportacion;
            lblCuotaSocial.Text += "$" + credito.cuota_social;
            lblInteres.Text += credito.interes + "%";
            lblFormaPago.Text += credito.forma_pago;

            if (!credito.activo)
            {
                btnGenerarDocs.Enabled = false;
                btnPagarCuota.Enabled = false;
            }
        }
        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            Form form = new FormCreditoPagarCuota(credito);
            form.ShowDialog();
        }

        private void FormCredito_Activated(object sender, EventArgs e)
        {
            lblSaldo.Text = "Saldo actual: $" + Math.Round(credito.saldoActual, 2);
            lblDiasMora.Text = "Días de mora: " + credito.diasMora.ToString();
            lblCategoria.Text = "Categoría: " + credito.categoria;

            tblTransacciones.Rows.Clear();

            int n = 1, index;
            DataGridViewRow row;
            foreach (CreditoDetalle detalle in credito.detallesPago)
            {
                index = tblTransacciones.Rows.Add();
                row = tblTransacciones.Rows[index];
                row.Cells["N"].Value = detalle.correlativo = n++;
                row.Cells["Fecha"].Value = detalle.fecha.ToShortDateString();
                row.Cells["Cuota"].Value = "$" +  Math.Round(detalle.monto_pagado, 2);
                row.Cells["Aportacion"].Value = Math.Round(detalle.aportacion, 2);
                row.Cells["CSocial"].Value = Math.Round(detalle.cuota_social, 2);
                row.Cells["Intereses"].Value = Math.Round(detalle.interes, 2);
                row.Cells["Capital"].Value = Math.Round(detalle.capital, 2);
                row.Cells["Saldo"].Value = "$" + Math.Round(detalle.saldoParcial, 2);
            }

            tblTransacciones.DoubleBuffered(true);
        }

        private void btnGarantias_Click(object sender, EventArgs e)
        {
            FormCreditoGarantias form = new FormCreditoGarantias(this.credito);
            form.ShowDialog();
        }

        private void btnGenerarDocs_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            if (ckbConstanciaSaldo.Checked) Reportes.constanciaSaldos(credito.asociado, credito);
            if (ckbEstadoCuenta.Checked) Reportes.estadoCuenta(credito.asociado, credito);
            if (ckbContraorden.Checked) Reportes.contraorden(credito.asociado, credito);

            formEspera.Close();
            Reportes.abrirCarpeta();
        }
    }
}

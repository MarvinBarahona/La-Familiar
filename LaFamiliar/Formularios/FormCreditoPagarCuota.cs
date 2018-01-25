using La_Familiar.ClasesEntidad;
using La_Familiar.Clases;
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

namespace La_Familiar.Formularios
{
    public partial class FormCreditoPagarCuota : Form
    {
        Credito credito;

        public FormCreditoPagarCuota(Credito credito)
        {
            InitializeComponent();

            this.credito = credito;
            
            nudMonto.Minimum = 1;
            nudMonto.Value = credito.cuota;
            nudMonto.Increment = credito.cuota;

            dtpFecha.MinDate = credito.fechaUltimoPago;
            dtpFecha.MaxDate = DateTime.Today;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int m = dtpFecha.Value.monthsSince(credito.fechaUltimoPago);

            if (credito.detallesPago.Count == 0) m++;

            Form formEspera = new FormEspera();
            formEspera.Show();

            try
            {
                Queries.transactionBegin();

                if (m == 0)
                {
                    credito.insertDetalle(nudMonto.Value, 0, 0, dtpFecha.Value);
                    this.Close();
                }
                else if (nudMonto.Value >= m * (credito.cuota_social + credito.aportacion))
                {
                    credito.insertDetalle(nudMonto.Value, credito.aportacion * m, credito.cuota_social * m, dtpFecha.Value);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El monto pagado es menor de lo que se debe en concepto de cuota social y aportación", "Pago insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                formEspera.Close();
                Queries.transactionCommit();
            }
            catch (Exception ex)
            {
                formEspera.Close();
                Queries.transactionRollback();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace La_Familiar.Formularios
{

    public partial class FormAhorro : Form
    {
        Ahorro ahorro;

        public FormAhorro(int idAhorro)
        {
            InitializeComponent();

            ahorro = AhorroServicio.select(idAhorro);

            txtAsociado.Text = ahorro.asociado.nombre + " " + ahorro.asociado.apellido;
            lblPlan.Text += ahorro.tipo;
            lblTasa.Text += ahorro.interes + "% anual";
            lblFecha.Text += ahorro.fecha.ToShortDateString();

            string plazo = "";
            switch (ahorro.tipo)
            {
                case "Corriente":
                    plazo = "indefinido";
                    btnFinalizar.Enabled = ahorro.caducado;
                    break;
                case "Depósito a plazo":
                    plazo = ahorro.ahorroPlazo.duracion + " meses";
                    btnFinalizar.Enabled = btnExtender.Enabled = ahorro.caducado;
                    break;
                case "Programado":
                    plazo = ahorro.ahorroProgramado.duracion + " meses";
                    btnFinalizar.Enabled = btnExtender.Enabled = ahorro.caducado;
                    btnContraorden.Enabled = ahorro.ahorroProgramado.formaPago == "Orden de descuento";
                    break;
            }
            lblPlazo.Text += plazo;

            txtCuenta.Text = ahorro.codigo;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form form = new FormAhorroMovimiento(ahorro);
            form.ShowDialog();
        }

        private void btnExtender_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Extender el plazo del ahorro?", "Extensión de plazo del ahorro", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ahorro.extenderPlazo();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Finalizar plan de ahorro?","Finalizar plan de ahorro",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                ahorro.finalizar();
            }
        }

        private void FormAhorro_Activated(object sender, EventArgs e)
        {
            lblSaldo.Text = "Saldo actual: " + ahorro.saldo.ToString("C");

            tblTransacciones.Rows.Clear();

            int n = 1, index;
            DataGridViewRow row;
            foreach (AhorroDetalle detalle in ahorro.detalles)
            {
                index = tblTransacciones.Rows.Add();
                row = tblTransacciones.Rows[index];

                row.Cells["num"].Value = detalle.correlativo = n++;
                row.Cells["fecha"].Value = detalle.fecha.ToShortDateString();
                row.Cells["saldo"].Value = detalle.saldoParcial.ToString("C");
                row.Cells["tipo"].Value = detalle.tipo;
                row.Cells["monto"].Value = detalle.monto.ToString("C");
            }

            tblTransacciones.DoubleBuffered(true);
        }

        private void btnCapitalizar_Click(object sender, EventArgs e)
        {
            ahorro.capitalizar(DateTime.Today);
        }

        private void btnContraorden_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.contraorden(ahorro.asociado, ahorro);

            formEspera.Close();
            Reportes.abrirCarpeta();
        }

        private void btnBeneficiarios_Click(object sender, EventArgs e)
        {
            FormAhorroBeneficiario form = new FormAhorroBeneficiario(ahorro, this);
            form.ShowDialog();
        }
    }
}

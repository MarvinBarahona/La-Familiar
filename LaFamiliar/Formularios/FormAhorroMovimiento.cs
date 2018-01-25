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
using La_Familiar.ClasesEntidad;
using La_Familiar.Clases;

namespace La_Familiar.Formularios
{
    public partial class FormAhorroMovimiento : Form
    {
        Ahorro ahorro;

        public FormAhorroMovimiento(Ahorro ahorro)
        {
            InitializeComponent();
            dtpFecha.MinDate = ahorro.ultimoMovimiento;
            dtpFecha.MaxDate = DateTime.Today;
            dtpFecha.Value = DateTime.Today;

            this.ahorro = ahorro;
            btnAbono.Checked = true;

            if (ahorro.tipo == "Depósito a plazo" || ahorro.saldo <= 0)
            {
                btnRetiro.Enabled = false;
            }
            else if (ahorro.tipo == "Programado")
            {
                nudMonto.Value = ahorro.ahorroProgramado.cuota;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            string tipo = btnAbono.Checked ? "Abono" : "Retiro";

            AhorroDetalle detalle = ahorro.insertDetalle(tipo, nudMonto.Value, dtpFecha.Value);
            Reportes.comprobanteMovimiento(ahorro.asociado, ahorro, detalle);
            
            formEspera.Close();
            this.Close();
        }

        private void btnRetiro_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRetiro.Checked)
            {
                nudMonto.Maximum = ahorro.saldo - 1;
            }
            else
            {
                nudMonto.Maximum = 5000;
            }
        }
    }
}

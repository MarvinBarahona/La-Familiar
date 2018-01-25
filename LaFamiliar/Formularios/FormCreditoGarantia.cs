using La_Familiar.ClasesEntidad;
using La_Familiar.ClasesServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Familiar.Formularios
{
    public partial class FormCreditoGarantias : Form
    {
        public FormCreditoGarantias(Credito credito)
        {
            InitializeComponent();
            GarantiasServicios.selectGarantias(credito);
            lblCodigo.Text = "Crédito: " + credito.codigo;

            foreach (GarantiaFiador fiador in credito.fiadores)
            {
                int i = dgvFiadores.Rows.Add();
                dgvFiadores.Rows[i].Cells["fiador"].Value = fiador.nombres + fiador.apellidos;
                dgvFiadores.Rows[i].Cells["dui"].Value = fiador.dui;
                dgvFiadores.Rows[i].Cells["nit"].Value = fiador.nit;
                dgvFiadores.Rows[i].Cells["tel"].Value = fiador.telefono;
                dgvFiadores.Rows[i].Cells["direccion"].Value = fiador.direccion;
            }

            foreach (GarantiaHipotecaria hipotecaria in credito.hipotecarias)
            {
                int i = dgvHipotecarias.Rows.Add();
                dgvHipotecarias.Rows[i].Cells["matricula"].Value = hipotecaria.matricula;
                dgvHipotecarias.Rows[i].Cells["medida"].Value = hipotecaria.medidas;
                dgvHipotecarias.Rows[i].Cells["hipoDir"].Value = hipotecaria.direccion;
                if (hipotecaria.fiador == null)
                    dgvHipotecarias.Rows[i].Cells["propietario"].Value = "Deudor";
                else
                    dgvHipotecarias.Rows[i].Cells["propietario"].Value = hipotecaria.fiador.nombres + " " + hipotecaria.fiador.apellidos;
            }

            foreach (GarantiaPrendaria prendaria in credito.prendarias)
            {
                int i = dgvPrendarias.Rows.Add();
                dgvPrendarias.Rows[i].Cells["bien"].Value = prendaria.bien;
                dgvPrendarias.Rows[i].Cells["prenDesc"].Value = prendaria.descripcion;
                if (prendaria.fiador == null)
                    dgvPrendarias.Rows[i].Cells["prenPropietario"].Value = "Deudor";
                else
                    dgvPrendarias.Rows[i].Cells["prenPropietario"].Value = prendaria.fiador.nombres + " " +prendaria.fiador.apellidos;
            }

            foreach (string codigoAhorro in credito.codDepositos)
            {
                lblDepositos.Text += " " + codigoAhorro;
            }

            lblAportaciones.Visible = credito.garantia_aportacion;
        }
    }
}

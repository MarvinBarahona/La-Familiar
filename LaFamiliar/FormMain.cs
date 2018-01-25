using La_Familiar.Formularios;
using La_Familiar.Clases;
using La_Familiar.ClasesServicio;
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

namespace La_Familiar
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            tblAsociados.CellMouseEnter += new DataGridViewCellEventHandler(Style.dataGridMouseEnter);
            tblAsociados.CellMouseLeave += new DataGridViewCellEventHandler(Style.dataGridMouseLeave);
            tblAhorros.CellMouseEnter += new DataGridViewCellEventHandler(Style.dataGridMouseEnter);
            tblAhorros.CellMouseLeave += new DataGridViewCellEventHandler(Style.dataGridMouseLeave);
            tblCreditos.CellMouseEnter += new DataGridViewCellEventHandler(Style.dataGridMouseEnter);
            tblCreditos.CellMouseLeave += new DataGridViewCellEventHandler(Style.dataGridMouseLeave);

            //Setea el atributo formMain de la clase FormProvider para poder cerrar o
            //mostrar la ventana desde otros form. 
            Provider.formMain = this;
        }

// #########################################################################################
// ##########       Eventos para doble click a las celdas de las tablas       ##############
// #########################################################################################

        private void tblAhorros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)tblAhorros.Rows[e.RowIndex].Cells["id"].Value;
            Form form = new FormAhorro(id);
            form.ShowDialog();
        }

        private void tblCreditos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = (int)tblCreditos.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FormCredito(id);
                form.ShowDialog();
            }            
        }

        private void tblAsociados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = (int)tblAsociados.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FormAsociado(id);
                form.Show();
                this.Hide();
            }            
        }

// #########################################################################################
// ##################         Botones para crear nuevos registros      #####################
// #########################################################################################

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form form = new FormCreditoNuevo();
            form.ShowDialog();
        }

        private void btnNuevoAhorro_Click(object sender, EventArgs e)
        {
            Form form = new FormAhorroNuevo();
            form.ShowDialog();
        }

        private void btnNuevoAsociado_Click(object sender, EventArgs e)
        {
            Form form = new FormAsociadoNuevo();
            form.ShowDialog();
        }

        private void btnAportacion_Click(object sender, EventArgs e)
        {
            Form form = new FormAportacionNueva();
            form.ShowDialog();
        }  

// #########################################################################################
// ##############       Llenar las tablas cuando se active el form      ####################
// #########################################################################################

        private void FormMain_Activated(object sender, EventArgs e)
        {
            AhorroServicio.fillTable(tblAhorros);
            CreditoServicio.fillTable(tblCreditos);
            AsociadoServicio.fillTable(tblAsociados);
        }

        private void tblAsociados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in tblAsociados.Rows)
            {
                int num = (int)row.Cells["id"].Value;
                string codigo = Provider.numToFilledZeroString(num, 6);
                row.Cells["idString"].Value = codigo;
            }
        }

        private void btnReportePagos_Click(object sender, EventArgs e)
        {
            Form form = new FormDatePicker();
            form.ShowDialog();
        }

        private void btnProvisional_Click(object sender, EventArgs e)
        {
            
        }
    }
}

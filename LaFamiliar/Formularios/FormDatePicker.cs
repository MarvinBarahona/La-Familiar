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

namespace La_Familiar.Formularios
{
    public partial class FormDatePicker : Form
    {
        public FormDatePicker()
        {
            InitializeComponent();

            dtpFecha.Value = DateTime.Today;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.pagosDiariosCredito(dtpFecha.Value);
            Reportes.abrirCarpeta();

            formEspera.Close();
            this.Close();
        }
    }
}

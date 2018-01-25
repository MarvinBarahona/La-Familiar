namespace La_Familiar.Formularios
{
    partial class FormCredito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCredito));
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblCuotaSocial = new System.Windows.Forms.Label();
            this.lblAportacion = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumPrestamo = new System.Windows.Forms.Label();
            this.lblAsociado = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.tblTransacciones = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagarCuota = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbContraorden = new System.Windows.Forms.CheckBox();
            this.btnGarantias = new System.Windows.Forms.Button();
            this.btnGenerarDocs = new System.Windows.Forms.Button();
            this.ckbEstadoCuenta = new System.Windows.Forms.CheckBox();
            this.ckbConstanciaSaldo = new System.Windows.Forms.CheckBox();
            this.lblDiasMora = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransacciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInfo
            // 
            this.grbInfo.BackColor = System.Drawing.Color.White;
            this.grbInfo.Controls.Add(this.lblFormaPago);
            this.grbInfo.Controls.Add(this.lblInteres);
            this.grbInfo.Controls.Add(this.lblCuotaSocial);
            this.grbInfo.Controls.Add(this.lblAportacion);
            this.grbInfo.Controls.Add(this.lblCuota);
            this.grbInfo.Controls.Add(this.lblMonto);
            this.grbInfo.Controls.Add(this.lblPlazo);
            this.grbInfo.Controls.Add(this.lblFecha);
            this.grbInfo.Controls.Add(this.lblNumPrestamo);
            this.grbInfo.Controls.Add(this.lblAsociado);
            this.grbInfo.Location = new System.Drawing.Point(22, 33);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(515, 203);
            this.grbInfo.TabIndex = 0;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Información del crédito";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(266, 171);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(103, 16);
            this.lblFormaPago.TabIndex = 11;
            this.lblFormaPago.Text = "Forma de pago: ";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(26, 171);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(121, 16);
            this.lblInteres.TabIndex = 10;
            this.lblInteres.Text = "Tasa interés anual: ";
            // 
            // lblCuotaSocial
            // 
            this.lblCuotaSocial.AutoSize = true;
            this.lblCuotaSocial.Location = new System.Drawing.Point(266, 135);
            this.lblCuotaSocial.Name = "lblCuotaSocial";
            this.lblCuotaSocial.Size = new System.Drawing.Size(141, 16);
            this.lblCuotaSocial.TabIndex = 9;
            this.lblCuotaSocial.Text = "Cuota social mensual: ";
            // 
            // lblAportacion
            // 
            this.lblAportacion.AutoSize = true;
            this.lblAportacion.Location = new System.Drawing.Point(26, 135);
            this.lblAportacion.Name = "lblAportacion";
            this.lblAportacion.Size = new System.Drawing.Size(131, 16);
            this.lblAportacion.TabIndex = 8;
            this.lblAportacion.Text = "Aportación mensual: ";
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Location = new System.Drawing.Point(266, 99);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(50, 16);
            this.lblCuota.TabIndex = 7;
            this.lblCuota.Text = "Cuota: ";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(26, 99);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(106, 16);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "Monto otorgado: ";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(266, 63);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(49, 16);
            this.lblPlazo.TabIndex = 3;
            this.lblPlazo.Text = "Plazo: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(26, 63);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(149, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de otorgamiento: ";
            // 
            // lblNumPrestamo
            // 
            this.lblNumPrestamo.AutoSize = true;
            this.lblNumPrestamo.Location = new System.Drawing.Point(26, 27);
            this.lblNumPrestamo.Name = "lblNumPrestamo";
            this.lblNumPrestamo.Size = new System.Drawing.Size(56, 16);
            this.lblNumPrestamo.TabIndex = 1;
            this.lblNumPrestamo.Text = "Código: ";
            // 
            // lblAsociado
            // 
            this.lblAsociado.AutoSize = true;
            this.lblAsociado.Location = new System.Drawing.Point(189, 27);
            this.lblAsociado.Name = "lblAsociado";
            this.lblAsociado.Size = new System.Drawing.Size(70, 16);
            this.lblAsociado.TabIndex = 0;
            this.lblAsociado.Text = "Asociado: ";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(34, 279);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(96, 16);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "Saldo actual: ";
            // 
            // tblTransacciones
            // 
            this.tblTransacciones.AllowUserToAddRows = false;
            this.tblTransacciones.AllowUserToDeleteRows = false;
            this.tblTransacciones.AllowUserToResizeColumns = false;
            this.tblTransacciones.AllowUserToResizeRows = false;
            this.tblTransacciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tblTransacciones.BackgroundColor = System.Drawing.Color.White;
            this.tblTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.Fecha,
            this.Cuota,
            this.Aportacion,
            this.CSocial,
            this.Intereses,
            this.Capital,
            this.Saldo});
            this.tblTransacciones.Location = new System.Drawing.Point(22, 320);
            this.tblTransacciones.MultiSelect = false;
            this.tblTransacciones.Name = "tblTransacciones";
            this.tblTransacciones.ReadOnly = true;
            this.tblTransacciones.RowHeadersVisible = false;
            this.tblTransacciones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tblTransacciones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tblTransacciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.tblTransacciones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tblTransacciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTransacciones.Size = new System.Drawing.Size(737, 202);
            this.tblTransacciones.TabIndex = 1;
            // 
            // N
            // 
            this.N.FillWeight = 33F;
            this.N.HeaderText = "N";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.N.Width = 30;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 73.00046F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.Width = 90;
            // 
            // Cuota
            // 
            this.Cuota.FillWeight = 80.84966F;
            this.Cuota.HeaderText = "Monto";
            this.Cuota.Name = "Cuota";
            this.Cuota.ReadOnly = true;
            this.Cuota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuota.Width = 110;
            // 
            // Aportacion
            // 
            this.Aportacion.FillWeight = 90.69865F;
            this.Aportacion.HeaderText = "Aportación";
            this.Aportacion.Name = "Aportacion";
            this.Aportacion.ReadOnly = true;
            this.Aportacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CSocial
            // 
            this.CSocial.FillWeight = 103.0569F;
            this.CSocial.HeaderText = "C. Social";
            this.CSocial.Name = "CSocial";
            this.CSocial.ReadOnly = true;
            this.CSocial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Intereses
            // 
            this.Intereses.FillWeight = 118.5638F;
            this.Intereses.HeaderText = "Intereses";
            this.Intereses.Name = "Intereses";
            this.Intereses.ReadOnly = true;
            this.Intereses.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Capital
            // 
            this.Capital.FillWeight = 138.0215F;
            this.Capital.HeaderText = "Capital";
            this.Capital.Name = "Capital";
            this.Capital.ReadOnly = true;
            this.Capital.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Saldo
            // 
            this.Saldo.FillWeight = 162.4366F;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Saldo.Width = 140;
            // 
            // btnPagarCuota
            // 
            this.btnPagarCuota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagarCuota.Location = new System.Drawing.Point(15, 218);
            this.btnPagarCuota.Name = "btnPagarCuota";
            this.btnPagarCuota.Size = new System.Drawing.Size(170, 35);
            this.btnPagarCuota.TabIndex = 2;
            this.btnPagarCuota.Text = "Efectuar pago";
            this.btnPagarCuota.UseVisualStyleBackColor = true;
            this.btnPagarCuota.Click += new System.EventHandler(this.btnPagarCuota_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbContraorden);
            this.groupBox1.Controls.Add(this.btnGarantias);
            this.groupBox1.Controls.Add(this.btnGenerarDocs);
            this.groupBox1.Controls.Add(this.btnPagarCuota);
            this.groupBox1.Controls.Add(this.ckbEstadoCuenta);
            this.groupBox1.Controls.Add(this.ckbConstanciaSaldo);
            this.groupBox1.Location = new System.Drawing.Point(559, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // ckbContraorden
            // 
            this.ckbContraorden.AutoSize = true;
            this.ckbContraorden.Location = new System.Drawing.Point(27, 67);
            this.ckbContraorden.Name = "ckbContraorden";
            this.ckbContraorden.Size = new System.Drawing.Size(151, 20);
            this.ckbContraorden.TabIndex = 10;
            this.ckbContraorden.Text = "Contra orden de desc";
            this.ckbContraorden.UseVisualStyleBackColor = true;
            // 
            // btnGarantias
            // 
            this.btnGarantias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGarantias.Location = new System.Drawing.Point(15, 171);
            this.btnGarantias.Name = "btnGarantias";
            this.btnGarantias.Size = new System.Drawing.Size(170, 35);
            this.btnGarantias.TabIndex = 9;
            this.btnGarantias.Text = "Ver garantías";
            this.btnGarantias.UseVisualStyleBackColor = true;
            this.btnGarantias.Click += new System.EventHandler(this.btnGarantias_Click);
            // 
            // btnGenerarDocs
            // 
            this.btnGenerarDocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarDocs.Location = new System.Drawing.Point(15, 126);
            this.btnGenerarDocs.Name = "btnGenerarDocs";
            this.btnGenerarDocs.Size = new System.Drawing.Size(170, 35);
            this.btnGenerarDocs.TabIndex = 7;
            this.btnGenerarDocs.Text = "Generar documentos";
            this.btnGenerarDocs.UseVisualStyleBackColor = true;
            this.btnGenerarDocs.Click += new System.EventHandler(this.btnGenerarDocs_Click);
            // 
            // ckbEstadoCuenta
            // 
            this.ckbEstadoCuenta.AutoSize = true;
            this.ckbEstadoCuenta.Location = new System.Drawing.Point(27, 44);
            this.ckbEstadoCuenta.Name = "ckbEstadoCuenta";
            this.ckbEstadoCuenta.Size = new System.Drawing.Size(129, 20);
            this.ckbEstadoCuenta.TabIndex = 6;
            this.ckbEstadoCuenta.Text = "Estado de cuenta";
            this.ckbEstadoCuenta.UseVisualStyleBackColor = true;
            // 
            // ckbConstanciaSaldo
            // 
            this.ckbConstanciaSaldo.AutoSize = true;
            this.ckbConstanciaSaldo.Location = new System.Drawing.Point(27, 21);
            this.ckbConstanciaSaldo.Name = "ckbConstanciaSaldo";
            this.ckbConstanciaSaldo.Size = new System.Drawing.Size(152, 20);
            this.ckbConstanciaSaldo.TabIndex = 5;
            this.ckbConstanciaSaldo.Text = "Constancia de saldos";
            this.ckbConstanciaSaldo.UseVisualStyleBackColor = true;
            // 
            // lblDiasMora
            // 
            this.lblDiasMora.AutoSize = true;
            this.lblDiasMora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasMora.Location = new System.Drawing.Point(222, 279);
            this.lblDiasMora.Name = "lblDiasMora";
            this.lblDiasMora.Size = new System.Drawing.Size(100, 16);
            this.lblDiasMora.TabIndex = 9;
            this.lblDiasMora.Text = "Días de mora: ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(387, 279);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 16);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 40);
            this.panel1.TabIndex = 11;
            // 
            // FormCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDiasMora);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblTransacciones);
            this.Controls.Add(this.grbInfo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Credito";
            this.Activated += new System.EventHandler(this.FormCredito_Activated);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransacciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.DataGridView tblTransacciones;
        private System.Windows.Forms.Label lblAsociado;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumPrestamo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerarDocs;
        private System.Windows.Forms.CheckBox ckbEstadoCuenta;
        private System.Windows.Forms.CheckBox ckbConstanciaSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblCuotaSocial;
        private System.Windows.Forms.Label lblAportacion;
        private System.Windows.Forms.Button btnGarantias;
        private System.Windows.Forms.CheckBox ckbContraorden;
        private System.Windows.Forms.Label lblDiasMora;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel panel1;
    }
}
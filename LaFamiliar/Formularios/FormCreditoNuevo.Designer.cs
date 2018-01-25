namespace La_Familiar.Formularios
{
    partial class FormCreditoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreditoNuevo));
            this.lblAsociado = new System.Windows.Forms.Label();
            this.cmbAsociado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPlazo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTasa = new System.Windows.Forms.NumericUpDown();
            this.btnGarantias = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.grbVistaPrevia = new System.Windows.Forms.GroupBox();
            this.lblCuota = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCuota = new System.Windows.Forms.NumericUpDown();
            this.lblCu = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.ckbGarantiaAportacion = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudAportacion = new System.Windows.Forms.NumericUpDown();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.ckbComisionSocial = new System.Windows.Forms.CheckBox();
            this.ckbCuotaIngreso = new System.Windows.Forms.CheckBox();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasa)).BeginInit();
            this.grbVistaPrevia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAportacion)).BeginInit();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAsociado
            // 
            this.lblAsociado.AutoSize = true;
            this.lblAsociado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsociado.Location = new System.Drawing.Point(84, 22);
            this.lblAsociado.Name = "lblAsociado";
            this.lblAsociado.Size = new System.Drawing.Size(66, 16);
            this.lblAsociado.TabIndex = 0;
            this.lblAsociado.Text = "Asociado:";
            // 
            // cmbAsociado
            // 
            this.cmbAsociado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAsociado.FormattingEnabled = true;
            this.cmbAsociado.Location = new System.Drawing.Point(162, 19);
            this.cmbAsociado.Name = "cmbAsociado";
            this.cmbAsociado.Size = new System.Drawing.Size(335, 24);
            this.cmbAsociado.TabIndex = 1;
            this.cmbAsociado.SelectedIndexChanged += new System.EventHandler(this.cmbAsociado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de crédito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto:";
            // 
            // nudMonto
            // 
            this.nudMonto.DecimalPlaces = 2;
            this.nudMonto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMonto.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMonto.Location = new System.Drawing.Point(131, 110);
            this.nudMonto.Maximum = new decimal(new int[] {
            75000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(121, 22);
            this.nudMonto.TabIndex = 4;
            this.nudMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMonto.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMonto.ValueChanged += new System.EventHandler(this.nudMonto_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plazo en meses:";
            // 
            // nudPlazo
            // 
            this.nudPlazo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlazo.Increment = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPlazo.Location = new System.Drawing.Point(456, 110);
            this.nudPlazo.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nudPlazo.Name = "nudPlazo";
            this.nudPlazo.Size = new System.Drawing.Size(62, 22);
            this.nudPlazo.TabIndex = 5;
            this.nudPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPlazo.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudPlazo.ValueChanged += new System.EventHandler(this.nudPlazo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Interes anual (%):";
            // 
            // nudTasa
            // 
            this.nudTasa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTasa.Location = new System.Drawing.Point(455, 60);
            this.nudTasa.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTasa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTasa.Name = "nudTasa";
            this.nudTasa.Size = new System.Drawing.Size(63, 22);
            this.nudTasa.TabIndex = 3;
            this.nudTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTasa.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudTasa.ValueChanged += new System.EventHandler(this.nudTasa_ValueChanged);
            // 
            // btnGarantias
            // 
            this.btnGarantias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGarantias.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarantias.Location = new System.Drawing.Point(62, 390);
            this.btnGarantias.Name = "btnGarantias";
            this.btnGarantias.Size = new System.Drawing.Size(140, 35);
            this.btnGarantias.TabIndex = 12;
            this.btnGarantias.Text = "Agregar garantías";
            this.btnGarantias.UseVisualStyleBackColor = true;
            this.btnGarantias.Click += new System.EventHandler(this.btnGarantias_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(332, 390);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 35);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseEnter += new System.EventHandler(this.btnGuardar_MouseEnter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(485, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 35);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Forma de pago:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Items.AddRange(new object[] {
            "Orden de descuento",
            "Personal",
            "Cargo a cuenta"});
            this.cmbFormaPago.Location = new System.Drawing.Point(131, 157);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(121, 24);
            this.cmbFormaPago.TabIndex = 6;
            this.cmbFormaPago.Text = "Seleccionar ...";
            this.cmbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPago_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(131, 197);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 22);
            this.dtpFecha.TabIndex = 8;
            // 
            // grbVistaPrevia
            // 
            this.grbVistaPrevia.Controls.Add(this.lblCuota);
            this.grbVistaPrevia.Controls.Add(this.lblCodigo);
            this.grbVistaPrevia.Controls.Add(this.label8);
            this.grbVistaPrevia.Controls.Add(this.label7);
            this.grbVistaPrevia.Controls.Add(this.nudCuota);
            this.grbVistaPrevia.Controls.Add(this.lblCu);
            this.grbVistaPrevia.Controls.Add(this.lblCod);
            this.grbVistaPrevia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVistaPrevia.Location = new System.Drawing.Point(40, 283);
            this.grbVistaPrevia.Name = "grbVistaPrevia";
            this.grbVistaPrevia.Size = new System.Drawing.Size(598, 55);
            this.grbVistaPrevia.TabIndex = 21;
            this.grbVistaPrevia.TabStop = false;
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Location = new System.Drawing.Point(291, 26);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(49, 16);
            this.lblCuota.TabIndex = 0;
            this.lblCuota.Text = "label10";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(82, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(93, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "___-__-______";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "REAL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "CUOTA";
            // 
            // nudCuota
            // 
            this.nudCuota.DecimalPlaces = 2;
            this.nudCuota.Location = new System.Drawing.Point(407, 24);
            this.nudCuota.Maximum = new decimal(new int[] {
            75000,
            0,
            0,
            0});
            this.nudCuota.Name = "nudCuota";
            this.nudCuota.Size = new System.Drawing.Size(86, 22);
            this.nudCuota.TabIndex = 10;
            this.nudCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCuota.ValueChanged += new System.EventHandler(this.nudCuota_ValueChanged);
            // 
            // lblCu
            // 
            this.lblCu.AutoSize = true;
            this.lblCu.Location = new System.Drawing.Point(206, 26);
            this.lblCu.Name = "lblCu";
            this.lblCu.Size = new System.Drawing.Size(79, 16);
            this.lblCu.TabIndex = 1;
            this.lblCu.Text = "SUGERIDA:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(13, 21);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(63, 16);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "CÓDIGO:";
            // 
            // ckbGarantiaAportacion
            // 
            this.ckbGarantiaAportacion.AutoSize = true;
            this.ckbGarantiaAportacion.Checked = true;
            this.ckbGarantiaAportacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbGarantiaAportacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGarantiaAportacion.Location = new System.Drawing.Point(56, 364);
            this.ckbGarantiaAportacion.Name = "ckbGarantiaAportacion";
            this.ckbGarantiaAportacion.Size = new System.Drawing.Size(175, 20);
            this.ckbGarantiaAportacion.TabIndex = 11;
            this.ckbGarantiaAportacion.Text = "Aportación como garantia";
            this.ckbGarantiaAportacion.UseVisualStyleBackColor = true;
            this.ckbGarantiaAportacion.CheckedChanged += new System.EventHandler(this.ckbGarantiaAportacion_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Aportación:";
            // 
            // nudAportacion
            // 
            this.nudAportacion.DecimalPlaces = 2;
            this.nudAportacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAportacion.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nudAportacion.Location = new System.Drawing.Point(458, 158);
            this.nudAportacion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAportacion.Name = "nudAportacion";
            this.nudAportacion.Size = new System.Drawing.Size(64, 22);
            this.nudAportacion.TabIndex = 7;
            this.nudAportacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAportacion.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            this.nudAportacion.ValueChanged += new System.EventHandler(this.nudAportacion_ValueChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Consumo",
            "Comercio",
            "Servicio",
            "Vivienda",
            "Sobre deposito a plazo",
            "Liquidez o rotativo",
            "Sobre aportación"});
            this.cmbTipo.Location = new System.Drawing.Point(131, 62);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(145, 24);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.Text = "Seleccionar ...";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // ckbComisionSocial
            // 
            this.ckbComisionSocial.AutoSize = true;
            this.ckbComisionSocial.Checked = true;
            this.ckbComisionSocial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbComisionSocial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbComisionSocial.Location = new System.Drawing.Point(346, 203);
            this.ckbComisionSocial.Name = "ckbComisionSocial";
            this.ckbComisionSocial.Size = new System.Drawing.Size(209, 20);
            this.ckbComisionSocial.TabIndex = 9;
            this.ckbComisionSocial.Text = "Añadir Comisión Social a cuota";
            this.ckbComisionSocial.UseVisualStyleBackColor = true;
            this.ckbComisionSocial.CheckedChanged += new System.EventHandler(this.ckbComisionSocial_CheckedChanged);
            // 
            // ckbCuotaIngreso
            // 
            this.ckbCuotaIngreso.AutoSize = true;
            this.ckbCuotaIngreso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCuotaIngreso.Location = new System.Drawing.Point(346, 226);
            this.ckbCuotaIngreso.Name = "ckbCuotaIngreso";
            this.ckbCuotaIngreso.Size = new System.Drawing.Size(164, 20);
            this.ckbCuotaIngreso.TabIndex = 13;
            this.ckbCuotaIngreso.Text = "Añadir cuota de ingreso";
            this.ckbCuotaIngreso.UseVisualStyleBackColor = true;
            this.ckbCuotaIngreso.CheckedChanged += new System.EventHandler(this.ckbCuotaIngreso_CheckedChanged);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.ckbCuotaIngreso);
            this.grbDatos.Controls.Add(this.ckbComisionSocial);
            this.grbDatos.Controls.Add(this.cmbTipo);
            this.grbDatos.Controls.Add(this.nudAportacion);
            this.grbDatos.Controls.Add(this.label9);
            this.grbDatos.Controls.Add(this.dtpFecha);
            this.grbDatos.Controls.Add(this.label6);
            this.grbDatos.Controls.Add(this.cmbFormaPago);
            this.grbDatos.Controls.Add(this.label5);
            this.grbDatos.Controls.Add(this.nudTasa);
            this.grbDatos.Controls.Add(this.label4);
            this.grbDatos.Controls.Add(this.nudPlazo);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.nudMonto);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Controls.Add(this.cmbAsociado);
            this.grbDatos.Controls.Add(this.lblAsociado);
            this.grbDatos.Location = new System.Drawing.Point(40, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(598, 249);
            this.grbDatos.TabIndex = 24;
            this.grbDatos.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(2, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 30);
            this.panel1.TabIndex = 25;
            // 
            // FormCreditoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.ckbGarantiaAportacion);
            this.Controls.Add(this.grbVistaPrevia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnGarantias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreditoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Crédito";
            this.Load += new System.EventHandler(this.FormCreditoNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasa)).EndInit();
            this.grbVistaPrevia.ResumeLayout(false);
            this.grbVistaPrevia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAportacion)).EndInit();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsociado;
        private System.Windows.Forms.ComboBox cmbAsociado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPlazo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTasa;
        private System.Windows.Forms.Button btnGarantias;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox grbVistaPrevia;
        private System.Windows.Forms.Label lblCu;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.CheckBox ckbGarantiaAportacion;
        private System.Windows.Forms.NumericUpDown nudCuota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudAportacion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.CheckBox ckbComisionSocial;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.CheckBox ckbCuotaIngreso;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Panel panel1;
    }
}
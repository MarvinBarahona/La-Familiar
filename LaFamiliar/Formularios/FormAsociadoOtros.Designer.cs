namespace La_Familiar.Formularios
{
    partial class FormAsociadoOtros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsociadoOtros));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbOtros = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbIngresos = new System.Windows.Forms.GroupBox();
            this.numIngresosOtros = new System.Windows.Forms.NumericUpDown();
            this.numIngresos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbDepedencias = new System.Windows.Forms.GroupBox();
            this.numDepenParcial = new System.Windows.Forms.NumericUpDown();
            this.numDepenTotal = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbConyuge = new System.Windows.Forms.GroupBox();
            this.txtConyugeTrabajo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConyugeNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbOtros.SuspendLayout();
            this.grbIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIngresosOtros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIngresos)).BeginInit();
            this.grbDepedencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepenParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepenTotal)).BeginInit();
            this.grbConyuge.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Location = new System.Drawing.Point(92, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 35);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(277, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grbOtros
            // 
            this.grbOtros.BackColor = System.Drawing.Color.White;
            this.grbOtros.Controls.Add(this.cmbEstado);
            this.grbOtros.Controls.Add(this.label7);
            this.grbOtros.Controls.Add(this.txtTelefono);
            this.grbOtros.Controls.Add(this.label2);
            this.grbOtros.Controls.Add(this.txtNit);
            this.grbOtros.Controls.Add(this.label1);
            this.grbOtros.Location = new System.Drawing.Point(23, 12);
            this.grbOtros.Name = "grbOtros";
            this.grbOtros.Size = new System.Drawing.Size(409, 90);
            this.grbOtros.TabIndex = 1;
            this.grbOtros.TabStop = false;
            this.grbOtros.Text = "Otros datos";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Viudo"});
            this.cmbEstado.Location = new System.Drawing.Point(253, 45);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(103, 24);
            this.cmbEstado.TabIndex = 3;
            this.cmbEstado.Text = "Seleccionar...";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Estado civil: ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(87, 53);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(106, 22);
            this.txtTelefono.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Teléfono: ";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(58, 21);
            this.txtNit.MaxLength = 17;
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(135, 22);
            this.txtNit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "NIT: ";
            // 
            // grbIngresos
            // 
            this.grbIngresos.BackColor = System.Drawing.Color.White;
            this.grbIngresos.Controls.Add(this.numIngresosOtros);
            this.grbIngresos.Controls.Add(this.numIngresos);
            this.grbIngresos.Controls.Add(this.label4);
            this.grbIngresos.Controls.Add(this.label3);
            this.grbIngresos.Location = new System.Drawing.Point(23, 119);
            this.grbIngresos.Name = "grbIngresos";
            this.grbIngresos.Size = new System.Drawing.Size(224, 82);
            this.grbIngresos.TabIndex = 2;
            this.grbIngresos.TabStop = false;
            this.grbIngresos.Text = "Ingresos";
            // 
            // numIngresosOtros
            // 
            this.numIngresosOtros.DecimalPlaces = 2;
            this.numIngresosOtros.Location = new System.Drawing.Point(133, 51);
            this.numIngresosOtros.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.numIngresosOtros.Name = "numIngresosOtros";
            this.numIngresosOtros.Size = new System.Drawing.Size(83, 22);
            this.numIngresosOtros.TabIndex = 5;
            this.numIngresosOtros.ThousandsSeparator = true;
            // 
            // numIngresos
            // 
            this.numIngresos.DecimalPlaces = 2;
            this.numIngresos.Location = new System.Drawing.Point(133, 25);
            this.numIngresos.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.numIngresos.Name = "numIngresos";
            this.numIngresos.Size = new System.Drawing.Size(83, 22);
            this.numIngresos.TabIndex = 4;
            this.numIngresos.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Otros ingresos ($): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ingresos ($): ";
            // 
            // grbDepedencias
            // 
            this.grbDepedencias.BackColor = System.Drawing.Color.White;
            this.grbDepedencias.Controls.Add(this.numDepenParcial);
            this.grbDepedencias.Controls.Add(this.numDepenTotal);
            this.grbDepedencias.Controls.Add(this.label6);
            this.grbDepedencias.Controls.Add(this.label5);
            this.grbDepedencias.Location = new System.Drawing.Point(265, 119);
            this.grbDepedencias.Name = "grbDepedencias";
            this.grbDepedencias.Size = new System.Drawing.Size(167, 82);
            this.grbDepedencias.TabIndex = 3;
            this.grbDepedencias.TabStop = false;
            this.grbDepedencias.Text = "Dependencias";
            // 
            // numDepenParcial
            // 
            this.numDepenParcial.Location = new System.Drawing.Point(98, 51);
            this.numDepenParcial.Name = "numDepenParcial";
            this.numDepenParcial.Size = new System.Drawing.Size(42, 22);
            this.numDepenParcial.TabIndex = 7;
            // 
            // numDepenTotal
            // 
            this.numDepenTotal.Location = new System.Drawing.Point(98, 25);
            this.numDepenTotal.Name = "numDepenTotal";
            this.numDepenTotal.Size = new System.Drawing.Size(42, 22);
            this.numDepenTotal.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Parciales: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Totales: ";
            // 
            // grbConyuge
            // 
            this.grbConyuge.BackColor = System.Drawing.Color.White;
            this.grbConyuge.Controls.Add(this.txtConyugeTrabajo);
            this.grbConyuge.Controls.Add(this.label8);
            this.grbConyuge.Controls.Add(this.txtConyugeNombre);
            this.grbConyuge.Controls.Add(this.label9);
            this.grbConyuge.Enabled = false;
            this.grbConyuge.Location = new System.Drawing.Point(23, 216);
            this.grbConyuge.Name = "grbConyuge";
            this.grbConyuge.Size = new System.Drawing.Size(409, 78);
            this.grbConyuge.TabIndex = 4;
            this.grbConyuge.TabStop = false;
            this.grbConyuge.Text = "Conyuge";
            // 
            // txtConyugeTrabajo
            // 
            this.txtConyugeTrabajo.Location = new System.Drawing.Point(133, 47);
            this.txtConyugeTrabajo.MaxLength = 2000;
            this.txtConyugeTrabajo.Name = "txtConyugeTrabajo";
            this.txtConyugeTrabajo.Size = new System.Drawing.Size(224, 22);
            this.txtConyugeTrabajo.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Lugar de trabajo: ";
            // 
            // txtConyugeNombre
            // 
            this.txtConyugeNombre.Location = new System.Drawing.Point(133, 15);
            this.txtConyugeNombre.MaxLength = 3000;
            this.txtConyugeNombre.Name = "txtConyugeNombre";
            this.txtConyugeNombre.Size = new System.Drawing.Size(224, 22);
            this.txtConyugeNombre.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nombre: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(-27, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 41);
            this.panel1.TabIndex = 12;
            // 
            // FormAsociadoOtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 360);
            this.Controls.Add(this.grbConyuge);
            this.Controls.Add(this.grbDepedencias);
            this.Controls.Add(this.grbIngresos);
            this.Controls.Add(this.grbOtros);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAsociadoOtros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otros datos del asociado";
            this.Load += new System.EventHandler(this.FormAsociadoOtros_Load);
            this.grbOtros.ResumeLayout(false);
            this.grbOtros.PerformLayout();
            this.grbIngresos.ResumeLayout(false);
            this.grbIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIngresosOtros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIngresos)).EndInit();
            this.grbDepedencias.ResumeLayout(false);
            this.grbDepedencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepenParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepenTotal)).EndInit();
            this.grbConyuge.ResumeLayout(false);
            this.grbConyuge.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grbOtros;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbIngresos;
        private System.Windows.Forms.NumericUpDown numIngresosOtros;
        private System.Windows.Forms.NumericUpDown numIngresos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbDepedencias;
        private System.Windows.Forms.NumericUpDown numDepenParcial;
        private System.Windows.Forms.NumericUpDown numDepenTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbConyuge;
        private System.Windows.Forms.TextBox txtConyugeTrabajo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConyugeNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}
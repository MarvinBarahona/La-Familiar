namespace La_Familiar.Formularios
{
    partial class FormAsociadoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsociadoNuevo));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.grbPersonales = new System.Windows.Forms.GroupBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.dtpDui = new System.Windows.Forms.DateTimePicker();
            this.txtLugarDui = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grbOtros = new System.Windows.Forms.GroupBox();
            this.btnBeneficiarios = new System.Windows.Forms.Button();
            this.btnTrabajo = new System.Windows.Forms.Button();
            this.btnOtros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbPersonales.SuspendLayout();
            this.grbOtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(168, 429);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 35);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(402, 429);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 35);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombres: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Apellidos: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(395, 78);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(228, 22);
            this.txtApellido.TabIndex = 4;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(145, 233);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(105, 22);
            this.dtpNacimiento.TabIndex = 10;
            this.dtpNacimiento.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lugar de nacimiento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "DUI:";
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(255, 35);
            this.txtDui.MaxLength = 10;
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(115, 22);
            this.txtDui.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha de ingreso:";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(505, 35);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(105, 22);
            this.dtpIngreso.TabIndex = 2;
            this.dtpIngreso.Value = new System.DateTime(2016, 12, 16, 20, 21, 55, 0);
            // 
            // grbPersonales
            // 
            this.grbPersonales.BackColor = System.Drawing.Color.White;
            this.grbPersonales.Controls.Add(this.txtDepartamento);
            this.grbPersonales.Controls.Add(this.label12);
            this.grbPersonales.Controls.Add(this.label6);
            this.grbPersonales.Controls.Add(this.txtMunicipio);
            this.grbPersonales.Controls.Add(this.label11);
            this.grbPersonales.Controls.Add(this.label10);
            this.grbPersonales.Controls.Add(this.txtNum);
            this.grbPersonales.Controls.Add(this.label9);
            this.grbPersonales.Controls.Add(this.txtDireccion);
            this.grbPersonales.Controls.Add(this.dtpIngreso);
            this.grbPersonales.Controls.Add(this.label5);
            this.grbPersonales.Controls.Add(this.label8);
            this.grbPersonales.Controls.Add(this.txtLugarNacimiento);
            this.grbPersonales.Controls.Add(this.dtpDui);
            this.grbPersonales.Controls.Add(this.txtLugarDui);
            this.grbPersonales.Controls.Add(this.label7);
            this.grbPersonales.Controls.Add(this.label4);
            this.grbPersonales.Controls.Add(this.label1);
            this.grbPersonales.Controls.Add(this.label2);
            this.grbPersonales.Controls.Add(this.txtNombre);
            this.grbPersonales.Controls.Add(this.txtApellido);
            this.grbPersonales.Controls.Add(this.txtDui);
            this.grbPersonales.Controls.Add(this.dtpNacimiento);
            this.grbPersonales.Controls.Add(this.label3);
            this.grbPersonales.Location = new System.Drawing.Point(23, 22);
            this.grbPersonales.Name = "grbPersonales";
            this.grbPersonales.Size = new System.Drawing.Size(638, 282);
            this.grbPersonales.TabIndex = 16;
            this.grbPersonales.TabStop = false;
            this.grbPersonales.Text = "Datos personales";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(447, 150);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(135, 22);
            this.txtDepartamento.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Departamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Municipio:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(165, 150);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(130, 22);
            this.txtMunicipio.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Fecha de emisión del DUI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha de nacimiento:";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(138, 35);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(56, 22);
            this.txtNum.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Número de asociado: ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(82, 122);
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(539, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Dirección: ";
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Location = new System.Drawing.Point(138, 198);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(157, 22);
            this.txtLugarNacimiento.TabIndex = 8;
            // 
            // dtpDui
            // 
            this.dtpDui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDui.Location = new System.Drawing.Point(475, 233);
            this.dtpDui.Name = "dtpDui";
            this.dtpDui.Size = new System.Drawing.Size(107, 22);
            this.dtpDui.TabIndex = 11;
            this.dtpDui.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtLugarDui
            // 
            this.txtLugarDui.Location = new System.Drawing.Point(469, 198);
            this.txtLugarDui.Name = "txtLugarDui";
            this.txtLugarDui.Size = new System.Drawing.Size(152, 22);
            this.txtLugarDui.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lugar de emisión del DUI: ";
            // 
            // grbOtros
            // 
            this.grbOtros.BackColor = System.Drawing.Color.GhostWhite;
            this.grbOtros.Controls.Add(this.btnBeneficiarios);
            this.grbOtros.Controls.Add(this.btnTrabajo);
            this.grbOtros.Controls.Add(this.btnOtros);
            this.grbOtros.Location = new System.Drawing.Point(23, 340);
            this.grbOtros.Name = "grbOtros";
            this.grbOtros.Size = new System.Drawing.Size(638, 68);
            this.grbOtros.TabIndex = 17;
            this.grbOtros.TabStop = false;
            this.grbOtros.Text = "Otros datos";
            // 
            // btnBeneficiarios
            // 
            this.btnBeneficiarios.BackColor = System.Drawing.Color.MistyRose;
            this.btnBeneficiarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeneficiarios.Location = new System.Drawing.Point(447, 21);
            this.btnBeneficiarios.Name = "btnBeneficiarios";
            this.btnBeneficiarios.Size = new System.Drawing.Size(140, 35);
            this.btnBeneficiarios.TabIndex = 14;
            this.btnBeneficiarios.Text = "Beneficiarios";
            this.btnBeneficiarios.UseVisualStyleBackColor = false;
            this.btnBeneficiarios.Click += new System.EventHandler(this.btnBeneficiarios_Click);
            // 
            // btnTrabajo
            // 
            this.btnTrabajo.BackColor = System.Drawing.Color.MistyRose;
            this.btnTrabajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrabajo.Location = new System.Drawing.Point(252, 21);
            this.btnTrabajo.Name = "btnTrabajo";
            this.btnTrabajo.Size = new System.Drawing.Size(140, 35);
            this.btnTrabajo.TabIndex = 13;
            this.btnTrabajo.Text = "Lugar de trabajo";
            this.btnTrabajo.UseVisualStyleBackColor = false;
            this.btnTrabajo.Click += new System.EventHandler(this.btnTrabajo_Click);
            // 
            // btnOtros
            // 
            this.btnOtros.BackColor = System.Drawing.Color.MistyRose;
            this.btnOtros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtros.Location = new System.Drawing.Point(70, 21);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(140, 35);
            this.btnOtros.TabIndex = 12;
            this.btnOtros.Text = "Otros datos";
            this.btnOtros.UseVisualStyleBackColor = false;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(1, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 30);
            this.panel1.TabIndex = 18;
            // 
            // FormAsociadoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbOtros);
            this.Controls.Add(this.grbPersonales);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAsociadoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Asociado";
            this.Load += new System.EventHandler(this.NuevoAsociado_Load);
            this.grbPersonales.ResumeLayout(false);
            this.grbPersonales.PerformLayout();
            this.grbOtros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.GroupBox grbPersonales;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLugarNacimiento;
        private System.Windows.Forms.DateTimePicker dtpDui;
        private System.Windows.Forms.TextBox txtLugarDui;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbOtros;
        private System.Windows.Forms.Button btnBeneficiarios;
        private System.Windows.Forms.Button btnTrabajo;
        private System.Windows.Forms.Button btnOtros;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace La_Familiar.Formularios
{
    partial class FormAsociadoTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsociadoTrabajo));
            this.grbLugar = new System.Windows.Forms.GroupBox();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.txtLugarDireccion = new System.Windows.Forms.TextBox();
            this.txtLugarTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTrabajo = new System.Windows.Forms.GroupBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbLugar.SuspendLayout();
            this.grbTrabajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLugar
            // 
            this.grbLugar.BackColor = System.Drawing.Color.White;
            this.grbLugar.Controls.Add(this.cmbNombre);
            this.grbLugar.Controls.Add(this.txtLugarDireccion);
            this.grbLugar.Controls.Add(this.txtLugarTelefono);
            this.grbLugar.Controls.Add(this.label3);
            this.grbLugar.Controls.Add(this.label2);
            this.grbLugar.Controls.Add(this.label1);
            this.grbLugar.Location = new System.Drawing.Point(24, 22);
            this.grbLugar.Name = "grbLugar";
            this.grbLugar.Size = new System.Drawing.Size(458, 111);
            this.grbLugar.TabIndex = 1;
            this.grbLugar.TabStop = false;
            this.grbLugar.Text = "Lugar de trabajo";
            // 
            // cmbNombre
            // 
            this.cmbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(81, 31);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(150, 24);
            this.cmbNombre.TabIndex = 1;
            this.cmbNombre.TextChanged += new System.EventHandler(this.cmbNombre_TextChanged);
            // 
            // txtLugarDireccion
            // 
            this.txtLugarDireccion.Location = new System.Drawing.Point(248, 31);
            this.txtLugarDireccion.Multiline = true;
            this.txtLugarDireccion.Name = "txtLugarDireccion";
            this.txtLugarDireccion.Size = new System.Drawing.Size(193, 54);
            this.txtLugarDireccion.TabIndex = 3;
            // 
            // txtLugarTelefono
            // 
            this.txtLugarTelefono.Location = new System.Drawing.Point(81, 63);
            this.txtLugarTelefono.MaxLength = 8;
            this.txtLugarTelefono.Name = "txtLugarTelefono";
            this.txtLugarTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtLugarTelefono.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre:";
            // 
            // grbTrabajo
            // 
            this.grbTrabajo.BackColor = System.Drawing.Color.White;
            this.grbTrabajo.Controls.Add(this.txtTiempo);
            this.grbTrabajo.Controls.Add(this.txtCargo);
            this.grbTrabajo.Controls.Add(this.label5);
            this.grbTrabajo.Controls.Add(this.label4);
            this.grbTrabajo.Location = new System.Drawing.Point(24, 162);
            this.grbTrabajo.Name = "grbTrabajo";
            this.grbTrabajo.Size = new System.Drawing.Size(458, 81);
            this.grbTrabajo.TabIndex = 2;
            this.grbTrabajo.TabStop = false;
            this.grbTrabajo.Text = "Trabajo";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(288, 29);
            this.txtTiempo.MaxLength = 20;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(120, 22);
            this.txtTiempo.TabIndex = 5;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(83, 28);
            this.txtCargo.MaxLength = 30;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(109, 22);
            this.txtCargo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tiempo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cargo: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(65, 278);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(292, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(1, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 30);
            this.panel1.TabIndex = 8;
            // 
            // FormAsociadoTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbTrabajo);
            this.Controls.Add(this.grbLugar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAsociadoTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lugar de trabajo del asociado";
            this.Load += new System.EventHandler(this.FormAsociadoTrabajo_Load);
            this.grbLugar.ResumeLayout(false);
            this.grbLugar.PerformLayout();
            this.grbTrabajo.ResumeLayout(false);
            this.grbTrabajo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLugar;
        private System.Windows.Forms.TextBox txtLugarDireccion;
        private System.Windows.Forms.TextBox txtLugarTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTrabajo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Panel panel1;
    }
}
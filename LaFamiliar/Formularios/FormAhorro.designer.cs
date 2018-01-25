namespace La_Familiar.Formularios
{
    partial class FormAhorro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAhorro));
            this.lblAsociado = new System.Windows.Forms.Label();
            this.txtAsociado = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTasa = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.Label();
            this.tblTransacciones = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnExtender = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnContraorden = new System.Windows.Forms.Button();
            this.btnBeneficiarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsociado
            // 
            this.lblAsociado.AutoSize = true;
            this.lblAsociado.Location = new System.Drawing.Point(18, 34);
            this.lblAsociado.Name = "lblAsociado";
            this.lblAsociado.Size = new System.Drawing.Size(70, 16);
            this.lblAsociado.TabIndex = 0;
            this.lblAsociado.Text = "Asociado: ";
            // 
            // txtAsociado
            // 
            this.txtAsociado.AutoSize = true;
            this.txtAsociado.BackColor = System.Drawing.Color.White;
            this.txtAsociado.Location = new System.Drawing.Point(94, 34);
            this.txtAsociado.Name = "txtAsociado";
            this.txtAsociado.Size = new System.Drawing.Size(131, 16);
            this.txtAsociado.TabIndex = 1;
            this.txtAsociado.Text = "Nombre del Asociado";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(333, 34);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(119, 16);
            this.lblCuenta.TabIndex = 2;
            this.lblCuenta.Text = "Número de ahorro: ";
            // 
            // grbInfo
            // 
            this.grbInfo.BackColor = System.Drawing.Color.White;
            this.grbInfo.Controls.Add(this.lblFecha);
            this.grbInfo.Controls.Add(this.lblTasa);
            this.grbInfo.Controls.Add(this.lblSaldo);
            this.grbInfo.Controls.Add(this.lblPlazo);
            this.grbInfo.Controls.Add(this.lblPlan);
            this.grbInfo.Controls.Add(this.txtCuenta);
            this.grbInfo.Controls.Add(this.lblCuenta);
            this.grbInfo.Controls.Add(this.txtAsociado);
            this.grbInfo.Controls.Add(this.lblAsociado);
            this.grbInfo.Location = new System.Drawing.Point(45, 39);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(567, 151);
            this.grbInfo.TabIndex = 3;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Información de la cuenta de ahorro";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 112);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 16);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha inicio:  ";
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Location = new System.Drawing.Point(333, 75);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(51, 16);
            this.lblTasa.TabIndex = 7;
            this.lblTasa.Text = "Tasa:   ";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(219, 112);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(103, 16);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo actual: $";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(198, 75);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(57, 16);
            this.lblPlazo.TabIndex = 5;
            this.lblPlazo.Text = "Plazo:   ";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(42, 75);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(50, 16);
            this.lblPlan.TabIndex = 4;
            this.lblPlan.Text = "Plan:   ";
            // 
            // txtCuenta
            // 
            this.txtCuenta.AutoSize = true;
            this.txtCuenta.BackColor = System.Drawing.Color.White;
            this.txtCuenta.Location = new System.Drawing.Point(458, 34);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(85, 16);
            this.txtCuenta.TabIndex = 3;
            this.txtCuenta.Text = "###########";
            // 
            // tblTransacciones
            // 
            this.tblTransacciones.AllowUserToAddRows = false;
            this.tblTransacciones.AllowUserToDeleteRows = false;
            this.tblTransacciones.AllowUserToResizeColumns = false;
            this.tblTransacciones.AllowUserToResizeRows = false;
            this.tblTransacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTransacciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tblTransacciones.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.tipo,
            this.monto,
            this.fecha,
            this.saldo});
            this.tblTransacciones.Location = new System.Drawing.Point(47, 273);
            this.tblTransacciones.MultiSelect = false;
            this.tblTransacciones.Name = "tblTransacciones";
            this.tblTransacciones.RowHeadersVisible = false;
            this.tblTransacciones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tblTransacciones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tblTransacciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.tblTransacciones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tblTransacciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTransacciones.Size = new System.Drawing.Size(675, 177);
            this.tblTransacciones.TabIndex = 4;
            // 
            // num
            // 
            this.num.FillWeight = 20F;
            this.num.HeaderText = "N";
            this.num.Name = "num";
            // 
            // tipo
            // 
            this.tipo.FillWeight = 160F;
            this.tipo.HeaderText = "Tipo de movimiento";
            this.tipo.Name = "tipo";
            // 
            // monto
            // 
            this.monto.FillWeight = 80F;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo parcial";
            this.saldo.Name = "saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "TRANSACCIONES";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Location = new System.Drawing.Point(320, 482);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(140, 35);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo Movimiento";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnExtender
            // 
            this.btnExtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtender.Enabled = false;
            this.btnExtender.Location = new System.Drawing.Point(582, 482);
            this.btnExtender.Name = "btnExtender";
            this.btnExtender.Size = new System.Drawing.Size(140, 35);
            this.btnExtender.TabIndex = 8;
            this.btnExtender.Text = "Extender Plazo";
            this.btnExtender.UseVisualStyleBackColor = true;
            this.btnExtender.Click += new System.EventHandler(this.btnExtender_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(45, 482);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(140, 35);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Terminar plan";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnContraorden
            // 
            this.btnContraorden.Enabled = false;
            this.btnContraorden.Location = new System.Drawing.Point(622, 48);
            this.btnContraorden.Name = "btnContraorden";
            this.btnContraorden.Size = new System.Drawing.Size(100, 50);
            this.btnContraorden.TabIndex = 11;
            this.btnContraorden.Text = "Generar contraorden";
            this.btnContraorden.UseVisualStyleBackColor = true;
            this.btnContraorden.Click += new System.EventHandler(this.btnContraorden_Click);
            // 
            // btnBeneficiarios
            // 
            this.btnBeneficiarios.Location = new System.Drawing.Point(622, 140);
            this.btnBeneficiarios.Name = "btnBeneficiarios";
            this.btnBeneficiarios.Size = new System.Drawing.Size(100, 50);
            this.btnBeneficiarios.TabIndex = 12;
            this.btnBeneficiarios.Text = "Ver beneficiarios";
            this.btnBeneficiarios.UseVisualStyleBackColor = true;
            this.btnBeneficiarios.Click += new System.EventHandler(this.btnBeneficiarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(-1, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 41);
            this.panel1.TabIndex = 13;
            // 
            // FormAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBeneficiarios);
            this.Controls.Add(this.btnContraorden);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnExtender);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblTransacciones);
            this.Controls.Add(this.grbInfo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAhorro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ahorro";
            this.Activated += new System.EventHandler(this.FormAhorro_Activated);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsociado;
        private System.Windows.Forms.Label txtAsociado;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label txtCuenta;
        private System.Windows.Forms.DataGridView tblTransacciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Button btnExtender;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.Button btnContraorden;
        private System.Windows.Forms.Button btnBeneficiarios;
        private System.Windows.Forms.Panel panel1;
    }
}
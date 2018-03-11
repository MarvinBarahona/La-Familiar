namespace La_Familiar
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAsociados = new System.Windows.Forms.TabPage();
            this.btnAportacion = new System.Windows.Forms.Button();
            this.btnNuevoAsociado = new System.Windows.Forms.Button();
            this.tblAsociados = new System.Windows.Forms.DataGridView();
            this.tabCreditos = new System.Windows.Forms.TabPage();
            this.btnReportePagos = new System.Windows.Forms.Button();
            this.btnNuevoCredito = new System.Windows.Forms.Button();
            this.tblCreditos = new System.Windows.Forms.DataGridView();
            this.tabAhorros = new System.Windows.Forms.TabPage();
            this.btnProvisional = new System.Windows.Forms.Button();
            this.btnNuevoAhorro = new System.Windows.Forms.Button();
            this.tblAhorros = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabMain.SuspendLayout();
            this.tabAsociados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAsociados)).BeginInit();
            this.tabCreditos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCreditos)).BeginInit();
            this.tabAhorros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAhorros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAsociados);
            this.tabMain.Controls.Add(this.tabCreditos);
            this.tabMain.Controls.Add(this.tabAhorros);
            this.tabMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.ItemSize = new System.Drawing.Size(80, 30);
            this.tabMain.Location = new System.Drawing.Point(0, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(784, 545);
            this.tabMain.TabIndex = 0;
            // 
            // tabAsociados
            // 
            this.tabAsociados.BackColor = System.Drawing.Color.White;
            this.tabAsociados.Controls.Add(this.btnAportacion);
            this.tabAsociados.Controls.Add(this.btnNuevoAsociado);
            this.tabAsociados.Controls.Add(this.tblAsociados);
            this.tabAsociados.Location = new System.Drawing.Point(4, 34);
            this.tabAsociados.Name = "tabAsociados";
            this.tabAsociados.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsociados.Size = new System.Drawing.Size(776, 507);
            this.tabAsociados.TabIndex = 0;
            this.tabAsociados.Text = "Asociados";
            // 
            // btnAportacion
            // 
            this.btnAportacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAportacion.Location = new System.Drawing.Point(435, 438);
            this.btnAportacion.Name = "btnAportacion";
            this.btnAportacion.Size = new System.Drawing.Size(140, 35);
            this.btnAportacion.TabIndex = 2;
            this.btnAportacion.Text = "Ingresar Aportación";
            this.btnAportacion.UseVisualStyleBackColor = true;
            this.btnAportacion.Click += new System.EventHandler(this.btnAportacion_Click);
            // 
            // btnNuevoAsociado
            // 
            this.btnNuevoAsociado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoAsociado.Location = new System.Drawing.Point(188, 438);
            this.btnNuevoAsociado.Name = "btnNuevoAsociado";
            this.btnNuevoAsociado.Size = new System.Drawing.Size(140, 35);
            this.btnNuevoAsociado.TabIndex = 1;
            this.btnNuevoAsociado.Text = "Nuevo Asociado";
            this.btnNuevoAsociado.UseVisualStyleBackColor = true;
            this.btnNuevoAsociado.Click += new System.EventHandler(this.btnNuevoAsociado_Click);
            // 
            // tblAsociados
            // 
            this.tblAsociados.AllowUserToAddRows = false;
            this.tblAsociados.AllowUserToDeleteRows = false;
            this.tblAsociados.AllowUserToResizeColumns = false;
            this.tblAsociados.AllowUserToResizeRows = false;
            this.tblAsociados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tblAsociados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblAsociados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAsociados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblAsociados.GridColor = System.Drawing.Color.Black;
            this.tblAsociados.Location = new System.Drawing.Point(45, 30);
            this.tblAsociados.MultiSelect = false;
            this.tblAsociados.Name = "tblAsociados";
            this.tblAsociados.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblAsociados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblAsociados.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.tblAsociados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tblAsociados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tblAsociados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tblAsociados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.tblAsociados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tblAsociados.RowTemplate.ReadOnly = true;
            this.tblAsociados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblAsociados.Size = new System.Drawing.Size(685, 390);
            this.tblAsociados.TabIndex = 0;
            this.tblAsociados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblAsociados_CellContentClick);
            this.tblAsociados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblAsociados_CellDoubleClick);
            this.tblAsociados.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblAsociados_ColumnHeaderMouseClick);
            // 
            // tabCreditos
            // 
            this.tabCreditos.BackColor = System.Drawing.Color.White;
            this.tabCreditos.Controls.Add(this.btnReportePagos);
            this.tabCreditos.Controls.Add(this.btnNuevoCredito);
            this.tabCreditos.Controls.Add(this.tblCreditos);
            this.tabCreditos.Location = new System.Drawing.Point(4, 34);
            this.tabCreditos.Name = "tabCreditos";
            this.tabCreditos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreditos.Size = new System.Drawing.Size(776, 507);
            this.tabCreditos.TabIndex = 1;
            this.tabCreditos.Text = "Créditos";
            // 
            // btnReportePagos
            // 
            this.btnReportePagos.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReportePagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportePagos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReportePagos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReportePagos.Location = new System.Drawing.Point(167, 444);
            this.btnReportePagos.Name = "btnReportePagos";
            this.btnReportePagos.Size = new System.Drawing.Size(140, 35);
            this.btnReportePagos.TabIndex = 3;
            this.btnReportePagos.Text = "Reporte Pagos";
            this.btnReportePagos.UseVisualStyleBackColor = false;
            this.btnReportePagos.Click += new System.EventHandler(this.btnReportePagos_Click);
            // 
            // btnNuevoCredito
            // 
            this.btnNuevoCredito.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCredito.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoCredito.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevoCredito.Location = new System.Drawing.Point(493, 444);
            this.btnNuevoCredito.Name = "btnNuevoCredito";
            this.btnNuevoCredito.Size = new System.Drawing.Size(140, 35);
            this.btnNuevoCredito.TabIndex = 2;
            this.btnNuevoCredito.Text = "Nuevo Crédito";
            this.btnNuevoCredito.UseVisualStyleBackColor = false;
            this.btnNuevoCredito.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tblCreditos
            // 
            this.tblCreditos.AllowUserToAddRows = false;
            this.tblCreditos.AllowUserToDeleteRows = false;
            this.tblCreditos.AllowUserToResizeColumns = false;
            this.tblCreditos.AllowUserToResizeRows = false;
            this.tblCreditos.BackgroundColor = System.Drawing.Color.White;
            this.tblCreditos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblCreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tblCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblCreditos.GridColor = System.Drawing.Color.Black;
            this.tblCreditos.Location = new System.Drawing.Point(45, 30);
            this.tblCreditos.MultiSelect = false;
            this.tblCreditos.Name = "tblCreditos";
            this.tblCreditos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblCreditos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tblCreditos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.tblCreditos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tblCreditos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tblCreditos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tblCreditos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.tblCreditos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tblCreditos.RowTemplate.ReadOnly = true;
            this.tblCreditos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCreditos.Size = new System.Drawing.Size(685, 390);
            this.tblCreditos.TabIndex = 1;
            this.tblCreditos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCreditos_CellDoubleClick);
            // 
            // tabAhorros
            // 
            this.tabAhorros.BackColor = System.Drawing.Color.White;
            this.tabAhorros.Controls.Add(this.btnProvisional);
            this.tabAhorros.Controls.Add(this.btnNuevoAhorro);
            this.tabAhorros.Controls.Add(this.tblAhorros);
            this.tabAhorros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAhorros.Location = new System.Drawing.Point(4, 34);
            this.tabAhorros.Name = "tabAhorros";
            this.tabAhorros.Size = new System.Drawing.Size(776, 507);
            this.tabAhorros.TabIndex = 2;
            this.tabAhorros.Text = "Cuentas de ahorro";
            // 
            // btnProvisional
            // 
            this.btnProvisional.Location = new System.Drawing.Point(156, 431);
            this.btnProvisional.Name = "btnProvisional";
            this.btnProvisional.Size = new System.Drawing.Size(140, 35);
            this.btnProvisional.TabIndex = 4;
            this.btnProvisional.Text = "Provisional";
            this.btnProvisional.UseVisualStyleBackColor = true;
            this.btnProvisional.Click += new System.EventHandler(this.btnProvisional_Click);
            // 
            // btnNuevoAhorro
            // 
            this.btnNuevoAhorro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoAhorro.Location = new System.Drawing.Point(482, 431);
            this.btnNuevoAhorro.Name = "btnNuevoAhorro";
            this.btnNuevoAhorro.Size = new System.Drawing.Size(140, 35);
            this.btnNuevoAhorro.TabIndex = 3;
            this.btnNuevoAhorro.Text = "Nuevo Ahorro";
            this.btnNuevoAhorro.UseVisualStyleBackColor = true;
            this.btnNuevoAhorro.Click += new System.EventHandler(this.btnNuevoAhorro_Click);
            // 
            // tblAhorros
            // 
            this.tblAhorros.AllowUserToAddRows = false;
            this.tblAhorros.AllowUserToDeleteRows = false;
            this.tblAhorros.AllowUserToResizeColumns = false;
            this.tblAhorros.AllowUserToResizeRows = false;
            this.tblAhorros.BackgroundColor = System.Drawing.Color.White;
            this.tblAhorros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblAhorros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tblAhorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAhorros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblAhorros.GridColor = System.Drawing.Color.Black;
            this.tblAhorros.Location = new System.Drawing.Point(45, 30);
            this.tblAhorros.MultiSelect = false;
            this.tblAhorros.Name = "tblAhorros";
            this.tblAhorros.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblAhorros.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tblAhorros.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.tblAhorros.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.tblAhorros.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tblAhorros.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tblAhorros.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.tblAhorros.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tblAhorros.RowTemplate.ReadOnly = true;
            this.tblAhorros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblAhorros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblAhorros.Size = new System.Drawing.Size(685, 390);
            this.tblAhorros.TabIndex = 2;
            this.tblAhorros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblAhorros_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 41);
            this.panel1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cooperativa La Familiar";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.tabMain.ResumeLayout(false);
            this.tabAsociados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblAsociados)).EndInit();
            this.tabCreditos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblCreditos)).EndInit();
            this.tabAhorros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblAhorros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAsociados;
        private System.Windows.Forms.TabPage tabCreditos;
        private System.Windows.Forms.TabPage tabAhorros;
        private System.Windows.Forms.DataGridView tblAsociados;
        private System.Windows.Forms.DataGridView tblCreditos;
        private System.Windows.Forms.DataGridView tblAhorros;
        private System.Windows.Forms.Button btnNuevoCredito;
        private System.Windows.Forms.Button btnNuevoAsociado;
        private System.Windows.Forms.Button btnNuevoAhorro;
        private System.Windows.Forms.Button btnAportacion;
        private System.Windows.Forms.Button btnProvisional;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReportePagos;
    }
}


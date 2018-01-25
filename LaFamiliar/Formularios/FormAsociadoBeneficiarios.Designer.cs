namespace La_Familiar.Formularios
{
    partial class FormAsociadoBeneficiarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsociadoBeneficiarios));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvBeneficiarios = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Location = new System.Drawing.Point(143, 247);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 35);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(443, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 35);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvBeneficiarios
            // 
            this.dgvBeneficiarios.AllowUserToResizeColumns = false;
            this.dgvBeneficiarios.AllowUserToResizeRows = false;
            this.dgvBeneficiarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBeneficiarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBeneficiarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.parentesco,
            this.edad,
            this.porcentaje,
            this.direccion,
            this.Eliminar});
            this.dgvBeneficiarios.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvBeneficiarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBeneficiarios.Location = new System.Drawing.Point(12, 31);
            this.dgvBeneficiarios.Name = "dgvBeneficiarios";
            this.dgvBeneficiarios.RowHeadersVisible = false;
            this.dgvBeneficiarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBeneficiarios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBeneficiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBeneficiarios.Size = new System.Drawing.Size(691, 192);
            this.dgvBeneficiarios.TabIndex = 0;
            this.dgvBeneficiarios.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBeneficiarios_EditingControlShowing);
            this.dgvBeneficiarios.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBeneficiarios_RowsAdded);
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombre.FillWeight = 200F;
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MaxInputLength = 80;
            this.nombre.Name = "nombre";
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.Width = 222;
            // 
            // parentesco
            // 
            this.parentesco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.parentesco.Frozen = true;
            this.parentesco.HeaderText = "Parentesco";
            this.parentesco.MaxInputLength = 30;
            this.parentesco.Name = "parentesco";
            this.parentesco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.parentesco.Width = 110;
            // 
            // edad
            // 
            this.edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edad.FillWeight = 50F;
            this.edad.Frozen = true;
            this.edad.HeaderText = "Edad";
            this.edad.MaxInputLength = 2;
            this.edad.Name = "edad";
            this.edad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.edad.Width = 56;
            // 
            // porcentaje
            // 
            this.porcentaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.porcentaje.FillWeight = 50F;
            this.porcentaje.Frozen = true;
            this.porcentaje.HeaderText = "%";
            this.porcentaje.MaxInputLength = 3;
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.porcentaje.Width = 55;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.direccion.FillWeight = 200F;
            this.direccion.Frozen = true;
            this.direccion.HeaderText = "Dirección";
            this.direccion.MaxInputLength = 200;
            this.direccion.Name = "direccion";
            this.direccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.direccion.Width = 222;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Eliminar.FillWeight = 20F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Text = "x";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 30);
            this.panel1.TabIndex = 5;
            // 
            // FormAsociadoBeneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBeneficiarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAsociadoBeneficiarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficiarios del asociado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvBeneficiarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentesco;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Panel panel1;
    }
}
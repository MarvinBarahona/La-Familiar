namespace La_Familiar.Formularios
{
    partial class FormCreditoGarantias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreditoGarantias));
            this.dgvFiadores = new System.Windows.Forms.DataGridView();
            this.fiador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHipotecarias = new System.Windows.Forms.DataGridView();
            this.propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hipoDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrendarias = new System.Windows.Forms.DataGridView();
            this.prenPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDepositos = new System.Windows.Forms.Label();
            this.lblAportaciones = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHipotecarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendarias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiadores
            // 
            this.dgvFiadores.AllowUserToAddRows = false;
            this.dgvFiadores.AllowUserToDeleteRows = false;
            this.dgvFiadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiadores.BackgroundColor = System.Drawing.Color.White;
            this.dgvFiadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fiador,
            this.dui,
            this.nit,
            this.tel,
            this.direccion});
            this.dgvFiadores.Location = new System.Drawing.Point(23, 153);
            this.dgvFiadores.Name = "dgvFiadores";
            this.dgvFiadores.ReadOnly = true;
            this.dgvFiadores.RowHeadersVisible = false;
            this.dgvFiadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiadores.Size = new System.Drawing.Size(620, 104);
            this.dgvFiadores.TabIndex = 9;
            // 
            // fiador
            // 
            this.fiador.FillWeight = 150F;
            this.fiador.HeaderText = "Fiador";
            this.fiador.Name = "fiador";
            this.fiador.ReadOnly = true;
            // 
            // dui
            // 
            this.dui.FillWeight = 75F;
            this.dui.HeaderText = "DUI";
            this.dui.Name = "dui";
            this.dui.ReadOnly = true;
            // 
            // nit
            // 
            this.nit.HeaderText = "NIT";
            this.nit.Name = "nit";
            this.nit.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.HeaderText = "Teléfono";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // dgvHipotecarias
            // 
            this.dgvHipotecarias.AllowUserToAddRows = false;
            this.dgvHipotecarias.AllowUserToDeleteRows = false;
            this.dgvHipotecarias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHipotecarias.BackgroundColor = System.Drawing.Color.White;
            this.dgvHipotecarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHipotecarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propietario,
            this.matricula,
            this.medida,
            this.hipoDir});
            this.dgvHipotecarias.Location = new System.Drawing.Point(23, 309);
            this.dgvHipotecarias.Name = "dgvHipotecarias";
            this.dgvHipotecarias.ReadOnly = true;
            this.dgvHipotecarias.RowHeadersVisible = false;
            this.dgvHipotecarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHipotecarias.Size = new System.Drawing.Size(620, 113);
            this.dgvHipotecarias.TabIndex = 10;
            // 
            // propietario
            // 
            this.propietario.FillWeight = 150F;
            this.propietario.HeaderText = "Propietario";
            this.propietario.Name = "propietario";
            this.propietario.ReadOnly = true;
            // 
            // matricula
            // 
            this.matricula.FillWeight = 50F;
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // medida
            // 
            this.medida.FillWeight = 50F;
            this.medida.HeaderText = "Medida";
            this.medida.Name = "medida";
            this.medida.ReadOnly = true;
            // 
            // hipoDir
            // 
            this.hipoDir.FillWeight = 150F;
            this.hipoDir.HeaderText = "Dirección";
            this.hipoDir.Name = "hipoDir";
            this.hipoDir.ReadOnly = true;
            // 
            // dgvPrendarias
            // 
            this.dgvPrendarias.AllowUserToAddRows = false;
            this.dgvPrendarias.AllowUserToDeleteRows = false;
            this.dgvPrendarias.AllowUserToResizeColumns = false;
            this.dgvPrendarias.AllowUserToResizeRows = false;
            this.dgvPrendarias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrendarias.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrendarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrendarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prenPropietario,
            this.bien,
            this.prenDesc});
            this.dgvPrendarias.Location = new System.Drawing.Point(23, 499);
            this.dgvPrendarias.Name = "dgvPrendarias";
            this.dgvPrendarias.ReadOnly = true;
            this.dgvPrendarias.RowHeadersVisible = false;
            this.dgvPrendarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrendarias.Size = new System.Drawing.Size(620, 82);
            this.dgvPrendarias.TabIndex = 11;
            // 
            // prenPropietario
            // 
            this.prenPropietario.HeaderText = "Propietario";
            this.prenPropietario.Name = "prenPropietario";
            this.prenPropietario.ReadOnly = true;
            // 
            // bien
            // 
            this.bien.FillWeight = 60F;
            this.bien.HeaderText = "Bien";
            this.bien.Name = "bien";
            this.bien.ReadOnly = true;
            // 
            // prenDesc
            // 
            this.prenDesc.FillWeight = 150F;
            this.prenDesc.HeaderText = "Descripción";
            this.prenDesc.Name = "prenDesc";
            this.prenDesc.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 2);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(23, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 2);
            this.label2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(23, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(619, 2);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fiadores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hipotecas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Prendarias";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(116, 16);
            this.lblCodigo.TabIndex = 19;
            this.lblCodigo.Text = "Código del crédito.";
            // 
            // lblDepositos
            // 
            this.lblDepositos.AutoSize = true;
            this.lblDepositos.Location = new System.Drawing.Point(23, 51);
            this.lblDepositos.Name = "lblDepositos";
            this.lblDepositos.Size = new System.Drawing.Size(255, 16);
            this.lblDepositos.TabIndex = 20;
            this.lblDepositos.Text = "Cuentas de ahorro garantías de el crédito: ";
            // 
            // lblAportaciones
            // 
            this.lblAportaciones.AutoSize = true;
            this.lblAportaciones.Location = new System.Drawing.Point(26, 80);
            this.lblAportaciones.Name = "lblAportaciones";
            this.lblAportaciones.Size = new System.Drawing.Size(260, 16);
            this.lblAportaciones.TabIndex = 21;
            this.lblAportaciones.Text = "Las aportaciones del asociado son garantía";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 2);
            this.label3.TabIndex = 14;
            // 
            // FormCreditoGarantias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lblAportaciones);
            this.Controls.Add(this.lblDepositos);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrendarias);
            this.Controls.Add(this.dgvHipotecarias);
            this.Controls.Add(this.dgvFiadores);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormCreditoGarantias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Garantias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHipotecarias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendarias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiadores;
        private System.Windows.Forms.DataGridView dgvHipotecarias;
        private System.Windows.Forms.DataGridView dgvPrendarias;
        private System.Windows.Forms.DataGridViewTextBoxColumn propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hipoDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn bien;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Label lblDepositos;
        private System.Windows.Forms.Label lblAportaciones;
        private System.Windows.Forms.Label label3;

    }
}
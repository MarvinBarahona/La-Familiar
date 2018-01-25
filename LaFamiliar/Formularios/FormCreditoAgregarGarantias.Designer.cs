namespace La_Familiar.Formularios
{
    partial class FormCreditoAgregarGarantias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreditoAgregarGarantias));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFiador = new System.Windows.Forms.TabPage();
            this.txtFiadorTel = new System.Windows.Forms.TextBox();
            this.txtFiadorNit = new System.Windows.Forms.TextBox();
            this.txtFiadorDui = new System.Windows.Forms.TextBox();
            this.dgvFiadores = new System.Windows.Forms.DataGridView();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fiadorObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiadorCancelar = new System.Windows.Forms.Button();
            this.btnFiadorAgregar = new System.Windows.Forms.Button();
            this.txtFiadorDir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiadorApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiadorNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabHipotecaria = new System.Windows.Forms.TabPage();
            this.txtHipotecarioMedida = new System.Windows.Forms.TextBox();
            this.btnHipotecariaCancelar = new System.Windows.Forms.Button();
            this.btnHipotecariaAgregar = new System.Windows.Forms.Button();
            this.dgvHipotecarias = new System.Windows.Forms.DataGridView();
            this.propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hipoDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hipoElim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hipoObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHipotecarioMatricula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHipotecarioDir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbHipotecarioPropietario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPrendaria = new System.Windows.Forms.TabPage();
            this.dgvPrendarias = new System.Windows.Forms.DataGridView();
            this.prenPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenElim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prenObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrendariaCancelar = new System.Windows.Forms.Button();
            this.btnPrendariaAgregar = new System.Windows.Forms.Button();
            this.txtPrendariaDescripcion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrendariaNombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbPredariaPropietario = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabDepositos = new System.Windows.Forms.TabPage();
            this.dgvDepositos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.depositoObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDepositosAgregar = new System.Windows.Forms.Button();
            this.cmbDepositos = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabFiador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiadores)).BeginInit();
            this.tabHipotecaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHipotecarias)).BeginInit();
            this.tabPrendaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendarias)).BeginInit();
            this.tabDepositos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFiador);
            this.tabControl1.Controls.Add(this.tabHipotecaria);
            this.tabControl1.Controls.Add(this.tabPrendaria);
            this.tabControl1.Controls.Add(this.tabDepositos);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(682, 421);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabFiador
            // 
            this.tabFiador.Controls.Add(this.txtFiadorTel);
            this.tabFiador.Controls.Add(this.txtFiadorNit);
            this.tabFiador.Controls.Add(this.txtFiadorDui);
            this.tabFiador.Controls.Add(this.dgvFiadores);
            this.tabFiador.Controls.Add(this.btnFiadorCancelar);
            this.tabFiador.Controls.Add(this.btnFiadorAgregar);
            this.tabFiador.Controls.Add(this.txtFiadorDir);
            this.tabFiador.Controls.Add(this.label6);
            this.tabFiador.Controls.Add(this.label5);
            this.tabFiador.Controls.Add(this.label4);
            this.tabFiador.Controls.Add(this.txtFiadorApellidos);
            this.tabFiador.Controls.Add(this.label3);
            this.tabFiador.Controls.Add(this.txtFiadorNombres);
            this.tabFiador.Controls.Add(this.label2);
            this.tabFiador.Controls.Add(this.label1);
            this.tabFiador.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFiador.Location = new System.Drawing.Point(4, 24);
            this.tabFiador.Name = "tabFiador";
            this.tabFiador.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiador.Size = new System.Drawing.Size(674, 393);
            this.tabFiador.TabIndex = 0;
            this.tabFiador.Text = "Fiador";
            this.tabFiador.UseVisualStyleBackColor = true;
            // 
            // txtFiadorTel
            // 
            this.txtFiadorTel.Location = new System.Drawing.Point(99, 159);
            this.txtFiadorTel.MaxLength = 8;
            this.txtFiadorTel.Name = "txtFiadorTel";
            this.txtFiadorTel.Size = new System.Drawing.Size(144, 21);
            this.txtFiadorTel.TabIndex = 4;
            // 
            // txtFiadorNit
            // 
            this.txtFiadorNit.Location = new System.Drawing.Point(99, 126);
            this.txtFiadorNit.Name = "txtFiadorNit";
            this.txtFiadorNit.Size = new System.Drawing.Size(144, 21);
            this.txtFiadorNit.TabIndex = 3;
            // 
            // txtFiadorDui
            // 
            this.txtFiadorDui.Location = new System.Drawing.Point(99, 90);
            this.txtFiadorDui.Name = "txtFiadorDui";
            this.txtFiadorDui.Size = new System.Drawing.Size(144, 21);
            this.txtFiadorDui.TabIndex = 2;
            // 
            // dgvFiadores
            // 
            this.dgvFiadores.AllowUserToAddRows = false;
            this.dgvFiadores.AllowUserToDeleteRows = false;
            this.dgvFiadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiadores.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvFiadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombres,
            this.apellidos,
            this.dui,
            this.tel,
            this.eliminar,
            this.fiadorObjeto});
            this.dgvFiadores.GridColor = System.Drawing.Color.White;
            this.dgvFiadores.Location = new System.Drawing.Point(48, 283);
            this.dgvFiadores.Name = "dgvFiadores";
            this.dgvFiadores.ReadOnly = true;
            this.dgvFiadores.RowHeadersVisible = false;
            this.dgvFiadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiadores.Size = new System.Drawing.Size(581, 84);
            this.dgvFiadores.TabIndex = 8;
            this.dgvFiadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiadores_CellClick);
            // 
            // nombres
            // 
            this.nombres.FillWeight = 150F;
            this.nombres.HeaderText = "Nombres";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // apellidos
            // 
            this.apellidos.FillWeight = 150F;
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            // 
            // dui
            // 
            this.dui.FillWeight = 75F;
            this.dui.HeaderText = "DUI";
            this.dui.Name = "dui";
            this.dui.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.HeaderText = "Teléfono";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.FillWeight = 25F;
            this.eliminar.HeaderText = "";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Text = "x";
            this.eliminar.UseColumnTextForButtonValue = true;
            // 
            // fiadorObjeto
            // 
            this.fiadorObjeto.HeaderText = "Objeto";
            this.fiadorObjeto.Name = "fiadorObjeto";
            this.fiadorObjeto.ReadOnly = true;
            this.fiadorObjeto.Visible = false;
            // 
            // btnFiadorCancelar
            // 
            this.btnFiadorCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiadorCancelar.Location = new System.Drawing.Point(386, 227);
            this.btnFiadorCancelar.Name = "btnFiadorCancelar";
            this.btnFiadorCancelar.Size = new System.Drawing.Size(140, 35);
            this.btnFiadorCancelar.TabIndex = 7;
            this.btnFiadorCancelar.Text = "Cancelar";
            this.btnFiadorCancelar.UseVisualStyleBackColor = true;
            this.btnFiadorCancelar.Click += new System.EventHandler(this.btnFiadorCancelar_Click);
            // 
            // btnFiadorAgregar
            // 
            this.btnFiadorAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiadorAgregar.Location = new System.Drawing.Point(159, 227);
            this.btnFiadorAgregar.Name = "btnFiadorAgregar";
            this.btnFiadorAgregar.Size = new System.Drawing.Size(140, 35);
            this.btnFiadorAgregar.TabIndex = 6;
            this.btnFiadorAgregar.Text = "Agregar";
            this.btnFiadorAgregar.UseVisualStyleBackColor = true;
            this.btnFiadorAgregar.Click += new System.EventHandler(this.btnFiadorAgregar_Click);
            // 
            // txtFiadorDir
            // 
            this.txtFiadorDir.Location = new System.Drawing.Point(333, 93);
            this.txtFiadorDir.Multiline = true;
            this.txtFiadorDir.Name = "txtFiadorDir";
            this.txtFiadorDir.Size = new System.Drawing.Size(283, 86);
            this.txtFiadorDir.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "TEL: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "NIT:";
            // 
            // txtFiadorApellidos
            // 
            this.txtFiadorApellidos.Location = new System.Drawing.Point(410, 29);
            this.txtFiadorApellidos.Name = "txtFiadorApellidos";
            this.txtFiadorApellidos.Size = new System.Drawing.Size(200, 21);
            this.txtFiadorApellidos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos:";
            // 
            // txtFiadorNombres
            // 
            this.txtFiadorNombres.Location = new System.Drawing.Point(99, 29);
            this.txtFiadorNombres.Name = "txtFiadorNombres";
            this.txtFiadorNombres.Size = new System.Drawing.Size(200, 21);
            this.txtFiadorNombres.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUI:";
            // 
            // tabHipotecaria
            // 
            this.tabHipotecaria.Controls.Add(this.txtHipotecarioMedida);
            this.tabHipotecaria.Controls.Add(this.btnHipotecariaCancelar);
            this.tabHipotecaria.Controls.Add(this.btnHipotecariaAgregar);
            this.tabHipotecaria.Controls.Add(this.dgvHipotecarias);
            this.tabHipotecaria.Controls.Add(this.txtHipotecarioMatricula);
            this.tabHipotecaria.Controls.Add(this.label10);
            this.tabHipotecaria.Controls.Add(this.label9);
            this.tabHipotecaria.Controls.Add(this.txtHipotecarioDir);
            this.tabHipotecaria.Controls.Add(this.label8);
            this.tabHipotecaria.Controls.Add(this.cmbHipotecarioPropietario);
            this.tabHipotecaria.Controls.Add(this.label7);
            this.tabHipotecaria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHipotecaria.Location = new System.Drawing.Point(4, 24);
            this.tabHipotecaria.Name = "tabHipotecaria";
            this.tabHipotecaria.Padding = new System.Windows.Forms.Padding(3);
            this.tabHipotecaria.Size = new System.Drawing.Size(674, 393);
            this.tabHipotecaria.TabIndex = 1;
            this.tabHipotecaria.Text = "Hipotecaria";
            this.tabHipotecaria.UseVisualStyleBackColor = true;
            // 
            // txtHipotecarioMedida
            // 
            this.txtHipotecarioMedida.Location = new System.Drawing.Point(103, 123);
            this.txtHipotecarioMedida.Name = "txtHipotecarioMedida";
            this.txtHipotecarioMedida.Size = new System.Drawing.Size(135, 21);
            this.txtHipotecarioMedida.TabIndex = 2;
            // 
            // btnHipotecariaCancelar
            // 
            this.btnHipotecariaCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHipotecariaCancelar.Location = new System.Drawing.Point(380, 190);
            this.btnHipotecariaCancelar.Name = "btnHipotecariaCancelar";
            this.btnHipotecariaCancelar.Size = new System.Drawing.Size(140, 35);
            this.btnHipotecariaCancelar.TabIndex = 5;
            this.btnHipotecariaCancelar.Text = "Cancelar";
            this.btnHipotecariaCancelar.UseVisualStyleBackColor = true;
            this.btnHipotecariaCancelar.Click += new System.EventHandler(this.btnHipotecariaCancelar_Click);
            // 
            // btnHipotecariaAgregar
            // 
            this.btnHipotecariaAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHipotecariaAgregar.Location = new System.Drawing.Point(173, 190);
            this.btnHipotecariaAgregar.Name = "btnHipotecariaAgregar";
            this.btnHipotecariaAgregar.Size = new System.Drawing.Size(140, 35);
            this.btnHipotecariaAgregar.TabIndex = 4;
            this.btnHipotecariaAgregar.Text = "Agregar";
            this.btnHipotecariaAgregar.UseVisualStyleBackColor = true;
            this.btnHipotecariaAgregar.Click += new System.EventHandler(this.btnHipotecariaAgregar_Click);
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
            this.hipoDir,
            this.hipoElim,
            this.hipoObjeto});
            this.dgvHipotecarias.Location = new System.Drawing.Point(30, 251);
            this.dgvHipotecarias.Name = "dgvHipotecarias";
            this.dgvHipotecarias.ReadOnly = true;
            this.dgvHipotecarias.RowHeadersVisible = false;
            this.dgvHipotecarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHipotecarias.Size = new System.Drawing.Size(617, 113);
            this.dgvHipotecarias.TabIndex = 6;
            this.dgvHipotecarias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHipotecarias_CellClick);
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
            // hipoElim
            // 
            this.hipoElim.FillWeight = 15F;
            this.hipoElim.HeaderText = "";
            this.hipoElim.Name = "hipoElim";
            this.hipoElim.ReadOnly = true;
            this.hipoElim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hipoElim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hipoElim.Text = "x";
            this.hipoElim.UseColumnTextForButtonValue = true;
            // 
            // hipoObjeto
            // 
            this.hipoObjeto.HeaderText = "Objeto";
            this.hipoObjeto.Name = "hipoObjeto";
            this.hipoObjeto.ReadOnly = true;
            this.hipoObjeto.Visible = false;
            // 
            // txtHipotecarioMatricula
            // 
            this.txtHipotecarioMatricula.Location = new System.Drawing.Point(103, 81);
            this.txtHipotecarioMatricula.Name = "txtHipotecarioMatricula";
            this.txtHipotecarioMatricula.Size = new System.Drawing.Size(163, 21);
            this.txtHipotecarioMatricula.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Medida:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Matricula:";
            // 
            // txtHipotecarioDir
            // 
            this.txtHipotecarioDir.Location = new System.Drawing.Point(408, 84);
            this.txtHipotecarioDir.Multiline = true;
            this.txtHipotecarioDir.Name = "txtHipotecarioDir";
            this.txtHipotecarioDir.Size = new System.Drawing.Size(219, 72);
            this.txtHipotecarioDir.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Dirección:";
            // 
            // cmbHipotecarioPropietario
            // 
            this.cmbHipotecarioPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHipotecarioPropietario.FormattingEnabled = true;
            this.cmbHipotecarioPropietario.Location = new System.Drawing.Point(103, 30);
            this.cmbHipotecarioPropietario.Name = "cmbHipotecarioPropietario";
            this.cmbHipotecarioPropietario.Size = new System.Drawing.Size(300, 23);
            this.cmbHipotecarioPropietario.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Propietario:";
            // 
            // tabPrendaria
            // 
            this.tabPrendaria.Controls.Add(this.dgvPrendarias);
            this.tabPrendaria.Controls.Add(this.btnPrendariaCancelar);
            this.tabPrendaria.Controls.Add(this.btnPrendariaAgregar);
            this.tabPrendaria.Controls.Add(this.txtPrendariaDescripcion);
            this.tabPrendaria.Controls.Add(this.label16);
            this.tabPrendaria.Controls.Add(this.txtPrendariaNombre);
            this.tabPrendaria.Controls.Add(this.label15);
            this.tabPrendaria.Controls.Add(this.cmbPredariaPropietario);
            this.tabPrendaria.Controls.Add(this.label13);
            this.tabPrendaria.Location = new System.Drawing.Point(4, 24);
            this.tabPrendaria.Name = "tabPrendaria";
            this.tabPrendaria.Size = new System.Drawing.Size(674, 393);
            this.tabPrendaria.TabIndex = 2;
            this.tabPrendaria.Text = "Prendaria";
            this.tabPrendaria.UseVisualStyleBackColor = true;
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
            this.prenDesc,
            this.prenElim,
            this.prenObjeto});
            this.dgvPrendarias.Location = new System.Drawing.Point(29, 273);
            this.dgvPrendarias.Name = "dgvPrendarias";
            this.dgvPrendarias.ReadOnly = true;
            this.dgvPrendarias.RowHeadersVisible = false;
            this.dgvPrendarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrendarias.Size = new System.Drawing.Size(621, 82);
            this.dgvPrendarias.TabIndex = 5;
            this.dgvPrendarias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrendarias_CellClick);
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
            // prenElim
            // 
            this.prenElim.FillWeight = 15F;
            this.prenElim.HeaderText = "";
            this.prenElim.Name = "prenElim";
            this.prenElim.ReadOnly = true;
            this.prenElim.Text = "x";
            this.prenElim.UseColumnTextForButtonValue = true;
            // 
            // prenObjeto
            // 
            this.prenObjeto.HeaderText = "Objeto";
            this.prenObjeto.Name = "prenObjeto";
            this.prenObjeto.ReadOnly = true;
            this.prenObjeto.Visible = false;
            // 
            // btnPrendariaCancelar
            // 
            this.btnPrendariaCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrendariaCancelar.Location = new System.Drawing.Point(390, 218);
            this.btnPrendariaCancelar.Name = "btnPrendariaCancelar";
            this.btnPrendariaCancelar.Size = new System.Drawing.Size(140, 35);
            this.btnPrendariaCancelar.TabIndex = 4;
            this.btnPrendariaCancelar.Text = "Cancelar";
            this.btnPrendariaCancelar.UseVisualStyleBackColor = true;
            this.btnPrendariaCancelar.Click += new System.EventHandler(this.btnPrendariaCancelar_Click);
            // 
            // btnPrendariaAgregar
            // 
            this.btnPrendariaAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrendariaAgregar.Location = new System.Drawing.Point(186, 218);
            this.btnPrendariaAgregar.Name = "btnPrendariaAgregar";
            this.btnPrendariaAgregar.Size = new System.Drawing.Size(140, 35);
            this.btnPrendariaAgregar.TabIndex = 3;
            this.btnPrendariaAgregar.Text = "Agregar";
            this.btnPrendariaAgregar.UseVisualStyleBackColor = true;
            this.btnPrendariaAgregar.Click += new System.EventHandler(this.btnPrendariaAgregar_Click);
            // 
            // txtPrendariaDescripcion
            // 
            this.txtPrendariaDescripcion.Location = new System.Drawing.Point(430, 103);
            this.txtPrendariaDescripcion.Multiline = true;
            this.txtPrendariaDescripcion.Name = "txtPrendariaDescripcion";
            this.txtPrendariaDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrendariaDescripcion.Size = new System.Drawing.Size(220, 75);
            this.txtPrendariaDescripcion.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(348, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 15);
            this.label16.TabIndex = 23;
            this.label16.Text = "Descripción:";
            // 
            // txtPrendariaNombre
            // 
            this.txtPrendariaNombre.Location = new System.Drawing.Point(112, 100);
            this.txtPrendariaNombre.Multiline = true;
            this.txtPrendariaNombre.Name = "txtPrendariaNombre";
            this.txtPrendariaNombre.Size = new System.Drawing.Size(203, 20);
            this.txtPrendariaNombre.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "Bien mueble:";
            // 
            // cmbPredariaPropietario
            // 
            this.cmbPredariaPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredariaPropietario.FormattingEnabled = true;
            this.cmbPredariaPropietario.Location = new System.Drawing.Point(102, 34);
            this.cmbPredariaPropietario.Name = "cmbPredariaPropietario";
            this.cmbPredariaPropietario.Size = new System.Drawing.Size(303, 23);
            this.cmbPredariaPropietario.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Propietario:";
            // 
            // tabDepositos
            // 
            this.tabDepositos.Controls.Add(this.dgvDepositos);
            this.tabDepositos.Controls.Add(this.btnDepositosAgregar);
            this.tabDepositos.Controls.Add(this.cmbDepositos);
            this.tabDepositos.Controls.Add(this.label17);
            this.tabDepositos.Location = new System.Drawing.Point(4, 24);
            this.tabDepositos.Name = "tabDepositos";
            this.tabDepositos.Size = new System.Drawing.Size(674, 393);
            this.tabDepositos.TabIndex = 3;
            this.tabDepositos.Text = "Deposito a plazo";
            this.tabDepositos.UseVisualStyleBackColor = true;
            // 
            // dgvDepositos
            // 
            this.dgvDepositos.AllowUserToAddRows = false;
            this.dgvDepositos.AllowUserToDeleteRows = false;
            this.dgvDepositos.AllowUserToResizeColumns = false;
            this.dgvDepositos.AllowUserToResizeRows = false;
            this.dgvDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepositos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.dataGridViewButtonColumn1,
            this.depositoObjeto});
            this.dgvDepositos.GridColor = System.Drawing.SystemColors.Window;
            this.dgvDepositos.Location = new System.Drawing.Point(229, 133);
            this.dgvDepositos.Name = "dgvDepositos";
            this.dgvDepositos.ReadOnly = true;
            this.dgvDepositos.RowHeadersVisible = false;
            this.dgvDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepositos.Size = new System.Drawing.Size(219, 82);
            this.dgvDepositos.TabIndex = 6;
            // 
            // codigo
            // 
            this.codigo.FillWeight = 97.48731F;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.FillWeight = 17.51269F;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "x";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // depositoObjeto
            // 
            this.depositoObjeto.HeaderText = "Objeto";
            this.depositoObjeto.Name = "depositoObjeto";
            this.depositoObjeto.ReadOnly = true;
            this.depositoObjeto.Visible = false;
            // 
            // btnDepositosAgregar
            // 
            this.btnDepositosAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepositosAgregar.Location = new System.Drawing.Point(407, 35);
            this.btnDepositosAgregar.Name = "btnDepositosAgregar";
            this.btnDepositosAgregar.Size = new System.Drawing.Size(140, 35);
            this.btnDepositosAgregar.TabIndex = 1;
            this.btnDepositosAgregar.Text = "Agregar";
            this.btnDepositosAgregar.UseVisualStyleBackColor = true;
            this.btnDepositosAgregar.Click += new System.EventHandler(this.btnDepositosAgregar_Click);
            // 
            // cmbDepositos
            // 
            this.cmbDepositos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepositos.FormattingEnabled = true;
            this.cmbDepositos.Location = new System.Drawing.Point(132, 42);
            this.cmbDepositos.Name = "cmbDepositos";
            this.cmbDepositos.Size = new System.Drawing.Size(201, 23);
            this.cmbDepositos.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(62, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Deposito:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(377, 1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(163, 1);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 35);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(1, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 39);
            this.panel1.TabIndex = 5;
            // 
            // FormCreditoAgregarGarantias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreditoAgregarGarantias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garantías";
            this.Load += new System.EventHandler(this.FormCreditoGarantias_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFiador.ResumeLayout(false);
            this.tabFiador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiadores)).EndInit();
            this.tabHipotecaria.ResumeLayout(false);
            this.tabHipotecaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHipotecarias)).EndInit();
            this.tabPrendaria.ResumeLayout(false);
            this.tabPrendaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendarias)).EndInit();
            this.tabDepositos.ResumeLayout(false);
            this.tabDepositos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFiador;
        private System.Windows.Forms.TabPage tabHipotecaria;
        private System.Windows.Forms.TabPage tabPrendaria;
        private System.Windows.Forms.TabPage tabDepositos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiadorApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiadorNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvFiadores;
        private System.Windows.Forms.Button btnFiadorAgregar;
        private System.Windows.Forms.TextBox txtFiadorDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbHipotecarioPropietario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHipotecarioDir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHipotecarioMatricula;
        private System.Windows.Forms.DataGridView dgvHipotecarias;
        private System.Windows.Forms.Button btnHipotecariaCancelar;
        private System.Windows.Forms.Button btnHipotecariaAgregar;
        private System.Windows.Forms.ComboBox cmbPredariaPropietario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPrendarias;
        private System.Windows.Forms.Button btnPrendariaCancelar;
        private System.Windows.Forms.Button btnPrendariaAgregar;
        private System.Windows.Forms.TextBox txtPrendariaDescripcion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPrendariaNombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDepositosAgregar;
        private System.Windows.Forms.ComboBox cmbDepositos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFiadorTel;
        private System.Windows.Forms.TextBox txtFiadorNit;
        private System.Windows.Forms.TextBox txtFiadorDui;
        private System.Windows.Forms.TextBox txtHipotecarioMedida;
        private System.Windows.Forms.Button btnFiadorCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn bien;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenDesc;
        private System.Windows.Forms.DataGridViewButtonColumn prenElim;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiadorObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hipoDir;
        private System.Windows.Forms.DataGridViewButtonColumn hipoElim;
        private System.Windows.Forms.DataGridViewTextBoxColumn hipoObjeto;
        private System.Windows.Forms.DataGridView dgvDepositos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositoObjeto;
        private System.Windows.Forms.Panel panel1;
    }
}
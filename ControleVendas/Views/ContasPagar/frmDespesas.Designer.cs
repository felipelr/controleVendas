namespace ControleVendas.Views.ContasPagar
{
    partial class frmDespesas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtPagaNao = new System.Windows.Forms.RadioButton();
            this.rbtPagaSim = new System.Windows.Forms.RadioButton();
            this.dtpDataDespesa = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.CellIdDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellPagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.CellExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.CellStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalDespesasGeral = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalDespesasPagas = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalDespesasNaoPagas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 43);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Despesas";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dtpDataDespesa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbCategoria);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbFornecedor);
            this.panel2.Controls.Add(this.btnInserir);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 638);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(12, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(18, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Despesa Paga";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtPagaNao);
            this.panel4.Controls.Add(this.rbtPagaSim);
            this.panel4.Location = new System.Drawing.Point(16, 339);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 32);
            this.panel4.TabIndex = 12;
            // 
            // rbtPagaNao
            // 
            this.rbtPagaNao.AutoSize = true;
            this.rbtPagaNao.Location = new System.Drawing.Point(63, 6);
            this.rbtPagaNao.Name = "rbtPagaNao";
            this.rbtPagaNao.Size = new System.Drawing.Size(48, 19);
            this.rbtPagaNao.TabIndex = 1;
            this.rbtPagaNao.Text = "Não";
            this.rbtPagaNao.UseVisualStyleBackColor = true;
            // 
            // rbtPagaSim
            // 
            this.rbtPagaSim.AutoSize = true;
            this.rbtPagaSim.Checked = true;
            this.rbtPagaSim.Location = new System.Drawing.Point(7, 6);
            this.rbtPagaSim.Name = "rbtPagaSim";
            this.rbtPagaSim.Size = new System.Drawing.Size(47, 19);
            this.rbtPagaSim.TabIndex = 0;
            this.rbtPagaSim.TabStop = true;
            this.rbtPagaSim.Text = "Sim";
            this.rbtPagaSim.UseVisualStyleBackColor = true;
            // 
            // dtpDataDespesa
            // 
            this.dtpDataDespesa.Font = new System.Drawing.Font("Roboto", 12F);
            this.dtpDataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDespesa.Location = new System.Drawing.Point(12, 282);
            this.dtpDataDespesa.Name = "dtpDataDespesa";
            this.dtpDataDespesa.Size = new System.Drawing.Size(237, 27);
            this.dtpDataDespesa.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(12, 166);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(240, 27);
            this.cmbCategoria.TabIndex = 6;
            this.cmbCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCategoria_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(16, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(12, 223);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(237, 27);
            this.txtValor.TabIndex = 8;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informações da Despesa";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFornecedor.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(12, 112);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(240, 27);
            this.cmbFornecedor.TabIndex = 4;
            this.cmbFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFornecedor_KeyDown);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInserir.Location = new System.Drawing.Point(12, 389);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(243, 39);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(12, 59);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(240, 27);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvDespesas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDespesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespesas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDespesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDespesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDespesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDespesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDespesas.ColumnHeadersHeight = 35;
            this.dgvDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CellIdDespesa,
            this.CellData,
            this.CellDescricao,
            this.CellCategoria,
            this.CellFornecedor,
            this.CellValor,
            this.CellPagar,
            this.CellExcluir,
            this.CellStatus});
            this.dgvDespesas.EnableHeadersVisualStyles = false;
            this.dgvDespesas.Location = new System.Drawing.Point(274, 94);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.RowHeadersVisible = false;
            this.dgvDespesas.RowTemplate.Height = 30;
            this.dgvDespesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesas.Size = new System.Drawing.Size(727, 483);
            this.dgvDespesas.TabIndex = 5;
            this.dgvDespesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespesas_CellClick);
            // 
            // CellIdDespesa
            // 
            this.CellIdDespesa.HeaderText = "CellIdDespesa";
            this.CellIdDespesa.Name = "CellIdDespesa";
            this.CellIdDespesa.ReadOnly = true;
            this.CellIdDespesa.Visible = false;
            // 
            // CellData
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.CellData.DefaultCellStyle = dataGridViewCellStyle3;
            this.CellData.HeaderText = "Data";
            this.CellData.Name = "CellData";
            this.CellData.ReadOnly = true;
            // 
            // CellDescricao
            // 
            this.CellDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.NullValue = null;
            this.CellDescricao.DefaultCellStyle = dataGridViewCellStyle4;
            this.CellDescricao.HeaderText = "Descrição";
            this.CellDescricao.Name = "CellDescricao";
            this.CellDescricao.ReadOnly = true;
            // 
            // CellCategoria
            // 
            this.CellCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CellCategoria.HeaderText = "Categoria";
            this.CellCategoria.Name = "CellCategoria";
            this.CellCategoria.ReadOnly = true;
            // 
            // CellFornecedor
            // 
            this.CellFornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CellFornecedor.HeaderText = "Fornecedor";
            this.CellFornecedor.Name = "CellFornecedor";
            this.CellFornecedor.ReadOnly = true;
            // 
            // CellValor
            // 
            dataGridViewCellStyle5.Format = "C2";
            this.CellValor.DefaultCellStyle = dataGridViewCellStyle5;
            this.CellValor.HeaderText = "Valor";
            this.CellValor.Name = "CellValor";
            this.CellValor.ReadOnly = true;
            this.CellValor.Width = 120;
            // 
            // CellPagar
            // 
            this.CellPagar.HeaderText = "Ações";
            this.CellPagar.Name = "CellPagar";
            this.CellPagar.ReadOnly = true;
            this.CellPagar.Width = 45;
            // 
            // CellExcluir
            // 
            this.CellExcluir.HeaderText = "";
            this.CellExcluir.Name = "CellExcluir";
            this.CellExcluir.ReadOnly = true;
            this.CellExcluir.Width = 45;
            // 
            // CellStatus
            // 
            this.CellStatus.HeaderText = "CellStatus";
            this.CellStatus.Name = "CellStatus";
            this.CellStatus.ReadOnly = true;
            this.CellStatus.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.lblTotalDespesasGeral);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(274, 647);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 34);
            this.panel3.TabIndex = 6;
            // 
            // lblTotalDespesasGeral
            // 
            this.lblTotalDespesasGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDespesasGeral.AutoSize = true;
            this.lblTotalDespesasGeral.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDespesasGeral.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalDespesasGeral.Location = new System.Drawing.Point(511, 6);
            this.lblTotalDespesasGeral.Name = "lblTotalDespesasGeral";
            this.lblTotalDespesasGeral.Size = new System.Drawing.Size(103, 19);
            this.lblTotalDespesasGeral.TabIndex = 1;
            this.lblTotalDespesasGeral.Text = "R$ 10.000,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(6, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "VALOR TOTAL GERAL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Image = global::ControleVendas.Properties.Resources.ic_buscar_branco_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(274, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtros Aplicados";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel5.Controls.Add(this.lblTotalDespesasPagas);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(274, 579);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(727, 34);
            this.panel5.TabIndex = 7;
            // 
            // lblTotalDespesasPagas
            // 
            this.lblTotalDespesasPagas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDespesasPagas.AutoSize = true;
            this.lblTotalDespesasPagas.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDespesasPagas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalDespesasPagas.Location = new System.Drawing.Point(511, 6);
            this.lblTotalDespesasPagas.Name = "lblTotalDespesasPagas";
            this.lblTotalDespesasPagas.Size = new System.Drawing.Size(103, 19);
            this.lblTotalDespesasPagas.TabIndex = 1;
            this.lblTotalDespesasPagas.Text = "R$ 10.000,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(6, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "VALOR TOTAL PAGO";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.lblTotalDespesasNaoPagas);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(274, 613);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(727, 34);
            this.panel6.TabIndex = 8;
            // 
            // lblTotalDespesasNaoPagas
            // 
            this.lblTotalDespesasNaoPagas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDespesasNaoPagas.AutoSize = true;
            this.lblTotalDespesasNaoPagas.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDespesasNaoPagas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalDespesasNaoPagas.Location = new System.Drawing.Point(511, 6);
            this.lblTotalDespesasNaoPagas.Name = "lblTotalDespesasNaoPagas";
            this.lblTotalDespesasNaoPagas.Size = new System.Drawing.Size(103, 19);
            this.lblTotalDespesasNaoPagas.TabIndex = 1;
            this.lblTotalDespesasNaoPagas.Text = "R$ 10.000,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(6, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "VALOR TOTAL NÃO PAGO";
            // 
            // frmDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDespesas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "frmDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDespesas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataDespesa;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalDespesasGeral;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtPagaNao;
        private System.Windows.Forms.RadioButton rbtPagaSim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellIdDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellValor;
        private System.Windows.Forms.DataGridViewImageColumn CellPagar;
        private System.Windows.Forms.DataGridViewImageColumn CellExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellStatus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalDespesasPagas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalDespesasNaoPagas;
        private System.Windows.Forms.Label label12;
    }
}
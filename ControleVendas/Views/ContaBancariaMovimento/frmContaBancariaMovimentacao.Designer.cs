namespace ControleVendas.Views.ContaBancariaMovimento
{
    partial class frmContaBancariaMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContaBancariaMovimentacao));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtTipoSaida = new System.Windows.Forms.RadioButton();
            this.rbtTipoEntrada = new System.Windows.Forms.RadioButton();
            this.dtpDataMovimentacao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbConta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalSaidas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvMovimentacoes = new System.Windows.Forms.DataGridView();
            this.CellIdContaMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacoes)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.lblSaldo);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(274, 647);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 34);
            this.panel3.TabIndex = 13;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSaldo.Location = new System.Drawing.Point(511, 6);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(103, 19);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "R$ 10.000,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(6, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "SALDO";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(12, 374);
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
            this.label8.Location = new System.Drawing.Point(18, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tipo da Movimentação";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtTipoSaida);
            this.panel4.Controls.Add(this.rbtTipoEntrada);
            this.panel4.Location = new System.Drawing.Point(16, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 32);
            this.panel4.TabIndex = 12;
            // 
            // rbtTipoSaida
            // 
            this.rbtTipoSaida.AutoSize = true;
            this.rbtTipoSaida.Location = new System.Drawing.Point(86, 6);
            this.rbtTipoSaida.Name = "rbtTipoSaida";
            this.rbtTipoSaida.Size = new System.Drawing.Size(57, 19);
            this.rbtTipoSaida.TabIndex = 1;
            this.rbtTipoSaida.Text = "Saída";
            this.rbtTipoSaida.UseVisualStyleBackColor = true;
            // 
            // rbtTipoEntrada
            // 
            this.rbtTipoEntrada.AutoSize = true;
            this.rbtTipoEntrada.Checked = true;
            this.rbtTipoEntrada.Location = new System.Drawing.Point(7, 6);
            this.rbtTipoEntrada.Name = "rbtTipoEntrada";
            this.rbtTipoEntrada.Size = new System.Drawing.Size(68, 19);
            this.rbtTipoEntrada.TabIndex = 0;
            this.rbtTipoEntrada.TabStop = true;
            this.rbtTipoEntrada.Text = "Entrada";
            this.rbtTipoEntrada.UseVisualStyleBackColor = true;
            // 
            // dtpDataMovimentacao
            // 
            this.dtpDataMovimentacao.Font = new System.Drawing.Font("Roboto", 12F);
            this.dtpDataMovimentacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMovimentacao.Location = new System.Drawing.Point(12, 229);
            this.dtpDataMovimentacao.Name = "dtpDataMovimentacao";
            this.dtpDataMovimentacao.Size = new System.Drawing.Size(237, 27);
            this.dtpDataMovimentacao.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data";
            // 
            // cmbConta
            // 
            this.cmbConta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbConta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbConta.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmbConta.FormattingEnabled = true;
            this.cmbConta.Location = new System.Drawing.Point(12, 114);
            this.cmbConta.Name = "cmbConta";
            this.cmbConta.Size = new System.Drawing.Size(240, 27);
            this.cmbConta.TabIndex = 6;
            this.cmbConta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbConta_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(16, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor";
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
            this.button1.TabIndex = 11;
            this.button1.Text = "Filtros Aplicados";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(12, 170);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(237, 27);
            this.txtValor.TabIndex = 8;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informações da Movimentação";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInserir.Location = new System.Drawing.Point(12, 329);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(243, 39);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
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
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel5.Controls.Add(this.lblTotalEntradas);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(274, 579);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(727, 34);
            this.panel5.TabIndex = 14;
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalEntradas.Location = new System.Drawing.Point(511, 6);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(103, 19);
            this.lblTotalEntradas.TabIndex = 1;
            this.lblTotalEntradas.Text = "R$ 10.000,00";
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
            this.label11.Text = "VALOR DE ENTRADA";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.lblTotalSaidas);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(274, 613);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(727, 34);
            this.panel6.TabIndex = 15;
            // 
            // lblTotalSaidas
            // 
            this.lblTotalSaidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSaidas.AutoSize = true;
            this.lblTotalSaidas.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaidas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalSaidas.Location = new System.Drawing.Point(511, 6);
            this.lblTotalSaidas.Name = "lblTotalSaidas";
            this.lblTotalSaidas.Size = new System.Drawing.Size(103, 19);
            this.lblTotalSaidas.TabIndex = 1;
            this.lblTotalSaidas.Text = "R$ 10.000,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(6, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "VALOR DE SAÍDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conta";
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
            // dgvMovimentacoes
            // 
            this.dgvMovimentacoes.AllowUserToAddRows = false;
            this.dgvMovimentacoes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvMovimentacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimentacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimentacoes.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovimentacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovimentacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMovimentacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimentacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovimentacoes.ColumnHeadersHeight = 35;
            this.dgvMovimentacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CellIdContaMovimentacao,
            this.CellData,
            this.CellDescricao,
            this.CellConta,
            this.CellValor,
            this.CellTipo,
            this.CellExcluir});
            this.dgvMovimentacoes.EnableHeadersVisualStyles = false;
            this.dgvMovimentacoes.Location = new System.Drawing.Point(274, 94);
            this.dgvMovimentacoes.Name = "dgvMovimentacoes";
            this.dgvMovimentacoes.ReadOnly = true;
            this.dgvMovimentacoes.RowHeadersVisible = false;
            this.dgvMovimentacoes.RowTemplate.Height = 30;
            this.dgvMovimentacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimentacoes.Size = new System.Drawing.Size(727, 483);
            this.dgvMovimentacoes.TabIndex = 12;
            this.dgvMovimentacoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimentacoes_CellClick);
            // 
            // CellIdContaMovimentacao
            // 
            this.CellIdContaMovimentacao.HeaderText = "CellIdContaMovimentacao";
            this.CellIdContaMovimentacao.Name = "CellIdContaMovimentacao";
            this.CellIdContaMovimentacao.ReadOnly = true;
            this.CellIdContaMovimentacao.Visible = false;
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
            // CellConta
            // 
            this.CellConta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CellConta.HeaderText = "Conta";
            this.CellConta.Name = "CellConta";
            this.CellConta.ReadOnly = true;
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
            // CellTipo
            // 
            this.CellTipo.HeaderText = "Tipo";
            this.CellTipo.Name = "CellTipo";
            this.CellTipo.ReadOnly = true;
            this.CellTipo.Width = 50;
            // 
            // CellExcluir
            // 
            this.CellExcluir.HeaderText = "Ações";
            this.CellExcluir.Name = "CellExcluir";
            this.CellExcluir.ReadOnly = true;
            this.CellExcluir.Width = 45;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dtpDataMovimentacao);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbConta);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnInserir);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 638);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimentação de Contas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 43);
            this.panel1.TabIndex = 9;
            // 
            // frmContaBancariaMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dgvMovimentacoes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "frmContaBancariaMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Bancário Movimentação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContaBancariaMovimentacao_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacoes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtTipoSaida;
        private System.Windows.Forms.RadioButton rbtTipoEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataMovimentacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbConta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalSaidas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView dgvMovimentacoes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellIdContaMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellTipo;
        private System.Windows.Forms.DataGridViewImageColumn CellExcluir;
    }
}
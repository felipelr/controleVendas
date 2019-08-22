namespace ControleVendas.Views.Movimentacoes
{
    partial class frmVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEstoqueAtual = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMovimentacoesProdutos = new System.Windows.Forms.DataGridView();
            this.CellIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellQuantidadeMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellValorTotalMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellRemover = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.lblTotalQuantidade = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacoesProdutos)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtPrecoVenda);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtQuantidade);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblEstoqueAtual);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbProduto);
            this.panel2.Controls.Add(this.btnInserir);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIdProduto);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 638);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(16, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Preço de Venda";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(12, 226);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(237, 27);
            this.txtPrecoVenda.TabIndex = 8;
            this.txtPrecoVenda.TextChanged += new System.EventHandler(this.txtPrecoVenda_TextChanged);
            this.txtPrecoVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoVenda_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(12, 167);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(237, 27);
            this.txtQuantidade.TabIndex = 6;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(16, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Estoque Atual";
            // 
            // lblEstoqueAtual
            // 
            this.lblEstoqueAtual.AutoSize = true;
            this.lblEstoqueAtual.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstoqueAtual.Location = new System.Drawing.Point(16, 291);
            this.lblEstoqueAtual.Name = "lblEstoqueAtual";
            this.lblEstoqueAtual.Size = new System.Drawing.Size(13, 17);
            this.lblEstoqueAtual.TabIndex = 10;
            this.lblEstoqueAtual.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informe a Quantidade e o Produto";
            // 
            // cmbProduto
            // 
            this.cmbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduto.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(12, 112);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(240, 27);
            this.cmbProduto.TabIndex = 4;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            this.cmbProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduto_KeyDown);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInserir.Location = new System.Drawing.Point(9, 326);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(243, 39);
            this.btnInserir.TabIndex = 11;
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
            this.label4.Size = new System.Drawing.Size(191, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição (digite para pesquisa)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.Location = new System.Drawing.Point(12, 59);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(240, 27);
            this.txtIdProduto.TabIndex = 2;
            this.txtIdProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdProduto_KeyDown);
            this.txtIdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProduto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(277, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Produtos inseridos na venda";
            // 
            // dgvMovimentacoesProdutos
            // 
            this.dgvMovimentacoesProdutos.AllowUserToAddRows = false;
            this.dgvMovimentacoesProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvMovimentacoesProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimentacoesProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimentacoesProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovimentacoesProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovimentacoesProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMovimentacoesProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimentacoesProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovimentacoesProdutos.ColumnHeadersHeight = 35;
            this.dgvMovimentacoesProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CellIdProduto,
            this.CellDescricaoProduto,
            this.CellQuantidadeMovimentacao,
            this.CellValorUnitario,
            this.CellValorTotalMovimentacao,
            this.CellRemover});
            this.dgvMovimentacoesProdutos.EnableHeadersVisualStyles = false;
            this.dgvMovimentacoesProdutos.Location = new System.Drawing.Point(280, 83);
            this.dgvMovimentacoesProdutos.Name = "dgvMovimentacoesProdutos";
            this.dgvMovimentacoesProdutos.ReadOnly = true;
            this.dgvMovimentacoesProdutos.RowHeadersVisible = false;
            this.dgvMovimentacoesProdutos.RowTemplate.Height = 30;
            this.dgvMovimentacoesProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimentacoesProdutos.Size = new System.Drawing.Size(716, 520);
            this.dgvMovimentacoesProdutos.TabIndex = 3;
            this.dgvMovimentacoesProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimentacoesProdutos_CellClick);
            // 
            // CellIdProduto
            // 
            dataGridViewCellStyle3.Format = "g";
            this.CellIdProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.CellIdProduto.HeaderText = "Código";
            this.CellIdProduto.Name = "CellIdProduto";
            this.CellIdProduto.ReadOnly = true;
            this.CellIdProduto.Width = 80;
            // 
            // CellDescricaoProduto
            // 
            this.CellDescricaoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.CellDescricaoProduto.DefaultCellStyle = dataGridViewCellStyle4;
            this.CellDescricaoProduto.HeaderText = "Produto";
            this.CellDescricaoProduto.Name = "CellDescricaoProduto";
            this.CellDescricaoProduto.ReadOnly = true;
            // 
            // CellQuantidadeMovimentacao
            // 
            dataGridViewCellStyle5.Format = "N2";
            this.CellQuantidadeMovimentacao.DefaultCellStyle = dataGridViewCellStyle5;
            this.CellQuantidadeMovimentacao.HeaderText = "Quantidade";
            this.CellQuantidadeMovimentacao.Name = "CellQuantidadeMovimentacao";
            this.CellQuantidadeMovimentacao.ReadOnly = true;
            // 
            // CellValorUnitario
            // 
            dataGridViewCellStyle6.Format = "C2";
            this.CellValorUnitario.DefaultCellStyle = dataGridViewCellStyle6;
            this.CellValorUnitario.HeaderText = "Valor Unitário";
            this.CellValorUnitario.Name = "CellValorUnitario";
            this.CellValorUnitario.ReadOnly = true;
            this.CellValorUnitario.Width = 120;
            // 
            // CellValorTotalMovimentacao
            // 
            dataGridViewCellStyle7.Format = "C2";
            this.CellValorTotalMovimentacao.DefaultCellStyle = dataGridViewCellStyle7;
            this.CellValorTotalMovimentacao.HeaderText = "Valor Total";
            this.CellValorTotalMovimentacao.Name = "CellValorTotalMovimentacao";
            this.CellValorTotalMovimentacao.ReadOnly = true;
            this.CellValorTotalMovimentacao.Width = 120;
            // 
            // CellRemover
            // 
            this.CellRemover.HeaderText = "Remover";
            this.CellRemover.Name = "CellRemover";
            this.CellRemover.ReadOnly = true;
            this.CellRemover.Width = 65;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmar.Location = new System.Drawing.Point(383, 621);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(243, 39);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Finalizar Venda";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTotalValor);
            this.panel3.Controls.Add(this.lblTotalQuantidade);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(647, 609);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 69);
            this.panel3.TabIndex = 5;
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalValor.Location = new System.Drawing.Point(133, 37);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(75, 23);
            this.lblTotalValor.TabIndex = 3;
            this.lblTotalValor.Text = "R$ 0,00";
            // 
            // lblTotalQuantidade
            // 
            this.lblTotalQuantidade.AutoSize = true;
            this.lblTotalQuantidade.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalQuantidade.Location = new System.Drawing.Point(133, 6);
            this.lblTotalQuantidade.Name = "lblTotalQuantidade";
            this.lblTotalQuantidade.Size = new System.Drawing.Size(47, 23);
            this.lblTotalQuantidade.TabIndex = 1;
            this.lblTotalQuantidade.Text = "0,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(42, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Valor Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(7, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quantidade Total:";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgvMovimentacoesProdutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacoesProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEstoqueAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView dgvMovimentacoesProdutos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Label lblTotalQuantidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellDescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellQuantidadeMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellValorTotalMovimentacao;
        private System.Windows.Forms.DataGridViewImageColumn CellRemover;
    }
}
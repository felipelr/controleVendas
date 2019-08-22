namespace ControleVendas.Views.Cadastros
{
    partial class frmProdutoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutoCadastro));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemoverEstoque = new System.Windows.Forms.Button();
            this.btnAddEstoque = new System.Windows.Forms.Button();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.btnAddMarca = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUnidade = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.CellIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellEstoqueAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellAlterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.CellRemover = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtMarca = new System.Windows.Forms.RadioButton();
            this.rbtUnidade = new System.Windows.Forms.RadioButton();
            this.rbtProduto = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtMargemLucro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtMargemLucro);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtPrecoVenda);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtCusto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnRemoverEstoque);
            this.panel2.Controls.Add(this.btnAddEstoque);
            this.panel2.Controls.Add(this.txtEstoque);
            this.panel2.Controls.Add(this.btnAddMarca);
            this.panel2.Controls.Add(this.cmbMarca);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbUnidade);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIdProduto);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 638);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(13, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(13, 457);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(242, 27);
            this.txtPrecoVenda.TabIndex = 19;
            this.txtPrecoVenda.TextChanged += new System.EventHandler(this.txtPrecoVenda_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(13, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Preço de Venda";
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.Location = new System.Drawing.Point(12, 340);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(243, 27);
            this.txtCusto.TabIndex = 15;
            this.txtCusto.TextChanged += new System.EventHandler(this.txtCusto_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(12, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Custo";
            // 
            // btnRemoverEstoque
            // 
            this.btnRemoverEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnRemoverEstoque.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRemoverEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverEstoque.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoverEstoque.Location = new System.Drawing.Point(215, 274);
            this.btnRemoverEstoque.Name = "btnRemoverEstoque";
            this.btnRemoverEstoque.Size = new System.Drawing.Size(40, 34);
            this.btnRemoverEstoque.TabIndex = 13;
            this.btnRemoverEstoque.Text = "-";
            this.btnRemoverEstoque.UseVisualStyleBackColor = false;
            this.btnRemoverEstoque.Click += new System.EventHandler(this.btnRemoverEstoque_Click);
            // 
            // btnAddEstoque
            // 
            this.btnAddEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnAddEstoque.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEstoque.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEstoque.Location = new System.Drawing.Point(172, 274);
            this.btnAddEstoque.Name = "btnAddEstoque";
            this.btnAddEstoque.Size = new System.Drawing.Size(40, 34);
            this.btnAddEstoque.TabIndex = 12;
            this.btnAddEstoque.Text = "+";
            this.btnAddEstoque.UseVisualStyleBackColor = false;
            this.btnAddEstoque.Click += new System.EventHandler(this.btnAddEstoque_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(12, 279);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(154, 27);
            this.txtEstoque.TabIndex = 11;
            // 
            // btnAddMarca
            // 
            this.btnAddMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnAddMarca.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMarca.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMarca.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddMarca.Location = new System.Drawing.Point(215, 220);
            this.btnAddMarca.Name = "btnAddMarca";
            this.btnAddMarca.Size = new System.Drawing.Size(40, 34);
            this.btnAddMarca.TabIndex = 9;
            this.btnAddMarca.Text = "+";
            this.btnAddMarca.UseVisualStyleBackColor = false;
            this.btnAddMarca.Click += new System.EventHandler(this.btnAddMarca_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarca.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(12, 223);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(197, 27);
            this.cmbMarca.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Marca";
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUnidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUnidade.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(12, 168);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(197, 27);
            this.cmbUnidade.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(12, 116);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(244, 27);
            this.txtDescricao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(12, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Estoque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informações do Produto";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(13, 498);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(243, 39);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.Location = new System.Drawing.Point(12, 59);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(244, 27);
            this.txtIdProduto.TabIndex = 2;
            this.txtIdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProduto_KeyPress);
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
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // btnAddUnidade
            // 
            this.btnAddUnidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnAddUnidade.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnidade.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnidade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddUnidade.Location = new System.Drawing.Point(216, 209);
            this.btnAddUnidade.Name = "btnAddUnidade";
            this.btnAddUnidade.Size = new System.Drawing.Size(40, 34);
            this.btnAddUnidade.TabIndex = 2;
            this.btnAddUnidade.Text = "+";
            this.btnAddUnidade.UseVisualStyleBackColor = false;
            this.btnAddUnidade.Click += new System.EventHandler(this.btnAddUnidade_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.ColumnHeadersHeight = 35;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CellIdProduto,
            this.CellDescricaoProduto,
            this.CellEstoqueAtual,
            this.CellAlterar,
            this.CellRemover});
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Location = new System.Drawing.Point(277, 128);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowTemplate.Height = 35;
            this.dgvProdutos.Size = new System.Drawing.Size(722, 551);
            this.dgvProdutos.TabIndex = 7;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
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
            // CellEstoqueAtual
            // 
            dataGridViewCellStyle5.Format = "N2";
            this.CellEstoqueAtual.DefaultCellStyle = dataGridViewCellStyle5;
            this.CellEstoqueAtual.HeaderText = "Estoque";
            this.CellEstoqueAtual.Name = "CellEstoqueAtual";
            this.CellEstoqueAtual.ReadOnly = true;
            // 
            // CellAlterar
            // 
            this.CellAlterar.HeaderText = "Ações";
            this.CellAlterar.Name = "CellAlterar";
            this.CellAlterar.ReadOnly = true;
            this.CellAlterar.Width = 50;
            // 
            // CellRemover
            // 
            this.CellRemover.HeaderText = "";
            this.CellRemover.Name = "CellRemover";
            this.CellRemover.ReadOnly = true;
            this.CellRemover.Width = 50;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(388, 52);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(480, 27);
            this.txtBuscar.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(316, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pesquisar";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtMarca);
            this.panel3.Controls.Add(this.rbtUnidade);
            this.panel3.Controls.Add(this.rbtProduto);
            this.panel3.Location = new System.Drawing.Point(388, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 35);
            this.panel3.TabIndex = 6;
            // 
            // rbtMarca
            // 
            this.rbtMarca.AutoSize = true;
            this.rbtMarca.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbtMarca.Location = new System.Drawing.Point(184, 8);
            this.rbtMarca.Name = "rbtMarca";
            this.rbtMarca.Size = new System.Drawing.Size(63, 21);
            this.rbtMarca.TabIndex = 2;
            this.rbtMarca.Text = "Marca";
            this.rbtMarca.UseVisualStyleBackColor = true;
            // 
            // rbtUnidade
            // 
            this.rbtUnidade.AutoSize = true;
            this.rbtUnidade.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbtUnidade.Location = new System.Drawing.Point(89, 8);
            this.rbtUnidade.Name = "rbtUnidade";
            this.rbtUnidade.Size = new System.Drawing.Size(73, 21);
            this.rbtUnidade.TabIndex = 1;
            this.rbtUnidade.Text = "Unidade";
            this.rbtUnidade.UseVisualStyleBackColor = true;
            // 
            // rbtProduto
            // 
            this.rbtProduto.AutoSize = true;
            this.rbtProduto.Checked = true;
            this.rbtProduto.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbtProduto.Location = new System.Drawing.Point(4, 8);
            this.rbtProduto.Name = "rbtProduto";
            this.rbtProduto.Size = new System.Drawing.Size(71, 21);
            this.rbtProduto.TabIndex = 0;
            this.rbtProduto.TabStop = true;
            this.rbtProduto.Text = "Produto";
            this.rbtProduto.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Image = global::ControleVendas.Properties.Resources.ic_buscar_branco_24;
            this.btnBuscar.Location = new System.Drawing.Point(874, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 34);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargemLucro.Location = new System.Drawing.Point(13, 398);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Size = new System.Drawing.Size(243, 27);
            this.txtMargemLucro.TabIndex = 17;
            this.txtMargemLucro.TextChanged += new System.EventHandler(this.txtMargemLucro_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(13, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Margem de Lucro";
            // 
            // frmProdutoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnAddUnidade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdutoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmProdutoCadastro_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.Button btnAddUnidade;
        private System.Windows.Forms.Button btnRemoverEstoque;
        private System.Windows.Forms.Button btnAddEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtMarca;
        private System.Windows.Forms.RadioButton rbtUnidade;
        private System.Windows.Forms.RadioButton rbtProduto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellDescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellEstoqueAtual;
        private System.Windows.Forms.DataGridViewImageColumn CellAlterar;
        private System.Windows.Forms.DataGridViewImageColumn CellRemover;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMargemLucro;
        private System.Windows.Forms.Label label11;
    }
}
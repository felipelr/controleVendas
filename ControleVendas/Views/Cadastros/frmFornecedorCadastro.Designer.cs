namespace ControleVendas.Views.Cadastros
{
    partial class frmFornecedorCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedorCadastro));
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.CellIdFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellAlterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.CellRemover = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(316, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pesquisar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(11, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 120);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 27);
            this.txtNome.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informações do Fornecedor";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(11, 160);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(243, 39);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvFornecedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornecedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFornecedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFornecedores.ColumnHeadersHeight = 35;
            this.dgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CellIdFornecedor,
            this.CellDescricao,
            this.CellAlterar,
            this.CellRemover});
            this.dgvFornecedores.EnableHeadersVisualStyles = false;
            this.dgvFornecedores.Location = new System.Drawing.Point(277, 89);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.RowTemplate.Height = 35;
            this.dgvFornecedores.Size = new System.Drawing.Size(722, 590);
            this.dgvFornecedores.TabIndex = 17;
            this.dgvFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedores_CellClick);
            // 
            // CellIdFornecedor
            // 
            dataGridViewCellStyle3.Format = "g";
            this.CellIdFornecedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.CellIdFornecedor.HeaderText = "Código";
            this.CellIdFornecedor.Name = "CellIdFornecedor";
            this.CellIdFornecedor.ReadOnly = true;
            this.CellIdFornecedor.Width = 80;
            // 
            // CellDescricao
            // 
            this.CellDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.CellDescricao.DefaultCellStyle = dataGridViewCellStyle4;
            this.CellDescricao.HeaderText = "Fornecedor";
            this.CellDescricao.Name = "CellDescricao";
            this.CellDescricao.ReadOnly = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIdFornecedor);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 638);
            this.panel2.TabIndex = 13;
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Enabled = false;
            this.txtIdFornecedor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFornecedor.Location = new System.Drawing.Point(12, 58);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(244, 27);
            this.txtIdFornecedor.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(388, 52);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(480, 27);
            this.txtBuscar.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fornecedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 43);
            this.panel1.TabIndex = 12;
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
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmFornecedorCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFornecedorCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.frmFornecedorCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellIdFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellDescricao;
        private System.Windows.Forms.DataGridViewImageColumn CellAlterar;
        private System.Windows.Forms.DataGridViewImageColumn CellRemover;
    }
}
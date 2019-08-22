namespace ControleVendas.Views.Cadastros
{
    partial class frmMarcaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcaCadastro));
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.CellIdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDescricaoMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellAlterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.CellRemover = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(13, 121);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(244, 27);
            this.txtDescricao.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informações da Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Marca";
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
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 161);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(243, 39);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(316, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pesquisar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(388, 52);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(480, 27);
            this.txtBuscar.TabIndex = 3;
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarca.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarca.ColumnHeadersHeight = 35;
            this.dgvMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CellIdMarca,
            this.CellDescricaoMarca,
            this.CellAlterar,
            this.CellRemover});
            this.dgvMarca.EnableHeadersVisualStyles = false;
            this.dgvMarca.Location = new System.Drawing.Point(277, 89);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.RowHeadersVisible = false;
            this.dgvMarca.RowTemplate.Height = 35;
            this.dgvMarca.Size = new System.Drawing.Size(722, 590);
            this.dgvMarca.TabIndex = 5;
            this.dgvMarca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarca_CellClick);
            // 
            // CellIdMarca
            // 
            dataGridViewCellStyle3.Format = "g";
            this.CellIdMarca.DefaultCellStyle = dataGridViewCellStyle3;
            this.CellIdMarca.HeaderText = "Código";
            this.CellIdMarca.Name = "CellIdMarca";
            this.CellIdMarca.ReadOnly = true;
            this.CellIdMarca.Width = 80;
            // 
            // CellDescricaoMarca
            // 
            this.CellDescricaoMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.CellDescricaoMarca.DefaultCellStyle = dataGridViewCellStyle4;
            this.CellDescricaoMarca.HeaderText = "Marca";
            this.CellDescricaoMarca.Name = "CellDescricaoMarca";
            this.CellDescricaoMarca.ReadOnly = true;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIdMarca);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 638);
            this.panel2.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnLimpar.Location = new System.Drawing.Point(13, 206);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(243, 39);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Enabled = false;
            this.txtIdMarca.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMarca.Location = new System.Drawing.Point(13, 59);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(244, 27);
            this.txtIdMarca.TabIndex = 2;
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
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmMarcaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "frmMarcaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Marca";
            this.Load += new System.EventHandler(this.frmMarcaCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellIdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellDescricaoMarca;
        private System.Windows.Forms.DataGridViewImageColumn CellAlterar;
        private System.Windows.Forms.DataGridViewImageColumn CellRemover;
    }
}
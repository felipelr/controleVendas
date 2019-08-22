namespace ControleVendas.Views.ContasPagar
{
    partial class frmDespesaFiltros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesaFiltros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checklistCategoria = new System.Windows.Forms.CheckedListBox();
            this.checklistFornecedor = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtPagoNao = new System.Windows.Forms.RadioButton();
            this.rbtPagoTodos = new System.Windows.Forms.RadioButton();
            this.rbtPagoSim = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // dtpDe
            // 
            this.dtpDe.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(88, 59);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(143, 27);
            this.dtpDe.TabIndex = 2;
            // 
            // dtpAte
            // 
            this.dtpAte.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(270, 59);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(143, 27);
            this.dtpAte.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "até";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(88, 96);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(400, 27);
            this.txtDescricao.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fornecedor:";
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
            this.button1.Location = new System.Drawing.Point(167, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Aplicar Filtros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checklistCategoria
            // 
            this.checklistCategoria.FormattingEnabled = true;
            this.checklistCategoria.Location = new System.Drawing.Point(88, 168);
            this.checklistCategoria.Name = "checklistCategoria";
            this.checklistCategoria.Size = new System.Drawing.Size(400, 130);
            this.checklistCategoria.TabIndex = 10;
            // 
            // checklistFornecedor
            // 
            this.checklistFornecedor.FormattingEnabled = true;
            this.checklistFornecedor.Location = new System.Drawing.Point(88, 308);
            this.checklistFornecedor.Name = "checklistFornecedor";
            this.checklistFornecedor.Size = new System.Drawing.Size(400, 130);
            this.checklistFornecedor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pago:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtPagoNao);
            this.panel2.Controls.Add(this.rbtPagoTodos);
            this.panel2.Controls.Add(this.rbtPagoSim);
            this.panel2.Location = new System.Drawing.Point(88, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 32);
            this.panel2.TabIndex = 8;
            // 
            // rbtPagoNao
            // 
            this.rbtPagoNao.AutoSize = true;
            this.rbtPagoNao.Location = new System.Drawing.Point(133, 8);
            this.rbtPagoNao.Name = "rbtPagoNao";
            this.rbtPagoNao.Size = new System.Drawing.Size(48, 19);
            this.rbtPagoNao.TabIndex = 2;
            this.rbtPagoNao.Text = "Não";
            this.rbtPagoNao.UseVisualStyleBackColor = true;
            // 
            // rbtPagoTodos
            // 
            this.rbtPagoTodos.AutoSize = true;
            this.rbtPagoTodos.Checked = true;
            this.rbtPagoTodos.Location = new System.Drawing.Point(3, 8);
            this.rbtPagoTodos.Name = "rbtPagoTodos";
            this.rbtPagoTodos.Size = new System.Drawing.Size(60, 19);
            this.rbtPagoTodos.TabIndex = 0;
            this.rbtPagoTodos.TabStop = true;
            this.rbtPagoTodos.Text = "Todos";
            this.rbtPagoTodos.UseVisualStyleBackColor = true;
            // 
            // rbtPagoSim
            // 
            this.rbtPagoSim.AutoSize = true;
            this.rbtPagoSim.Location = new System.Drawing.Point(74, 8);
            this.rbtPagoSim.Name = "rbtPagoSim";
            this.rbtPagoSim.Size = new System.Drawing.Size(47, 19);
            this.rbtPagoSim.TabIndex = 1;
            this.rbtPagoSim.Text = "Sim";
            this.rbtPagoSim.UseVisualStyleBackColor = true;
            // 
            // frmDespesaFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(512, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checklistFornecedor);
            this.Controls.Add(this.checklistCategoria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpAte);
            this.Controls.Add(this.dtpDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 527);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(528, 527);
            this.Name = "frmDespesaFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesa Filtros";
            this.Load += new System.EventHandler(this.frmDespesaFiltros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checklistCategoria;
        private System.Windows.Forms.CheckedListBox checklistFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtPagoNao;
        private System.Windows.Forms.RadioButton rbtPagoTodos;
        private System.Windows.Forms.RadioButton rbtPagoSim;
    }
}
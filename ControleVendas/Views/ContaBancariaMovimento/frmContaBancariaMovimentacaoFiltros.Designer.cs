namespace ControleVendas.Views.ContaBancariaMovimento
{
    partial class frmContaBancariaMovimentacaoFiltros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContaBancariaMovimentacaoFiltros));
            this.rbtTipoSaida = new System.Windows.Forms.RadioButton();
            this.rbtTipoEntrada = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtTipoTodos = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.checklistContas = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtTipoSaida
            // 
            this.rbtTipoSaida.AutoSize = true;
            this.rbtTipoSaida.Location = new System.Drawing.Point(154, 8);
            this.rbtTipoSaida.Name = "rbtTipoSaida";
            this.rbtTipoSaida.Size = new System.Drawing.Size(57, 19);
            this.rbtTipoSaida.TabIndex = 2;
            this.rbtTipoSaida.Text = "Saída";
            this.rbtTipoSaida.UseVisualStyleBackColor = true;
            // 
            // rbtTipoEntrada
            // 
            this.rbtTipoEntrada.AutoSize = true;
            this.rbtTipoEntrada.Location = new System.Drawing.Point(74, 8);
            this.rbtTipoEntrada.Name = "rbtTipoEntrada";
            this.rbtTipoEntrada.Size = new System.Drawing.Size(68, 19);
            this.rbtTipoEntrada.TabIndex = 1;
            this.rbtTipoEntrada.Text = "Entrada";
            this.rbtTipoEntrada.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtTipoSaida);
            this.panel2.Controls.Add(this.rbtTipoTodos);
            this.panel2.Controls.Add(this.rbtTipoEntrada);
            this.panel2.Location = new System.Drawing.Point(88, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 32);
            this.panel2.TabIndex = 22;
            // 
            // rbtTipoTodos
            // 
            this.rbtTipoTodos.AutoSize = true;
            this.rbtTipoTodos.Checked = true;
            this.rbtTipoTodos.Location = new System.Drawing.Point(3, 8);
            this.rbtTipoTodos.Name = "rbtTipoTodos";
            this.rbtTipoTodos.Size = new System.Drawing.Size(60, 19);
            this.rbtTipoTodos.TabIndex = 0;
            this.rbtTipoTodos.TabStop = true;
            this.rbtTipoTodos.Text = "Todos";
            this.rbtTipoTodos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tipo:";
            // 
            // checklistContas
            // 
            this.checklistContas.FormattingEnabled = true;
            this.checklistContas.Location = new System.Drawing.Point(88, 168);
            this.checklistContas.Name = "checklistContas";
            this.checklistContas.Size = new System.Drawing.Size(400, 130);
            this.checklistContas.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Conta:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(88, 96);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(400, 27);
            this.txtDescricao.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "até";
            // 
            // dtpAte
            // 
            this.dtpAte.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(270, 59);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(143, 27);
            this.dtpAte.TabIndex = 18;
            // 
            // dtpDe
            // 
            this.dtpDe.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(88, 59);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(143, 27);
            this.dtpDe.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 50);
            this.panel1.TabIndex = 14;
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
            this.button1.Location = new System.Drawing.Point(162, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Aplicar Filtros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmContaBancariaMovimentacaoFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(512, 349);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checklistContas);
            this.Controls.Add(this.button1);
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
            this.MaximumSize = new System.Drawing.Size(528, 388);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(528, 388);
            this.Name = "frmContaBancariaMovimentacaoFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros";
            this.Load += new System.EventHandler(this.frmContaBancariaMovimentacaoFiltros_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtTipoSaida;
        private System.Windows.Forms.RadioButton rbtTipoEntrada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtTipoTodos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checklistContas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
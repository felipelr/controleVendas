namespace ControleVendas.Views.Movimentacoes
{
    partial class frmVendaDetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendaDetalhes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.CellIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellQuantidadeMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellValorTotalMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQtdeItens = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1008, 43);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes da Venda";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens.ColumnHeadersHeight = 35;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CellIdProduto,
            this.CellDescricaoProduto,
            this.CellQuantidadeMovimentacao,
            this.CellValorUnitario,
            this.CellValorTotalMovimentacao});
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.Location = new System.Drawing.Point(12, 149);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowTemplate.Height = 30;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(984, 520);
            this.dgvItens.TabIndex = 4;
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
            this.CellQuantidadeMovimentacao.Width = 130;
            // 
            // CellValorUnitario
            // 
            dataGridViewCellStyle6.Format = "C2";
            this.CellValorUnitario.DefaultCellStyle = dataGridViewCellStyle6;
            this.CellValorUnitario.HeaderText = "Valor Unitário";
            this.CellValorUnitario.Name = "CellValorUnitario";
            this.CellValorUnitario.ReadOnly = true;
            this.CellValorUnitario.Width = 150;
            // 
            // CellValorTotalMovimentacao
            // 
            dataGridViewCellStyle7.Format = "C2";
            this.CellValorTotalMovimentacao.DefaultCellStyle = dataGridViewCellStyle7;
            this.CellValorTotalMovimentacao.HeaderText = "Valor Total";
            this.CellValorTotalMovimentacao.Name = "CellValorTotalMovimentacao";
            this.CellValorTotalMovimentacao.ReadOnly = true;
            this.CellValorTotalMovimentacao.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data da Venda:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataInicio.Location = new System.Drawing.Point(115, 13);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(73, 15);
            this.lblDataInicio.TabIndex = 20;
            this.lblDataInicio.Text = "01/01/0001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(226, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantidade de Itens:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(278, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Valor Total:";
            // 
            // lblQtdeItens
            // 
            this.lblQtdeItens.AutoSize = true;
            this.lblQtdeItens.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQtdeItens.Location = new System.Drawing.Point(358, 13);
            this.lblQtdeItens.Name = "lblQtdeItens";
            this.lblQtdeItens.Size = new System.Drawing.Size(45, 15);
            this.lblQtdeItens.TabIndex = 23;
            this.lblQtdeItens.Text = "100,00";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValorTotal.Location = new System.Drawing.Point(358, 46);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(63, 15);
            this.lblValorTotal.TabIndex = 24;
            this.lblValorTotal.Text = "R$ 100,00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblValorTotal);
            this.panel2.Controls.Add(this.lblQtdeItens);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblDataInicio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 86);
            this.panel2.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(60, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(115, 48);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 15);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Finalizada";
            // 
            // frmVendaDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "frmVendaDetalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes da Venda";
            this.Load += new System.EventHandler(this.frmVendaDetalhes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellDescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellQuantidadeMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellValorTotalMovimentacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQtdeItens;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
    }
}
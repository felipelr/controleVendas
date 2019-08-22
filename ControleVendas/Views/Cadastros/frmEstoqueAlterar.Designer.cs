namespace ControleVendas.Views.Cadastros
{
    partial class frmEstoqueAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoqueAlterar));
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTexto.Location = new System.Drawing.Point(34, 17);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(45, 17);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Texto:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(31, 41);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(295, 40);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(202, 87);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 39);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Confirmar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(72, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEstoqueAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(356, 142);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblTexto);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(358, 144);
            this.MinimumSize = new System.Drawing.Size(358, 144);
            this.Name = "frmEstoqueAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEstoqueAlterar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button button1;
    }
}
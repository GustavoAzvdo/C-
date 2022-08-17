namespace EX_4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSalarioFixo = new System.Windows.Forms.Label();
            this.labelNomeVendedor = new System.Windows.Forms.Label();
            this.labelSalarioFinal = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioFixo = new System.Windows.Forms.TextBox();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtVendas = new System.Windows.Forms.TextBox();
            this.labelQuantidadeVenda = new System.Windows.Forms.Label();
            this.txtSalarioFinal = new System.Windows.Forms.TextBox();
            this.btnDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(186, 97);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelSalarioFixo
            // 
            this.labelSalarioFixo.AutoSize = true;
            this.labelSalarioFixo.Location = new System.Drawing.Point(160, 135);
            this.labelSalarioFixo.Name = "labelSalarioFixo";
            this.labelSalarioFixo.Size = new System.Drawing.Size(64, 13);
            this.labelSalarioFixo.TabIndex = 0;
            this.labelSalarioFixo.Text = "Salario Fixo:";
            // 
            // labelNomeVendedor
            // 
            this.labelNomeVendedor.AutoSize = true;
            this.labelNomeVendedor.Location = new System.Drawing.Point(112, 238);
            this.labelNomeVendedor.Name = "labelNomeVendedor";
            this.labelNomeVendedor.Size = new System.Drawing.Size(119, 13);
            this.labelNomeVendedor.TabIndex = 0;
            this.labelNomeVendedor.Text = "O nome do vendedor é:";
            // 
            // labelSalarioFinal
            // 
            this.labelSalarioFinal.AutoSize = true;
            this.labelSalarioFinal.Location = new System.Drawing.Point(123, 277);
            this.labelSalarioFinal.Name = "labelSalarioFinal";
            this.labelSalarioFinal.Size = new System.Drawing.Size(108, 13);
            this.labelSalarioFinal.TabIndex = 0;
            this.labelSalarioFinal.Text = "Seu salario final é de:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(244, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtSalarioFixo
            // 
            this.txtSalarioFixo.Location = new System.Drawing.Point(244, 128);
            this.txtSalarioFixo.Name = "txtSalarioFixo";
            this.txtSalarioFixo.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioFixo.TabIndex = 1;
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(242, 231);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtNomeVendedor.TabIndex = 1;
            // 
            // txtVendas
            // 
            this.txtVendas.Location = new System.Drawing.Point(244, 172);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(100, 20);
            this.txtVendas.TabIndex = 2;
            // 
            // labelQuantidadeVenda
            // 
            this.labelQuantidadeVenda.AutoSize = true;
            this.labelQuantidadeVenda.Location = new System.Drawing.Point(77, 179);
            this.labelQuantidadeVenda.Name = "labelQuantidadeVenda";
            this.labelQuantidadeVenda.Size = new System.Drawing.Size(147, 13);
            this.labelQuantidadeVenda.TabIndex = 3;
            this.labelQuantidadeVenda.Text = "Quantidade em Vendas( R$ ):";
            // 
            // txtSalarioFinal
            // 
            this.txtSalarioFinal.Location = new System.Drawing.Point(242, 270);
            this.txtSalarioFinal.Name = "txtSalarioFinal";
            this.txtSalarioFinal.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioFinal.TabIndex = 4;
            // 
            // btnDados
            // 
            this.btnDados.Location = new System.Drawing.Point(244, 198);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(98, 27);
            this.btnDados.TabIndex = 5;
            this.btnDados.Text = "Gerar Dados";
            this.btnDados.UseVisualStyleBackColor = true;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.txtSalarioFinal);
            this.Controls.Add(this.labelQuantidadeVenda);
            this.Controls.Add(this.txtVendas);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.txtSalarioFixo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelSalarioFinal);
            this.Controls.Add(this.labelNomeVendedor);
            this.Controls.Add(this.labelSalarioFixo);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSalarioFixo;
        private System.Windows.Forms.Label labelNomeVendedor;
        private System.Windows.Forms.Label labelSalarioFinal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioFixo;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.TextBox txtVendas;
        private System.Windows.Forms.Label labelQuantidadeVenda;
        private System.Windows.Forms.TextBox txtSalarioFinal;
        private System.Windows.Forms.Button btnDados;
    }
}


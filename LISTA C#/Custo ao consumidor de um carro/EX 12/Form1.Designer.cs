namespace EX_12
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
            this.txtCarroNovo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.btnImposto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCarroNovo
            // 
            this.txtCarroNovo.Location = new System.Drawing.Point(136, 111);
            this.txtCarroNovo.Name = "txtCarroNovo";
            this.txtCarroNovo.Size = new System.Drawing.Size(114, 22);
            this.txtCarroNovo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custo de Fábrica de um carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Custo ao consumidor após impostos:";
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(136, 234);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(114, 22);
            this.txtCusto.TabIndex = 3;
            // 
            // btnImposto
            // 
            this.btnImposto.Location = new System.Drawing.Point(155, 155);
            this.btnImposto.Name = "btnImposto";
            this.btnImposto.Size = new System.Drawing.Size(75, 38);
            this.btnImposto.TabIndex = 4;
            this.btnImposto.Text = "Impostos";
            this.btnImposto.UseVisualStyleBackColor = true;
            this.btnImposto.Click += new System.EventHandler(this.btnImposto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 426);
            this.Controls.Add(this.btnImposto);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarroNovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarroNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Button btnImposto;
    }
}


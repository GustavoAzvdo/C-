namespace EX_15
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
            this.labelNum = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtComparacao = new System.Windows.Forms.TextBox();
            this.btnComparacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(23, 94);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(117, 16);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "Digite um número: ";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(161, 88);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(122, 22);
            this.txtN1.TabIndex = 1;
            // 
            // txtComparacao
            // 
            this.txtComparacao.Location = new System.Drawing.Point(38, 193);
            this.txtComparacao.Name = "txtComparacao";
            this.txtComparacao.Size = new System.Drawing.Size(207, 22);
            this.txtComparacao.TabIndex = 2;
            this.txtComparacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnComparacao
            // 
            this.btnComparacao.Location = new System.Drawing.Point(87, 157);
            this.btnComparacao.Name = "btnComparacao";
            this.btnComparacao.Size = new System.Drawing.Size(96, 30);
            this.btnComparacao.TabIndex = 3;
            this.btnComparacao.Text = "Comparação";
            this.btnComparacao.UseVisualStyleBackColor = true;
            this.btnComparacao.Click += new System.EventHandler(this.btnComparacao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 280);
            this.Controls.Add(this.btnComparacao);
            this.Controls.Add(this.txtComparacao);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.labelNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtComparacao;
        private System.Windows.Forms.Button btnComparacao;
    }
}


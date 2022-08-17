namespace EX_9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRendimento = new System.Windows.Forms.Button();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.txtRendimento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " O valor depositado ao banco é de:  R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "O rendimento mensal foi de: R$";
            // 
            // btnRendimento
            // 
            this.btnRendimento.Location = new System.Drawing.Point(297, 112);
            this.btnRendimento.Name = "btnRendimento";
            this.btnRendimento.Size = new System.Drawing.Size(100, 23);
            this.btnRendimento.TabIndex = 1;
            this.btnRendimento.Text = "Rendimento";
            this.btnRendimento.UseVisualStyleBackColor = true;
            this.btnRendimento.Click += new System.EventHandler(this.btnRendimento_Click);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(297, 70);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(100, 20);
            this.txtDeposito.TabIndex = 2;
            // 
            // txtRendimento
            // 
            this.txtRendimento.Location = new System.Drawing.Point(297, 157);
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.Size = new System.Drawing.Size(100, 20);
            this.txtRendimento.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRendimento);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.btnRendimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRendimento;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.TextBox txtRendimento;
    }
}


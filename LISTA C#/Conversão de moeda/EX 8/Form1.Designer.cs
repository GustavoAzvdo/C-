namespace EX_8
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
            this.labelConversao = new System.Windows.Forms.Label();
            this.labelDolar = new System.Windows.Forms.Label();
            this.labelReal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReais = new System.Windows.Forms.TextBox();
            this.txtConversao = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.btnConversao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConversao
            // 
            this.labelConversao.AutoSize = true;
            this.labelConversao.Location = new System.Drawing.Point(107, 104);
            this.labelConversao.Name = "labelConversao";
            this.labelConversao.Size = new System.Drawing.Size(135, 13);
            this.labelConversao.TabIndex = 0;
            this.labelConversao.Text = "O valor da conversão (U$):";
            // 
            // labelDolar
            // 
            this.labelDolar.AutoSize = true;
            this.labelDolar.Location = new System.Drawing.Point(134, 143);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(108, 13);
            this.labelDolar.TabIndex = 0;
            this.labelDolar.Text = "Quantidade de Dólar:";
            // 
            // labelReal
            // 
            this.labelReal.AutoSize = true;
            this.labelReal.Location = new System.Drawing.Point(40, 217);
            this.labelReal.Name = "labelReal";
            this.labelReal.Size = new System.Drawing.Size(178, 13);
            this.labelReal.TabIndex = 0;
            this.labelReal.Text = "Após a conversão, a pessoa possui:";
            this.labelReal.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "R$";
            // 
            // txtReais
            // 
            this.txtReais.Location = new System.Drawing.Point(248, 210);
            this.txtReais.Name = "txtReais";
            this.txtReais.Size = new System.Drawing.Size(132, 20);
            this.txtReais.TabIndex = 2;
            this.txtReais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConversao
            // 
            this.txtConversao.Location = new System.Drawing.Point(248, 97);
            this.txtConversao.Name = "txtConversao";
            this.txtConversao.Size = new System.Drawing.Size(132, 20);
            this.txtConversao.TabIndex = 3;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(248, 136);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(132, 20);
            this.txtDolar.TabIndex = 4;
            // 
            // btnConversao
            // 
            this.btnConversao.Location = new System.Drawing.Point(305, 172);
            this.btnConversao.Name = "btnConversao";
            this.btnConversao.Size = new System.Drawing.Size(75, 23);
            this.btnConversao.TabIndex = 5;
            this.btnConversao.Text = "Conversão";
            this.btnConversao.UseVisualStyleBackColor = true;
            this.btnConversao.Click += new System.EventHandler(this.btnConversao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConversao);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtConversao);
            this.Controls.Add(this.txtReais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelReal);
            this.Controls.Add(this.labelDolar);
            this.Controls.Add(this.labelConversao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConversao;
        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.Label labelReal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReais;
        private System.Windows.Forms.TextBox txtConversao;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Button btnConversao;
    }
}


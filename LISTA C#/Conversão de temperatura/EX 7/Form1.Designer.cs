namespace EX_7
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
            this.labelCelsius = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnConversao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Location = new System.Drawing.Point(160, 153);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(138, 13);
            this.labelCelsius.TabIndex = 0;
            this.labelCelsius.Text = "A temperatura em Celsius é:";
            this.labelCelsius.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Após a conversão, a temperatura em Fahrenheit é:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(304, 146);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(112, 20);
            this.txtCelsius.TabIndex = 3;
            this.txtCelsius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(304, 200);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(112, 20);
            this.txtFahrenheit.TabIndex = 4;
            // 
            // btnConversao
            // 
            this.btnConversao.Location = new System.Drawing.Point(426, 173);
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
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCelsius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnConversao;
    }
}


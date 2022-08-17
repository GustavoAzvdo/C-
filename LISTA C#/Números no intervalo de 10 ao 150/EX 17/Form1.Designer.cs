namespace EX_17
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnIntervalo = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(63, 57);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(117, 16);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "Digite um número: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Os numeros digitados\r\n entre 10 e 150 foram: ";
            // 
            // btnIntervalo
            // 
            this.btnIntervalo.Location = new System.Drawing.Point(200, 98);
            this.btnIntervalo.Name = "btnIntervalo";
            this.btnIntervalo.Size = new System.Drawing.Size(100, 23);
            this.btnIntervalo.TabIndex = 1;
            this.btnIntervalo.Text = "Intervalo";
            this.btnIntervalo.UseVisualStyleBackColor = true;
            this.btnIntervalo.Click += new System.EventHandler(this.btnIntervalo_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(200, 51);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 2;
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Location = new System.Drawing.Point(200, 145);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(100, 22);
            this.txtIntervalo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 226);
            this.Controls.Add(this.txtIntervalo);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnIntervalo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIntervalo;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtIntervalo;
    }
}


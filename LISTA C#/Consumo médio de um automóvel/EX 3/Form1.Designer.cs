namespace EX_3
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
            this.labelDistanciaPercorrida = new System.Windows.Forms.Label();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.labelConsumoMedio = new System.Windows.Forms.Label();
            this.labelKmPorLitro = new System.Windows.Forms.Label();
            this.btnConsumoMedio = new System.Windows.Forms.Button();
            this.txtDp = new System.Windows.Forms.TextBox();
            this.txtCg = new System.Windows.Forms.TextBox();
            this.txtCm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDistanciaPercorrida
            // 
            this.labelDistanciaPercorrida.AutoSize = true;
            this.labelDistanciaPercorrida.Location = new System.Drawing.Point(76, 105);
            this.labelDistanciaPercorrida.Name = "labelDistanciaPercorrida";
            this.labelDistanciaPercorrida.Size = new System.Drawing.Size(105, 13);
            this.labelDistanciaPercorrida.TabIndex = 0;
            this.labelDistanciaPercorrida.Text = "Distância Percorrida:";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.Location = new System.Drawing.Point(86, 145);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(98, 13);
            this.labelCombustivel.TabIndex = 0;
            this.labelCombustivel.Text = "Combustivel Gasto:";
            // 
            // labelConsumoMedio
            // 
            this.labelConsumoMedio.AutoSize = true;
            this.labelConsumoMedio.Location = new System.Drawing.Point(95, 235);
            this.labelConsumoMedio.Name = "labelConsumoMedio";
            this.labelConsumoMedio.Size = new System.Drawing.Size(86, 13);
            this.labelConsumoMedio.TabIndex = 0;
            this.labelConsumoMedio.Text = "Consumo Medio:";
            // 
            // labelKmPorLitro
            // 
            this.labelKmPorLitro.AutoSize = true;
            this.labelKmPorLitro.Location = new System.Drawing.Point(293, 235);
            this.labelKmPorLitro.Name = "labelKmPorLitro";
            this.labelKmPorLitro.Size = new System.Drawing.Size(67, 13);
            this.labelKmPorLitro.TabIndex = 0;
            this.labelKmPorLitro.Text = "litros por Km.";
            // 
            // btnConsumoMedio
            // 
            this.btnConsumoMedio.Location = new System.Drawing.Point(187, 180);
            this.btnConsumoMedio.Name = "btnConsumoMedio";
            this.btnConsumoMedio.Size = new System.Drawing.Size(100, 23);
            this.btnConsumoMedio.TabIndex = 1;
            this.btnConsumoMedio.Text = "Calcular";
            this.btnConsumoMedio.UseVisualStyleBackColor = true;
            this.btnConsumoMedio.Click += new System.EventHandler(this.btnConsumoMedio_Click);
            // 
            // txtDp
            // 
            this.txtDp.Location = new System.Drawing.Point(187, 98);
            this.txtDp.Name = "txtDp";
            this.txtDp.Size = new System.Drawing.Size(100, 20);
            this.txtDp.TabIndex = 2;
            // 
            // txtCg
            // 
            this.txtCg.Location = new System.Drawing.Point(187, 138);
            this.txtCg.Name = "txtCg";
            this.txtCg.Size = new System.Drawing.Size(100, 20);
            this.txtCg.TabIndex = 2;
            // 
            // txtCm
            // 
            this.txtCm.Location = new System.Drawing.Point(187, 228);
            this.txtCm.Name = "txtCm";
            this.txtCm.Size = new System.Drawing.Size(100, 20);
            this.txtCm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCm);
            this.Controls.Add(this.txtCg);
            this.Controls.Add(this.txtDp);
            this.Controls.Add(this.btnConsumoMedio);
            this.Controls.Add(this.labelKmPorLitro);
            this.Controls.Add(this.labelConsumoMedio);
            this.Controls.Add(this.labelCombustivel);
            this.Controls.Add(this.labelDistanciaPercorrida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistanciaPercorrida;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.Label labelConsumoMedio;
        private System.Windows.Forms.Label labelKmPorLitro;
        private System.Windows.Forms.Button btnConsumoMedio;
        private System.Windows.Forms.TextBox txtDp;
        private System.Windows.Forms.TextBox txtCg;
        private System.Windows.Forms.TextBox txtCm;
    }
}


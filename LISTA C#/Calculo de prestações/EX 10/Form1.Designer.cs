namespace EX_10
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
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.btnParcelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Após dividir a compra em 5x,\r\ncada parcela sera no valor de:\r\n";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(179, 103);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCompra.TabIndex = 1;
            // 
            // txtParcela
            // 
            this.txtParcela.Location = new System.Drawing.Point(179, 193);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(100, 20);
            this.txtParcela.TabIndex = 1;
            // 
            // btnParcelar
            // 
            this.btnParcelar.Location = new System.Drawing.Point(179, 144);
            this.btnParcelar.Name = "btnParcelar";
            this.btnParcelar.Size = new System.Drawing.Size(100, 23);
            this.btnParcelar.TabIndex = 2;
            this.btnParcelar.Text = "Parcelar";
            this.btnParcelar.UseVisualStyleBackColor = true;
            this.btnParcelar.Click += new System.EventHandler(this.btnParcelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 398);
            this.Controls.Add(this.btnParcelar);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.txtCompra);
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
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Button btnParcelar;
    }
}


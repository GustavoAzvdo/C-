namespace EX_6
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelTrocaA = new System.Windows.Forms.Label();
            this.labelTrocaB = new System.Windows.Forms.Label();
            this.labeTextin = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtTrocaA = new System.Windows.Forms.TextBox();
            this.txtTrocaB = new System.Windows.Forms.TextBox();
            this.btnTroca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(92, 123);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(97, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Digite o valor de A:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(92, 167);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(97, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "Digite o valor de B:";
            // 
            // labelTrocaA
            // 
            this.labelTrocaA.AutoSize = true;
            this.labelTrocaA.Location = new System.Drawing.Point(111, 263);
            this.labelTrocaA.Name = "labelTrocaA";
            this.labelTrocaA.Size = new System.Drawing.Size(78, 13);
            this.labelTrocaA.TabIndex = 2;
            this.labelTrocaA.Text = "O valor de A é:";
            // 
            // labelTrocaB
            // 
            this.labelTrocaB.AutoSize = true;
            this.labelTrocaB.Location = new System.Drawing.Point(103, 312);
            this.labelTrocaB.Name = "labelTrocaB";
            this.labelTrocaB.Size = new System.Drawing.Size(86, 13);
            this.labelTrocaB.TabIndex = 3;
            this.labelTrocaB.Text = "E o valor de B é:";
            // 
            // labeTextin
            // 
            this.labeTextin.AutoSize = true;
            this.labeTextin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeTextin.Location = new System.Drawing.Point(85, 211);
            this.labeTextin.Name = "labeTextin";
            this.labeTextin.Size = new System.Drawing.Size(104, 18);
            this.labeTextin.TabIndex = 4;
            this.labeTextin.Text = "Após a troca...";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(195, 116);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(196, 160);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 5;
            // 
            // txtTrocaA
            // 
            this.txtTrocaA.Location = new System.Drawing.Point(195, 256);
            this.txtTrocaA.Name = "txtTrocaA";
            this.txtTrocaA.Size = new System.Drawing.Size(100, 20);
            this.txtTrocaA.TabIndex = 5;
            // 
            // txtTrocaB
            // 
            this.txtTrocaB.Location = new System.Drawing.Point(195, 305);
            this.txtTrocaB.Name = "txtTrocaB";
            this.txtTrocaB.Size = new System.Drawing.Size(100, 20);
            this.txtTrocaB.TabIndex = 5;
            // 
            // btnTroca
            // 
            this.btnTroca.Location = new System.Drawing.Point(206, 207);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(75, 29);
            this.btnTroca.TabIndex = 6;
            this.btnTroca.Text = "Troca";
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.btnTroca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroca);
            this.Controls.Add(this.txtTrocaB);
            this.Controls.Add(this.txtTrocaA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.labeTextin);
            this.Controls.Add(this.labelTrocaB);
            this.Controls.Add(this.labelTrocaA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelTrocaA;
        private System.Windows.Forms.Label labelTrocaB;
        private System.Windows.Forms.Label labeTextin;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtTrocaA;
        private System.Windows.Forms.TextBox txtTrocaB;
        private System.Windows.Forms.Button btnTroca;
    }
}


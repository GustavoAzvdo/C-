namespace EX_18
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelMP = new System.Windows.Forms.Label();
            this.btnMP = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.txtNomeDnv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(6, 6);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(76, 110);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(78, 145);
            this.labelIdade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(37, 13);
            this.labelIdade.TabIndex = 1;
            this.labelIdade.Text = "Idade:";
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.Location = new System.Drawing.Point(35, 243);
            this.labelMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(79, 13);
            this.labelMP.TabIndex = 1;
            this.labelMP.Text = "Essa pessoa é:";
            // 
            // btnMP
            // 
            this.btnMP.Location = new System.Drawing.Point(124, 166);
            this.btnMP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMP.Name = "btnMP";
            this.btnMP.Size = new System.Drawing.Size(116, 26);
            this.btnMP.TabIndex = 2;
            this.btnMP.Text = "Maior ou Menor";
            this.btnMP.UseVisualStyleBackColor = true;
            this.btnMP.Click += new System.EventHandler(this.btnMP_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(124, 106);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(117, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(124, 141);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(117, 20);
            this.txtIdade.TabIndex = 3;
            this.txtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(124, 240);
            this.txtMP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(117, 20);
            this.txtMP.TabIndex = 3;
            // 
            // txtNomeDnv
            // 
            this.txtNomeDnv.Location = new System.Drawing.Point(124, 211);
            this.txtNomeDnv.Name = "txtNomeDnv";
            this.txtNomeDnv.Size = new System.Drawing.Size(117, 20);
            this.txtNomeDnv.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seu Nome é: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeDnv);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnMP);
            this.Controls.Add(this.labelMP);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.Button btnMP;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtNomeDnv;
        private System.Windows.Forms.Label label1;
    }
}


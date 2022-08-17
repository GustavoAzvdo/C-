using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            string nome;
            double salario, salariofinal, vendas, comissao;

            nome = txtNome.Text;
            txtNomeVendedor.Text= nome;

            salario = double.Parse(txtSalarioFixo.Text);
            vendas = double.Parse(txtVendas.Text);
            comissao = vendas * 0.15;
            salariofinal = salario + comissao;
            txtSalarioFinal.Text = salariofinal.ToString();
        }
    }
}

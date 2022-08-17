using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ano, valor, total2000, total;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            ano = double.Parse(txtAno.Text);
            valor = double .Parse(txtValor.Text);

            if (ano >= 2000)
            {
                valor = valor - (valor * 12) / 100;
                total = total + 1;
                total2000 = total2000 + 1;
                txtDesconto.Text = valor.ToString();
            }
            if (ano < 2000)
            {
                valor = valor - (valor * 7) / 100;
                total = total + 1;
                txtDesconto.Text = valor.ToString();
            }
                txtAno2000.Text = total2000.ToString();
                txtCarros.Text = total.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double impostos, carroNovo, distribuidora, custo;
        private void btnImposto_Click(object sender, EventArgs e)
        {
            carroNovo = double.Parse(txtCarroNovo.Text);

            impostos = (carroNovo * 45) / 100;
            carroNovo += impostos;
            distribuidora = (carroNovo * 28) / 100;
            custo = distribuidora + carroNovo;

            txtCusto.Text = custo.ToString();
        }
    }
}

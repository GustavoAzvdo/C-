using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtNum.Text);

            if (num <= 10)
            {
                txtSituacao.Text = "Nº MENOR que 10";
            }
            else
            {
                txtSituacao.Text = "Nº MAIOR que 10";
            }

        }
    }
}

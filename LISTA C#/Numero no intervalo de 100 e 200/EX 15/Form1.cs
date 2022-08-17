using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1;
        private void btnComparacao_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            if (n1 >= 100 && n1 <= 200)
            {
                txtComparacao.Text = "O Nº esta entre 100 e 200.";
            }
            else
            {
                txtComparacao.Text = "O Nº esta fora do intervalo.";
            }
        }
    }
}

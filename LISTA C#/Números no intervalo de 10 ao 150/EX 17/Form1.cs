using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num, inter;
        private void btnIntervalo_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtNum.Text);

            if (num >=10 && num <= 150)
            {
                inter += 1;
                txtIntervalo.Text = inter.ToString();
            }
            else
            {
               txtNum.Text = "";
                MessageBox.Show("NUMERO FORA DO INTERVALO");
            }
            
        }
    }
}

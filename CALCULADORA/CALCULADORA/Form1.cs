using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class CALCULADORA : Form
    {
        public CALCULADORA()
        {
            InitializeComponent();
        }
        float n1;
        float n2;
        string opcao;
        float rst;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (rst == 1)
            {
                rst = 0;
                txtVisor.Text = "";
            }

            

            txtVisor.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (rst == 1)
            {
                rst = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (rst == 1)
            {
                rst = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (rst == 1)
            {
                rst = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (rst == 1)
            {
                rst = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (rst == 1)
            {
                rst = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (rst == 1)
            {
                rst = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (rst == 1)
            {
                rst = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (rst == 1)
            {
                rst = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (rst == 1)
            {
                rst = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text += "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            n1 = 0;
            n2 = 0;

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                if (n1!=0)
                opcao = "soma";
                n2 = float.Parse(txtVisor.Text);
                n1 = n1 + n2;
                txtVisor.Text = "";
                txtVisor.Text = n1.ToString();
                rst = 1;

            }
           else
            {
                opcao = "soma";
                n1 = float.Parse(txtVisor.Text);
                txtVisor.Text = "";            

            }           
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                if (n1 != 0) 
                opcao = "subtracao";
                n2 = float.Parse(txtVisor.Text);
                n1 = n1 - n2;
                txtVisor.Text = "";
                txtVisor.Text = n1.ToString();
                rst = 1;

            }
            else
            {
                opcao = "subtracao";
                n1 = float.Parse(txtVisor.Text);
                txtVisor.Text = "";

            }
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {

            if (txtVisor.Text != "")
            {
                if (n1 != 0)
                opcao = "divisao";
                n2 = float.Parse(txtVisor.Text);
                n1 = n1 / n2;
                txtVisor.Text = "";
                txtVisor.Text = n1.ToString();
                rst = 1;

            }
            else
            {
                opcao = "divisao";
                n1 = float.Parse(txtVisor.Text);
                txtVisor.Text = "";
            }
        }
        private void btnMultipliccao_Click(object sender, EventArgs e)
        {

            if (txtVisor.Text != "")
            {
                if (n1 != 0) 
                opcao = "multiplicacao";
                n2 = float.Parse(txtVisor.Text);
                n1 = n1 * n2;
                txtVisor.Text = "";
                txtVisor.Text = n1.ToString();
                rst = 1;

            }
            else
            {
                opcao = "multiplicacao";
                n1 = float.Parse(txtVisor.Text);
                txtVisor.Text = "";

            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {


           n2 = float.Parse(txtVisor.Text);

            
            if (opcao == "soma")
            {                          
                n1 = n1 + n2;
                txtVisor.Text= n1.ToString();

            }
            if (opcao == "subtracao")
            {
                n1 = n1 - n2;
                txtVisor.Text = n1.ToString();

            }
            if (opcao == "divisao")
            {
                n1 = n1 / n2;
                txtVisor.Text = n1.ToString();

            }
            if (opcao == "multiplicacao")
            {
                n1 = n1 * n2;
                txtVisor.Text = n1.ToString();
            }





        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + ",";
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "-";
        }
    }
}


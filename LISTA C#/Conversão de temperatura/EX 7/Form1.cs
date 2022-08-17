using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double c, f;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConversao_Click(object sender, EventArgs e)
        {
            c = double.Parse(txtCelsius.Text);

            f = (9 * c + 160) / 5;

            txtFahrenheit.Text = f.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

       
        }
    }
}

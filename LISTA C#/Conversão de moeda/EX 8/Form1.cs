using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double us, rs, conv;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConversao_Click(object sender, EventArgs e)
        {
            conv = double.Parse(txtConversao.Text);
            us = double.Parse(txtDolar.Text);

            rs = conv * us;

            txtReais.Text = rs.ToString();
            
        }
    }
}

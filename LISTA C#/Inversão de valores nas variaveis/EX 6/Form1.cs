using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            int a, b, troca;

            a = int.Parse(txtA.Text); 
            b = int.Parse(txtB.Text);

            troca = a;
            a = b;
            b = troca;

            txtTrocaA.Text = a.ToString();
            txtTrocaB.Text = b.ToString();
        }
    }
}

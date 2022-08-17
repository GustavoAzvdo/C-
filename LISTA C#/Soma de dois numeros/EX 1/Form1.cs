using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1, n2, somar;
        private void btnSomar_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);

            somar = n1 + n2;

            txtSomar.Text = somar.ToString();
        }
    }
}

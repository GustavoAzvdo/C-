using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsumoMedio_Click(object sender, EventArgs e)
        {
            double dp, cg, cm;

            dp = double.Parse(txtDp.Text);
            cg = double.Parse(txtCg.Text);

            cm = dp / cg;

            txtCm.Text = cm.ToString();
        }
    }
}

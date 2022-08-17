using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double valorC, valorP;
        private void btnParcelar_Click(object sender, EventArgs e)
        {
            valorC = double.Parse(txtCompra.Text);

            valorP = valorC / 5;

            txtParcela.Text = valorP.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double custo, porcentagem, venda;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            custo = double.Parse(txtCusto.Text);
            porcentagem = double.Parse(txtPorc.Text);

            porcentagem = (custo * porcentagem) / 100;
            venda = custo + porcentagem;

            txtVenda.Text = venda.ToString();
        }
    }
}

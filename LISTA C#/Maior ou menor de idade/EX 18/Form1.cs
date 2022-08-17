using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nome;
        float idade;
        private void btnMP_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            idade = float.Parse(txtIdade.Text);
            txtNomeDnv.Text = nome;

            if (idade >= 18)
            {
                txtMP.Text = "MAIOR DE IDADE.";
            }
            else
            {
                txtMP.Text = "MENOR DE IDADE.";
            }
        }
    }
}

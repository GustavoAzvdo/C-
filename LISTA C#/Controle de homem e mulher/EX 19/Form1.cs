using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nome, m, f, sexo;
        float sexoM, sexoF;
        private void btnDados_Click(object sender, EventArgs e)
        {
          
            nome = txtNome.Text;
                       
            if (txtSexo.Text == "m")
            {
                sexoM = sexoM + 1;
            }
            if (txtSexo.Text == "f")
            {
                sexoF = sexoF + 1;
            }
            txtM.Text = sexoM.ToString();
            txtF.Text = sexoF.ToString();
        }
       
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

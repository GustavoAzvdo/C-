using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORTEADOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string j1, j2, j3, j4;
        float placar1, placar2, placar3, placar4, placarF1, placarF2, placarT1, placarT2;

        private void button1_Click(object sender, EventArgs e)
        {
            txtJ1.Text = "";
            txtJ2.Text = "";
            txtJ3.Text = "";
            txtJ4.Text = "";
            txtPlacar1.Text = "";
            txtPlacar2.Text = "";
            txtPlacar3.Text = "";
            txtPlacar4.Text = "";
            txtPlacarF1.Text = "";
            txtPlacarF2.Text = "";
            txtPlacarT1.Text = "";
            txtPlacarT2.Text = "";
            txtFinalista1.Text = "";
            txtFinalista2.Text = "";
            txtTerceiro1.Text = "";
            txtTerceiro2.Text = "";
            txtCampeao.Text = "";
            txtSegundo.Text = "";
            txtTerceiro.Text = "";
        }

        private void btnTerceiroLugar_Click(object sender, EventArgs e)
        {
            placarT1 = float.Parse(txtPlacarT1.Text);
            placarT2 = float.Parse(txtPlacarT2.Text);

            if (placarT1 > placarT2)
            {
                txtTerceiro.Text = txtTerceiro1.Text;
            }
            else
            {
                txtTerceiro.Text = txtTerceiro2.Text;
            }
        }
        
        private void btnCampeao_Click(object sender, EventArgs e)
        {
            placarF1 = float.Parse(txtPlacarF1.Text);
            placarF2 = float.Parse(txtPlacarF2.Text);

            if (placarF1 > placarF2)
            {
                txtCampeao.Text = txtFinalista1.Text;
                txtSegundo.Text = txtFinalista2.Text;
                MessageBox.Show("O CAMPEÃO É " + txtFinalista1.Text + " !");
            }
            else
            {
                txtCampeao.Text = txtFinalista2.Text;
                txtSegundo.Text = txtFinalista1.Text;
                MessageBox.Show("O CAMPEÃO É " + txtFinalista2.Text + " !");
            }
        }
        
        private void btnDados_Click(object sender, EventArgs e)
        {
            j1 = txtJ1.Text;
            j2 = txtJ2.Text;
            j3 = txtJ3.Text;
            j4 = txtJ4.Text;

            placar1 = float.Parse(txtPlacar1.Text);
            placar2 = float.Parse(txtPlacar2.Text);
            placar3 = float.Parse(txtPlacar3.Text);
            placar4 = float.Parse(txtPlacar4.Text);

            if (placar1 > placar2)
            {
                txtFinalista1.Text = txtJ1.Text;
                txtTerceiro1.Text = txtJ2.Text;
            }
            else
            {
                txtFinalista1.Text = txtJ2.Text;
                txtTerceiro1.Text = txtJ1.Text;
            }

                    if (placar3 > placar4)
                    {
                     txtFinalista2.Text = txtJ3.Text;
                txtTerceiro2.Text = txtJ4.Text;    
                    }
                    else 
                    {
                      txtFinalista2.Text =txtJ4.Text;
                txtTerceiro2.Text=txtJ3.Text;
                    }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void lblIMC_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;

            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);

            imc = Math.Round(peso / Math.Pow(altura, 2),2);

            lblResultado_IMC.Text = imc.ToString();

            if (imc < 19)
            {
                lblSituacao.Text = "Abaixo do Peso";
            }

            else if (imc <= 25)
            {
                lblSituacao.Text = "Peso Normal";
            }

            else if (imc <= 30)
            {
                lblSituacao.Text = "Sobre Peso";
            }

            else if (imc <= 40)
            {
                lblSituacao.Text = "Obeso";
            }

            else
            {
                lblSituacao.Text = "Obeso Mórbido";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
            lblResultado_IMC.Text = "";
            lblSituacao.Text = "";
            txtPeso.Focus();
        }
    }
}

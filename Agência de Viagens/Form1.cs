using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Agência_de_Viagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            comboBoxDestino.Text = "";
            radioBtnAviao.Checked = false;
            radioBtnOnibus.Checked = false;
            lblGastoDestino.Text = "";
            lblGastoTransporte.Text = "";
            txtValorTotal.Text = "";
            txtNome.Focus();
            groupBoxResultado.Visible = false;
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start(@"c:\windows\system32\calc.exe"); 
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(690, 529);
        }

        private void btnCalculadorViagem_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Não se esqueça de digitar o nome do passageiro...");
                txtNome.Focus();
            }

            if (comboBoxDestino.Text == "")
            {
                MessageBox.Show("Destino não escolhido");
                comboBoxDestino.Focus();
            }

            if (radioBtnAviao.Checked == false && radioBtnOnibus.Checked == false)
            {
                MessageBox.Show("Meio de transporte não escolhido");
                radioBtnAviao.Focus();
            }

            float gasto_destino, gasto_transporte, gasto_total;

            switch (comboBoxDestino.Text.ToUpper())
            {
                case "SP": gasto_destino = 1000;
                    break;
                case "RJ":
                    gasto_destino = 1500;
                    break;
                case "SC":
                    gasto_destino = 2000;
                    break;
                default:
                    gasto_destino = 0;
                    break;
            }
            if (radioBtnAviao.Checked == true)
            {
                gasto_transporte = 100;
            }

            else
            {
                gasto_transporte = 30;
            }

            gasto_total = gasto_destino + gasto_transporte;
            this.ClientSize = new System.Drawing.Size(690, 529);
            groupBoxResultado.Visible = true;
            lblGastoDestino.Text = gasto_destino.ToString("C2");
            lblGastoTransporte.Text = gasto_transporte.ToString("C2");
            txtValorTotal.Text = gasto_total.ToString("C2");

        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.Text = txtNome.Text.ToUpper();
        }
    }
}

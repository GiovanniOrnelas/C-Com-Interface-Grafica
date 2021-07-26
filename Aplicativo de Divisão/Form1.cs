using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_de_Divisão
{
    public partial class FrmExcecao : Form
    {
        public FrmExcecao()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtResultado.Text = "";
            txtValor1.Focus();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor1, valor2, resultado;

                valor1 = Convert.ToDecimal(txtValor1.Text);
                valor2 = Convert.ToDecimal(txtValor2.Text);

                resultado = valor1 / valor2;

                txtResultado.Text = Math.Round(resultado,2).ToString();
            }

            catch (DivideByZeroException)
            {
                MessageBox.Show("Não existe divisão por 0, tente novamente!!!");
            }

            catch (OverflowException)
            {
                MessageBox.Show("Erro de estouro, a calculadora não suporta os valores!!!");
            }

            catch (FormatException)
            {
                MessageBox.Show("Formato inválido de dados!!!");
            }

            finally
            {
                MessageBox.Show("Isto acontece sempre, dando erro ou não!!!");
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

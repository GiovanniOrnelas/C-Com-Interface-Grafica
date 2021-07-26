using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Média_De_4_Notas
{
    public partial class FrmCalculaMedia : Form
    {
        public FrmCalculaMedia()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, media;

            nota1 = Convert.ToDouble(txtN1.Text);
            nota2 = Convert.ToDouble(txtN2.Text);
            nota3 = Convert.ToDouble(txtN3.Text);
            nota4 = Convert.ToDouble(txtN4.Text);

            media = Math.Round((nota1 + nota2 + nota3 + nota4) / 4,2);

            lblResultadoMedia.Text = media.ToString();

            if (media < 7)
            {
                lblSituacao.Text = "REPROVADO!";
            }

            else
            {
                lblSituacao.Text = "APROVADO!";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultadoMedia.Text = "";
            lblSituacao.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";
            txtN1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string texto = "Deseja sair do programa?";
            string titulo = "**** FINALIZANDO ****";

            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

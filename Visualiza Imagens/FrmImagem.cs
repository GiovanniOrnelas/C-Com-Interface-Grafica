using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualiza_Imagens
{
    public partial class FrmImagem : Form
    {
        public FrmImagem()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string texto = "Deseja sair do programa?";
            string cabec = "*** Finalizando o aplicativo ***";
            bool resposta = (MessageBox.Show(texto, cabec, MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==  DialogResult.Yes);

            if (resposta == true)
            {
                this.Close();
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                dlgAbrir.ShowDialog();
                if (dlgAbrir.FileName != "")
                {
                    picImagem.Load(dlgAbrir.FileName);
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message + "\nO arquivo solicitado não é um arquivo de imagem", "**** ERRO DE ARQUIVO ****", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

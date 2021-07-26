using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criação_de_Menus
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Item de Menu do Cálculo da Média
        private void calculoDaMediatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Média_De_4_Notas.FrmCalculaMedia item1 = new Média_De_4_Notas.FrmCalculaMedia();
            item1.MdiParent = this;
            item1.Show();
        }

        #endregion

        #region Item de Menu da Lista de Nomes
        private void listaDeNomestoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_de_Nomes.FrmListadeNomes item2 = new Lista_de_Nomes.FrmListadeNomes();
            item2.MdiParent = this;
            item2.Show();
        }
        #endregion

        #region Item de Movimentar Imagem
        private void movimentarImagemtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviTeclas.FrmMovimentaTeclas item3 = new MoviTeclas.FrmMovimentaTeclas();
            item3.MdiParent = this;
            item3.Show();
        }

        #endregion

        #region Item Relógio
        private void relogiotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relógio.FrmRelogio item4 = new Relógio.FrmRelogio();
            item4.MdiParent = this;
            item4.Show();
        }
        #endregion

        #region Item de Visualizar Imagem
        private void visualizarImagemtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualiza_Imagens.FrmImagem item5 = new Visualiza_Imagens.FrmImagem();
            item5.MdiParent = this;
            item5.Show();
        }
        #endregion

        private void sairDoProgramatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

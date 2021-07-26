using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListadeNomes
{
    public partial class FrmListadeNomes : Form
    {
        public FrmListadeNomes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor = lstNome.SelectedIndex;
            if (valor == -1)
            {
                MessageBox.Show("Para excluir um item da lista é preciso primeiro selecioná-lo");
                btnRemove.Enabled = false;
                txtNome.Focus();
            }

            else
            {
                lstNome.Items.RemoveAt(valor);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (txtNome.Text != "")
            {
                lstNome.Items.Add(nome.ToUpper());
                txtNome.Clear();
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("***Precisa digitar algo no campo***");
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNome.Items.Count == 0)
            {
                MessageBox.Show("A lista está vazia!!\nAdicione primeiro um item e depois remova-o");
                txtNome.Focus();
            }

            else
            {
                btnRemover.Enabled = false;
                lstNome.Items.Clear();
                txtNome.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {                   
                btnRemover.Enabled = true;                     
        }

        private void FrmListadeNomes_Load(object sender, EventArgs e)
        {
            btnRemover.Enabled = false;
        }

        private void lstNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemover.Enabled = true;
        }
    }
}

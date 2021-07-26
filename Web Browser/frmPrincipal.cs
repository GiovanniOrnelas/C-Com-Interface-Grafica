﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            novaAbaToolStripMenuItem_Click(null, null);
        }

        private void tbcAbas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string paginaInicial = "https://bing.com.br";

        private void novaAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ADICIONA TABPAGE NO TABCONTROL (NOVA ABA)
            tbcAbas.TabPages.Add("nova", paginaInicial);
            txtEndereco.Text = paginaInicial;
            //CRIA UM WEBBROWNSER
            WebBrowser webBrowser = new WebBrowser();
            //DEFINE PREECHIMENTO TOTAL
            webBrowser.Dock = DockStyle.Fill;
            Uri uri = new Uri(paginaInicial);
            webBrowser.Url = uri;
            //ADICIONA O COMPONENTE WEBBROWSER DENTRO DA ABA CRIADA
            tbcAbas.TabPages[tbcAbas.TabCount - 1].Controls.Add(webBrowser);
            tbcAbas.SelectedIndex = tbcAbas.TabCount - 1;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            foreach (Control control in tbcAbas.SelectedTab.Controls)
            {
                (control as WebBrowser).GoBack();
                txtEndereco.Text = (control as WebBrowser).Url.AbsoluteUri;
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {           
                foreach (Control control in tbcAbas.SelectedTab.Controls)
                    (control as WebBrowser).GoForward();           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {          
                foreach (Control control in tbcAbas.SelectedTab.Controls)
                    (control as WebBrowser).Refresh();           
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            foreach (Control control in tbcAbas.SelectedTab.Controls)
                (control as WebBrowser).Stop();
        }

        private void btnInicial_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(paginaInicial);
            txtEndereco.Text = paginaInicial;
            foreach (Control control in tbcAbas.SelectedTab.Controls)
                (control as WebBrowser).Url = uri;
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Uri uri = (txtEndereco.Text.ToLower().StartsWith("http://")) ?
                new Uri(txtEndereco.Text.ToLower()) :
                new Uri("http://" + txtEndereco.Text.ToLower());
                foreach (Control control in tbcAbas.SelectedTab.Controls)
                    (control as WebBrowser).Url = uri;
            }
        }

        private void páginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FrmPaginaInicial form = new FrmPaginaInicial  ();
            form.txtPaginaInicial.Text = paginaInicial;
            if (form.ShowDialog() == DialogResult.OK)
                paginaInicial = form.txtPaginaInicial.Text;
        }
    }
}

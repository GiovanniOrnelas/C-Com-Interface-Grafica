using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saudação
{
    public partial class Form_Saudacao : Form
    {
        public Form_Saudacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_exibe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boa tarde, " + txtNome.Text , "Minhas saudações", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }
    }
}

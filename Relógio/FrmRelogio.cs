using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relógio
{
    public partial class FrmRelogio : Form
    {
        public FrmRelogio()
        {
            InitializeComponent();
        }

        private void FrmRelogio_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void lblRelogio_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

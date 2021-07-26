﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviTeclas
{
    public partial class FrmMovimentaTeclas : Form
    {
        public FrmMovimentaTeclas()
        {
            InitializeComponent();
        }

        private void FrmMovimentaTeclas_KeyDown(object sender, KeyEventArgs e)
        {
            #region Mover para a esquerda
            if (e.KeyCode == Keys.Left)
            {
                if (imgLogo.Location.X > -99)
                {
                    imgLogo.Left -= 10;
                }
                else
                {
                    imgLogo.Left = 615;
                }
            }
            #endregion

            #region Mover para cima
            if (e.KeyCode == Keys.Up)
            {
                if (imgLogo.Location.Y > -94)
                {
                    imgLogo.Top -= 10;
                }
                else
                {
                    imgLogo.Top = 514;
                }
            }
            #endregion

            #region Mover para a direita
            if (e.KeyCode == Keys.Right)
            {
                if (imgLogo.Location.X < 615)
                {
                    imgLogo.Left += 10;
                }
                else
                {
                    imgLogo.Left = -99;
                }
            }
            #endregion

            #region Mover para baixo
            if (e.KeyCode == Keys.Down)
            {
                if (imgLogo.Location.Y < 514)
                {
                    imgLogo.Top += 10;
                }
                else
                {
                    imgLogo.Top = -94;
                }
            }
            #endregion
        }
    }
}

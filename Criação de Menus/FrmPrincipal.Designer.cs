
namespace Criação_de_Menus
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDaMediatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeNomestoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentarImagemtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relogiotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImagemtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairDoProgramatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDaMediatoolStripMenuItem,
            this.listaDeNomestoolStripMenuItem,
            this.movimentarImagemtoolStripMenuItem,
            this.relogiotoolStripMenuItem,
            this.visualizarImagemtoolStripMenuItem,
            this.toolStripSeparator1,
            this.sairDoProgramatoolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // calculoDaMediatoolStripMenuItem
            // 
            this.calculoDaMediatoolStripMenuItem.Name = "calculoDaMediatoolStripMenuItem";
            this.calculoDaMediatoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculoDaMediatoolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.calculoDaMediatoolStripMenuItem.Text = "Calculo da Média";
            this.calculoDaMediatoolStripMenuItem.Click += new System.EventHandler(this.calculoDaMediatoolStripMenuItem_Click);
            // 
            // listaDeNomestoolStripMenuItem
            // 
            this.listaDeNomestoolStripMenuItem.Name = "listaDeNomestoolStripMenuItem";
            this.listaDeNomestoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listaDeNomestoolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.listaDeNomestoolStripMenuItem.Text = "Lista de Nomes";
            this.listaDeNomestoolStripMenuItem.Click += new System.EventHandler(this.listaDeNomestoolStripMenuItem_Click);
            // 
            // movimentarImagemtoolStripMenuItem
            // 
            this.movimentarImagemtoolStripMenuItem.Name = "movimentarImagemtoolStripMenuItem";
            this.movimentarImagemtoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.movimentarImagemtoolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.movimentarImagemtoolStripMenuItem.Text = "Movimentar Imagens";
            this.movimentarImagemtoolStripMenuItem.Click += new System.EventHandler(this.movimentarImagemtoolStripMenuItem_Click);
            // 
            // relogiotoolStripMenuItem
            // 
            this.relogiotoolStripMenuItem.Name = "relogiotoolStripMenuItem";
            this.relogiotoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relogiotoolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.relogiotoolStripMenuItem.Text = "Relógio";
            this.relogiotoolStripMenuItem.Click += new System.EventHandler(this.relogiotoolStripMenuItem_Click);
            // 
            // visualizarImagemtoolStripMenuItem
            // 
            this.visualizarImagemtoolStripMenuItem.Name = "visualizarImagemtoolStripMenuItem";
            this.visualizarImagemtoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.visualizarImagemtoolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.visualizarImagemtoolStripMenuItem.Text = "Visualizar Imagem";
            this.visualizarImagemtoolStripMenuItem.Click += new System.EventHandler(this.visualizarImagemtoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // sairDoProgramatoolStripMenuItem
            // 
            this.sairDoProgramatoolStripMenuItem.Name = "sairDoProgramatoolStripMenuItem";
            this.sairDoProgramatoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sairDoProgramatoolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.sairDoProgramatoolStripMenuItem.Text = "Sair do Programa";
            this.sairDoProgramatoolStripMenuItem.Click += new System.EventHandler(this.sairDoProgramatoolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 480);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menus criados em C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDaMediatoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeNomestoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentarImagemtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relogiotoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarImagemtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairDoProgramatoolStripMenuItem;
    }
}


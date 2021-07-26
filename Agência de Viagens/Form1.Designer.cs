
namespace Agência_de_Viagens
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataEmbarque = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTransporte = new System.Windows.Forms.GroupBox();
            this.radioBtnOnibus = new System.Windows.Forms.RadioButton();
            this.radioBtnAviao = new System.Windows.Forms.RadioButton();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblGastoDestino = new System.Windows.Forms.Label();
            this.lblGastoTransporte = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculadorViagem = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.groupBoxTransporte.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserva De Passagem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de embarque";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(195, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 23);
            this.txtNome.TabIndex = 4;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "SC"});
            this.comboBoxDestino.Location = new System.Drawing.Point(195, 148);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(249, 23);
            this.comboBoxDestino.TabIndex = 5;
            // 
            // dateTimePickerDataEmbarque
            // 
            this.dateTimePickerDataEmbarque.Location = new System.Drawing.Point(195, 185);
            this.dateTimePickerDataEmbarque.Name = "dateTimePickerDataEmbarque";
            this.dateTimePickerDataEmbarque.Size = new System.Drawing.Size(249, 23);
            this.dateTimePickerDataEmbarque.TabIndex = 6;
            // 
            // groupBoxTransporte
            // 
            this.groupBoxTransporte.Controls.Add(this.radioBtnOnibus);
            this.groupBoxTransporte.Controls.Add(this.radioBtnAviao);
            this.groupBoxTransporte.ForeColor = System.Drawing.Color.Black;
            this.groupBoxTransporte.Location = new System.Drawing.Point(73, 231);
            this.groupBoxTransporte.Name = "groupBoxTransporte";
            this.groupBoxTransporte.Size = new System.Drawing.Size(262, 100);
            this.groupBoxTransporte.TabIndex = 7;
            this.groupBoxTransporte.TabStop = false;
            this.groupBoxTransporte.Text = "Meio de Transporte";
            // 
            // radioBtnOnibus
            // 
            this.radioBtnOnibus.AutoSize = true;
            this.radioBtnOnibus.Location = new System.Drawing.Point(147, 41);
            this.radioBtnOnibus.Name = "radioBtnOnibus";
            this.radioBtnOnibus.Size = new System.Drawing.Size(63, 19);
            this.radioBtnOnibus.TabIndex = 1;
            this.radioBtnOnibus.TabStop = true;
            this.radioBtnOnibus.Text = "Ônibus";
            this.radioBtnOnibus.UseVisualStyleBackColor = true;
            // 
            // radioBtnAviao
            // 
            this.radioBtnAviao.AutoSize = true;
            this.radioBtnAviao.Location = new System.Drawing.Point(6, 41);
            this.radioBtnAviao.Name = "radioBtnAviao";
            this.radioBtnAviao.Size = new System.Drawing.Size(55, 19);
            this.radioBtnAviao.TabIndex = 0;
            this.radioBtnAviao.TabStop = true;
            this.radioBtnAviao.Text = "Avião";
            this.radioBtnAviao.UseVisualStyleBackColor = true;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.txtValorTotal);
            this.groupBoxResultado.Controls.Add(this.lblGastoDestino);
            this.groupBoxResultado.Controls.Add(this.lblGastoTransporte);
            this.groupBoxResultado.Controls.Add(this.label7);
            this.groupBoxResultado.Controls.Add(this.label6);
            this.groupBoxResultado.Controls.Add(this.label5);
            this.groupBoxResultado.Location = new System.Drawing.Point(73, 349);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(262, 100);
            this.groupBoxResultado.TabIndex = 8;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Valores do Pacote";
            this.groupBoxResultado.Visible = false;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(147, 68);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 23);
            this.txtValorTotal.TabIndex = 5;
            // 
            // lblGastoDestino
            // 
            this.lblGastoDestino.AutoSize = true;
            this.lblGastoDestino.Location = new System.Drawing.Point(147, 43);
            this.lblGastoDestino.Name = "lblGastoDestino";
            this.lblGastoDestino.Size = new System.Drawing.Size(0, 15);
            this.lblGastoDestino.TabIndex = 4;
            // 
            // lblGastoTransporte
            // 
            this.lblGastoTransporte.AutoSize = true;
            this.lblGastoTransporte.Location = new System.Drawing.Point(147, 19);
            this.lblGastoTransporte.Name = "lblGastoTransporte";
            this.lblGastoTransporte.Size = new System.Drawing.Size(0, 15);
            this.lblGastoTransporte.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valor Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gasto com Destino :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gasto Transporte :";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(557, 111);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 30);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(557, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculadorViagem
            // 
            this.btnCalculadorViagem.Location = new System.Drawing.Point(557, 288);
            this.btnCalculadorViagem.Name = "btnCalculadorViagem";
            this.btnCalculadorViagem.Size = new System.Drawing.Size(83, 59);
            this.btnCalculadorViagem.TabIndex = 12;
            this.btnCalculadorViagem.Text = "Calcular Valor da Viagem";
            this.btnCalculadorViagem.UseVisualStyleBackColor = true;
            this.btnCalculadorViagem.Click += new System.EventHandler(this.btnCalculadorViagem_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Location = new System.Drawing.Point(557, 231);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(83, 30);
            this.btnCalculadora.TabIndex = 13;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(670, 486);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.btnCalculadorViagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBoxResultado);
            this.Controls.Add(this.groupBoxTransporte);
            this.Controls.Add(this.dateTimePickerDataEmbarque);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agência de Viagens - TI20";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTransporte.ResumeLayout(false);
            this.groupBoxTransporte.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEmbarque;
        private System.Windows.Forms.GroupBox groupBoxTransporte;
        private System.Windows.Forms.RadioButton radioBtnOnibus;
        private System.Windows.Forms.RadioButton radioBtnAviao;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblGastoDestino;
        private System.Windows.Forms.Label lblGastoTransporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculadorViagem;
        private System.Windows.Forms.Button btnCalculadora;
    }
}


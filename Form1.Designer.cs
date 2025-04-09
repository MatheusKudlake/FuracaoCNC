namespace FuracaoCNC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inicioLento = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.programa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.profInicial = new System.Windows.Forms.NumericUpDown();
            this.incrementoDeCorte = new System.Windows.Forms.NumericUpDown();
            this.avanco = new System.Windows.Forms.NumericUpDown();
            this.profFinal = new System.Windows.Forms.NumericUpDown();
            this.profLento = new System.Windows.Forms.NumericUpDown();
            this.avancoLento = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.profInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incrementoDeCorte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profLento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avancoLento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configurações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Avanço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Incremento de corte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Profundidade inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Profundidade final:";
            // 
            // inicioLento
            // 
            this.inicioLento.AutoSize = true;
            this.inicioLento.Location = new System.Drawing.Point(39, 183);
            this.inicioLento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inicioLento.Name = "inicioLento";
            this.inicioLento.Size = new System.Drawing.Size(168, 20);
            this.inicioLento.TabIndex = 9;
            this.inicioLento.Text = "Avanço menor no início";
            this.inicioLento.UseVisualStyleBackColor = true;
            this.inicioLento.CheckedChanged += new System.EventHandler(this.check_change);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Profundidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Avanço inicial:";
            // 
            // programa
            // 
            this.programa.Location = new System.Drawing.Point(354, 45);
            this.programa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.programa.Multiline = true;
            this.programa.Name = "programa";
            this.programa.Size = new System.Drawing.Size(307, 285);
            this.programa.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Programa final:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 299);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Gerar programa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profInicial
            // 
            this.profInicial.DecimalPlaces = 3;
            this.profInicial.Location = new System.Drawing.Point(183, 109);
            this.profInicial.Name = "profInicial";
            this.profInicial.Size = new System.Drawing.Size(89, 22);
            this.profInicial.TabIndex = 17;
            // 
            // incrementoDeCorte
            // 
            this.incrementoDeCorte.DecimalPlaces = 3;
            this.incrementoDeCorte.Location = new System.Drawing.Point(183, 77);
            this.incrementoDeCorte.Name = "incrementoDeCorte";
            this.incrementoDeCorte.Size = new System.Drawing.Size(89, 22);
            this.incrementoDeCorte.TabIndex = 18;
            // 
            // avanco
            // 
            this.avanco.DecimalPlaces = 3;
            this.avanco.Location = new System.Drawing.Point(183, 45);
            this.avanco.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.avanco.Name = "avanco";
            this.avanco.Size = new System.Drawing.Size(89, 22);
            this.avanco.TabIndex = 19;
            // 
            // profFinal
            // 
            this.profFinal.DecimalPlaces = 3;
            this.profFinal.Location = new System.Drawing.Point(183, 146);
            this.profFinal.Name = "profFinal";
            this.profFinal.Size = new System.Drawing.Size(89, 22);
            this.profFinal.TabIndex = 20;
            // 
            // profLento
            // 
            this.profLento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.profLento.DecimalPlaces = 3;
            this.profLento.Location = new System.Drawing.Point(183, 212);
            this.profLento.Name = "profLento";
            this.profLento.Size = new System.Drawing.Size(89, 22);
            this.profLento.TabIndex = 21;
            // 
            // avancoLento
            // 
            this.avancoLento.DecimalPlaces = 3;
            this.avancoLento.Location = new System.Drawing.Point(183, 242);
            this.avancoLento.Name = "avancoLento";
            this.avancoLento.Size = new System.Drawing.Size(89, 22);
            this.avancoLento.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.avancoLento);
            this.Controls.Add(this.profLento);
            this.Controls.Add(this.profFinal);
            this.Controls.Add(this.avanco);
            this.Controls.Add(this.incrementoDeCorte);
            this.Controls.Add(this.profInicial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.programa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inicioLento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incrementoDeCorte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profLento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avancoLento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox inicioLento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox programa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown profInicial;
        private System.Windows.Forms.NumericUpDown incrementoDeCorte;
        private System.Windows.Forms.NumericUpDown avanco;
        private System.Windows.Forms.NumericUpDown profFinal;
        private System.Windows.Forms.NumericUpDown profLento;
        private System.Windows.Forms.NumericUpDown avancoLento;
    }
}


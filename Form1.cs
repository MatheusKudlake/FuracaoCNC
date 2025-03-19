using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FuracaoCNC
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            foreach (Control controle in this.Controls)
            {
                if(controle is NumericUpDown caixa && caixa.Value == 0)
                {
                     caixa.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                profundidade.Enabled = false;
                avancoInicial.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal repeticoes = 0;
            float ultimoFuro = (float) profInicial.Value;
            if(incrementoDeCorte.Value != 0)
            {
                repeticoes = (profFinal.Value - profInicial.Value) / incrementoDeCorte.Value;

            }
            programa.AppendText("G0X0Z" + (profInicial.Value + 1));
            programa.AppendText(Environment.NewLine);

            for(int i = 0; i < repeticoes; i++)
            {
                programa.AppendText("G1Z" + (ultimoFuro - (float)incrementoDeCorte.Value));
                if (i == 0)
                {
                    programa.AppendText("F" + avanco.Value);
                }
                programa.AppendText(Environment.NewLine);
                programa.AppendText("G0Z1");
                programa.AppendText(Environment.NewLine);
                ultimoFuro -= (float)incrementoDeCorte.Value;
                if (i != repeticoes - 1)
                {
                    programa.AppendText("Z" + (ultimoFuro + 1));
                    programa.AppendText(Environment.NewLine);
                }
            }
        }

        private void check_change(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                profundidade.Enabled = false;
                avancoInicial.Enabled = false;
            }
            else
            {
                profundidade.Enabled = true;
                avancoInicial.Enabled = true;
            }
        }
    }
}

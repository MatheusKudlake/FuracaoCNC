using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

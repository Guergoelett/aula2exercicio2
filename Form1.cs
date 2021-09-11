using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula2exercicio2
{
    public partial class Form1 : Form
    {
        private object resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float num01, num02;
            num01 = float.Parse(campo01.Text);
            num02 = float.Parse(campo02.Text);
            resultado = num01 + num02;
            campoResultado.Text = resultado.ToString()
        }

        private void botao1_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

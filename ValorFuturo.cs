using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cálculo_De_Incertezas
{
    public partial class ValorFuturo : Form
    {
        public ValorFuturo()
        {
            InitializeComponent();
        }

        Cálculos calculos = new Cálculos();
        double[] vector = new double[3];

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vector[0] = Double.Parse(textBox1.Text);
            vector[1] = Double.Parse(textBox2.Text);
            vector[2] = Double.Parse(textBox3.Text);

           textBox4.Text = calculos.ValorFuturo(vector).ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

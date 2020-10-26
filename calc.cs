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
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        Cálculos calculos = new Cálculos();
        double[] vector = new double[5];

        private void button1_Click(object sender, EventArgs e)
        {
            vector[0] = Double.Parse(textBox2.Text);
            vector[1] = Double.Parse(textBox3.Text);
            vector[2] = Double.Parse(textBox4.Text);
            vector[3] = Double.Parse(textBox5.Text);
            vector[4] = Double.Parse(textBox6.Text);

            textBox7.Text = calculos.Calculo(vector).ToString();
        }
                
    }
}

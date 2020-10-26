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
    public partial class meses : Form
    {
        public meses()
        {
            InitializeComponent();
        }

        Cálculos calculos = new Cálculos();
        double[] vector = new double[3];

        private void button1_Click(object sender, EventArgs e)
        {
            vector[0] = Double.Parse(textBox1.Text);
            vector[1] = Double.Parse(textBox2.Text);
            vector[2] = Double.Parse(textBox3.Text);

            textBox4.Text = calculos.Meses(vector).ToString();

        }
    }
}

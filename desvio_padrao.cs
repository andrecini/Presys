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
    public partial class desvio_padrao : Form
    {
        public desvio_padrao()
        {
            InitializeComponent();
        }

        Cálculos calculos = new Cálculos();
        public List<float> Lista = new List<float>();

        private void desvio_padrao_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista.Add(float.Parse(textBox2.Text));
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista.Add(float.Parse(textBox1.Text));
            textBox3.Text = calculos.DesvioPadrao(Lista).ToString();

            Lista.Clear();
            textBox1.Enabled = true;
        }


    }
}
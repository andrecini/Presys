﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cálculo_De_Incertezas
{
    public partial class Somatoria : Form
    {
        public Somatoria()
        {
            InitializeComponent();
        }

        Cálculos calculos = new Cálculos();
        public List<float> Lista = new List<float>();

        private void button2_Click(object sender, EventArgs e)
        {
            Lista.Add(float.Parse(textBox2.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista.Add(float.Parse(textBox1.Text));
            textBox3.Text = calculos.Somatoria(Lista).ToString();            
        }
    }
}

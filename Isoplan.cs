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
    public partial class Isoplan : Form
    {
        public Isoplan()
        {
            InitializeComponent();
            button1.Focus();
        }

        Cálculos calculos = new Cálculos();
        public List<float> Lista = new List<float>();
        public int cont = 1;
        public float[,] array = 
               { 
                {1f, 13.97f},
                {2f, 4.53f},
                {3f, 3.31f},
                {4f, 2.87f},
                {5f, 2.65f},
                {6f, 2.52f},
                {7f, 2.43f},
                {8f, 2.37f},
                {9f, 2.32f},
                {10f, 2.28f},
                {11f, 2.25f},
                {12f, 2.23f},
                {13f, 2.21f},
                {14f, 2.20f},
                {15f, 2.18f},
                {16f, 2.17f},
                {17f, 2.16f},
                {18f, 2.15f},
                {19f, 2.14f},
                {20f, 2.13f},
                {25f, 2.11f},
                {30f, 2.09f},
                {35f, 2.07f},
                {40f, 2.06f},
                {45f, 2.06f},
                {50f, 2.05f},
                {100f, 2.025f}
                            
               };

        private void button1_Click(object sender, EventArgs e)
        {
          
                
            try
                {

                    if (cont == int.Parse(textBox1.Text))
                    {
                        Lista.Add(float.Parse(textBox3.Text));

                    textBox4.Text += "Leitura(" + cont + "): " + textBox3.Text + "; \n";

                    cont = 1;

                    button1.Enabled = false;
                    button2.Enabled = true;
                    button2.Focus();
                    }
                                        
                    else
                    {
                    Lista.Add(float.Parse(textBox3.Text));

                    textBox4.Text += "Leitura(" + cont + "): " + textBox3.Text + "; \n";

                    cont++;
                    }
                }
                catch (Exception ex)
                {
                    /// EXIBE UMA MESSAGE BOX CASO ALGO NÃO OCORRA CORRETAMENTE
                    MessageBox.Show(ex.Message);
                }
               

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            textBox5.Text = calculos.CalculaMedia(Lista).ToString();
            textBox6.Text = calculos.DesvioPadrao(Lista).ToString();

            button3.Enabled = true;
            button3.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

            float[] vector = new float[2];

            vector[0] = (float)(calculos.DesvioPadrao(Lista));
            vector[1] = float.Parse(textBox1.Text);

            textBox7.Text = calculos.Ua(vector).ToString();

            button4.Enabled = true;
            button4.Focus();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            List<float> Lista1 = new List<float>();

            Lista1.Add(float.Parse(textBox7.Text));
            Lista1.Add(float.Parse(textBox8.Text));
            Lista1.Add(float.Parse(textBox9.Text));

            textBox14.Text = calculos.Somatoria(Lista1).ToString();

            float[] vector = new float[3];
            vector[0] = float.Parse(textBox14.Text);
            vector[1] = float.Parse(textBox7.Text);
            vector[2] = float.Parse(textBox1.Text);

            textBox11.Text = calculos.Veff(vector).ToString();

            textBox16.Text = calculos.K(array, calculos.Veff(vector)).ToString();

            float[] vector1 = new float[2];
            vector1[0] = float.Parse(textBox14.Text);
            vector1[1] = float.Parse(textBox16.Text);

            textBox13.Text = calculos.Uf(vector1).ToString();


            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Lista.Clear();

            button1.Focus();

        }
               
        private void Isoplan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 32)
            {
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
            
            }
        }

        private void Isoplan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.PerformClick();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

       
       
        }
           
    

}

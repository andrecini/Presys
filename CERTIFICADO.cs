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
    public partial class CERTIFICADO : Form
    {
        public CERTIFICADO()
        {
            InitializeComponent();
        }
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
        DataTable Tbl;
        Cálculos calculos = new Cálculos();
        public List<float> Lista = new List<float>();
        public List<float> Leituras = new List<float>();
        public List<float> referencias = new List<float>();
        float[] vector = new float[8];
        /// vector[0] = media
        /// vector[1] = erro
        /// vector[2] = desvio
        /// vector[3] = u1
        /// vector[4] = uc
        /// vector[5] = Veff
        /// vector[6] = k
        /// vector[7] = Uf

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            Tbl = new DataTable();
            DataRow Linha;

            double x = (double)numLow.Value;
            double y = (double)numHigh.Value;
            double[] vector = new double[5];
            vector[3] = 4;
            vector[2] = 20;
            vector[1] = x;
            vector[0] = y;
            double aux = 0;


            Tbl.Columns.Add("Pontos:", typeof(double));
            Tbl.Columns.Add("Referência:", typeof(double));

            int num1 = (int)numLeituras.Value;
            int num2 = (int)numPontos.Value;


            for (int i = 1; i <= num1; i++)
            {
                Tbl.Columns.Add("Leitura (" + i + "):", typeof(double));
            }

            Tbl.Columns[1].ReadOnly = true;
            Tbl.Columns[0].ReadOnly = true;
            Tbl.Columns.Add("Aceitação:", typeof(string));



            for (int k = 0; k < num2; k++)
            {
                Linha = Tbl.NewRow();

                if (k == 0)
                {
                    //aux += y / num2;
                    Linha[0] = 0;
                    vector[4] = 0;
                    Linha[1] = calculos.Calculo(vector);
                }

                else
                {
                    aux += y / (num2 - 1);
                    Linha[0] = aux;
                    vector[4] = aux;
                    Linha[1] = calculos.Calculo(vector);
                }

                /// COMANDO PARA ADICIONAR A LINHA NA TABELA
                Tbl.Rows.Add(Linha);
            }

            dataGridView1.DataSource = Tbl;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = (int)numLeituras.Value;
            int num2 = (int)numPontos.Value;

            for (int L = 0; L < num2; L++)
            {
                for (int C = 2; C < num1; C++)
                {
                    Leituras.Add(float.Parse(dataGridView1.Rows[L].Cells[C].Value.ToString()));
                    vector[0] = Leituras.Average();
                    vector[1] = float.Parse(dataGridView1.Rows[L].Cells[1].Value.ToString()) - vector[0];
                    vector[2] = (float)calculos.DesvioPadrao(Leituras);

                    float[] aux = new float[2];
                    aux[0] = vector[2];
                    aux[1] = num1;

                    vector[3] = calculos.Ua(aux);

                    float[] aux1 = new float[2];
                    aux1[0] = vector[4];
                    aux1[1] = 0.005688585f;

                    vector[4] = calculos.Somatoria1(aux1);

                    float[] aux2 = new float[3];
                    aux2[0] = vector[5];
                    aux2[1] = vector[4];
                    aux2[2] = num1;

                    vector[5] = calculos.Veff(aux2);

                    vector[6] = calculos.K(array, vector[5]);

                    float[] aux3 = new float[2];
                    aux3[0] = vector[4];
                    aux3[1] = vector[6];

                    vector[7] = calculos.Uf(aux3);

                    Leituras.Clear();




                }
            }
            
        }
    }
        
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cálculo_De_Incertezas
{
    class Cálculos
    {      

        public float CalculaMedia(List<float> Lista)
        {
            return Lista.Average();
        }

        public float Mediana(List<float> Lista)
        {
            Lista.Sort();

            if (Lista.Count % 2 != 0)
            {
                return Lista.ElementAt(Lista.Count / 2);
            }
            else
            {
                float saida;

                saida = ((Lista.ElementAt((Lista.Count + Lista.Count % 2) / 2) + (Lista.ElementAt((Lista.Count - Lista.Count % 2) / 2)) / 2));
                return saida;
            }
        }

        public string Moda(List<float> Lista)
        {
            Lista.Sort();
            List<float> Aux = new List<float>();
            List<float> Aux2 = new List<float>();


            float conta = 0, moda = 0;
            

            for (int a = 0; a < Lista.Count; a++)
            {
                Aux.Add(0);
            }

            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j = i + 1; j < Lista.Count; j++)
                {
                    if (Lista[i] == Lista[j])
                    {
                        Aux[i]++;
                        if (Aux[i] >= conta)
                        {
                            conta = Aux[i];
                            moda = Lista[i];
                        }
                    }
                }
            }

            if (conta == 0)
            {
                return ("Não existe moda");
            }
            else
            {
                
                return (moda.ToString());
            }
        }

        public double DesvioPadrao(List<float> Lista)
        {
            double media = Lista.Average();
            double desvio, somatoria = 0;

        
            for(int i = 0; i < Lista.Count; i++)
            {
                somatoria += Math.Pow(((double)(Lista[i] - media)), 2.0);
            }          

            desvio = Math.Sqrt((somatoria / (double)(Lista.Count - 1.00)));

            return desvio;
        }

        public double ValorFuturo (double[] vector)
        {
           ///vector[0] ---> VP
           ///vector[1] ---> taxa
           ///vector[2] ---> meses

            double montante = vector[0] * Math.Pow((1 + vector[1]/100), vector[2]);

            return montante;    
        }

        public double ValorPresente(double[] vector)
        {
            ///vector[0] ---> VF
            ///vector[1] ---> taxa
            ///vector[2] ---> meses

            double Vp = vector[0] / Math.Pow((1 + vector[1]/100), vector[2]);

            return Vp;
        }
        
        public double taxa(double[] vector)
        {
            ///vector[0] ---> VF
            ///vector[1] ---> VP
            ///vector[2] ---> meses

            double taxa = Math.Pow((vector[0] / vector[1]), 1 / vector[2]) - 1;

            return taxa*100;
        }

        public double Meses(double[] vector)
        {
            ///vector[0] ---> VF
            ///vector[1] ---> VP
            ///vector[2] ---> taxa

            double meses = Math.Log((vector[0] / vector[1]), 1 + vector[2]/100);

            return meses;
        }

        public double Somatoria(List<float> Lista)
        {
            double somatoria = 0;

            for (int i = 0; i < Lista.Count; i++)
            {
                somatoria += Math.Pow((float)Lista[i], 2);
            }

            double saida = Math.Sqrt(somatoria);

            return saida;
        }

        public double Calculo(double[] vector)
        {
            double a = (vector[3] - vector[2]) / (vector[1] - vector[0]);
            double b = vector[3] - vector[1]*a;

            double saida = a*vector[4] + b;

            return saida;
        }

        public float Ua(float[] vector)
        {
            /// vector[0] ---> desvio
            /// vector[1] ---> leituras

            //float saida = vector[0] / Math.Sqrt(vector[1]);

            return (float)(vector[0] / Math.Sqrt(vector[1]));
        }

        public float Veff (float[] vector)
        {
            ///vector[0] ---> Uc
            ///vector[1] ---> U¹
            ///vector[2] ---> n
            
            return (float)((Math.Pow(vector[0], 4.0) / ((Math.Pow(vector[1], 4.0) / (vector[2] - 1)))));
        }

        public float K(float[,] array, float Veff)
        {
            
            float x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            if (Veff > 100)
                return 2.0f;
            else
                for (int i = 1; i < 27; i++)
                {
                    if (array[i, 0] >= Veff && array[i - 1, 0] <= Veff)
                    {
                        x1 = array[i, 0];
                        x2 = array[i - 1, 0];
                        y1 = array[i, 1];
                        y2 = array[i - 1, 1];
                        break;
                    }

                }
            
            double[] vector = new double[5];
            vector[0] = x1;
            vector[1] = x2;
            vector[2] = y1;
            vector[3] = y2;
            vector[4] = Veff;
            
            return (float)Calculo(vector);

        }

        public float Uf(float[] vector)
        {
            /// vector[0] ---> Uc
            /// vector[1] ---> k
            
            return (float)(vector[0] * vector[1]);
        }

        public float Somatoria1(float[] vector)
        {
            double somatoria = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                somatoria += Math.Pow(vector[i], 2);
            }

            double saida = Math.Sqrt(somatoria);

            return (float)saida;
        }

    }
}


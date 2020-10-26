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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            Média tela = new Média();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            Mediana tela = new Mediana();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

            moda tela = new moda();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;

            desvio_padrao tela = new desvio_padrao();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;

            ValorFuturo tela = new ValorFuturo();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button5.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;

            ValorPresente tela = new ValorPresente();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button6.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;

            Taxa tela = new Taxa();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button7.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;

            meses tela = new meses();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button8.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;

            Somatoria tela = new Somatoria();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button9.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            button10.Enabled = false;

            calc tela = new calc();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button10.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;

            Isoplan tela = new Isoplan();
            this.Hide();
            tela.ShowDialog();
            this.Show();

            button11.Enabled = true;
        }
    }
}

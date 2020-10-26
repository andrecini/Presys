namespace Cálculo_De_Incertezas
{
    partial class CERTIFICADO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numLeituras = new System.Windows.Forms.NumericUpDown();
            this.numPontos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.numLow = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numHigh = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLeituras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // numLeituras
            // 
            this.numLeituras.Location = new System.Drawing.Point(15, 30);
            this.numLeituras.Name = "numLeituras";
            this.numLeituras.Size = new System.Drawing.Size(111, 20);
            this.numLeituras.TabIndex = 0;
            this.numLeituras.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numPontos
            // 
            this.numPontos.Location = new System.Drawing.Point(191, 30);
            this.numPontos.Name = "numPontos";
            this.numPontos.Size = new System.Drawing.Size(120, 20);
            this.numPontos.TabIndex = 1;
            this.numPontos.Tag = "";
            this.numPontos.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Leituras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de Pontos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 364);
            this.dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ponto Low:";
            // 
            // numLow
            // 
            this.numLow.Location = new System.Drawing.Point(380, 30);
            this.numLow.Name = "numLow";
            this.numLow.Size = new System.Drawing.Size(111, 20);
            this.numLow.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ponto High:";
            // 
            // numHigh
            // 
            this.numHigh.Location = new System.Drawing.Point(554, 30);
            this.numHigh.Name = "numHigh";
            this.numHigh.Size = new System.Drawing.Size(111, 20);
            this.numHigh.TabIndex = 9;
            this.numHigh.Tag = "100";
            this.numHigh.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 20);
            this.button2.TabIndex = 11;
            this.button2.Text = "GERAR TABELA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 20);
            this.button3.TabIndex = 12;
            this.button3.Text = "GERAR CERTIFICADO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CERTIFICADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 444);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numHigh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numLow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPontos);
            this.Controls.Add(this.numLeituras);
            this.Name = "CERTIFICADO";
            this.Text = "CERTIFICADO";
            ((System.ComponentModel.ISupportInitialize)(this.numLeituras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHigh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numLeituras;
        private System.Windows.Forms.NumericUpDown numPontos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numLow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numHigh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
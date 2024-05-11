using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _8._3
{
    public partial class Form1 : Form
    {
        double[] P = new double[5];
        int[] Statistic = new int[5];
        double[] Frequency = new double[5];
        Random rand = new Random();
        double alfa;

        public Form1()
        {
            InitializeComponent();
        }

        private void auto_Click(object sender, EventArgs e)
        {

            P[0] = double.Parse(Prob1.Text);
            P[1] = double.Parse(Prob2.Text);
            P[2] = double.Parse(Prob3.Text);
            P[3] = double.Parse(Prob4.Text);

            P[4] = 1 - P[0] - P[1] - P[2] - P[3];

        }

        private void button1_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Points.Clear();

            int N = int.Parse(NN.Text);

            for (int i = 0; i < 5; i++) 
            {
                Statistic[i] = 0;
            }

            int j = 0;

            while(j < N)
            {
                int k = Data();

                Statistic[k]++;

                j++;
            }

            for (int i = 0; i < 5; i++)
            {
                Frequency[i] = ((double)Statistic[i]/ (double)N);
                chart1.Series[0].Points.AddXY(i, Frequency[i]);
            }



        }

        public int Data()
        {

            alfa = rand.NextDouble();

            double A = alfa;
            int k = 0;


            while (A > 0)
            {
                A = A - P[k];
                k++;
            }

            k--;

            return k;
        }
        
    }




}

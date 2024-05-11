using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            double alfa = rand.NextDouble();

            double p = 0.45;

            if (alfa < p)
            {
                label2.Text = "Да";
                label2.Visible = true;
                label2.BackColor = Color.PaleGreen;
            }
            else
            {
                label2.Text = "Нет";
                label2.Visible = true;
                label2.BackColor = Color.Tomato;
            }

        }
    }








}

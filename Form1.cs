
/* 1. В массиве из 20 целых чисел найти наибольший элемент и 
   поменять его местами с первым элементом.*/

using System;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] M = new int[20];

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = rand.Next(-30, 50);
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + M[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Max = 0, 
                index = 0; 
            listBox2.Items.Clear();
            for (int i = 0; i < M.Length; i++)
            {
                if (M[i] > Max)
                {
                    Max = M[i];
                    index = i;
                }
                
                
            }
            M[index] = M[0];
            M[0] = Max;
            for (int i = 0; i < M.Length; i++)
                listBox2.Items.Add("Mas[" + Convert.ToString(i) + "] = " + M[i].ToString());
        }
    }
}

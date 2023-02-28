using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Escribir una función recursiva que retorne los primeros N números
de la serie de Fibonacci. */

namespace exercise04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int getFibonacciSequence(int n)
        {
            if (n <= 1) return n;
            else return getFibonacciSequence(n - 1) + getFibonacciSequence(n - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = string.Empty;
                int operationQty = (int)numericUpDown1.Value;

                for (int i = 0; i < operationQty; i++)
                {
                    result += $"{getFibonacciSequence(i)} ";
                }

                textBox1.Text = result;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

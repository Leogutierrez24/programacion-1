using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Escribir un programa que encuentre la suma de los enteros
positivos pares desde N hasta 2. Chequear que si N es impar se
imprima un mensaje de error. */

namespace exercise06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetEvenSum(int number)
        {
            int result = 0;
            if (number != 1)
            {
                if (number % 2 == 0) result += number + GetEvenSum(number - 1);
                else result += GetEvenSum(number - 1);
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                int maxValue = (int)numericUpDown1.Value;

                if (maxValue % 2 != 0) MessageBox.Show("The Max. value must be an even number!!!");
                else
                {
                    result = GetEvenSum(maxValue);
                }

                label4.Text = result.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

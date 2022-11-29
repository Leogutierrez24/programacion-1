using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Consigna: Desarrollar un programa que permita calcular la suma, resta, multiplicación, división, potencia
            y raíz cuadrada de dos números. Seleccione los controles que utilizará para ingresar los número
            y visualizar el resultado. Las operaciones se ejecutarán con botones de comando.
*/

namespace lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = Convert.ToInt32(textBox1.Text);
                int secondNumber = Convert.ToInt32(textBox2.Text);
                textBox3.Text = $"{firstNumber + secondNumber}";
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = Convert.ToInt32(textBox1.Text);
                int secondNumber = Convert.ToInt32(textBox2.Text);
                textBox3.Text = $"{firstNumber - secondNumber}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = Convert.ToInt32(textBox1.Text);
                int secondNumber = Convert.ToInt32(textBox2.Text);
                textBox3.Text = $"{firstNumber * secondNumber}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = Convert.ToInt32(textBox1.Text);
                int secondNumber = Convert.ToInt32(textBox2.Text);
                textBox3.Text = $"{(decimal)firstNumber / (decimal)secondNumber}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = Convert.ToInt32(textBox1.Text);
                int secondNumber = Convert.ToInt32(textBox2.Text);
                int result = 0;

                for(int i = 0; i < secondNumber; i++)
                {
                    if (i == 0) result = firstNumber;
                    else result *= firstNumber;
                }

                textBox3.Text = $"{result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = Convert.ToInt32(textBox1.Text);
                int secondNumber = Convert.ToInt32(textBox2.Text);

                double firstResult = Math.Sqrt((double)firstNumber);
                double secondResult = Math.Sqrt((double)secondNumber);

                textBox3.Text = $"{firstResult} {secondResult}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

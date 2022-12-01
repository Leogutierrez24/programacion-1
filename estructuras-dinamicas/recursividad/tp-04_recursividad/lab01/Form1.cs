using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Consigna: Implementación de un método recursivo que reciba un parámetro de tipo entero y luego
            llame en forma recursiva con el valor del parámetro menos 1. Deberá mostrar por consola : “10 9
            8 7 6 5 4 3 2 1 “
 
 */

namespace lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Primer programa");
            printNumber(10);
        }

        public void printNumber(int number)
        {
            if (number != 0)
            {
                Console.WriteLine($"{number} ");
                printNumber(number - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Resultado";
            try
            {
                int number = Convert.ToInt32(textBox1.Text);
                if (number <= 0) MessageBox.Show("El número debe ser mayor que 0");
                else label2.Text = $"{factorial(number)}";
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int factorial(int number)
        {
            int result = number;
            if (number != 1)
            {
                result = number * factorial(number - 1);
            }
            return result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label6.Text = "";
                int[] arr = {4, 5, 3, 1, 2};
                
                

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

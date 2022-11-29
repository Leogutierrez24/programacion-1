using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Consigna: Desarrollar un programa que permita calcular los primeros n números de la serie de Fibonacci.
             El número n es ingresado por el usuario.
 */

namespace lab06
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
                textBox1.Text = string.Empty;

                int qtyNumbers = (int)numericUpDown1.Value;
                int x = 0;
                int y = 1;
                int result = 0;
                
                for(int i = 0; i < qtyNumbers; i++)
                {
                    result = x + y;
                    y = x;
                    x = result;

                    textBox1.Text += $"{result} ";
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

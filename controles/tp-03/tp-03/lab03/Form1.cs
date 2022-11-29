using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Consigna: Desarrollar un programa que permita cargar una cantidad n de números ingresados por el
             usuario y mostrar los números ingresados en un textbox y el resultado en un label.
             Nota: Como no se especifica el resultado del label, el total de los números es 
                   una suma. 
*/

namespace lab03
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
                int numbersQuantity = (int)numericUpDown1.Value;
                string allNumbers = string.Empty;
                int total = 0;
                
                for(int i = 0; i < numbersQuantity; i++)
                {
                    string number = Interaction.InputBox("Ingrese el número:");
                    allNumbers += number + " ";
                    total += Convert.ToInt32(number);
                }

                textBox1.Text = allNumbers;
                label2.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

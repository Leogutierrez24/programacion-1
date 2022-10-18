using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int getDecimalNumber(int numberLength, char[] number, int aux)
        {
            if(numberLength <= 0)
            {
                return 0;
            } else
            {
                int arrNumber = Int32.Parse(number[numberLength - 1].ToString()) * aux;
                return arrNumber + getDecimalNumber(numberLength - 1, number, aux * 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aux = 1;
            char[] numberToChange = textBox2.Text.ToCharArray();
            int numberDigits = numberToChange.Length;
            int newNumber = getDecimalNumber(numberDigits, numberToChange, aux);
            textBox1.Text = newNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

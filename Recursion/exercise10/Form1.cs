using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Programe un método recursivo que transforme un número
expresado en notación binaria a un número entero. */

namespace exercise10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int GetDecimal(char[] number)
        {
            int arrayLength = number.Length;
            return CalculateNumber(number, arrayLength - 1, 1);
        }

        private int CalculateNumber(char[] number, int i, int j)
        {
            int result = 0;
            if (i != -1) result += (int)Char.GetNumericValue(number[i]) * j + CalculateNumber(number, i - 1, j * 2);
            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string binaryNumber = textBox1.Text;
                char[] binaryArr = binaryNumber.ToCharArray();
                int decimalNumber = GetDecimal(binaryArr);
                textBox2.Text = decimalNumber.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

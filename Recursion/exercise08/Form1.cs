using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Escribir una función recursiva Mayúsculas(unString) -> otro string
igual pero en mayusculas. Tratar el strings como un vector de
caracteres. Ejemplo Mayúscula(“hola”) -> HOLA */

namespace exercise08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ToUpperCase(char[] text)
        {
            int i = 0;
            string textToUpperCase = ConvertToUpperCase(text, i);
            return textToUpperCase;
        }

        private string ConvertToUpperCase(char[] arr, int i)
        {
            string text = string.Empty;
            if (i <= arr.Length - 1) text += $"{Char.ToUpper(arr[i]) + ConvertToUpperCase(arr, i + 1)}";
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text;
                char[] charArr = text.ToCharArray();
                string textToUpperCase = ToUpperCase(charArr);
                textBox2.Text = textToUpperCase;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

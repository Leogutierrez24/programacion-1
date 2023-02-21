using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Escribir una función recursiva que devuelva los primeros N números pares. */

namespace exercise02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetEvenNumbers(int maxNumber, int i, string result)
        {
            if (i != maxNumber + 1)
            {
                if (i % 2 == 0) result += i + " " + GetEvenNumbers(maxNumber, i + 1, result);
                else result += GetEvenNumbers(maxNumber, i + 1, result);
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int maxNumber = (int)numericUpDown1.Value;
                label1.Text = GetEvenNumbers(maxNumber, 1, "");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

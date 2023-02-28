using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Programe un método recursivo que transforme un número entero
positivo a notación binaria. */

namespace exercise09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int GetBinary(int number)
        {
            if (number == 0)
                return 0;
            else
                return (number % 2 + 10 * GetBinary(number / 2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int decimalNumber = (int)numericUpDown1.Value;
                int binaryNumber = GetBinary(decimalNumber);
                textBox1.Text = binaryNumber.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

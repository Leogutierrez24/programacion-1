using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int findEvenNumbers(int a)
        {
            int evenNumbers = 0;
            if(a < 1)
            {
                return 0;
            } else {
                if (a % 2 == 0) evenNumbers++;
                return evenNumbers + findEvenNumbers(a - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int theNumber = (int)numericUpDown1.Value;
            int theResult = findEvenNumbers(theNumber);
            MessageBox.Show($"Hay {theResult} números pares en {theNumber}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

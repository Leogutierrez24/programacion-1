using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int sumar(int a)
        {
            if(a == 0)
            {
                return 0;
            } else
            {
                return a + sumar(a - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int theNumber = (int)numericUpDown1.Value;
            int theResult = sumar(theNumber);
            MessageBox.Show($"La suma de todos los números hasta {theNumber} es: {theResult}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Consigna: Desarrollar un programa que le permita al usuario indicar un número mínimo y un número
            máximo. Mostrar en un Listbox todos aquellos que son primos.
 */

namespace lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkInputs()
        {
            if(numericUpDown1.Value >= numericUpDown2.Value) numericUpDown2.Value = numericUpDown1.Value + 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int lastNumber = (int)numericUpDown2.Value;

            for(int i = (int)numericUpDown1.Value; i <= lastNumber; i++)
            {
                if(checkNumber(i) == true) listBox1.Items.Add(i.ToString());
            }
        }

        private bool checkNumber(int number)
        {
            bool result = true;

            for(int i = 2; i < number; i++)
            {
                int operation = number % i;
                if (operation == 0) result = false;
            }

            return result;
        }
    }
}

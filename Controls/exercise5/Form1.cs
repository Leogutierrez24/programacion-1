using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetInput()
        {
            textBox1.Text = string.Empty;
        }

        private bool CheckIfPrime(int number)
        {
            int operations = 0;
            bool response = true;

            for(int i = 1; i <= number; i++)
            {
                if (number % i == 0) operations++;
                if (operations > 2)
                {
                    response = false;
                    break;
                }
            }

            return response;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int minValue = Convert.ToInt32(numericUpDown1.Value);
                int maxValue = Convert.ToInt32(numericUpDown2.Value);
                

                for(int i = minValue; i <= maxValue; i++)
                {
                    if (CheckIfPrime(i)) textBox1.Text += $"{i} " ;
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value) numericUpDown2.Value = numericUpDown1.Value + 1;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value < numericUpDown1.Value) numericUpDown2.Value = numericUpDown1.Value + 1;
        }
    }
}

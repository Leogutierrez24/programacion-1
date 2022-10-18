using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int AddEvenNumbers(int n, int result)
        {
            if(n >= 2)
            {
                if (n % 2 == 0)
                {
                    result += n;
                    return AddEvenNumbers(n - 1, result);
                } else
                {
                    return AddEvenNumbers(n - 1, result);
                }
            } else
            {
                return result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value % 2 != 0) {
                MessageBox.Show("El número a elegir debe ser par ! ! !");
            } else {
                int initialNumber = (int)numericUpDown1.Value;
                int result = AddEvenNumbers(initialNumber, 0);
                textBox1.Text = result.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            textBox1.Text = "";
        }
    }
}

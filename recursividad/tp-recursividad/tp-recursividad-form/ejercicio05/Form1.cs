using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int fibonacci(int n, int initialNumb, int nextNumb)
        {
            int result = 0;
            if (n == 0)
            {
                return 0;
            } else if (initialNumb == 0) {
                result = initialNumb + nextNumb;
                initialNumb = nextNumb;
                nextNumb = result;
                textBox1.Text += $"{initialNumb} {result} ";
                return fibonacci(n - 2, initialNumb, nextNumb);
            } else {
                result = initialNumb + nextNumb;
                initialNumb = nextNumb;
                nextNumb = result;
                textBox1.Text += $"{result} ";
                return fibonacci(n - 1, initialNumb, nextNumb);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int theNumber = (int)numericUpDown1.Value;
            int theResult = fibonacci(theNumber, 0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

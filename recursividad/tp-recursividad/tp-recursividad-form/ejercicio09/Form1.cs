using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public string getBinaryNumber(int n, string binaryNumber)
        {
            if(n > 2)
            {
                int nextNumber = n / 2;
                int binaryElement = n % 2;
                binaryNumber += binaryElement.ToString();
                return getBinaryNumber(nextNumber, binaryNumber);
            } else
            {
                int binaryElementB = n % 2;
                binaryNumber += binaryElementB.ToString();
                int binaryElementA = n / 2;
                binaryNumber += binaryElementA.ToString();
                char[] charArray = binaryNumber.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int theNumber = Int32.Parse(textBox2.Text);
                string theResult = getBinaryNumber(theNumber, "");
                textBox1.Text = theResult;
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato del número no es válido! ! !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetResult()
        {
            label6.Text = "0";
        }

        private decimal Operate(decimal x, decimal y, string value)
        {
            decimal result = 0;

            if (value == "+") result = x + y;
            if (value == "-") result = x - y;
            if (value == "*") result = x * y;
            if (value == "/")
            {
                if (y == 0) throw new Exception("No se puede dividir por 0 !!!");
                else result = x / y;
            }
            if (value == "^") result = (decimal)Math.Pow(Convert.ToDouble(x), Convert.ToDouble(y));
            if (value == "sqrt") result = (decimal)Math.Sqrt(Convert.ToDouble(x));

            return Decimal.Round(result, 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ResetResult();
                decimal firstNum = numericUpDown1.Value;
                decimal secondNum = numericUpDown2.Value;
                string operation = comboBox1.SelectedItem.ToString();

                string result = Operate(firstNum, secondNum, operation).ToString();
                label6.Text = result;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

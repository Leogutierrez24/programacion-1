using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int totalValues = Convert.ToInt32(numericUpDown1.Value);
                int x = 0;
                int y = 1;
                int z = 0;
                ClearInput();

                for (int i = 0; i < totalValues; i++)
                {
                    if(i == 0) textBox1.Text += $"{x} {y} ";
                    else
                    {
                        z = x + y;
                        x = y;
                        y = z;
                        textBox1.Text += $"{z} ";
                    }
                    
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearInput()
        {
            textBox1.Text = string.Empty;
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int newValue = Convert.ToInt32(textBox1.Text);
                textBox2.Text += $"{newValue} ";
                clearInput();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

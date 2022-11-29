using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    /* Consigna: Desarrollar un programa que permita ingresar dos números por medio de cajas de texto y
    retorne la suma de los mismos en un label. */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "El resultado es: ";
                int firstNumber = Convert.ToInt32(textBox1.Text);
                int secondNumber = Convert.ToInt32(textBox2.Text);

                label3.Text += $"{firstNumber + secondNumber}";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt16(Interaction.InputBox("Ingrese el primer número:"));
            int secondNumber = Convert.ToInt16(Interaction.InputBox("Ingrese el segundo número:"));

            MessageBox.Show($"La suma entre los dos números es: {firstNumber + secondNumber}");
            
        }
    }
}

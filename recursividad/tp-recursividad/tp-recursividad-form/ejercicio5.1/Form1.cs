using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int SumaHasta(int n, int hasta)
        {
            if(n > 1)
            {
                return hasta + SumaHasta(n - 1, hasta + 1);
            } else
            {
                return hasta;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nRepeticiones = (int)numericUpDown1.Value;
            int numeroInicio = (int)numericUpDown2.Value;
            int resultado = SumaHasta(nRepeticiones, numeroInicio);
            textBox1.Text = resultado.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox1.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}

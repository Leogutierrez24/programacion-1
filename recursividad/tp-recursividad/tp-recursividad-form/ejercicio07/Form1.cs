using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public char[] Aparear(char[] lista1, char[] lista2)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == textBox2.Text.Length)
            {
                int nIteraciones = textBox1.Text.Length;
                char[] primeraLista = textBox1.Text.ToCharArray();
                char[] segundaLista = textBox2.Text.ToCharArray();
                char[] listaFinal = Aparear(primeraLista, segundaLista);
            } else
            {
                MessageBox.Show("Las listas deben tener igual cant. de caracteres! ! !");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

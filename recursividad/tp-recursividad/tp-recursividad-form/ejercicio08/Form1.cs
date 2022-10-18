using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public char[] mayusculas(int n, char[] texto)
        {
            if(n >= 0)
            {
                char newChar = char.ToUpper(texto[n]);
                texto[n] = newChar;
                return mayusculas(n - 1, texto);
            } else
            {
                return texto;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nRepeticiones = textBox2.Text.Length - 1;
            char[] algo = textBox2.Text.ToCharArray();
            char[] textoModificado = mayusculas(nRepeticiones, algo);
            textBox1.Text = new string(textoModificado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

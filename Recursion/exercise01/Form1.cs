using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Escribir una función recursiva que devuelva la suma de los primeros N enteros. */

namespace exercise01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetOperation(int maxNumber)
        {
            int result = 0;
            if (maxNumber != 0) result += maxNumber + GetOperation(maxNumber - 1);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int maxNumber = (int)numericUpDown1.Value;
                int result = GetOperation(maxNumber);

                label1.Text = result.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Escribir una función recursiva que resuelva Np donde N y p son
números positivos. */

namespace exercise03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            if (powNum != 0) result = baseNum * GetPow(baseNum, powNum - 1);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int baseNumber = (int)numericUpDown1.Value;
                int powerNumber = (int)numericUpDown2.Value;
                label6.Text = GetPow(baseNumber, powerNumber).ToString();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Escribir una función recursiva SumaHasta(n, desde) ->
numero. Debe retornar la suma de los números desde el valor
“desde” hasta los N consecutivos a él. Por ejemplo.
SumaHasta(5,10) = 10 + 11 + 12 + 13 + 14 => 60. */

namespace exercise05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int SumTill(int i, int number)
        {
            int result = number;
            if (i != 1) result += SumTill(i - 1, number + 1);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                int baseNumber = (int)numericUpDown2.Value;
                int iterationQty = (int)numericUpDown1.Value;
                
                result = SumTill(iterationQty, baseNumber);
                label4.Text = result.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

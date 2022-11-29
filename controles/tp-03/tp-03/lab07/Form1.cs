using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Consigna: Desarrollar un programa que permita calcular los intereses de un plazo fijo. Para ello nos
            informan que la manera de obtenerlo es haciendo M * T * D / 36500. Donde: M=Monto, T=Tasa
            Nominal Anual, D=Días que dura la imposición. Mostrar los valores ingresados y los resultados
            en una Grilla del tipo DataGridView.
 */

namespace lab07
{
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
                int n = dataGridView1.Rows.Add();
                decimal mount = Convert.ToDecimal(textBox1.Text);
                decimal interes = numericUpDown1.Value;
                decimal qtyDays = numericUpDown2.Value;
                decimal total = (mount * interes * qtyDays) / 36500;

                dataGridView1.Rows[n].Cells[0].Value = mount;
                dataGridView1.Rows[n].Cells[1].Value = interes;
                dataGridView1.Rows[n].Cells[2].Value = qtyDays;
                dataGridView1.Rows[n].Cells[3].Value = Decimal.Round(total, 2);

                textBox1.Text = "0";
                numericUpDown1.Value = 1;
                numericUpDown2.Value = 30;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

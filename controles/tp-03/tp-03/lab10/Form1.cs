using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Consigna: Desarrollar un programa que permita transformar temperaturas entre las siguientes escalas:
            Celsius, Fahrenheit, Kelvin, Rankine. el programa deberá permitir indicar: la escala inicial, la
            escala final y la cantidad a transformar. Se debe obtener la cantidad en la escala final. Los
            valores ingresados y calculados deberán permaneces visibles en una grilla.
 */

namespace lab10
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
                string initScale = comboBox1.SelectedItem.ToString();
                string finalScale = comboBox2.SelectedItem.ToString();
                decimal temperature = Convert.ToDecimal(textBox1.Text);
                decimal finalTemp = convertTemp(initScale, finalScale, temperature);

                dataGridView1.Rows[n].Cells[0].Value = temperature;
                dataGridView1.Rows[n].Cells[1].Value = initScale;
                dataGridView1.Rows[n].Cells[2].Value = finalTemp;
                dataGridView1.Rows[n].Cells[3].Value = finalScale;

                textBox1.Text = "0";

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public decimal convertTemp(string init, string final, decimal temp)
        {
            if(init == "Celsius")
            {
                switch (final)
                {
                    case "Fahrenheit":
                        temp = (temp * 9 / 5) + 32;
                        break;
                    case "Kelvin":
                        temp = temp + 273;
                        break;
                    case "Rankine":
                        temp = (temp * 9 / 5) + 491;
                        break;
                    case "Celsius":
                        MessageBox.Show("Ambas escalas no deben ser iguales!!!");
                        break;
                    default:
                        MessageBox.Show("Hubo un error!!!");
                        break;
                }
            } else if(init == "Fahrenheit")
            {
                switch (final)
                {
                    case "Celsius":
                        temp = (temp - 32) * (5/9);
                        break;
                    case "Kelvin":
                        temp = (temp - 32) * (5/9) + 273;
                        break;
                    case "Rankine":
                        temp = temp + 459;
                        break;
                    case "Fahrenheit":
                        MessageBox.Show("Ambas escalas no deben ser iguales!!!");
                        break;
                    default:
                        MessageBox.Show("Hubo un error!!!");
                        break;
                }
            } else if(init == "Kelvin")
            {
                switch (final)
                {
                    case "Celsius":
                        temp = temp - 273;
                        break;
                    case "Fahrenheit":
                        temp = (temp - 273) * (9/5) + 32;
                        break;
                    case "Rankine":
                        temp = temp * (decimal)1.8;
                        break;
                    case "Kelvin":
                        MessageBox.Show("Ambas escalas no deben ser iguales!!!");
                        break;
                    default:
                        MessageBox.Show("Hubo un error!!!");
                        break;
                }
            } else if(init == "Rankine")
            {
                switch (final)
                {
                    case "Celsius":
                        temp = (temp - 491) * (5 / 9);
                        break;
                    case "Kelvin":
                        temp = (temp - 32) * (5 / 9);
                        break;
                    case "Fahrenheit":
                        temp = temp - 459;
                        break;
                    case "Rankine":
                        MessageBox.Show("Ambas escalas no deben ser iguales!!!");
                        break;
                    default:
                        MessageBox.Show("Hubo un error!!!");
                        break;
                }
            }
            return temp;
        }
    }
}

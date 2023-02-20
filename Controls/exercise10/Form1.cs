using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
    Desarrollar un programa que permita transformar temperaturas entre las siguientes escalas:
    Celsius, Fahrenheit, Kelvin, Rankine. el programa deberá permitir indicar: la escala inicial, la
    escala final y la cantidad a transformar. Se debe obtener la cantidad en la escala final. Los
    valores ingresados y calculados deberán permaneces visibles en una grilla.
 
*/

namespace exercise10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal ConvertTemp(decimal temp, string defaultScale, string finalScale)
        {
            decimal finalTemp = 0;

            if (defaultScale == "CELSIUS")
            {
                switch (finalScale)
                {
                    case "FAHRENHEIT":
                        finalTemp = (temp * (9 / 5)) + 32;
                        break;
                    case "KELVIN":
                        finalTemp = temp + (decimal)273.15;
                        break;
                    case "RANKINE":
                        finalTemp = finalTemp = (temp * (9 / 5)) + (decimal)491.67;
                        break;
                    default: MessageBox.Show("An error ocurred!!!");
                        break;
                }
            } else if (defaultScale == "FAHRENHEIT")
            {
                switch (finalScale)
                {
                    case "CELSIUS":
                        finalTemp = (temp - 32) * (5/9);
                        break;
                    case "KELVIN":
                        finalTemp = ((temp - 32) * (5 / 9)) + (decimal)273.15;
                        break;
                    case "RANKINE":
                        finalTemp = temp + (decimal)491.67;
                        break;
                    default:
                        MessageBox.Show("An error ocurred!!!");
                        break;
                }
            } else if (defaultScale == "KELVIN")
            {
                switch (finalScale)
                {
                    case "CELSIUS":
                        finalTemp = temp - (decimal)273.15;
                        break;
                    case "FAHRENHEIT":
                        finalTemp = (temp - (decimal)273.15) * (9/5) + 32;
                        break;
                    case "RANKINE":
                        finalTemp = temp  * (decimal)1.8;
                        break;
                    default:
                        MessageBox.Show("An error ocurred!!!");
                        break;
                }
            } else if (defaultScale == "RANKINE")
            {
                switch (finalScale)
                {
                    case "CELSIUS":
                        finalTemp = (temp - (decimal)491.67) * (5 / 9);
                        break;
                    case "KELVIN":
                        finalTemp = temp * (5 / 9);
                        break;
                    case "FAHRENHEIT":
                        finalTemp = temp - (decimal)459.67;
                        break;
                    default:
                        MessageBox.Show("An error ocurred!!!");
                        break;
                }
            }

            return finalTemp;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal defaultTemp = numericUpDown1.Value;
                decimal finalTemp = 0;
                string defaultTempScale = comboBox1.GetItemText(comboBox1.SelectedItem);
                string finalConvertScale = comboBox2.GetItemText(comboBox2.SelectedItem);

                if (defaultTempScale == finalConvertScale) MessageBox.Show("Not valid convertion!!!");
                else
                {
                    finalTemp = ConvertTemp(defaultTemp, defaultTempScale, finalConvertScale);
                    textBox1.Text = $"{finalTemp} {finalConvertScale}";
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}

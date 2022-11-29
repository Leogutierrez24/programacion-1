using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Consigna: 8) Desarrollar un programa que simule la tirada de un dado.
             9) Desarrollar un programa que simule la tirada de dos dados y mostrar en una grilla la cantidad
                de veces que salió cada número y el porcentaje que representa esa cantidad en el total de
                tiradas. Las tiradas se deben realizar al oprimir un botón.
 */

namespace lab08
{
    public partial class Form1 : Form
    {
        int qtyDrops = 0;
        int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0;
        Random randomNumber = new Random((int)DateTime.Now.Ticks);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if(i == 5) dataGridView1.Rows[i].Cells[0].Value = i + 1;
                else
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                } 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qtyDrops++;
            
            int diceValue1 = randomNumber.Next(1, 7);
            int diceValue2 = randomNumber.Next(1, 7);

            label2.Text = diceValue1.ToString();
            label4.Text = diceValue2.ToString();
            label5.Text = qtyDrops.ToString();

            checkValue(diceValue1);
            checkValue(diceValue2);
            updateList();
        }

        public void checkValue(int number)
        {
            switch (number)
            {
                case 1:
                    one++;
                    dataGridView1.Rows[0].Cells[1].Value = one;
                    break;
                case 2:
                    two++;
                    dataGridView1.Rows[1].Cells[1].Value = two;
                    break;
                case 3:
                    three++;
                    dataGridView1.Rows[2].Cells[1].Value = three;
                    break;
                case 4:
                    four++;
                    dataGridView1.Rows[3].Cells[1].Value = four;
                    break;
                case 5:
                    five++;
                    dataGridView1.Rows[4].Cells[1].Value = five;
                    break;
                case 6:
                    six++;
                    dataGridView1.Rows[5].Cells[1].Value = six;
                    break;
                default:
                    MessageBox.Show("Hubo un error");
                    break;
            }
        }

        public void updateList()
        {
            dataGridView1.Rows[0].Cells[2].Value = Decimal.Round((decimal)(100 * one) / qtyDrops, 2);
            dataGridView1.Rows[1].Cells[2].Value = Decimal.Round((decimal)(100 * two) / qtyDrops, 2);
            dataGridView1.Rows[2].Cells[2].Value = Decimal.Round((decimal)(100 * three) / qtyDrops, 2);
            dataGridView1.Rows[3].Cells[2].Value = Decimal.Round((decimal)(100 * four) / qtyDrops, 2);
            dataGridView1.Rows[4].Cells[2].Value = Decimal.Round((decimal)(100 * five) / qtyDrops, 2);
            dataGridView1.Rows[5].Cells[2].Value = Decimal.Round((decimal)(100 * six) / qtyDrops, 2);
        }
    }
}

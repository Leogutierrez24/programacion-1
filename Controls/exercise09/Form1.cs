using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise09
{
    public partial class Form1 : Form
    {
        public int rolls = 0;

        public Random r = new Random();

        public int one = 0;
        public int two = 0;
        public int three = 0;
        public int four = 0;
        public int five = 0;
        public int six = 0;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                if (i != 5)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.Rows[i].Cells[1].Value = 0;
                    dataGridView1.Rows[i].Cells[2].Value = 0;
                } else
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.Rows[i].Cells[1].Value = 0;
                    dataGridView1.Rows[i].Cells[2].Value = 0;
                }
            }
        }

        private void AddDiceValue(int value)
        {
            switch (value)
            {
                case 1: one++;
                    break;
                case 2:
                    two++;
                    break;
                case 3:
                    three++;
                    break;
                case 4:
                    four++;
                    break;
                case 5:
                    five++;
                    break;
                case 6:
                    six++;
                    break;
                default: MessageBox.Show("An error occurred!!!");
                    break;
            }
        }

        private void Calculate()
        {
            dataGridView1.Rows[0].Cells[1].Value = Convert.ToDecimal((one * 100) / rolls);
            dataGridView1.Rows[0].Cells[2].Value = one;

            dataGridView1.Rows[1].Cells[1].Value = Convert.ToDecimal((two * 100) / rolls);
            dataGridView1.Rows[1].Cells[2].Value = two;

            dataGridView1.Rows[2].Cells[1].Value = Convert.ToDecimal((three * 100) / rolls);
            dataGridView1.Rows[2].Cells[2].Value = three;

            dataGridView1.Rows[3].Cells[1].Value = Convert.ToDecimal((four * 100) / rolls);
            dataGridView1.Rows[3].Cells[2].Value = four;

            dataGridView1.Rows[4].Cells[1].Value = Convert.ToDecimal((five * 100) / rolls);
            dataGridView1.Rows[4].Cells[2].Value = five;

            dataGridView1.Rows[5].Cells[1].Value = Convert.ToDecimal((six * 100) / rolls);
            dataGridView1.Rows[5].Cells[2].Value = six;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rolls++;
                label3.Text = string.Empty;
                label4.Text = string.Empty;

                int diceOne = 0;
                int diceTwo = 0;

                
                diceOne = r.Next(1, 7);
                diceTwo = r.Next(1, 7);

                AddDiceValue(diceOne);
                AddDiceValue(diceTwo);

                label3.Text = diceOne.ToString();
                label4.Text = diceTwo.ToString();

                Calculate();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

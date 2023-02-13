using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal amount = numericUpDown1.Value;
            decimal interest = numericUpDown2.Value;
            decimal days = numericUpDown3.Value;
            decimal total = (amount * interest * days) / 36500;

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = amount;
            dataGridView1.Rows[n].Cells[1].Value = interest;
            dataGridView1.Rows[n].Cells[2].Value = days;
            dataGridView1.Rows[n].Cells[3].Value = Math.Round(total, 2);
        }
    }
}

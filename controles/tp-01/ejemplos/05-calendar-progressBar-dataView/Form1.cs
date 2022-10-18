using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_calendar_progressBar_dataView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            DateTime date = dateTimePicker1.Value;
            monthCalendar1.SetDate(date);
            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;
            } else {
                int n = dataGridView2.Rows.Add();
                if (progressBar1.Value == 100) dataGridView2.Rows[n].Cells[0].Value = date.ToShortDateString();
                progressBar1.Value = 0;
                timer1.Stop();
            }
        }
    }
}

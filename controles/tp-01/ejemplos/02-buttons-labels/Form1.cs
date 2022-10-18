using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_buttons_labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label02.Text = "Soy el Button 1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label02.Text = "Yo el Button 2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label02.Text = "y Yo soy el Button 3";
        }
    }
}

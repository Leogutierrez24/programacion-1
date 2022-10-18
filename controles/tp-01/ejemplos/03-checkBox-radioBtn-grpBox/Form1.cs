using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_checkBox_radioBtn_grpBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.CheckedChanged += textBox1_TextChanged;
            checkBox2.CheckedChanged += textBox1_TextChanged;
            checkBox3.CheckedChanged += textBox1_TextChanged;
            radioButton1.CheckedChanged += textBox1_TextChanged;
            radioButton2.CheckedChanged += textBox1_TextChanged;
            radioButton3.CheckedChanged += textBox1_TextChanged;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string info = "";
            info += $"{(checkBox1.Checked ? checkBox1.Text : null)} " +
                $"{(checkBox2.Checked ? checkBox2.Text : null)} " +
                $"{(checkBox3.Checked ? checkBox3.Text : null)} ";
            if (radioButton1.Checked == true)
            {
                info += $"{radioButton1.Text}";
            }
            else if (radioButton2.Checked == true)
            {
                info += $"{radioButton2.Text}";
            }
            else if (radioButton3.Checked == true)
            {
                info += $"{radioButton3.Text}";
            }
            textBox1.Text = info;
        }      
    }
}

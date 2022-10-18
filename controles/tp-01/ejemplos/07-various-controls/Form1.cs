using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_various_controls
{
    public partial class Form1 : Form
    {
        string colorData = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(numericUpDown1.Value.ToString());
            newItem.SubItems.Add(numericUpDown2.Value.ToString());
            newItem.SubItems.Add(numericUpDown3.Value.ToString());
            newItem.SubItems.Add(colorData);
            listView1.Items.Add(newItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem newItem in listView1.SelectedItems)
            {
                newItem.Remove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorData = "";
            if(checkedListBox1.CheckedItems.Count != 0)
            {
                for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    colorData += $"{checkedListBox1.CheckedItems[i].ToString()} ";
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Visited(Node someNode)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = someNode.Id;
            } else
            {
                textBox1.Text += $" {someNode.Id}";
            }
        }

        private void PreOrder(Node someNode)
        {
            Visited(someNode);
            if (someNode.Left != null) PreOrder(someNode.Left);
            if (someNode.Right != null) PreOrder(someNode.Right);
        }

        private void InOrder(Node someNode)
        {
            if (someNode.Left != null) PreOrder(someNode.Left);
            Visited(someNode);
            if (someNode.Right != null) PreOrder(someNode.Right);
        }

        private void PostOrder(Node someNode)
        {
            if (someNode.Left != null) PreOrder(someNode.Left);
            if (someNode.Right != null) PreOrder(someNode.Right);
            Visited(someNode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Node a = new Node("A");
            Node b = new Node("B");
            Node c = new Node("C");
            Node d = new Node("D");
            Node _e = new Node("E");
            Node f = new Node("F");

            a.Left = b;
            a.Right = c;

            b.Right = d;

            c.Left = _e;
            c.Right = f;

            textBox1.Text = string.Empty;

            PreOrder(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Node a = new Node("A");
            Node b = new Node("B");
            Node c = new Node("C");
            Node d = new Node("D");
            Node _e = new Node("E");
            Node f = new Node("F");

            a.Left = b;
            a.Right = c;

            b.Right = d;

            c.Left = _e;
            c.Right = f;

            textBox1.Text = string.Empty;

            InOrder(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Node a = new Node("A");
            Node b = new Node("B");
            Node c = new Node("C");
            Node d = new Node("D");
            Node _e = new Node("E");
            Node f = new Node("F");

            a.Left = b;
            a.Right = c;

            b.Right = d;

            c.Left = _e;
            c.Right = f;

            textBox1.Text = string.Empty;

            PostOrder(a);
        }

        
    }
}

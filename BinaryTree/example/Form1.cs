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
        Node a;
        Node b;
        Node c;
        Node d;
        Node _e;
        Node f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = new Node("A");
            b = new Node("B");
            c = new Node("C");
            d = new Node("D");
            _e = new Node("E");
            f = new Node("F");

            a.Left = b;
            a.Right = c;

            b.Right = d;

            c.Left = _e;
            c.Right = f;

            treeView1.ExpandAll();
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
            if (someNode.Left != null) InOrder(someNode.Left);
            Visited(someNode);
            if (someNode.Right != null) InOrder(someNode.Right);
        }

        private void PostOrder(Node someNode)
        {
            if (someNode.Left != null) PostOrder(someNode.Left);
            if (someNode.Right != null) PostOrder(someNode.Right);
            Visited(someNode);
        }

        private void Amplitud(List<Node> nodes, TextBox textBox)
        {
            if (nodes.Exists(node => node.Id != "@"))
            {
                List<Node> auxNodeList = new List<Node> ();
                foreach(Node n in nodes)
                {
                    textBox.Text += $"{n.Id} ";
                    auxNodeList.Add(n.Left != null ? n.Left : new Node("@"));
                    auxNodeList.Add(n.Right != null ? n.Right : new Node("@"));
                }
                Amplitud(auxNodeList, textBox);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            PreOrder(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            InOrder(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            PostOrder(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            Amplitud(new List<Node> { a }, textBox1);
        }
    }
}

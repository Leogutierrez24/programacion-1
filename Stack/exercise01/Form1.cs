using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Un almacén tiene capacidad para apilar n contenedores. Cada contenedor tiene un número de
identificación. Cuando se desea retirar un contenedor específico, deben retirarse primero los
contenedores que están encima de él y colocarlos en otra pila, efectuar el retiro y regresarlos.
Codifique los métodos Push ( ) y Pop ( ) para gestionar los contenedores. */

namespace exercise01
{
    public partial class Form1 : Form
    {
        Stack containerStack;
        Stack auxStack;

        public Form1()
        {
            InitializeComponent();
            containerStack = new Stack();
            auxStack = new Stack();
        }

        private void PrintAll(Node someNode)
        {
            listView1.Items.Add($"{someNode.Id}");
            if (someNode.Next != null) PrintAll(someNode.Next);
        }

        private void RecursionPop(int id, Node someNode)
        {
            if (someNode.Id != id)
            {
                containerStack.Pop();
                someNode.Next = null;
                auxStack.Push(someNode);
                RecursionPop(id, containerStack.Show());
            } else
            {
                containerStack.Pop();
                if (auxStack.Show() != null) RestoreStack(auxStack.Show());
            }
        }

        private void RestoreStack(Node someNode)
        {
            if (someNode != null)
            {
                auxStack.Pop();
                someNode.Next = null;
                containerStack.Push(someNode);
                RestoreStack(auxStack.Show());
            }
        }

        private void ShowStack()
        {
            listView1.Items.Clear();
            Node lastNode = containerStack.Show();

            if (lastNode != null) PrintAll(lastNode);
        }

        private void PushButton_Click(object sender, EventArgs e)
        {
            try
            {
                Node newNode = new Node
                {
                    Id = (int)numericUpDown1.Value,
                };
                containerStack.Push(newNode);
                ShowStack();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopButton_Click(object sender, EventArgs e)
        {
            try
            {
                int popValue = (int)numericUpDown2.Value;

                if (popValue == 0) containerStack.Pop();
                else
                {
                    RecursionPop(popValue, containerStack.Show());
                }

                ShowStack();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

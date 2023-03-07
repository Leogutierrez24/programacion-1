using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* En un natatorio se tiene una cola para la revisación médica para ingresar a una pileta, es por esto
que se ordena dividir la cola en una de hombres y una de mujeres.
Mostrar la cola inicial y las 2 nuevas generadas luego de la separación por sexos.
 */

namespace exercise01
{
    public partial class Form1 : Form
    {
        Queue clientList;
        Queue womenList;
        Queue menList;

        public Form1()
        {
            InitializeComponent();
            clientList = new Queue();
            womenList = new Queue();
            menList = new Queue();
        }

        private void PrintMainList(Node someClient)
        {
            listView1.Items.Add(someClient.Name);
            if (someClient.Next != null) PrintMainList(someClient.Next);
        }

        private void ShowMainList()
        {
            listView1.Items.Clear();
            Node firstClient = clientList.Peek();

            if (firstClient != null) 
            {
                PrintMainList(firstClient);
            }
        }

        private void PrintWomenList(Node someClient)
        {
            listView2.Items.Add(someClient.Name);
            if (someClient.Next != null) PrintWomenList(someClient.Next);
        }

        private void ShowWomenList()
        {
            listView2.Items.Clear();
            Node firstClient = womenList.Peek();

            if (firstClient != null)
            {
                PrintWomenList(firstClient);
            }
        }

        private void PrintMenList(Node someClient)
        {
            listView3.Items.Add(someClient.Name);
            if (someClient.Next != null) PrintMenList(someClient.Next);
        }

        private void ShowMenList()
        {
            listView3.Items.Clear();
            Node firstClient = menList.Peek();

            if (firstClient != null)
            {                 
                PrintMenList(firstClient);
            }
        }

        private void DequeueMainList()
        {
            Node toEnqueue = clientList.Dequeue();

            if (toEnqueue.Sex == "MAN")
            {
                menList.Enqueue(toEnqueue);
            } 
            else
            {
                womenList.Enqueue(toEnqueue);
            }

            if (clientList.Peek() != null) DequeueMainList();
        }

        private void EnqueueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") MessageBox.Show("The name is invalid");
                else if (comboBox1.SelectedIndex == -1) MessageBox.Show("No option selected");
                else
                {
                    Node newClient = new Node()
                    {
                        Name = textBox1.Text,
                        Sex = comboBox1.SelectedItem.ToString(),
                    };

                    clientList.Enqueue(newClient);
                    ShowMainList();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientList.Peek() == null) MessageBox.Show("Error, the list is empty");
                else
                {
                    DequeueMainList();
                    ShowMainList();
                    ShowWomenList();
                    ShowMenList();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DequeueWBtn_Click(object sender, EventArgs e)
        {
            try
            {
                womenList.Dequeue();
                ShowWomenList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DequeueMBtn_Click(object sender, EventArgs e)
        {
            try
            {
                menList.Dequeue();
                ShowMenList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

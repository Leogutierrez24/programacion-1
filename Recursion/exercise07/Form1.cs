using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Escribir un función recursiva Aparear(unaLista, otra) -> lista de
    pares (x, y): tal que "x" pertence a "unaLista", e y pertenece a
    "otra". Ejemplo: Aparear([1,2,3], ['a','b','c']) -> [ (1,'a'), (2,'b'),
    (3,'c')]. 
*/

namespace exercise07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MixLists(int[] numbers, char[] chars, int i)
        {
            if(i != 0)
            {
                NewList element = new NewList(numbers[])
            }
        }

        public void CreateNewList(int[] numbers, char[] chars)
        {
            int i = numbers.Length;
            int j = chars.Length;

            

            if (i != j) MessageBox.Show("The lists must have the same length!!!");
            else
            {
                MixLists(numbers, chars, i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string numbers = textBox1.Text;
                string chars = textBox2.Text;
                int[] numberList = numbers.Split(',').Select(element => int.Parse(element)).ToArray();
                char[] charList = chars.ToCharArray();

                CreateNewList(numberList, charList);
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private class NewList
        {
            public NewList(int number, char character)
            {
                this.Number = number;
                this.Character = character;
            }

            public int Number { get; set; }
            public char Character { get; set; }
        }
    }
}

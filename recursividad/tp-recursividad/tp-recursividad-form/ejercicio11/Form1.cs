using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool checkWord(int wordLength, string word, int counter)
        {
            if(counter != wordLength)
            {
                if (word[wordLength] == word[counter])
                {
                    counter++;
                    return checkWord(wordLength - 1, word, counter);
                } else
                {
                    return false;
                }
            } else
            {
                if (word[wordLength] == word[counter]) return true;
                else return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theWord = textBox2.Text;
            bool isPalindrome = checkWord(theWord.Length - 1, theWord, 0);
            if (isPalindrome) textBox1.Text = $"La palabra {theWord} es palíndromo! ! !";
            else textBox1.Text = $"La palabra {theWord} no es palíndromo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

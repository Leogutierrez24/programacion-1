using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Desarrolle un programa que simule el juego del TA-TE-TI */

namespace exercise11
{
    public partial class Form1 : Form
    {
        private int playerTurn = 0;
        private int round = 0;
        private bool endGame = true;

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            endGame = false;
            round++;
        }
        private void EndGame()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            endGame = true;
        }

        private void RestartGame()
        {
            round = 0;
            playerTurn = 0;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            StartGame();
        }

        private void CheckGame()
        {
            string finalMessage = "The winner is: " + (playerTurn == 0 ? "X" : "O");

            if (button1.Text != "" && button1.Text == button2.Text && button1.Text == button3.Text) // first row
            {
                MessageBox.Show(finalMessage);
                EndGame();
            } else if (button4.Text != "" && button4.Text == button5.Text && button4.Text == button6.Text) // second row
            {
                MessageBox.Show(finalMessage);
                EndGame();
            } else if (button7.Text != "" && button7.Text == button8.Text && button7.Text == button9.Text) // third row
            {
                MessageBox.Show(finalMessage);
                EndGame();
            }

            if (button1.Text != "" && button1.Text == button4.Text && button1.Text == button7.Text) // first column
            {
                MessageBox.Show(finalMessage);
                EndGame();
            } else if (button2.Text != "" && button2.Text == button5.Text && button2.Text == button8.Text) // second column
            {
                MessageBox.Show(finalMessage);
                EndGame();
            } else if (button3.Text != "" && button3.Text == button6.Text && button3.Text == button9.Text) // third column
            {
                MessageBox.Show(finalMessage);
                EndGame();
            }

            if (button1.Text != "" && button1.Text == button5.Text && button1.Text == button9.Text) // first diagonal
            {
                MessageBox.Show(finalMessage);
                EndGame();
            }
            else if (button3.Text != "" && button3.Text == button5.Text && button3.Text == button7.Text) // second diagonal
            {
                MessageBox.Show(finalMessage);
                EndGame();
            }

            if (playerTurn == 0) playerTurn++;
            else playerTurn--;

            if (endGame == false && round == 9)
            {
                EndGame();
                MessageBox.Show("It's a draw!!!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0) button1.Text = "X";
            else button1.Text = "O";
            round++;
            button1.Enabled = false;
            CheckGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0) button2.Text = "X";
            else button2.Text = "O";
            round++;
            button2.Enabled = false;
            CheckGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0) button3.Text = "X";
            else button3.Text = "O";
            round++;
            button3.Enabled = false;
            CheckGame();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0) button4.Text = "X";
            else button4.Text = "O";
            round++;
            button4.Enabled = false;
            CheckGame();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0) button5.Text = "X";
            else button5.Text = "O";
            round++;
            button5.Enabled = false;
            CheckGame();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0) button6.Text = "X";
            else button6.Text = "O";
            round++;
            button6.Enabled = false;
            CheckGame();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0) button7.Text = "X";
            else button7.Text = "O";
            round++;
            button7.Enabled = false;
            CheckGame();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0) button8.Text = "X";
            else button8.Text = "O";
            round++;
            button8.Enabled = false;
            CheckGame();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0) button9.Text = "X";
            else button9.Text = "O";
            round++;
            button9.Enabled = false;
            CheckGame();
        }
    }
}

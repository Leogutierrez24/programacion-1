using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Consigna: Desarrolle un programa que simule el juego del TA-TE-TI
 */

namespace lab11
{
    public partial class Form1 : Form
    {
        //player1 => 'X';
        //player2 => 'O';

        int turns = 9;
        int playing = 1;
        int winner = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetButtons();
        }

        public void resetButtons()
        {
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
        }


        public void checkGame()
        {
            checkPlay();
            if(turns == 0)
            {
                MessageBox.Show("Fin del juego!!!");
                endGame();
            }
        }

        public void checkPlay()
        {
            if(button1.Text != "" && button1.Text == button5.Text && button1.Text == button9.Text) // primera diagonal
            {
                if (button1.Text == "X") winner = 1;
                else winner = 2;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                endGame();
            } else if(button3.Text != "" && button3.Text == button5.Text && button3.Text == button7.Text) // segunda diagonal
            {
                if (button3.Text == "X") winner = 1;
                else winner = 2;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                endGame();
            } else if(button1.Text != "" && button1.Text == button2.Text && button1.Text == button3.Text) // primera fila
            {
                if (button1.Text == "X") winner = 1;
                else winner = 2;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                endGame();
            } else if(button4.Text != "" && button4.Text == button5.Text && button4.Text == button6.Text) // segunda fila
            {
                if (button4.Text == "X") winner = 1;
                else winner = 2;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                endGame();
            } else if(button7.Text != "" && button7.Text == button8.Text && button7.Text == button9.Text) // tercer fila
            {
                if (button7.Text == "X") winner = 1;
                else winner = 2;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                endGame();
            } else if(button1.Text != "" && button1.Text == button4.Text && button1.Text == button7.Text) // primera columna
            {
                if (button1.Text == "X") winner = 1;
                else winner = 2;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                endGame();
            } else if(button2.Text != "" && button2.Text == button5.Text && button2.Text == button8.Text) // segunda columna
            {
                if (button2.Text == "X") winner = 1;
                else winner = 2;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                endGame();
            } else if(button3.Text != "" && button3.Text == button6.Text && button3.Text == button9.Text) // tercera columna
            {
                if (button3.Text == "X") winner = 1;
                else winner = 2;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                endGame();
            }
        }

        public void endGame()
        {
            button10.Visible = true;
            label2.Visible = true;

            if (winner == 1) label2.Text = "El ganador es: el jugador 1";
            else if (winner == 2) label2.Text = "El ganador es: el jugador 2";
            else label2.Text = "Empate!!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playing == 1)
            {
                button1.Text = "X";
                playing = 2;
            }
            else
            {
                button1.Text = "O";
                playing = 1;
            }
            button1.Enabled = false;
            turns--;
            checkGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (playing == 1)
            {
                button2.Text = "X";
                playing = 2;
            }
            else
            {
                button2.Text = "O";
                playing = 1;
            }
            button2.Enabled = false;
            turns--;
            checkGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (playing == 1)
            {
                button3.Text = "X";
                playing = 2;
            }
            else
            {
                button3.Text = "O";
                playing = 1;
            }
            button3.Enabled = false;
            turns--;
            checkGame();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (playing == 1)
            {
                button4.Text = "X";
                playing = 2;
            }
            else
            {
                button4.Text = "O";
                playing = 1;
            }
            button4.Enabled = false;
            turns--;
            checkGame();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (playing == 1)
            {
                button5.Text = "X";
                playing = 2;
            }
            else
            {
                button5.Text = "O";
                playing = 1;
            }
            button5.Enabled = false;
            turns--;
            checkGame();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (playing == 1)
            {
                button6.Text = "X";
                playing = 2;
            }
            else
            {
                button6.Text = "O";
                playing = 1;
            }
            button6.Enabled = false;
            turns--;
            checkGame();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (playing == 1)
            {
                button7.Text = "X";
                playing = 2;
            }
            else
            {
                button7.Text = "O";
                playing = 1;
            }
            button7.Enabled = false;
            turns--;
            checkGame();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (playing == 1)
            {
                button8.Text = "X";
                playing = 2;
            }
            else
            {
                button8.Text = "O";
                playing = 1;
            }
            button8.Enabled = false;
            turns--;
            checkGame();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (playing == 1)
            {
                button9.Text = "X";
                playing = 2;
            }
            else
            {
                button9.Text = "O";
                playing = 1;
            }
            button9.Enabled = false;
            turns--;
            checkGame();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            turns = 9;
            playing = 1;
            winner = 0;
            label2.Text = "";
            button10.Visible = false;
            label2.Visible = false;
            resetButtons();
        }
    }
}

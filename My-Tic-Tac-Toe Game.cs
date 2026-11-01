using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course14
{
    public partial class My_Tic_Tac_Toe_Game : Form
    {
        public My_Tic_Tac_Toe_Game()
        {
            InitializeComponent();
        }

        private void MyTicTacToeGame_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(white);
            pen.Width = 5;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Vertical lines
            e.Graphics.DrawLine(pen, 208, 96, 208, 440);
            e.Graphics.DrawLine(pen, 341, 96, 341, 440);

            // Horizontal lines
            e.Graphics.DrawLine(pen, 72, 216, 476, 216);
            e.Graphics.DrawLine(pen, 72, 340, 476, 340);

        }

        enum enPlayers
        {
            player1 = 1,
            player2 = 2,
        }

        enum enElements
        {
            X = 1,
            O = 2,
            questionMark = 3
        }

        enum enWinner
        {
            inProgress = 1,
            player1 = 2,
            player2 = 3,
            draw = 4
        }


        enPlayers currentPlayer = enPlayers.player1;
        enWinner winnerName = enWinner.inProgress;
        bool gameOver = false; 

        private void funcCheckSquareStatus(Button button)
        {
            if (gameOver)
            {
                return;
            }

            if(button.Tag == "?")
            {
                if (currentPlayer == enPlayers.player1)
                {
                    button.Image = Properties.Resources.X;
                    button.Tag = "X";
                }
                else
                {
                    button.Image = Properties.Resources.O;
                    button.Tag = "O";
                }
                funcCheckWinner();
                funcCheckDraw();


                if (!gameOver)
                {
                    funcSwitchPlayers();
                }
            }
            else
            {
                MessageBox.Show("Error Message", "Wrong Choice", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void funcSwitchPlayers()
        {
            if (currentPlayer == enPlayers.player1) {

                currentPlayer = enPlayers.player2;
                labelTurnName.Text = "Player 2";
            }
            else
            {
                currentPlayer = enPlayers.player1;
                labelTurnName.Text = "Player 1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcCheckSquareStatus(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcCheckSquareStatus(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funcCheckSquareStatus(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            funcCheckSquareStatus(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            funcCheckSquareStatus(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            funcCheckSquareStatus(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            funcCheckSquareStatus(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            funcCheckSquareStatus(button8); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            funcCheckSquareStatus(button9);
        }



        private void funcCheckWinner()
        {
            if(button1.Tag != "?" && button1.Tag == button2.Tag && button2.Tag == button3.Tag)
            {
                button1.BackColor = Color.GreenYellow;
                button2.BackColor = Color.GreenYellow;
                button3.BackColor = Color.GreenYellow;
                gameOver = true;
                funcCheckWinnerName(button1);
            }
            if (button4.Tag != "?" && button4.Tag == button5.Tag && button5.Tag == button6.Tag)
            {
                button4.BackColor = Color.GreenYellow;
                button5.BackColor = Color.GreenYellow;
                button6.BackColor = Color.GreenYellow;
                funcCheckWinnerName(button4);
                gameOver = true;
            }
            if (button7.Tag != "?" && button7.Tag == button8.Tag && button8.Tag == button9.Tag)
            {
                button7.BackColor = Color.GreenYellow;
                button8.BackColor = Color.GreenYellow;
                button9.BackColor = Color.GreenYellow;
                gameOver = true;
                funcCheckWinnerName(button7);
            }
            if (button1.Tag != "?" && button1.Tag == button4.Tag && button4.Tag == button7.Tag)
            {
                button1.BackColor = Color.GreenYellow;
                button4.BackColor = Color.GreenYellow;
                button7.BackColor = Color.GreenYellow;
                gameOver = true;
                funcCheckWinnerName(button1);
            }
            if (button2.Tag != "?" && button2.Tag == button5.Tag && button5.Tag == button8.Tag)
            {
                button2.BackColor = Color.GreenYellow;
                button5.BackColor = Color.GreenYellow;
                button8.BackColor = Color.GreenYellow;
                gameOver = true;
                funcCheckWinnerName(button2);
            }
            if (button3.Tag != "?" && button3.Tag == button6.Tag && button6.Tag == button9.Tag)
            {
                button3.BackColor = Color.GreenYellow;
                button6.BackColor = Color.GreenYellow;
                button9.BackColor = Color.GreenYellow;
                gameOver = true;
                funcCheckWinnerName(button3);
            }
            if (button1.Tag != "?" && button1.Tag == button5.Tag && button5.Tag == button9.Tag)
            {
                button1.BackColor = Color.GreenYellow;
                button5.BackColor = Color.GreenYellow;
                button9.BackColor = Color.GreenYellow;
                gameOver = true;
                funcCheckWinnerName(button1);
            }
            if (button3.Tag != "?" && button3.Tag == button5.Tag && button5.Tag == button7.Tag)
            {
                button3.BackColor = Color.GreenYellow;
                button5.BackColor = Color.GreenYellow;
                button7.BackColor = Color.GreenYellow;
                gameOver = true;
                funcCheckWinnerName(button3);
            }
            labelTurnName.Text = "Game Over";
        }


        private void funcCheckWinnerName(Button button)
        {
            if (button.Tag == "X")
            {
                winnerName = enWinner.player1;
                labelInProgress.Text = "Player 1";
            }
            else {

                winnerName = enWinner.player2;
                labelInProgress.Text = "Player 2";
            }
            
        }


        private void funcCheckDraw()
        {
            if (winnerName == enWinner.inProgress &&
                button1.Tag!= "?" &&
                button2.Tag != "?" &&
                button3.Tag != "?" &&
                button4.Tag != "?" &&
                button5.Tag != "?" &&
                button6.Tag != "?" &&
                button7.Tag != "?" &&
                button8.Tag != "?" &&
                button9.Tag != "?" )
            {
                winnerName = enWinner.draw;
                gameOver = true;
                labelInProgress.Text = "Draw";
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            currentPlayer = enPlayers.player1;
            winnerName = enWinner.inProgress;
            gameOver = false;

            labelTurnName.Text = "Player 1";
            labelInProgress.Text = "In Progress";

            button1.Image = Properties.Resources.question_mark_96;
            button2.Image = Properties.Resources.question_mark_96;
            button3.Image = Properties.Resources.question_mark_96;
            button4.Image = Properties.Resources.question_mark_96;
            button5.Image = Properties.Resources.question_mark_96;
            button6.Image = Properties.Resources.question_mark_96;
            button7.Image = Properties.Resources.question_mark_96;
            button8.Image = Properties.Resources.question_mark_96;
            button9.Image = Properties.Resources.question_mark_96;


            button1.Tag = "?";
            button2.Tag = "?";
            button3.Tag = "?";
            button4.Tag = "?";
            button5.Tag = "?";
            button6.Tag = "?";
            button7.Tag = "?";
            button8.Tag = "?";
            button9.Tag = "?";


            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
        }
    }



    }

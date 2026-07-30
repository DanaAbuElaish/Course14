using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course14
{
    public partial class Tic_Tac_Toe_Game_ : Form
    {
        public Tic_Tac_Toe_Game_()
        {
            InitializeComponent();
        }

        enum enPlayers
        {
            player1 ,
            player2 
        }

        enum enCellState
        {
            Empty,
            X,
            O
        }
        
        enum enGameStatus
        {
            InProgress,
            Player1Won,
            Player2Won,
            Draw
        }

        enCellState[] board = new enCellState[10];
        enPlayers currentPlayer;
        enGameStatus gameStatus;


        private bool PlayMove(byte cellNumber)
        {
            
            if (gameStatus != enGameStatus.InProgress) {
                return false;
            }

            enCellState currentCell = board[cellNumber];
            if (currentCell != enCellState.Empty)
            {
                MessageBox.Show("Wrong Choice","Wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
                if (currentPlayer == enPlayers.player1)
                {
                    board[cellNumber] = enCellState.X;
                }

                else
                {
                    board[cellNumber] = enCellState.O;
                }
            if (CheckWinner())
            {
                if (currentPlayer == enPlayers.player1)
                {
                    gameStatus = enGameStatus.Player1Won;
                    labelInProgress.Text = "Player 1";
                   

                }
                else
                {
                    gameStatus = enGameStatus.Player2Won;
                    labelInProgress.Text = "Player 2";
                }
                return true;
            }
            else if (CheckDraw())
            {
                gameStatus = enGameStatus.Draw;
                labelInProgress.Text = "Draw";
            }
            else
            {
                SwitchPlayer();
            }
            return true;
            
        }


        private void SwitchPlayer()
        {
            if (currentPlayer == enPlayers.player1)
            {
                currentPlayer = enPlayers.player2;
                labelTurnName.Text = "Player 2";
            }
            else
            {
                currentPlayer=enPlayers.player1;
                labelTurnName.Text = "Player 1";
            }
        }


        private bool CheckWinner ()
        {
            if (board[1]!=enCellState.Empty && board[1] == board[2] && board[2] == board[3])
            {
                button1.BackColor = Color.FromArgb(57, 255, 20);
                button2.BackColor = Color.FromArgb(57, 255, 20);
                button3.BackColor = Color.FromArgb(57, 255, 20);
                return true;
            }
            if (board[4] != enCellState.Empty && board[4] == board[5] && board[5] == board[6])
            {
                button4.BackColor = Color.FromArgb(57, 255, 20);
                button5.BackColor = Color.FromArgb(57, 255, 20);
                button6.BackColor = Color.FromArgb(57, 255, 20);
                return true;
            }
            if (board[7] != enCellState.Empty && board[7] == board[8] && board[8] == board[9])
            {
                button7.BackColor =Color.FromArgb(57, 255, 20);
                button8.BackColor =Color.FromArgb(57, 255, 20);
                button9.BackColor = Color.FromArgb(57, 255, 20);
                return true;
            }
            if (board[1] != enCellState.Empty && board[1] == board[5] && board[5] == board[9])
            {
                button1.BackColor = Color.FromArgb(57, 255, 20);
                button5.BackColor = Color.FromArgb(57, 255, 20);
                button9.BackColor = Color.FromArgb(57, 255, 20);
                return true;
            }
            if (board[3] != enCellState.Empty && board[3] == board[5] && board[5] == board[7])
            {
                button3.BackColor = Color.FromArgb(57, 255, 20);
                button5.BackColor = Color.FromArgb(57, 255, 20);
                button7.BackColor = Color.FromArgb(57, 255, 20);
                return true;
            }
            if (board[1] != enCellState.Empty && board[1] == board[4] && board[4] == board[7])
            {
                button1.BackColor = Color.FromArgb(57, 255, 20);
                button4.BackColor = Color.FromArgb(57, 255, 20);
                button7.BackColor = Color.FromArgb(57, 255, 20);
                return true;
            }
            if (board[2] != enCellState.Empty && board[2] == board[5] && board[5] == board[8])
            {
                button2.BackColor = Color.FromArgb(57, 255, 20);
                button5.BackColor = Color.FromArgb(57, 255, 20);
                button8.BackColor = Color.FromArgb(57, 255, 20);
                return true;
            }
            if (board[3] != enCellState.Empty && board[3] == board[6] && board[6] == board[9])
            {
                button3.BackColor = Color.FromArgb(57, 255, 20);
                button6.BackColor = Color.FromArgb(57, 255, 20);
                button9.BackColor = Color.FromArgb(57, 255, 20);
                return true;
            }

            return false;
        }

        private bool CheckDraw()
        {
            if (board[1]!=enCellState.Empty && board[2] != enCellState.Empty && board[3] != enCellState.Empty && board[4] != enCellState.Empty && board[5] != enCellState.Empty&& board[6] != enCellState.Empty&& board[7] != enCellState.Empty&& board[8] != enCellState.Empty&& board[9] != enCellState.Empty)
            
                return true;
               else
                return false;
        }


        private void Tic_Tac_Toe_Game__Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(White);
            pen.Width = 5;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 200, 100, 200, 450);
            e.Graphics.DrawLine(pen, 100, 200, 450, 200);
            e.Graphics.DrawLine(pen, 100, 350, 450, 350);
            e.Graphics.DrawLine(pen, 350, 100, 350, 450);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            byte tag = Convert.ToByte(btn.Tag);

            if (PlayMove(tag))
            {
                enCellState cellState = board[tag];
                if (cellState == enCellState.X)
                {
                    btn.BackgroundImage = Properties.Resources.X;
                }else
                {
                    btn.BackgroundImage = Properties.Resources.O;
                }

                if (gameStatus == enGameStatus.Player1Won || gameStatus == enGameStatus.Player2Won)
                {
                    MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (gameStatus == enGameStatus.Draw)
                {
                    MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                }

            }
        }

        private void InitializeGame()
        {
            currentPlayer = enPlayers.player1;
            gameStatus = enGameStatus.InProgress;
           

            for(byte i = 1; i< board.Length; i++)
            {
                board[i] = enCellState.Empty;
            }
            labelTurnName.Text = "Player 1";

            button1.BackgroundImage = Properties.Resources.question_mark_96;
            button2.BackgroundImage = Properties.Resources.question_mark_96;
            button3.BackgroundImage = Properties.Resources.question_mark_96;
            button4.BackgroundImage = Properties.Resources.question_mark_96;
            button5.BackgroundImage = Properties.Resources.question_mark_96;
            button6.BackgroundImage = Properties.Resources.question_mark_96;
            button7.BackgroundImage = Properties.Resources.question_mark_96;
            button8.BackgroundImage = Properties.Resources.question_mark_96;
            button9.BackgroundImage = Properties.Resources.question_mark_96;

            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;

            labelInProgress.Text = "In Progress";
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }
    }
}

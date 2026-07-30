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

        enCellState[] board = new enCellState[10];
        enPlayers currentPlayer;

        private void PlayMove(byte cellNumber)
        {

            enCellState currentCell = board[cellNumber];

            if (currentCell == enCellState.Empty)
            {
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
                    return;
                }
                SwitchPlayer();
            }

            
        }


        private void SwitchPlayer()
        {
            if (currentPlayer == enPlayers.player1)
            {
                currentPlayer = enPlayers.player2;
            }else
            {
                currentPlayer=enPlayers.player1;
            }
        }


        private bool CheckWinner ()
        {
            if (board[1]!=enCellState.Empty && board[1] == board[2] && board[2] == board[3])
            {
                return true;
            }
            if (board[4] != enCellState.Empty && board[4] == board[5] && board[5] == board[6])
            {
                return true;
            }
            if (board[7] != enCellState.Empty && board[7] == board[8] && board[8] == board[9])
            {
                return true;
            }
            if (board[1] != enCellState.Empty && board[1] == board[5] && board[5] == board[9])
            {
                return true;
            }
            if (board[3] != enCellState.Empty && board[3] == board[5] && board[5] == board[7])
            {
                return true;
            }
            if (board[1] != enCellState.Empty && board[1] == board[4] && board[4] == board[7])
            {
                return true;
            }
            if (board[2] != enCellState.Empty && board[2] == board[5] && board[5] == board[8])
            {
                return true;
            }
            if (board[3] != enCellState.Empty && board[3] == board[6] && board[6] == board[9])
            {
                return true;
            }

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

      

       
    }
}

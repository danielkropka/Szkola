using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TicTacToeApp
{
    enum Player
    {
        Nobody,
        Circle,
        Cross
    };

    internal class TicTacToe
    {
        private Player[,] board;
        private Player currentPlayer;
        public Player[,] Board => board;
        public Player CurrentPlayer => currentPlayer;

        public TicTacToe()
        {
            board = new Player[3, 3];
            currentPlayer = Player.Nobody;
        }

        private void resetBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    board[i, j] = Player.Nobody;
            }
        }

        public void StartGame()
        {
            Random rnd = new Random();
            currentPlayer = rnd.Next(1, 3) == 1 ? Player.Circle : Player.Cross;
            resetBoard();
        }

        public void NextPlayer() =>
            currentPlayer = currentPlayer == Player.Circle ? Player.Cross : Player.Circle;
    }
}

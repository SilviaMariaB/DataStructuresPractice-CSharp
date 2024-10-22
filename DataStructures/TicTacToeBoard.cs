using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class TicTacToeBoard
    {
        public void MainTicTacToeBoard()
        {
            char[,] board = new char[,] {
            {'O','X','X' },
            {'X','O','O' },
            {'O','X','X' }
            };

            for (int i = 0; i < board.GetLength(0); i++) //Rows
            {
                for (int j = 0; j < board.GetLength(1); j++) //Columns
                {
                    Console.Write($"| {board[i, j]} ");
                }
                Console.WriteLine("|");
                if (i < board.GetLength(0) - 1)
                {
                    Console.WriteLine("-------------");
                }
            }
            Console.ReadLine();
        }
    }
}

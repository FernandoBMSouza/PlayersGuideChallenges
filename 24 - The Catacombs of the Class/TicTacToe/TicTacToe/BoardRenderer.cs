using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class BoardRenderer
    {
        private char[,] symbols = new char[3, 3];
        public void Draw(Board board)
        {
            for (int i = 0; i < symbols.GetLength(1); i++)
            {
                for (int j = 0; j < symbols.GetLength(0); j++)
                {
                    symbols[i, j] = GetCharacterFor(board.ContentsOf(i, j));
                }
            }
            Console.WriteLine($" {symbols[0, 0]} | {symbols[0, 1]} | {symbols[0, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]}");
        }

        private char GetCharacterFor(Cell cell)
        {
            switch (cell)
            {
                case Cell.X: return 'X'; break;
                case Cell.O: return 'O'; break;
                case Cell.Empty: return ' '; break;
                default: return ' '; break;
            }
        }
    }
}

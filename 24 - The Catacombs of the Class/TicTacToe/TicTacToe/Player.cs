using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        public Cell Symbol { get; }

        public Player(Cell symbol)
        {
            Symbol = symbol;
        }

        public Square PickSquare(Board board)
        {
            while (true)
            {
                Console.Write("Square: ");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();

                Square choice;

                switch (key)
                {
                    case ConsoleKey.NumPad7: choice = new Square(0, 0); break;
                    case ConsoleKey.NumPad8: choice = new Square(0, 1); break;
                    case ConsoleKey.NumPad9: choice = new Square(0, 2); break;
                    case ConsoleKey.NumPad4: choice = new Square(1, 0); break;
                    case ConsoleKey.NumPad5: choice = new Square(1, 1); break;
                    case ConsoleKey.NumPad6: choice = new Square(1, 2); break;
                    case ConsoleKey.NumPad1: choice = new Square(2, 0); break;
                    case ConsoleKey.NumPad2: choice = new Square(2, 1); break;
                    case ConsoleKey.NumPad3: choice = new Square(2, 2); break;
                    default: choice = null; break;
                }

                if (board.isEmpty(choice.Row, choice.Column))
                    return choice;
                else
                    Console.WriteLine("The square is already taken.");
            }
        }
    }
}

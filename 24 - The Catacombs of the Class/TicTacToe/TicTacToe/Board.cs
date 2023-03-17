using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board
    {
        private readonly Cell[,] _cells = new Cell[3, 3];

        public Cell ContentsOf(int row, int column) => _cells[row, column];
        public void FillCell(int row, int column, Cell value) => _cells[row, column] = value;
        public bool isEmpty(int row, int column) => _cells[row, column] == Cell.Empty;
    }
}

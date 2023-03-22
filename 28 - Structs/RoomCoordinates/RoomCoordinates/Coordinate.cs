using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCoordinates
{
    public struct Coordinate
    {
        public int Row { get; }
        public int Column { get; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public static bool AreAdjacent(Coordinate a, Coordinate b)
        {
            int columnChange = a.Column - b.Column;
            int rowChange = a.Row - b.Row;

            if (Math.Abs(columnChange) <= 1 && rowChange == 0) return true;
            if (Math.Abs(rowChange) <= 1 && columnChange == 0) return true;

            return false;
        }
    }
}

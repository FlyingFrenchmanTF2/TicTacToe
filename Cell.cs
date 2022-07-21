using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Cell
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public CellType cellStatus { get; set; } = CellType.Empty;

        public Cell(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal static class Board
    {
        public static Cell[,] MyBoard { get; set; }
        /// <summary>
        /// Generates a 3x3 table
        /// </summary>
        public static void Generate()
        {
            MyBoard = new Cell[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MyBoard[i, j] = new Cell(i, j);
                }
            }
        }
        /// <summary>
        /// Updates the cells of the matrix table with the marker of the related player
        /// </summary>
        /// <param name="coordinates"></param>
        /// <param name="currentMarker"></param>
        public static void Update((int, int) coordinates, CellType currentMarker)
        {
            int positionX, positionY;
            (positionX, positionY) = coordinates;
            MyBoard[positionX, positionY].cellStatus = currentMarker;
        }
        public static bool CheckWinCondition(CellType currentMarker)
        {
            //horizontal check
            if (MyBoard[0, 0].cellStatus == currentMarker && MyBoard[0, 1].cellStatus == currentMarker && MyBoard[0, 2].cellStatus == currentMarker) return true;
            if (MyBoard[1, 0].cellStatus == currentMarker && MyBoard[1, 1].cellStatus == currentMarker && MyBoard[1, 2].cellStatus == currentMarker) return true;
            if (MyBoard[2, 0].cellStatus == currentMarker && MyBoard[2, 1].cellStatus == currentMarker && MyBoard[2, 2].cellStatus == currentMarker) return true;
            //vertical check
            if (MyBoard[0, 0].cellStatus == currentMarker && MyBoard[1, 0].cellStatus == currentMarker && MyBoard[2, 0].cellStatus == currentMarker) return true;
            if (MyBoard[0, 1].cellStatus == currentMarker && MyBoard[1, 1].cellStatus == currentMarker && MyBoard[2, 1].cellStatus == currentMarker) return true;
            if (MyBoard[0, 2].cellStatus == currentMarker && MyBoard[1, 2].cellStatus == currentMarker && MyBoard[2, 2].cellStatus == currentMarker) return true;
            //diagonal check
            if (MyBoard[0, 0].cellStatus == currentMarker && MyBoard[1, 1].cellStatus == currentMarker && MyBoard[2, 2].cellStatus == currentMarker) return true;
            if (MyBoard[0, 2].cellStatus == currentMarker && MyBoard[1, 1].cellStatus == currentMarker && MyBoard[2, 0].cellStatus == currentMarker) return true;
            return false;
        }

        public static void Draw()
        {
            char Cell00 = GetChar(MyBoard[0, 0]);
            char Cell01 = GetChar(MyBoard[0, 1]);
            char Cell02 = GetChar(MyBoard[0, 2]);
            char Cell10 = GetChar(MyBoard[1, 0]);
            char Cell11 = GetChar(MyBoard[1, 1]);
            char Cell12 = GetChar(MyBoard[1, 2]);
            char Cell20 = GetChar(MyBoard[2, 0]);
            char Cell21 = GetChar(MyBoard[2, 1]);
            char Cell22 = GetChar(MyBoard[2, 2]);

            Console.WriteLine($" {Cell00} | {Cell01} | {Cell02} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {Cell10} | {Cell11} | {Cell12} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {Cell20} | {Cell21} | {Cell22} ");
        }

        private static char GetChar(Cell MyBoard)
        {
            char cellChar;
            cellChar = MyBoard.cellStatus switch
            {
                CellType.Empty => ' ',
                CellType.X => 'X',
                CellType.O => 'O',
            };
            return cellChar;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        public (int, int) GetMove()
        {
            while (true)
            {
                Console.WriteLine("Where do you want to place the marker?");
                char input = Convert.ToChar(Console.ReadLine());
                (int, int) choice = input switch
                {
                    '1' => (0, 0),
                    '2' => (0, 1),
                    '3' => (0, 2),
                    '4' => (1, 0),
                    '5' => (1, 1),
                    '6' => (1, 2),
                    '7' => (2, 0),
                    '8' => (2, 1),
                    '9' => (2, 2),
                };
                int positionX, positionY;
                (positionX, positionY) = choice;
                if (Board.MyBoard[positionX, positionY].cellStatus == CellType.Empty )
                {
                    return choice;
                }
                Console.WriteLine("Invalid move");
            }
            
        }
    }
}

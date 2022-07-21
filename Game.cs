using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        public static void Start()
        {
            Board.Generate();
            Player player = new Player();
            CellType currentMarker;
            int turns = 1;
            while (turns < 10)
            {
                Console.Clear();
                if (turns % 2 == 0)
                {
                    currentMarker = CellType.X;
                } 
                else
                {
                    currentMarker = CellType.O;
                }

                Console.WriteLine($"Player {currentMarker} turn");
                Board.Draw();
                (int, int) choice = player.GetMove();
                Board.Update(choice, currentMarker);
                if (Board.CheckWinCondition(currentMarker))
                {
                    Console.Clear();
                    Console.WriteLine($"Player {currentMarker} wins");
                    Board.Draw();
                    return;
                };
                turns++;
            }
            Console.Clear();
            Console.WriteLine("Draw!");
            Board.Draw();
        }

    }
}

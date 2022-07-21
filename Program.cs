namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tic-Tac-Toe";
            Console.WriteLine("This is Tic-Tac-Toe, use 1 - 9 to play");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Game.Start();
        }
    }
}
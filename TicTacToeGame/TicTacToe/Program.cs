using System;
using TicTacToe.Players;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TicTacToeGame(new ConsolePlayer(), new ConsolePlayer());
            var result = game.Play();

            
            Console.WriteLine("Game over!");
            Console.WriteLine($"Winner: {result.Winner}");
            Console.WriteLine("Final Table View!");
            Console.WriteLine(result.Board.ToString());
            Console.ReadLine();
        }
    }
}

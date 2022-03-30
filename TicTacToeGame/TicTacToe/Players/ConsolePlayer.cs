using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe.Players
{
    public class ConsolePlayer : IPlayer
    {
        public Index Play(Board board, Symbol symbol)
        {
            Console.WriteLine(board.ToString());
            Index position;
            while (true)
            {
                Console.Write($"You play with this symbol -> {symbol} \nPlease enter position: ");
                var line = Console.ReadLine();
                try
                {
                    position = new Index(line);
                }
                catch
                {
                    Console.WriteLine("Invalid position!");
                    continue;
                }

                if (!board.GetEmptyPositions().Any(x => x.Equals(position)))
                {
                    Console.WriteLine("This position in not avalibe!");
                    continue;
                }
                break;

            }

            return position;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe.Players
{
    public class RandomPlayer : IPlayer
    {
        private Random random;

        public RandomPlayer()
        {
            this.random = new Random();
        }

        public Index Play(Board board, Symbol symbol)
        {
            var avalibePositions = board.GetEmptyPositions().ToList();
            return avalibePositions[random.Next(0, avalibePositions.Count)];

        }
    }
}

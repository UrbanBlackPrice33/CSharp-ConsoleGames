using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Players;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public TicTacToeGame(IPlayer firstPlayer, IPlayer secondPlayer)
        {
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
        }

        public IPlayer FirstPlayer { get; }
        public IPlayer SecondPlayer { get; }

        public GameResult Play()
        {
            Board board = new Board();
            IPlayer currentPlayer = this.FirstPlayer;
            Symbol symbol = Symbol.X;
            while (!IsGameOver(board))
            {
                var move = currentPlayer.Play(board,symbol);
                board.PlaceSymbol(move, symbol);

                if (currentPlayer == this.FirstPlayer)
                {
                    currentPlayer = this.SecondPlayer;
                    symbol = Symbol.O;
                }
                else
                {
                    currentPlayer = this.FirstPlayer;
                    symbol = Symbol.X;
                }
            }
            var winner = GetWinner(board);
            return new GameResult(winner,board);
        }

        private bool IsGameOver(Board board)
        {
            for (int row = 0; row < board.Rows; row++)
            {
                if (board.GetRowSymbol(row) != Symbol.None)
                {
                    return true;
                }
            }

            for (int col = 0; col < board.Rows; col++)
            {
                if (board.GetColumnSymbol(col) != Symbol.None)
                {
                    return true;
                }
            }

            if (board.GetDiagonalTLBRSymbol() != Symbol.None)
            {
                return true;
            }

            if (board.GetDiagonalTRBLSymbol() != Symbol.None)
            {
                return true;
            }

            if(board.IsFull())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Symbol GetWinner(Board board)
        {
            for (int row = 0; row < board.Rows; row++)
            {
                var winner = board.GetRowSymbol(row);
                if (winner != Symbol.None)
                {
                    return winner;
                }
            }

            for (int col = 0; col < board.Rows; col++)
            {
                var winner = board.GetColumnSymbol(col);
                if (winner != Symbol.None)
                {
                    return winner;
                }
            }

            var diagonal1 = board.GetDiagonalTLBRSymbol();
            if (diagonal1 != Symbol.None)
            {
                return diagonal1;
            }

            var diaginal2 = board.GetDiagonalTRBLSymbol();
            if (diaginal2 != Symbol.None)
            {
                return diaginal2;
            }

            return Symbol.None;
           
        }
    }
}

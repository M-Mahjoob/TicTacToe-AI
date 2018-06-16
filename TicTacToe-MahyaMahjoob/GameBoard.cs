using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_MahyaMahjoob
{
    public enum Player
    {
        X = 1,
        O = -1,
        Open = 0,
    }
    public abstract class GameBoard
    {
        public Player[,] squares;
        public abstract Player this[int x, int y] { get; set; }
        public abstract bool IsFull { get; }
        public abstract int Size { get; }
    }
}

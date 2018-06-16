using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_MahyaMahjoob
{
    class TicTacToeBoard : GameBoard
    {
        public TicTacToeBoard()
        {
            squares = new Player[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        }
        public override int Size { get { return 9; } }
        public override Player this[int x, int y]
        {
            get
            {
                return squares[x, y];
            }

            set
            {
                squares[x, y] = value;
            }
        }

    }
}

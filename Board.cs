using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourEx2
{
    public class Board 
    {
        public int[,] board;
        public const int DIMENSION = 8;
        
        void ChessBoard()
        {
            board = new int[DIMENSION, DIMENSION];      
        }
    }
}

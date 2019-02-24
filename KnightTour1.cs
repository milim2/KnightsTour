using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourEx2
{
    public partial class KnightTour : Board, PrintInterface1
    {
        public  void PrintMovement()
        {
            Console.WriteLine();
            
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    Console.Write("{0, 4}", board[row, col]);                 
                }
                Console.WriteLine();
            }
        }
    }
}

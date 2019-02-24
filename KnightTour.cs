

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourEx2
{
    public partial class KnightTour 
    {
        int[] row = { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] col = { -1, -2, -2, -1, 1, 2, 2, 1 };

        int curRow;
        int curCol;
        bool gameOver = false;

        public virtual void Movement()
        {
            int move = 0;
            board = new int[8, 8]; // board size

            // next row position
            int nextRow;
            // next column position
            int nextCol;
            // input from user
            InputLoc();

            Console.WriteLine("How many trials do you want? (1-5)");
            int t = Convert.ToInt32(Console.ReadLine());
            int z = 1;
            while (z <= t)
            {
                // movement
                board[curRow, curCol] = move++;
                // The game will be continued as long as there is a space to move to next step
                while (!gameOver)
                {
                    bool spaceMove = false;
                    for (int i = 0; i < 8 && !spaceMove; i++)
                    {
                        nextRow = curRow + row[i];
                        nextCol = curCol + col[i];

                        spaceMove = ValidMove(nextRow, nextCol);

                        if (spaceMove)
                        {
                            curRow = nextRow;
                            curCol = nextCol;
                            board[curRow, curCol] = ++move;
                        }
                    }

                    if (!spaceMove || move == 64)
                        gameOver = true;
                }

                Console.WriteLine("Trial {0}: The knight was able to successfully touch {1} squares.", z, move);
                z++;
                if (move == 64)
                {
                    Console.WriteLine("Knight's tour was fully reached!!!");
                    Console.WriteLine();
                }
            }
            PrintMovement();

            bool ValidMove(int next_row, int next_col)
            {
                return (next_row >= 0 && next_row < 8 && next_col >= 0 && next_col < 8 && board[next_row, next_col] == 0);
            }

        }

        public virtual void InputLoc()
        {
            Console.Write("Enter Target's X axis for the knight(0-7): ");
            string strRow = Console.ReadLine();

            Console.Write("Enter Target's Y axis for the knight(0-7): ");
            string strCol = Console.ReadLine();

            curRow = Convert.ToInt32(strRow);
            curCol = Convert.ToInt32(strCol);
            bool chk = true;
            chk = ValidChk(curRow, curCol);
            if (!chk)
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("Enter valid type of the number from 0 - 7 !!!");
                Console.WriteLine("************************************************");
                Console.WriteLine();
                InputLoc();
            }

            bool ValidChk(int curRow, int curCol)
            {
                return (curRow >= 0 && curRow < 8 && curCol >= 0 && curCol < 8 && board[curRow, curCol] == 0);
            }
        }

       
    }
}


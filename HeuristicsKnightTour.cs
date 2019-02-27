/*****************************************
 * Date : 2019-02-20                     *
 * Class : web services Using .NET & C#  *
 * Professor : Dario Guiao               *
 * File : HeuristicsKnightTour.cs        *
 * Name : Milim Lee (991274533)          *
 *****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourEx2
{
    class HeuristicsKnightTour : KnightTour, PrintInterface1
    {
       // int[,] board;
        int[,] matrix =
        {
            { 2, 3, 4, 4, 4, 4, 3, 2},
            { 3, 4, 6, 6, 6, 6, 4, 3},
            { 4, 6, 8, 8, 8, 8, 6, 4 },
            { 4, 6, 8, 8, 8, 8, 6, 4 },
            { 4, 6, 8, 8, 8, 8, 6, 4 },
            { 4, 6, 8, 8, 8, 8, 6, 4 },
            { 3, 4, 6, 6, 6, 6, 4, 3 },
            { 2, 3, 4, 4, 4, 4, 3, 2 }
        };

        public int curRow { get; set; } = 0;
        public int curCol { get; set; } = 0;
        int[] row = { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] col = { -1, -2, -2, -1, 1, 2, 2, 1 };
        int num;
       
        public override void Movement()
        {
            int move = 0;
            // row position
            int nextRow;
            // column position
            int nextCol;
            bool gameOver = false;

            board = new int[8, 8];
            int minRow = -2;
            int minCol = -2;

            InputLoc();

            // movement
            board[curRow, curCol] = move++;
            int z = 1;
            // The game will be continued as long as there is a space to move to next step
            while (!gameOver)
            {
                num = 100;
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    nextRow = curRow + row[i];
                    nextCol = curCol + col[i];

                    if (ValidMove(nextRow, nextCol))
                    {
                        if (matrix[nextRow, nextCol] < num)
                        {
                            num = matrix[nextRow, nextCol];
                            minRow = nextRow;
                            minCol = nextCol;
                        }
                        else if (matrix[nextRow, nextCol] == num)
                        {
                            int lowerNum = NextMove(nextRow, nextCol);
                            int lowerMinNum = NextMove(minRow, minCol);
                            // next move
                            if (lowerNum <= lowerMinNum)
                            {
                                num = matrix[nextRow, nextCol];
                                // minimum values
                                minRow = nextRow;
                                minCol = nextCol;
                            }
                        }
                        matrix[nextRow, nextCol]--;
                    }
                }

                if (num == 100)
                    gameOver = true;
                else
                {
                    // move
                    curRow = minRow;
                    curCol = minCol;
                    board[curRow, curCol] = ++move;
                }
            }
            Console.WriteLine("Trial {0}: The knight was able to successfully touch {1} squares.", z, move);
            z++;
           PrintMovement();
        }

        public override void InputLoc()
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

        public int NextMove(int irow, int icol)
        {
            int nmRow;
            int nmCol;
            int nmNum = num;
            int[,] nmboard = new int[8, 8];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    nmboard[i, j] = matrix[i, j];
                }
            }
            for (int k = 0; k < board.GetLength(0); k++)
            {
                nmRow = irow + row[k];
                nmCol = icol + col[k];


                if (ValidMove(nmRow, nmCol))
                {
                    if (matrix[nmRow, nmCol] < nmNum)
                    {
                        nmNum = nmboard[nmRow, nmCol];
                    }

                    nmboard[nmRow, nmCol]--;
                }
            }
            return nmNum;
        }

        public bool ValidMove(int next_row, int next_col)
        {
            return (next_row >= 0 && next_row < 8 && next_col >= 0 && next_col < 8 && board[next_row, next_col] == 0);
        }

        public void PrintMovement()
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


# Knight's Tour - Non-intelligent Method

: The knight makes L-shaped moves
: from a square in the middle of an empty chessboard, 
  the knight can make eight different moves (0 through 7) 
: The board is represented by an 8-by-8 two-dimensional array
        <row>             <column>
	horizontal[0] = 2	vertical[0] = -1
	horizontal[1] = 1	vertical[1] = -2
	horizontal[2] = -1	vertical[2] = -2
	horizontal[3] = -2	vertical[3] = -1
	horizontal[4] = -2	vertical[4] = 1
	horizontal[5] = -1	vertical[5] = 2
	horizontal[6] = 1	vertical[6] = 2
	horizontal[7] = 2	vertical[7] = 1

## Solution
: variables curRow, curCol - the knight's current position
  Checking the validation of input number by a user

: [i] represents  the knight's movement to reach for the next location which is between 0 and 7
	nextRow = curRow + row[i];
    nextCol = curCol + col[i];

: movement counter is from 1 to 64
  if there is no available space or the movement becomes 64 --> game over

: Before moving to next position, check available space to move which is not visited
   // using ValidMove method, checking validation
   spaceMove = ValidMove(nextRow, nextCol); 

: To track the knight's tour, using PrintMovement method

## Files
KnightTour (3 files) = partial class, properities, 
                       inheritance from Board.cs and PrintInterface1.cs
Interface1 (1 file) = PrintInterface1
Board (1 file) = parent 
Program  = Main
ReadMe   = MilimLeeNonIntelligentMethod.txt

## OUTPUT

Enter Target's X axis for the knight(0-7): 2
Enter Target's Y axis for the knight(0-7): 3
How many trials do you want? (1-5)
1
Trial 1: The knight was able to successfully touch 41 squares.

   6  25  40  15   0  27   0   0
   
  41  14   7  26  39   0   0   0
  
  24   5  16   0  28   0   0   0
  
  13   8  23  38   0  30   0   0
  
  4  17   2  29  22  37   0   0
  
  9  12  19  34  31   0   0   0
  
  18   3  10  21  36  33   0   0
  
  11  20  35  32   0   0   0   0

  ============================================================















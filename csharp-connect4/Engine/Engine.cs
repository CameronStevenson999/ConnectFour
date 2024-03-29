using System;

namespace csharp_connect4
{
    public class Engine
    {
        public int NUMBER_OF_ROWS;
        public int NUMBER_OF_COLUMNS;
        
        const int DEFAULT_NUMBER_OF_ROWS = 6, DEFAULT_NUMBER_OF_COLUMNS = 7;
        const char EMPTY = '0', PLAYER1 = '1', PLAYER2 = '2';

        private char[,] grid;

        int pieceCount;

        public Engine()
        {
            GetGameBoardDimensions();
            BuildGameBoard(NUMBER_OF_ROWS, NUMBER_OF_COLUMNS);
            DisplayGrid(NUMBER_OF_ROWS, NUMBER_OF_COLUMNS);
        }

        private void GetGameBoardDimensions()
        {            
            bool IsValidRows = false;
            bool IsValidColumns = false;
            //string strInput = Console.ReadLine();
            //int result = 0;
            //int numberOfRows = 0;
            //int numberOfColumns = 0;

            // Console.WriteLine("Please enter the board dimensions (number of rows, number of columns) separated by a space.");
            //Console.WriteLine("Please enter the board dimensions (number of rows, number of columns)");

            while (!IsValidRows && !IsValidColumns)
            {
                Console.WriteLine("Please enter the board dimensions (number of rows, number of columns) separated by a space.");
                
                string[] boardDimensions = Console.ReadLine().Split();

                if (boardDimensions.Length != 2)
                {
                    Console.WriteLine("Please enter row and column values correctly.");
                    IsValidRows = false;
                    IsValidColumns = false;
                }
                else if (int.TryParse(boardDimensions[0], out NUMBER_OF_ROWS)
                        && int.TryParse(boardDimensions[1], out NUMBER_OF_COLUMNS))
                {
                    if (NUMBER_OF_ROWS < 4 || NUMBER_OF_ROWS > 60 
                        || NUMBER_OF_COLUMNS < 4 || NUMBER_OF_COLUMNS > 60)
                    {
                        Console.WriteLine("You chose a number that will create invalid board dimensions");
                        Console.WriteLine("The dimensions need to be between 4 and 60");
                        IsValidRows = false;
                        IsValidColumns = false;
                    }
                    else
                    {
                        IsValidRows = true;
                        IsValidColumns = true;
                    }
                }
            }
        }

        private void BuildGameBoard(int numRows, int numCols)
        {
            grid = new char[NUMBER_OF_ROWS, NUMBER_OF_COLUMNS];

            for (int y = 0; y < NUMBER_OF_ROWS; y++)
                for(int x = 0; x < NUMBER_OF_COLUMNS; x++)
                    grid[y, x] = EMPTY;
        }

        public void DisplayGrid(int numRows, int numCols)
        {
            // grid = new char[numRows, numCols];

            // for (int y = 0; y < numRows; y++)
            //     for(int x = 0; x < numCols; x++)
            //         grid[y, x] = EMPTY;

            for (int y = 0; y < numRows; y++) {
                for (int x = 0; x < numCols; x++) {
                    Console.Write(grid[y, x]);
                    Console.Write(' ');
                }
                Console.Write('\n');
            } 
        }
        public void DisplayGridDefault()
        {
            grid = new char[NUMBER_OF_ROWS, NUMBER_OF_COLUMNS];

            for (int y = 0; y < NUMBER_OF_ROWS; y++)
                for(int x = 0; x < NUMBER_OF_COLUMNS; x++)
                    grid[y, x] = EMPTY;

            for (int y = 0; y < NUMBER_OF_ROWS; y++) {
                for (int x = 0; x < NUMBER_OF_COLUMNS; x++) {
                    Console.Write(grid[y, x]);
                    Console.Write(' ');
                }
                Console.Write('\n');
            } 
        }

        // Returns true if the piece can be dropped in that column.
        public bool DropPieceInGrid(char player, int column)
        {
            column--;

            if (grid[0, column] != EMPTY)
                return false;

            for (int y = 0; y < NUMBER_OF_ROWS; y++) {
                if ((y == NUMBER_OF_ROWS - 1) || (grid[y + 1, column] != EMPTY)) {
                    grid[y, column] = player;
                    break;
                }
            }

            pieceCount++;
            return true;
        }

        public bool FourInARow(char player)
        {
            // Horizontal check:

            for (int y = 0; y < NUMBER_OF_ROWS; y++)
                for (int x = 0; x < 4; x++)
                    if (grid[y, x] == player && grid[y, x + 1] == player)
                        if (grid[y, x + 2] == player && grid[y, x + 3] == player)
                            return true;

            // Vertical check:

            for (int y = 0; y < 3; y++)
                for (int x = 0; x < NUMBER_OF_COLUMNS; x++)
                    if (grid[y, x] == player && grid[y + 1, x] == player)
                        if (grid[y + 2, x] == player && grid[y + 3, x] == player)
                            return true;

            // Diagonal check:

            for (int y = 0; y < 3; y++) {
                for (int x = 0; x < NUMBER_OF_COLUMNS; x++) {

                    if (grid[y, x] == player) {

                        // Diagonally left:
                        try {
                            if (grid[y + 1, x - 1] == player) {
                                if (grid[y + 2, x - 2] == player)
                                    if (grid[y + 3, x - 3] == player)
                                        return true;
                            }
                        }
                        catch (IndexOutOfRangeException) {}

                        // Diagonally right:
                        try {
                            if (grid[y + 1, x + 1] == player) {
                                if (grid[y + 2, x + 2] == player)
                                    if (grid[y + 3, x + 3] == player)
                                        return true;
                            }
                        }
                        catch (IndexOutOfRangeException) {}
                    }
                }
            }

            return false;
        }

        public bool GridIsFull()
        {
            return pieceCount >= NUMBER_OF_ROWS * NUMBER_OF_COLUMNS;
        }
    }
}
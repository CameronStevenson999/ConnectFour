using System;

namespace csharp_connect4
{
    public class Game
    {
    
        public void StartGame()
        {
            Engine myNewEngine = new Engine();
            Console.WriteLine("Please enter the board dimensions (number of rows, number of columns)");
            
            string strInput = Console.ReadLine();
            int result = 0;
            int numberOfRows = 0;
            int numberOfColumns = 0;

            
            while (strInput != "quit")
            {
                if (int.TryParse(strInput, out result))
                {
                    if ((result > 60) || (result < 4))
                    {
                        Console.WriteLine("You chose a number that will create invalid board dimensions");
                        Console.WriteLine("The dimensions need to be between 4 and 60");
                    }
                    numberOfRows = result;
                }
                else
                {
                    Console.WriteLine("Your input ({0}) is not a number", strInput);
                }
                Console.WriteLine("Please enter the next number");
                strInput = Console.ReadLine();
            }


            Console.WriteLine("Please enter the number of columns");
            
            strInput = Console.ReadLine();
            while (strInput != "quit")
            {
                if (int.TryParse(strInput, out result))
                {
                    if ((result > 60) || (result < 4))
                    {
                        Console.WriteLine("You chose a number that will create invalid board dimensions");
                        Console.WriteLine("The dimensions need to be between 4 and 60");
                    }
                    numberOfColumns = result;
                }
                else
                {
                    Console.WriteLine("Your input ({0}) is not a number", strInput);
                }
                Console.WriteLine("Please enter the next number");
                strInput = Console.ReadLine();
            }

            myNewEngine.DisplayGrid(numberOfRows, numberOfColumns);
        }

        // I am reading in 2 integers from the console
        // This is required for setting up the board dimensions
        public void StartGameCleanCode() 
        {
            Engine myNewEngine = new Engine();
            NextPlayersTurn(myNewEngine);
        }

        static void NextPlayersTurn(Engine nextTurnEngine)
        {
            char player = '1';

            int column;
            bool gameLoop = true;
            bool inputLoop;

            while (gameLoop)
            {
                //nextTurnEngine.DisplayGrid(nextTurnEngine.NUMBER_OF_ROWS, nextTurnEngine.NUMBER_OF_COLUMNS);

                do {
                    inputLoop = true;
                    Console.Write("\nPlayer ");
                    Console.Write(player);
                    Console.Write(": ");

                    if (Int32.TryParse(Console.ReadLine(), out column)) {
                        if (1 <= column && column <= nextTurnEngine.NUMBER_OF_COLUMNS) {
                            // if (game.DropPieceInGrid(player, column)) {
                            //     inputLoop = false;
                            // }
                            // else {
                            //     System.Console.Clear();
                            //     game.DisplayGrid();
                            //     Console.WriteLine("\nThat column is full.");
                            // }
                            Console.WriteLine("\nCorrect move.");
                            nextTurnEngine.DisplayGrid(nextTurnEngine.NUMBER_OF_ROWS, nextTurnEngine.NUMBER_OF_COLUMNS);
                        }
                        else {
                            //System.Console.Clear();
                            Console.WriteLine($"\nThe integer must be between 1 and {nextTurnEngine.NUMBER_OF_COLUMNS}.");
                            nextTurnEngine.DisplayGrid(nextTurnEngine.NUMBER_OF_ROWS, nextTurnEngine.NUMBER_OF_COLUMNS);
                        }
                    }
                    else {
                        //System.Console.Clear();
                        Console.WriteLine("\nPlease enter an integer.");
                        nextTurnEngine.DisplayGrid(nextTurnEngine.NUMBER_OF_ROWS, nextTurnEngine.NUMBER_OF_COLUMNS);
                        
                        Console.WriteLine("\nExiting game.");
                        gameLoop = false;
                        inputLoop = false;
                    }                    
                } while (inputLoop);
            }

            Console.ReadKey();
        }

        // static void SetupGameBoardDimensions()
        // {
        //     Engine myNewEngine = new Engine();
        //     bool IsValidRows = false;
        //     bool IsValidColumns = false;
        //     //string strInput = Console.ReadLine();
        //     //int result = 0;
        //     int numberOfRows = 0;
        //     int numberOfColumns = 0;

        //     // Console.WriteLine("Please enter the board dimensions (number of rows, number of columns) separated by a space.");
        //     //Console.WriteLine("Please enter the board dimensions (number of rows, number of columns)");

        //     while (!IsValidRows && !IsValidColumns)
        //     {
        //         Console.WriteLine("Please enter the board dimensions (number of rows, number of columns) separated by a space.");
                
        //         string[] boardDimensions = Console.ReadLine().Split();

        //         if (boardDimensions.Length != 2)
        //         {
        //             Console.WriteLine("Please enter row and column values correctly.");
        //             IsValidRows = false;
        //             IsValidColumns = false;
        //         }
        //         else if (int.TryParse(boardDimensions[0], out numberOfRows)
        //                 && int.TryParse(boardDimensions[1], out numberOfColumns))
        //         {
        //             if (numberOfRows < 4 || numberOfRows > 60 
        //                 || numberOfColumns < 4 || numberOfColumns > 60)
        //             {
        //                 Console.WriteLine("You chose a number that will create invalid board dimensions");
        //                 Console.WriteLine("The dimensions need to be between 4 and 60");
        //                 IsValidRows = false;
        //                 IsValidColumns = false;
        //             }
        //             else
        //             {
        //                 IsValidRows = true;
        //                 IsValidColumns = true;
        //             }
        //         }
        //     }

        //     myNewEngine.DisplayGrid(numberOfRows, numberOfColumns);
        // }
    
        public string ReturnMessage()
        {
            return "Happy coding!";
        }
    }

}
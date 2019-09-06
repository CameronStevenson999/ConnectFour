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
            SetupGameBoardDimensions();
        }

        static void SetupGameBoardDimensions()
        {
            Engine myNewEngine = new Engine();
            bool IsValidRows = false;
            bool IsValidColumns = false;
            //string strInput = Console.ReadLine();
            //int result = 0;
            int numberOfRows = 0;
            int numberOfColumns = 0;

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
                else if (int.TryParse(boardDimensions[0], out numberOfRows)
                        && int.TryParse(boardDimensions[1], out numberOfColumns))
                {
                    if (numberOfRows < 4 || numberOfRows > 60 
                        || numberOfColumns < 4 || numberOfColumns > 60)
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

            myNewEngine.DisplayGrid(numberOfRows, numberOfColumns);
        }
    
        public string ReturnMessage()
        {
            return "Happy coding!";
        }
    }

}
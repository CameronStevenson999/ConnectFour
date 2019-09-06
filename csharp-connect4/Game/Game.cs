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
            Console.WriteLine("Please enter the board dimensions (number of rows, number of columns)");
            
            string strInput = Console.ReadLine();
            int result = 0;
            int numberOfRows = 0;
            int numberOfColumns = 0;

            while (!)
            
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

        static void SetupGameBoardDimensions()
        {
            bool IsValid = false;
            //string strInput = Console.ReadLine();
            int result = 0;
            int numberOfRows = 0;
            int numberOfColumns = 0;

            Console.WriteLine("Please enter the board dimensions (number of rows, number of columns) separated by a space.");
            //Console.WriteLine("Please enter the board dimensions (number of rows, number of columns)");

            while (!IsValid)
            {
                string[] boardDimensions = Console.ReadLine().Split();

                if (boardDimensions.Length != 2)
                {
                    Console.WriteLine("Please enter row and column values correctly.");
                    IsValid = false;
                }
                else if (int.TryParse(boardDimensions[0], out numberOfRows))
                {
                    if (numberOfRows < 4 || numberOfRows > 60)
                    {
                        Console.WriteLine("You chose a number that will create invalid board dimensions");
                        Console.WriteLine("The dimensions need to be between 4 and 60");
                        IsValid = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number: Value of 'N' Should be greater than 1 and lessthan 10000.");
                    return false;
                }

                if (int.TryParse(NK[1], out K))
                {
                    Console.WriteLine("Enter all elements Separated by space.");
                    string[] kElements = Console.ReadLine().Split();

                    for (int i = 0; i < kElements.Length; i++)
                    {
                        int ele;

                        if (int.TryParse(kElements[i], out ele))
                        {
                            if (ele < -99999 || ele > 99999)
                            {
                                Console.WriteLine("Invalid Range( " + kElements[i] + "): Element value should be Between -99999 and 99999.");
                                return false;
                            }

                            dicElements.Add(i, ele);
                        }
                        else
                        {
                            Console.WriteLine("Invalid number( " + kElements[i] + "): Element value should be Between -99999 and 99999.");
                            return false;
                        }
                    }
                    }

                }
                else
                {
                    Console.WriteLine(" Invalid number ,Value of 'K'.");
                    return false;
                }
            }
        }
        public string ReturnMessage()
        {
            return "Happy coding!";
        }
    }

}
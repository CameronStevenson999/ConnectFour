using System;

namespace csharp_connect4
{
    public class Game
    {

        public Engine engine;
        public Game(Engine newEngine)
        {
            engine = newEngine;
        }
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
            NextPlayersTurn();
        }

        void NextPlayersTurn()
        {
            char player = '1';

            int column;
            bool gameLoop = true;
            bool inputLoop;

            while (gameLoop)
            {
                do {
                    inputLoop = true;
                    Console.Write("\nPlayer ");
                    Console.Write(player);
                    Console.Write(": ");

                    var userInput = Console.ReadLine();

                    if (IsInputCorrect(userInput))
                    {
                        column = 4; // Error here -- need to get column integer correctly
                        engine.DropPieceInGrid(player, column);
                        inputLoop = false;
                        gameLoop = false; // remove this when implemented correctly
                    }
                                        
                } while (inputLoop);
            }

            Console.ReadKey();
        }

        bool IsInputCorrect(string userInput)
        {
            int column;
            if (Int32.TryParse(Console.ReadLine(), out column)) 
            {
                if (1 <= column && column <= engine.NUMBER_OF_COLUMNS) 
                {
                    DisplayGridWithMessage("\nCorrect move.");
                    return true;
                }
                else {
                    DisplayGridWithMessage($"\nThe integer must be between 1 and {engine.NUMBER_OF_COLUMNS}.");
                    //engine.DisplayGrid(engine.NUMBER_OF_ROWS, engine.NUMBER_OF_COLUMNS);
                }
            }
            else {
                //System.Console.Clear();
                //Console.WriteLine("\nPlease enter an integer.");
                DisplayGridWithMessage("\nPlease enter an integer.");
                //engine.DisplayGrid(engine.NUMBER_OF_ROWS, engine.NUMBER_OF_COLUMNS);
                
                Console.WriteLine("\nExiting game.");
            }
            return false;
        }
        void NextPlayersTurnOldCode()
        {
            char player = '1';

            int column;
            bool gameLoop = true;
            bool inputLoop;

            while (gameLoop)
            {
                do {
                    inputLoop = true;
                    Console.Write("\nPlayer ");
                    Console.Write(player);
                    Console.Write(": ");

                    if (Int32.TryParse(Console.ReadLine(), out column)) {
                        if (1 <= column && column <= engine.NUMBER_OF_COLUMNS) {
                            // if (game.DropPieceInGrid(player, column)) {
                            //     inputLoop = false;
                            // }
                            // else {
                            //     System.Console.Clear();
                            //     game.DisplayGrid();
                            //     Console.WriteLine("\nThat column is full.");
                            // }
                            DisplayGridWithMessage("\nCorrect move.");
                            engine.DisplayGrid(engine.NUMBER_OF_ROWS, engine.NUMBER_OF_COLUMNS);
                        }
                        else {
                            //System.Console.Clear();
                            Console.WriteLine($"\nThe integer must be between 1 and {engine.NUMBER_OF_COLUMNS}.");
                            engine.DisplayGrid(engine.NUMBER_OF_ROWS, engine.NUMBER_OF_COLUMNS);
                        }
                    }
                    else {
                        //System.Console.Clear();
                        Console.WriteLine("\nPlease enter an integer.");
                        engine.DisplayGrid(engine.NUMBER_OF_ROWS, engine.NUMBER_OF_COLUMNS);
                        
                        Console.WriteLine("\nExiting game.");
                        gameLoop = false;
                        inputLoop = false;
                    }                    
                } while (inputLoop);
            }

            Console.ReadKey();
        }

        void DisplayGridWithMessage(string message)
        {
            DisplayGrid();
            Console.WriteLine(message);
        }

        void DisplayGrid()
        {
            engine.DisplayGrid(engine.NUMBER_OF_ROWS, engine.NUMBER_OF_COLUMNS);
        }

    
        public string ReturnMessage()
        {
            return "Happy coding!";
        }
    }

}
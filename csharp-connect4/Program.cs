using System;
using System.Text;

namespace csharp_connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);

            // Console.WriteLine("Please enter the board dimensions (number of rows, number of columns)");
            
            // string strInput = Console.ReadLine();
            // int result = 0;
            // int numberOfRows = 0;
            // int numberOfColumns = 0;

            
            // while (strInput != "quit")
            // {
            //     if (int.TryParse(strInput, out result))
            //     {
            //         if ((result > 60) || (result < 4))
            //         {
            //             Console.WriteLine("You chose a number that will create invalid board dimensions");
            //             Console.WriteLine("The dimensions need to be between 4 and 60");
            //         }
            //         numberOfRows = result;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Your input ({0}) is not a number", strInput);
            //     }
            //     Console.WriteLine("Please enter the next number");
            //     strInput = Console.ReadLine();
            // }


            // Console.WriteLine("Please enter the number of columns");
            
            // strInput = Console.ReadLine();
            // while (strInput != "quit")
            // {
            //     if (int.TryParse(strInput, out result))
            //     {
            //         if ((result > 60) || (result < 4))
            //         {
            //             Console.WriteLine("You chose a number that will create invalid board dimensions");
            //             Console.WriteLine("The dimensions need to be between 4 and 60");
            //         }
            //         numberOfColumns = result;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Your input ({0}) is not a number", strInput);
            //     }
            //     Console.WriteLine("Please enter the next number");
            //     strInput = Console.ReadLine();
            // }

            
            //myNewEngine.DisplayGrid(numberOfRows, numberOfColumns);

            Game myNewGame = new Game();

            //myNewGame.StartGame();
            myNewGame.StartGameCleanCode();

            Console.WriteLine($"\nThe game is over! {myNewGame.ReturnMessage()}");
        }

    }


}

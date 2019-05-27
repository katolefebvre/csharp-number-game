using KatoLefebvre_Assignment1;
using System;

/**
* Name: Kato Lefebvre
* Student #: 991323245
* Date: May 26th, 2019
*/
namespace KatoLefebvre_Assignment1_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGame numberGame = new NumberGame();

            int[] nums;

            Console.WriteLine("Welcome to the Number Game!");
            Console.WriteLine("Get a score of 100 or more and you win!");
            Console.WriteLine("Press any key to begin the game.");
            Console.ReadKey();

            for (int i = 0; i < 5; i++)
            {
                nums = numberGame.PlayRound();
                Console.WriteLine(nums[0] + " " + nums[1] + " " + nums[2] + " " 
                    + nums[3] + " " + nums[4]);
                Console.WriteLine("Current Score: " + numberGame.GenerateResult());
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

            Console.WriteLine("Your final score is: " + numberGame.GenerateResult());

            if (numberGame.GenerateResult() > 100)
                Console.WriteLine("Congratulations! You Win!");
            else if (numberGame.GenerateResult() == 100)
                Console.WriteLine("Game Draw!");
            else if (numberGame.GenerateResult() < 100)
                Console.WriteLine("You Lose! Try Again.");

            Console.WriteLine("Press any key to close this game.");
            Console.ReadKey();
        }
    }
}

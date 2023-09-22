# GuessAnumber

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// Tensae Girma Seifu (NET23)
namespace NumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables for the game
            string choice; //variable that hold the users choice to continue or exit the game
            int counter = 5; // Number of chances
            int guessed = 0; // The user's guessed number

            // Create a random number generator
            Random random = new Random();

            // Display a welcome message
            Console.WriteLine("Welcome to a Guessing Game");
            Console.WriteLine("=========================\n\n");

            do
            {
                // Ask the user to choose a difficulty level
                Console.WriteLine("Press 1 for Easy, Press 2 for Medium, Press 3 For Hard");
                Console.WriteLine("======================================================\n\n");
                int val = Convert.ToInt32(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        Console.WriteLine("Guess a number 1 - 10");

                        // Generate a random number between 1 and 10 for the user to guess
                        int number = random.Next(1, 10);
                        // Call the Commen method to handle the guessing logic
                        Commen(number, counter, guessed);
                        break;

                    case 2:
                        Console.WriteLine("Guess a number 1 - 30");

                        // Generate a random number between 1 and 30 for the user to guess
                        int number2 = random.Next(1, 30);
                        // Call the Commen method to handle the guessing logic
                        Commen(number2, counter, guessed);
                        break;

                    case 3:
                        Console.WriteLine("Guess a number 1 - 50\n\n");

                        // Generate a random number between 1 and 50 for the user to guess
                        int number3 = random.Next(1, 50);
                        // Call the Commen method to handle the guessing logic
                        Commen(number3, counter, guessed);
                        break;

                    default:
                        Console.WriteLine("Wrong choice Please choose 1, 2, or 3");
                        break;
                }

                Console.WriteLine("\n==============================================\n");
                Console.WriteLine("\n Would you like to try again? Press Y or y if YES\n");
                choice = Console.ReadLine();

            } while (choice == "y" || choice == "Y"); // Repeat the game if the user enters 'Y' or 'y'
        }

        // Method to handle the guessing logic
        public static void Commen(int number, int counter, int guessed)
        {
            while (counter > 0)
            {
                guessed = Convert.ToInt32(Console.ReadLine());

                if (guessed == number)
                {
                    // Display a win message and the number of tries left
                    Console.WriteLine("You Win!" + " " + (counter - 1) + " " + "tries Left");
                    break;
                }
                else if (guessed > number)
                {
                    Console.WriteLine("Guess Lower");
                }
                else if (guessed < number)
                {
                    Console.WriteLine("Guess Higher");
                }

                counter--; // Decrement the remaining chances
            }

            if (counter == 0)
            {
                // Display a message when the user runs out of chances
                Console.WriteLine("You lose. The correct number was: " + number);
            }
        }
    }
}

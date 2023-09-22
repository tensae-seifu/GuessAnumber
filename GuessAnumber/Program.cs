using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


// Tensae Girma Seifu
namespace NumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            int counter = 5;
            int guessed = 0; 

            Random random = new Random();




            Console.WriteLine("Welcome to a Gessing Game");
            Console.WriteLine("=========================\n\n");

            do
            {

                Console.WriteLine("Press 1 for Easy, Press 2 for Medium, Press 3 For Hard");
                Console.WriteLine("======================================================\n\n");
                int val = Convert.ToInt32(Console.ReadLine());




                switch (val)




                {


                        case 1:

                        Console.WriteLine("Guess a number 1 - 10");

                        int number = random.Next(1, 10);
                        Commen(number, counter, guessed);


                        break;

                        case 2:

                        Console.WriteLine("Guess a number 1 - 30");

                        int number2=random.Next(1,30);
                        Commen(number2,counter,guessed);
                  

                        break;


                        case 3:

                        Console.WriteLine("Guess a number 1 - 50\n\n");

                        int number3=random.Next(1,50);
                        Commen(number3, counter, guessed);

                        break;

                        default:

                        Console.WriteLine("Wrong choice Please choose 1,2 or 3");

                        break;
                }



                Console.WriteLine("\n==============================================\n");
                Console.WriteLine("\n Would youlike to try agin press Y or y if YES\n");
                choice = Console.ReadLine();

            } while (choice == "y" && choice == "y");


        }

        public static void Commen(int number,int counter,int guessed)
        {
           

            while (counter > 0)
            {
                guessed = Convert.ToInt32(Console.ReadLine());

                if (guessed == number)
                {

                    Console.WriteLine("You Win!" + " " + (counter - 1) + " " + "tryes Left");
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

                counter--;
            }

            if (counter == 0)
            {
                Console.WriteLine("You lose. The correct number was: " + number);
            }

            

        }

    }
}



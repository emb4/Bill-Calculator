/*
 Eric Bates
 C# Programming
 10/13/2017
 Coin Flipping Program
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_29
{
    class Program
    {
        static bool Flip() // method that flips coin
        {
            Random toss = new Random();
            int coin = toss.Next(2); // generates a random number thats either 0 or 1
            return coin == 0; // returns true if coin flips 0, false if coin flips 1

        }
        static void Main(string[] args)
        {
            int choice = 0, headscount = 0, tailscount = 0; // choice is for the menus, others keep track of coin flips and assigns to 0
            bool coinFlip;

            while (choice != 2) // loops until the user inputs 2
            {

                Console.WriteLine("1. Toss Coin");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    coinFlip = Flip(); //assigns coinFlip to either true or false
                    if (coinFlip == true)
                    {
                        ++headscount;
                        Console.WriteLine("You rolled heads!");
                    }

                    else
                    {
                        ++tailscount;
                        Console.WriteLine("You rolled tails!");
                    }
                }
                else break; // breaks if user inputs 2

                if (headscount != 1)
                    Console.WriteLine("Heads has been rolled " + headscount + " times."); // prints amount of times coins have been flipped, with extra code for grammar
                else
                    Console.WriteLine("Heads has been rolled " + headscount + " time."); 

                if (tailscount != 1)
                    Console.WriteLine("Tails has been rolled " + tailscount + " times.");
                else
                    Console.WriteLine("Tails has been rolled " + tailscount + " time.");
            }
        }
    }
}

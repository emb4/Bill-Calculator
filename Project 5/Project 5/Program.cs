/*
 Eric Bates
 C# Programming
 10/16/2017
 Double Dice Roll Program
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Program
    {
        static int diceRoll() // method that flips dice
        {
            Random toss = new Random();
            int coin = 1 + toss.Next(6); // generates a random number from 1-6
            return coin;
        }

        static void Assign(int roll1, int roll2, int[] frequency) // adds the two dice rolls together and counts how often it appears inside array
        {
            int sum = roll1 + roll2;
            int element = sum - 2; // minuses 2 because arrays start at 0 but the sum of rolls start at 2
            frequency[element] += 1; //for some reason this doesnt seem to count all 11 possible options.. not sure why
        }

        static double Percentage(int x, int[] frequency) // supposed to calculate the percentage, causes program to crash/unfinished
        {
                return frequency[x] / 3600;
        }

        static void Main(string[] args)
        {
            int coinFlip1, coinFlip2;
            int[] frequency = new int[11];

            for (int i = 0; i < 36000; i++) //loops the required amount of times and seems to be fully functional
            {
                coinFlip1 = diceRoll();
                coinFlip2 = diceRoll();
                Assign(coinFlip1, coinFlip2, frequency);
            }

            Console.WriteLine("Sum Frequency");

            for (int x = 2; x <= 12; x++)
                Console.WriteLine(x + "      " + frequency[x - 2] /* + " " +  Percentage(x, frequency)*/); //prints out chart, Percentage makes it crash so its commented out
        }
    }
}

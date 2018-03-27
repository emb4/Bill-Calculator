/*
 * Eric Bates
 * Sales Program
 * Exercise 6-17
 * 10/09/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_17
{
    class Sales
    {
        static void Main(string[] args)
        {
            int prompt = 4;
            int number;
            double Total = 0;

            // makes classes for three products and sets the prices
            Product item1 = new Product(2.98);
            Product item2 = new Product(4.50);
            Product item3 = new Product(9.98);

            while (prompt != -1) //loops until user inputs -1
            {
                //lists out all products with their prices
                Console.WriteLine("Product 1: $" + item1.price);
                Console.WriteLine("Product 2: $" + item2.price);
                Console.WriteLine("Product 3: $" + item3.price);

                //Prompt that gets the product number
                Console.WriteLine("Enter Product number(-1 to quit)");
                prompt = int.Parse(Console.ReadLine());
                if (prompt == -1)
                    break; //exits if user inputs -1

                Console.WriteLine("Enter quantity");
                number = int.Parse(Console.ReadLine()); //get quantity

                switch (prompt) // Calculates total based on which product the user chose and the quantity
                {
                    case 1:
                        item1.quantity = number;
                        Total = item1.GetTotal(item1.price, item1.quantity, item1.total);
                        break;

                    case 2:
                        item2.quantity = number;
                        Total = item2.GetTotal(item2.price, item2.quantity, item2.total);
                        break;

                    case 3:
                        item3.quantity = number;
                        Total = item3.GetTotal(item3.price, item3.quantity, item3.total);
                        break;
                }

                Console.WriteLine("Total: $" + Total); //outputs the total
                Console.WriteLine();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_17
{
    class Product
    {
        public double price, total;
        public int quantity;

        public double GetTotal(double a, int b, double c) //function that calculates total
        {
            price = a; quantity = b; total = c;
            c = a * b;
            return c;
        }

        public Product(double a) //constructor for setting the price
        {
            price = a;
        }
    }
}

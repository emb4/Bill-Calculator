/*Eric Bates
 * Project 6
 * November 5, 2017
 * */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // new array of invoice data
            var invoices = new[] {
                new Invoice(83, "Electric Sander", 7, 57.98m),
                new Invoice(24, "Power saw", 18, 99.99m),
                new Invoice(7, "Sledge hammer", 11, 21.50m),
                new Invoice(77, "Hammer", 76, 11.99m),
                new Invoice(39, "Lawn mower", 3, 79.50m),
                new Invoice(68, "Screwdriver", 106, 6.99m),
                new Invoice(56, "Jig saw", 21, 11.00m),
                new Invoice(3, "Wrench", 34, 7.50m),
            };

            //A. sort by Partdescription and display
            var sortbypart =
                from i in invoices
                orderby i.PartDescription
                select i;

            Console.WriteLine("Sorted by part number:");
            Console.WriteLine();

            foreach (var item in sortbypart)
                Console.WriteLine(item);
            Console.WriteLine();

            //B. sort by price and display
            var sortbyprice =
                from p in invoices
                orderby p.Price
                select p;

            Console.WriteLine("Sorted by price:");
            Console.WriteLine();

            foreach (var item in sortbyprice)
                Console.WriteLine(item);
            Console.WriteLine();

            //C. select description and quantity and sort by quantity and display
            var sortbyquant =
                from q in invoices
                orderby q.Quantity
                select new { Quantity = q.Quantity , Description = q.PartDescription,};

            Console.WriteLine("Sorted by quantity:");
            Console.WriteLine();

            foreach (var item in sortbyquant)
                Console.WriteLine(item);
            Console.WriteLine();

            //D. select the description, calculate total, and display, sorted by total
            var invoicetotal =
                from t in invoices
                let total = t.Quantity * t.Price
                orderby total
                select new { Total = total, Description = t.PartDescription};

            Console.WriteLine("Sorted by total:");
            Console.WriteLine();

            foreach (var item in invoicetotal)
                Console.WriteLine(item);
            Console.WriteLine();

            //E. select invoicetotal in the range of $200-$500 and display
            var invoicerange =
                from r in invoicetotal
                where (r.Total >= 200m) && (r.Total <= 500m)
                select r;

            Console.WriteLine("Showing totals between $200-$500:");
            Console.WriteLine();

            foreach (var item in invoicerange)
                Console.WriteLine(item);

        }
    }
}

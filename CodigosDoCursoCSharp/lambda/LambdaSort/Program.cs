using Course.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.0));
            products.Add(new Product("Notebook", 1200.0));
            products.Add(new Product("Tablet", 450.0));

            products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        
    }
}

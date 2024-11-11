using System;
using System.Collections.Generic;
using System.IO;
using Course.Entities;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Mouse", 50.0));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            list.ForEach(p => { p.Price += p.Price * 0.1; });

            list.RemoveAll(ProductTest);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
      
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        public static bool ProductTest(Product product)
        {
            return product.Price >= 100.0;
        }
    }
}

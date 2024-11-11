using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Define the query expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}

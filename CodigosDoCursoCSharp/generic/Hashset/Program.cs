using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            SortedSet<int> a = new SortedSet<int>() { 10, 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrinCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrinCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            d.ExceptWith(b);
            PrinCollection(e);
        }

        static void PrinCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}

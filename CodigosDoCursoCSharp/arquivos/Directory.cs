
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";
            try
            {
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string item in folder)
                {
                    Console.WriteLine(item);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}


using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file3.txt";

            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine(Path.GetTempPath());
        }
    }
}

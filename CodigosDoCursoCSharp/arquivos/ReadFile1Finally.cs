
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            StreamReader streamReader = null;
            try
            {
                streamReader = File.OpenText(path);
                while (streamReader != null && !streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
            }


        }
    }
}

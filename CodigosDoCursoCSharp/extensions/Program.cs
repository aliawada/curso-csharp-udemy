﻿using Course.Extensions;
using System;
using System.Collections.Generic;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 12, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students";
            Console.WriteLine(s1.Cut(10));
        }
    }
}

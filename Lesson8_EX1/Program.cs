﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson8_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Revit 2022 SDK";
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file in files) 
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}

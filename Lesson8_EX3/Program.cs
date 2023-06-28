using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson8_EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\L8EX3.txt";
            string[] words;
            string[] strings;
            int symbols = 0;
            string text = null;
            using(StreamReader sr = new StreamReader(path)) 
            {
                text = sr.ReadToEnd();              
            }
            symbols = text.Count();
            strings = text.Split('\n');
            text.Trim(',', ' ', '.', '\n');
            words = text.Split(' ');
            Console.WriteLine("Символов {0}, слов {1}, строк {2}", symbols, words.Length, strings.Length);
            Console.ReadKey();            
        }
    }
}

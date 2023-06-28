using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson8_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\L8EX2.txt";
            Random random = new Random();
            using(StreamWriter sw = new StreamWriter(path)) 
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10,10)) ;
                }
            }
            int a = 0;
            using(StreamReader sr = new StreamReader(path)) 
            {
            for (int i = 0; i<10; i++)
                {
                    a += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

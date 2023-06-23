using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();            
            string[] strArr = str.Split(' ');
            int k = 0;
            foreach (string word in strArr)
            {
                if (word.Length > k)
                    k = word.Length;
            }
            Console.WriteLine("Самое длинное слово содержит {0} символов",k);
        }
    }
}

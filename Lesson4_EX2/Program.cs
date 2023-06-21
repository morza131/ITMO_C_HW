using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int countPositive = 0;
            int countNegative = 0;
            Console.WriteLine("вводите числа последовательности, 0 - конец последовательности");
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a>0)
                    countPositive++;
                else if (a<0)
                    countNegative++;
            }
            while (a != 0);
            if (countPositive > countNegative)
            {
                Console.WriteLine("Положительных чисел больше, чем отрицательных");
            }
            else if (countPositive == countNegative)
            {
                Console.WriteLine("Положительных чисел столько же, сколько отрицательных");
            }
            else
                Console.WriteLine("Отрицательных чисел больше, чем положительных");
        }
    }
}

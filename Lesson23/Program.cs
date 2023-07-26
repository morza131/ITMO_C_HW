using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления факториала");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = FactorialAsync(n).Result;
            Console.WriteLine(r);
            Thread.Sleep(1000);
            Console.WriteLine("Метод main завершен");
        }
        static async Task<int> FactorialAsync(int n)
        {
            int result = await Task.Run(() => Factorial(n));
            Thread.Sleep(1000);
            return result;
        }
        static int Factorial(int x) 
        {
            int a=1;
            for (int i = 1; i<= x; i++) 
            {
                a *= i;
                
            }
            return a;
        }
    }
}

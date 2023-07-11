using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите К и В");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Equation equation = new Equation(k,b);
            double x = equation.Root();
            if (double.IsInfinity(x))
                Console.WriteLine("Ошибка деления на 0");
            else
                Console.WriteLine($"x = {x}");
            
            
        }
    }
}

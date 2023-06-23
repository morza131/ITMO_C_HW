using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_EX1
{
    internal class Program
    {
        /// <summary>
        /// Расчет площади треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>площадь</returns>
        static double AreaOfTriangle(int a, int b, int c)
        {
            int p = (a + b + c) / 2;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
        /// <summary>
        /// проверка существования треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>bool</returns>
        static bool IfTriangleExist(int a, int b, int c) 
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите стороны треугольника 1");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            if (!(IfTriangleExist(a1, b1, c1)))
            {
               Console.WriteLine("Ошибка! Треугольник не существует");
               Environment.Exit(9999);
            }
            Console.WriteLine("Введите стороны треугольника 2");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            if (!(IfTriangleExist(a2, b2, c2)))
            {
                Console.WriteLine("Ошибка! Треугольник не существует");
                Environment.Exit(9999);
            }

            double s1 = AreaOfTriangle(a1, b1, c1);
            double s2 = AreaOfTriangle(a2, b2, c2);
            if (s1 > s2)
                Console.WriteLine("Площадь треугольника 1 больше, чем у треугольника 2");
            else if (s1 == s2)
                Console.WriteLine("Площадь треугольника 1 равна площади треугольника 2");
            else Console.WriteLine("Площадь треугольника 1 меньше, чем у треугольника 2");
        }
    }
}

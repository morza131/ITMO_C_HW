using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal static class Circle
    {
        public static double GetСircumference(double r)
        {
            return 2*Math.PI*r;
        }
        public static double GetCircumSquare(double r)
        {
            return Math.PI*Math.Pow(r,2);
        }
        public static bool IsCircleContaisPoint(double x, double y, double r)
        {
            if (Math.Abs(x)<=r && Math.Abs(y) <=r)
                return true;
            else
                return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Длина окружности равна {Circle.GetСircumference(r)}\nПлощаль окружности равна {Circle.GetCircumSquare(r)}");
            Console.WriteLine("Введите координаты точки x,y для проверки принадлежности");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (Circle.IsCircleContaisPoint(x, y, r))
                Console.WriteLine("Точка лежит внутри окружности");
            else
                Console.WriteLine("Точка не лежит внутри окружности");
        }
    }
}

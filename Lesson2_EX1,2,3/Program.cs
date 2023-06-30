using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_C
{
    internal class Program
    {
        /// <summary>
        /// Нахождение длины отрезка для прямоугольника
        /// </summary>
        /// <param name="x1">координата первой точки</param>
        /// <param name="x2">координата второй точки</param>
        /// <returns>длина отрезка</returns>
        static double FindLengthByCoordinate(double x1, double x2)
        {
            double l = Math.Abs(x2 - x1);
            return l;
        }
        /// <summary>
        /// Нахождение длины отрезка для треугольника
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns>длина отрезка</returns>
        static double FindLengthByCoordinate(double x1, double y1, double x2, double y2)
        {
            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y2 - y1);
            double l = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
            return l;
        }
        static void FindRadiusAndArea()
        {
            Console.WriteLine("Введите длину окружности");
            double L = Convert.ToDouble(Console.ReadLine());
            double R, S;
            R = L / (2 * Math.PI);
            S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Радиус окружности равен {0}, площадь круга равна {1}", R, S);
            Console.ReadKey();
        }
        static void FindAreaOfRectangle()
        {
            Console.WriteLine("Введите x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double p = FindLengthByCoordinate(x1,x2)* 2+ FindLengthByCoordinate(y1, y2) * 2;
            double s = FindLengthByCoordinate(x1,x2)*FindLengthByCoordinate(y1,y2);
            Console.WriteLine("Периметр прямоугольника равен {0}, площадь равна {1}", p, s);
            Console.ReadKey();
        }
        static void FindAreaOfTriangle()
        {
            Console.WriteLine("Введите x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x3");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y3");
            double y3 = Convert.ToDouble(Console.ReadLine());
            double a = FindLengthByCoordinate(x1, y1, x2, y2);
            double b = FindLengthByCoordinate(x1, y1, x3, y3);
            double c = FindLengthByCoordinate(x2, y2, x3, y3);
            if (a + b > c && a + c > b && b + c > a)
            {
                double p = a + b + c;
                double p2 = p / 2;
                double s = Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c));
                Console.WriteLine("Периметр треугольника равен {0}, площадь равна {1}", p, s);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка - треугольник не существует");
                 Console.ReadKey();   
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Какие расчеты проведем?\n" +
                "0 - Рассчитать радиус и площадь по длине окружности круга\n" +
                "1 - Рассчитать площадь прямоугольника по координатам двух противоположных вершин\n" +
                "2 - Рассчитать периметр и площадь треугольника по координатам его вершин");
            int chosenHomework = Convert.ToInt32(Console.ReadLine());
            switch (chosenHomework) 
            {
                case 0:
                    FindRadiusAndArea();
                    break;
                case 1:
                    FindAreaOfRectangle();
                    break;
                case 2:
                    FindAreaOfTriangle();
                    break;    
            }
        }
    }
}

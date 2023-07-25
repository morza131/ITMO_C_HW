using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20
{
    internal class Program
    {
        public delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = Сircumference;
            Console.WriteLine($"Длина окружности равна { myDelegate(r)}");
            myDelegate = Square;
            Console.WriteLine($"Площадь круга равна { myDelegate(r)}");
            myDelegate = Volume;
            Console.WriteLine($"Объем сферы равен { myDelegate(r)}");


        }
        public static double Сircumference(double r)
        {
            return 2 * Math.PI * r;
        }
        public static double Square (double r)
        {
            return Math.PI * r*r;
        }
        public static double Volume (double r) 
        {
            return Math.PI * r*r*r*4/3;
        }
    }
}

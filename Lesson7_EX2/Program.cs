using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_EX2
{
    internal class Program
    {
        static void ValueOfCube(double x, out double v, out double s)
        {
            v = Math.Pow(x, 3);
            s = Math.Pow(x, 2) * 6;            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба");
            int x = Convert.ToInt32(Console.ReadLine());
            double v;
            double s;
            ValueOfCube(x,out v, out s);
            Console.WriteLine("Объем = {0}, площадь поверхности куба = {1}", v, s);
        }
    }
}

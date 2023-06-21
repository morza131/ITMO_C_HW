using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты 3 точек прямоугольника");
            Console.WriteLine("x1=");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1=");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2=");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2=");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x3=");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y3=");
            int y3 = Convert.ToInt32(Console.ReadLine());  
            if ((x1 == x2 ||  x2 == x3 || x1 ==x3)&& (y1 == y2 || y2 == y3 || y1 == y3)) 
            {
                int x4 = (x1 == x2) ? x3 : (x2 == x3) ? x1 : x2;
                int y4 = (y1 == y2) ? y3 : (y2 == y3) ? y1 : y2;
                Console.WriteLine("x4 = {0}, y4 = {1}",x4,y4);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Координаты введены с ошибкой");
                Console.ReadKey();
            }
        }
    }
}

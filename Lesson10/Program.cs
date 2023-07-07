using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите по очереди градус, минуты, секунды");
            int gradus = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int sec = Convert.ToInt32(Console.ReadLine());
                       
            Angle angle = new Angle(gradus, min, sec);
            double rad = angle.ToRadians();
            Console.WriteLine(angle.Gradus);
            Console.WriteLine(rad);
            Console.ReadKey();
        }
    }
}

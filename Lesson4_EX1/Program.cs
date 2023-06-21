using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int sqr=0;
            for (int i = 1; i < (2*n); )
            {
                sqr = sqr + i;
                i += 2;
                Console.WriteLine(sqr);
            }
        }
    }
}

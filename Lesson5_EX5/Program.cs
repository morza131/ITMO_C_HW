using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_EX5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            byte[,] arr = new byte[n,n];
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                        arr[i, j] = 1;
                    else if (i%2 !=0 && j%2 !=0)
                        arr[i, j] = 1;
                    Console.Write("{0,4}", arr[i,j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}

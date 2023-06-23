using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[7];
            double sum =0;
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("{0:f2}",sum/arr.Length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = random.Next(-50,50);
                Console.Write(arr[i]+" ");
            }
            for (int i = 0;i < arr.Length; i++) 
            {
                if (i%2==0 && arr[i]>0 && arr[i]%2!=0) 
                count++;
            }
            Console.WriteLine("\n"+count);   
        }
    }
}

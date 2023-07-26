using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                arr[i] =  random.Next(0, 100);
            Func<object, int> func = new Func<object, int>(Sum);
            Task<int> task = new Task<int>(func, arr);
            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(MaxV);
            Task<int> task2 = task.ContinueWith<int>(func2);

            task.Start();
            

        }
        static int MaxV(Task<int[]> task) 
        {
            int[] array = task.Result;
            int max = 0;
            for (int i = 0;i < array.Length;i++)
            {
                if (array[i] > max) max = array[i];
            }
            return max;
        }
        static int Sum(object _arr) 
        {
            int[] arr = (int[])_arr;
            int sum = 0;
            for (int i = 0; i< arr.Length ; i++)
                sum += arr[i];
            return sum;
        }
    }
}

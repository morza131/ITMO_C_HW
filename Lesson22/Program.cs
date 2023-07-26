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
            
            Func<object, int[]> func1 = new Func<object, int[]>(GetArr);
            Task<int[]> task1 = new Task<int[]>(func1, n);


            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(MaxV);
            Task<int> task2 = task1.ContinueWith<int>(func2);

            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(Sum);
            Task<int> task3 = task1.ContinueWith<int>(func3);

            task1.Start();

            Console.WriteLine($"Наибольшее число массива: {task2.Result}");
            Console.WriteLine($"Сумма чисел массива: {task3.Result}");

        }
        static int[] GetArr(object n)
        {
            int k = (int)n;
            int[] arr = new int[k];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            return arr; 
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
        static int Sum(Task<int[]> task) 
        {
            int[] arr = task.Result;
            int sum = 0;
            for (int i = 0; i< arr.Length ; i++)
                sum += arr[i];
            return sum;
        }
    }
}

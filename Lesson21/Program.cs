using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson21
{
    
    internal class Program
    {
        const int n = 9;
        static int[,] garden = new int[n, n];
        static void Main(string[] args)
        {
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    garden[i, j] = 0;
                }
            }
            ThreadStart threadStart1 = new ThreadStart(Gardener1);
            Thread thread1 = new Thread(threadStart1);
            thread1.Start();
            Gardener2();
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < n; j++)
                Console.Write($"{garden[i,j]}  ");
                Console.WriteLine();
            }
        }
        static void Gardener1()
        {
            for (int i = 0;i <n; i++) 
            {
                for (int j = 0; j< n; j++)
                {
                    if (garden[i, j] == 0)
                    {
                        garden[i,j] = 1;
                        Thread.Sleep(10);
                    }
                }
            }
        }
        static void Gardener2()
        {
            for (int j = n-1; j >= 0; j--)
            {
                for (int i = n-1; i >= 0; i--)
                {
                    if (garden[i, j] == 0)
                    {
                        garden[i, j] = 2;
                        Thread.Sleep(10);
                    }
                }
            }
        }
    }
}

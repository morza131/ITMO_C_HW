using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();
            string[] strArr = str.ToLower().Split(' ');
            string newstr="";
            foreach (var word in strArr)
            {
                newstr+=word;
            }
            Console.WriteLine(newstr);
            bool flag = true;
            for (int i = 0; i < newstr.Length/2; i++)
            {
                char ch = newstr[i];
                Console.WriteLine(ch);
                if (!(newstr[i] == newstr[newstr.Length-i-1])) 
                {
                    flag = false;
                }
            }
            Console.WriteLine(flag);
        }
    }
}

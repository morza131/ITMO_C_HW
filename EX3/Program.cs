using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст");
            byte age = Convert.ToByte(Console.ReadLine());
            string first="";
            string second="";
            string third = "";
            if (age > 19 && age < 30)
                first = "двадцать ";
            else if (age < 40)
                first = "тридцать ";
            else if (age < 50)
                first = "сорок ";
            else if (age < 60)
                first = "пятьдесят ";
            else if (age < 70)
                first = "шестьдесят ";
            else
                Console.WriteLine("некорректный возраст");

            switch (age % 10)
            {
                case 0:
                    second = "";
                    break;
                case 1:
                    second = "один ";
                    break;
                case 2:
                    second = "два ";
                    break;
                case 3:
                    second = "три ";
                    break;
                case 4:
                    second = "четыре ";
                    break;
                case 5:
                    second = "пять ";
                    break;
                case 6:
                    second = "шесть ";
                    break;
                case 7:
                    second = "семь ";
                    break;
                case 8:
                    second = "восемь ";
                    break;
                case 9:
                    second = "девять ";
                    break;               
            }

            if (age % 10 == 0 || age % 10 > 4)
                third = "лет";
            else if (age % 10 == 1)
                third = "год";
            else
                third = "года";

            Console.WriteLine(first +second+ third);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор");
                Console.WriteLine("Введите первое число");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n\t1 - сложение\n\t2 - вычитание\n\t3 - умножение\n\t4 - деление");
                byte c = Convert.ToByte(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Console.WriteLine("Результат: {0}", a + b);
                        break;
                    case 2:
                        Console.WriteLine("Результат: {0}", a - b);
                        break;
                    case 3:
                        Console.WriteLine("Результат: {0}", a * b);
                        break;
                    case 4:
                        double d = a / b;
                        if (double.IsInfinity(d))
                            Console.WriteLine("Ошибка, деление на 0");
                        else
                            Console.WriteLine("Результат: {0}", d);
                        break;
                    default:
                        Console.WriteLine("Код операции введён с ошибкой");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода числа");
            }
            
        }
    }
}

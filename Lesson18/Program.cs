using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teststring1 = "{}{][[]][]{()())}";
            string teststring2 = "{}[]()(({}))(";
            string teststring3 = "{}[]()(({}))";
            Stack<char> stack = new Stack<char>();
            bool flag = false;
            foreach (char i in teststring2) 
            {
                switch (i)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    default:
                        if (stack.First() == i)
                            stack.Pop();
                        else
                            flag = true;    
                            break;
                }
                Console.WriteLine(stack.Count);
                if (flag)
                {
                    Console.WriteLine("Строка неправильная!");
                    Environment.Exit(0);
                    break;                    
                }
            }
            Console.WriteLine(stack.Count);
            if (stack.Count == 0)
                Console.WriteLine("Строка правильная!");
            else
                Console.WriteLine("Строка неправильная!");
        }
    }
}

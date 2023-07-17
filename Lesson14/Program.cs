using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name) 
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat : Animal
    {
        string name;
        public Cat(string name) : base(name)
        {
            this.name = name;
        }

        public override string Name { get; set; }

        public override void Say()
        {
            Console.WriteLine("Meow"); 
        }        
    }
    class Dog : Animal
    {
        string name;
        public Dog(string name) : base(name)
        {
            this.name = name;
        }

        public override string Name { get; set; }

        public override void Say()
        {
            Console.WriteLine("Bork");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Simba");
            Dog dog = new Dog("Zoya");
            cat.ShowInfo();
            dog.ShowInfo();
        }
    }
}

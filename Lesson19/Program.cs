using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lesson19
{
    class Computer
    {
        public int Article { get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public double Frequence { get; set; }
        public byte RAM { get; set; }
        public int SSD { get; set; }
        public byte VRAM { get; set; }
        public byte NumberOfComputers { get; set; }
        public int Price { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            { 
                new Computer(){ Article = 516164, Model = "Zalman Z3080", CPU = "Intel Core i9-12900K", Frequence = 5.2, RAM = 64, SSD = 2048, VRAM = 16, NumberOfComputers = 4, Price = 240000},
                new Computer(){ Article = 463467, Model = "BeQuet Z3060", CPU = "Intel Core i7-12700", Frequence = 5.1, RAM = 32, SSD = 1024, VRAM = 6, NumberOfComputers = 3, Price = 170000},
                new Computer(){ Article = 437869, Model = "Zalman Z4080", CPU = "Intel Core i5-12600K", Frequence = 4.7, RAM = 16, SSD = 1024, VRAM = 12, NumberOfComputers = 31, Price = 280000},
                new Computer(){ Article = 366786, Model = "Zalman Z3090", CPU = "Intel Core i9-13900F", Frequence = 5.5, RAM = 64, SSD = 2048, VRAM = 16, NumberOfComputers = 1, Price = 260000},
                new Computer(){ Article = 345366, Model = "Zalman FX7700", CPU = "Ryzen 7 5700", Frequence = 4.8, RAM = 32, SSD = 2048, VRAM = 12, NumberOfComputers = 3, Price = 140000},
                new Computer(){ Article = 378962, Model = "Steelseries RX3050", CPU = "Intel Core i5-14600KF", Frequence = 5.2, RAM = 32, SSD = 1024, VRAM = 8, NumberOfComputers = 6, Price = 130000},
                new Computer(){ Article = 678756, Model = "BeQuet Z3070", CPU = "Intel Core i9-12900K", Frequence = 5.2, RAM = 64, SSD = 2048, VRAM = 12, NumberOfComputers = 6, Price = 180000},
                new Computer(){ Article = 327837, Model = "BeQuet Z4060Ti", CPU = "Intel Core i5-12600K", Frequence = 4.7, RAM = 32, SSD = 1024, VRAM = 12, NumberOfComputers = 8, Price = 180000},
                               
            };
            Console.WriteLine("Введите название процессора");
            string findname = Console.ReadLine();
            Print(computers.Where(x => x.CPU == findname).ToList());
            Console.WriteLine("Введите объем ОЗУ");
            byte ram = Convert.ToByte(Console.ReadLine());
            Print(computers.Where(x => x.RAM > ram).ToList());
            Console.WriteLine("Сортировка по увеличению стоимости");
            Print(computers.OrderBy(x => x.Price).ToList());
            Console.WriteLine("Группировка по типу процессора");
            IEnumerable<IGrouping<string, Computer>> group = computers.GroupBy(x => x.CPU);
            foreach (IGrouping<string , Computer> g in group)
            {
                Console.WriteLine((g.Key));
                foreach (Computer c in g)
                {
                    Console.WriteLine($"{c.Article}, {c.Model}, {c.Price}, {c.NumberOfComputers}");
                }
            }
            
            Computer computermax = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Computer computermin = computers.OrderByDescending(x => x.Price).LastOrDefault();
            Console.WriteLine($"Самый дорогой компьютер: {computermax.Article}, {computermax.Model}, {computermax.Price}, {computermax.NumberOfComputers}");
            Console.WriteLine($"Самый дешевый компьютер: {computermin.Article}, {computermin.Model}, {computermin.Price}, {computermin.NumberOfComputers}");
            Console.WriteLine($"Есть ли компьютеров в наличии не менее 30? {computers.Any(x => x.NumberOfComputers >=30)}");

        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"{c.Article}, {c.Model}, {c.Price}, {c.NumberOfComputers}");
            }
        }
    }
}

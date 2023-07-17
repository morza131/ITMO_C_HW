using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Building
    {
        string adress;
        int length;
        int width;
        int height;
        public string Adress { get { return adress; } set {  adress = value; } }
        public int Length { get { return length; } set { length = value; } }
        public int Width { get { return width; } set { width = value; } }   
        public int Height { get { return height; } set { height = value; } }    
        public Building(string adress, int length, int width, int height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }
        public string Print()
        {
            return $"Адрес: {adress}, Длина: {length}, ширина: {width}, высота: {height}";
        }
    }
    sealed class Multibuilding : Building
    {
        int numberOfFloors;
        public int NumberOfFloors { get { return numberOfFloors; } set { numberOfFloors = value; } }  
        public Multibuilding(string adress, int length, int width, int height, int numberOfFloors) : base(adress, length, width, height)
        {
            NumberOfFloors = numberOfFloors;
        }
        public string Print()
        {
            string result = base.Print();
            result += $" Число этажей: {numberOfFloors}";
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string adress = "Москва, ул. Нижние поля, д.1";
            Building building = new Building(adress, 100, 10, 3);
            Console.WriteLine(building.Print());
            string adress2 = "Москва, ул. Юных Ленинцев, д.6";
            Multibuilding multibuilding = new Multibuilding(adress2, 60, 16, 35, 11);
            Console.WriteLine(multibuilding.Print());
        }
    }
}

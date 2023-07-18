using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Lesson16
{
    internal class ProgramWrite
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Product[] products = new Product[n];
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Введите данные товара {i+1}");
                Console.WriteLine("Введите код товара");
                int code = Convert.ToInt32( Console.ReadLine() );
                Console.WriteLine("Введите название товара");
                string name = Console.ReadLine();
                Console.WriteLine("Введите цену товара");
                double price = Convert.ToDouble( Console.ReadLine() );
                products[i] = new Product() {ProductCode = code, ProductName = name, Price = price };
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            { Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
              WriteIndented = true };

            string jsonString = JsonSerializer.Serialize(products, options);
            using (StreamWriter writer = new StreamWriter("../../../Products.json"))
            {
                writer.WriteLine(jsonString);
            }
        }
    }
}

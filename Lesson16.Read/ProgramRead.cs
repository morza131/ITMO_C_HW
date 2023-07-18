using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Lesson16
{
    internal class ProgramRead
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader rd = new StreamReader("../../../Products.json"))
            {
                jsonString = rd.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            Product highCostProduct = products[0];
            foreach (Product product in products)
            {
                if (product.Price > highCostProduct.Price) 
                {
                    highCostProduct = product;
                }
            }
            Console.WriteLine($"Самый дорогой товар: {highCostProduct.ProductName}");
        }
    }
}

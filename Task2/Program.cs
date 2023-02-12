using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string JsonString = string.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.Json"))
            {
                JsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(JsonString);
            Product maxproduct = products[0];
            foreach(Product p in products) 
            { 
                if(p.Price>maxproduct.Price)
                {
                    maxproduct = p;
                }

            }
            Console.WriteLine($"{maxproduct.Code} {maxproduct.Name} {maxproduct.Price}");
            Console.ReadKey();
        }
    }
}

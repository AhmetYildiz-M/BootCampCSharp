using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Elma";
            double unitPrice = 15;
            string description = "Amasya elması";

            string[] fruits = new string[] { "Elma", "Karpuz" };

            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.UnitPrice = 15;
            product1.Description = "Amasya elması";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.UnitPrice = 80;
            product2.Description = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            //type-safe -- tip güvenli
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.UnitPrice);
                Console.WriteLine(product.Description);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("------------Methods---------------");
            //instance - örnek
            //encapsulation

            ProductManager productManager = new ProductManager();
            productManager.Add(product2);
            productManager.Add(product1);

            Console.WriteLine("-----------Second Methods-------");

            //Aşağıdaki şekilde yapıldığında oluşacak olan hatayı göstermek için örnek olarak oluşturduk. 
            productManager.Add2("Armut", "Yeşil armut", 12, 10);
            productManager.Add2("Elma", "Yeşil elma", 12, 9);
            productManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice

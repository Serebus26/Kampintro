using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 001;
            product1.Name = "Elma";
            product1.Description = "Amasya Elmasi";
            product1.Price = 20;
            product1.Stock = 5;

            Product product2 = new Product();
            product2.Id = 002;
            product2.Name = "Karpuz";
            product2.Description = "Diyarbakır Karpuzu";
            product2.Price = 10;
            product2.Stock = 8;

            Product product3 = new Product();
            product3.Id = 003;
            product3.Name = "Muz";
            product3.Description = "İthal Muz";
            product3.Price = 30;
            product3.Stock = 2;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Id + " : " + product.Name
                    + " : " + product.Description + " : "
                    + product.Price + " TL " + " stok : " + product.Stock);
            }

            Console.WriteLine("----------Methods----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add(product3);



        }
    }
}

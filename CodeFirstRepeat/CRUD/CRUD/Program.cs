using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (ProductContext context = new ProductContext())
            {
                Product p = new Product
                {
                    ProductId = "P3",
                    Title = "Mobile",
                    Price = 15000,
                    Quantity = 1,
                    InStocks = true

                };
                Product p1 = new Product
                {
                    ProductId = "P2",
                    Title = "Car",
                    Price = 150000,
                    Quantity = 1,
                    InStocks = true

                };


                //context.products.Add(p);
                //context.products.Add(p1);

                var find = context.products.Find("p3");
               
                //find.Price = 500;
                //var x = context.products.Find("p3");
                //context.products.Remove(x);
                //var data = context.products.Include("Product");
                context.products.ToList().ForEach((i) =>
                {
                    Console.WriteLine($" Product ID :{i.ProductId}\n Product Name :{i.Title}\n Price :{i.Price}\n " +
                        $"Quantity :{i.Quantity}\n InStocks :{i.InStocks}");
                });
                context.SaveChanges();
                Console.WriteLine(" Data Save");


            }

        }
    }
}

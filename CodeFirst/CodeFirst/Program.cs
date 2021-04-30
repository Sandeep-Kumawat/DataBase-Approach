using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using(FooContext context = new FooContext())
            {
                Product p = new Product
                {
                    Title = "Car",
                    Price = 1000
                };

                //context.products.Add(p);
                Employee emp = new Employee
                {
                    Title = "Sandeep",
                    City = "Sikar"
                };
                //context.employees.Add(emp);
                //ProductDetail proD = new ProductDetail
                //{
                //    Owner = "Sandeep",
                //    Vendor = "Taazaa",
                //    Product = p
                //};

                // context.productDetails.Add(proD);

                // var p2 = abc.products.Find(2);
                //Console.WriteLine(p2.Price);

                // p2.Title = "NoteBook";
                //Console.WriteLine(p2.Title);
                var getList = context.productDetails.Include("Product");
                getList.ToList().ForEach(
                    (i) =>
                    {
                        Console.WriteLine($"{i.Owner}\t{i.Vendor}\t{i.ProductId}\t{i.ProductDetailId}");
                    });


                try
                {
                    context.SaveChanges();
                    Console.WriteLine("Data Save");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}

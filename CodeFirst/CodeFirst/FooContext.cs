using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst
{
    public class FooContext: DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Employee> employees { get; set; }

        public DbSet<ProductDetail> productDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2M5OOP4;Initial Catalog=CodeFirst;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}

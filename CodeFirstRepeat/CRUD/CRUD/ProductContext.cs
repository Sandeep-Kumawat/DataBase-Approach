using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2M5OOP4;Initial Catalog=CodeFirstSandeep;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}

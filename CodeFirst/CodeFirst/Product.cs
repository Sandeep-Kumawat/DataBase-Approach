using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirst
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Title { get; set; }
        public  int Price { get; set; }

        public ProductDetail productDetail { get; set; }
    }
}

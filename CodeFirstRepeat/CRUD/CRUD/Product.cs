using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CRUD
{
    public class Product
    {
        [Required]
        public string ProductId { get; set; }

        
        public string Title { get; set; }

        [Required]
        public int Price { get; set; }
        public bool InStocks { get; set; }
        public int Quantity { get; set; }
    }
}

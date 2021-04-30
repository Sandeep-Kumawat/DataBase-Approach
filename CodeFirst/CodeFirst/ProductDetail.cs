using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirst
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public string Owner { get; set; }
        public string Vendor { get; set; }

        public int ProductId { get; set; }

        [Required]

        public Product Product { get; set; }
    }
}

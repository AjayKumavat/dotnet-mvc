using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopManagement.Models;

namespace ShopManagement.Models
{
    public class ProductDetails
    {
        public Product productDetails { get; set; }
        public Category categoryDetails { get; set; }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagement.Models
{
    [Table("product_master")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [MaxLength(50, ErrorMessage = "Maximum 50 characters are allowed")]
        [MinLength(3, ErrorMessage = "Product Name must contain more than 3 letters")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "Category Id is required")]
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

    }
    
}
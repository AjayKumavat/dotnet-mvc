using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("con")
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FAIC.Models;

namespace FAIC.data
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext") { }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
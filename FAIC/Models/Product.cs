using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAIC.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string SupplierId { get; set; }
        public int CategoryId { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
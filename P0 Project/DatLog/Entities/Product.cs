using System;
using System.Collections.Generic;

#nullable disable

namespace DatLog.Entities
{
    public partial class Product
    {
        public Product()
        {
            Inventories = new HashSet<Inventory>();
            LineItems = new HashSet<LineItem>();
        }

        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductCode { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}

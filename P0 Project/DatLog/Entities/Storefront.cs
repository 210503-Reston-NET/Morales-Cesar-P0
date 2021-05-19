using System;
using System.Collections.Generic;

#nullable disable

namespace DatLog.Entities
{
    public partial class Storefront
    {
        public Storefront()
        {
            Inventories = new HashSet<Inventory>();
            Orders = new HashSet<Order>();
        }

        public string StorefrontTown { get; set; }
        public int StorefrontId { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

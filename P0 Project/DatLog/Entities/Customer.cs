using System;
using System.Collections.Generic;

#nullable disable

namespace DatLog.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string CustomerName { get; set; }
        public int CustomerPassword { get; set; }
        public string Customerhometown { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

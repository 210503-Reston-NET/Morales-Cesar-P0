using System;
using System.Collections.Generic;

#nullable disable

namespace DatLog.Entities
{
    public partial class Order
    {
        public Order()
        {
            LineItems = new HashSet<LineItem>();
        }

        public int OrderTiming { get; set; }
        public int OrderId { get; set; }
        public double OrderTotal { get; set; }
        public int OrderCustomerId { get; set; }
        public int OrderStroreFrontId { get; set; }

        public virtual Customer OrderCustomer { get; set; }
        public virtual Storefront OrderStroreFront { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}

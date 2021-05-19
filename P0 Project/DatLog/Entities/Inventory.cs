using System;
using System.Collections.Generic;

#nullable disable

namespace DatLog.Entities
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int InventoryQuantity { get; set; }
        public int InventoryName { get; set; }
        public int StoreId { get; set; }

        public virtual Product InventoryNameNavigation { get; set; }
        public virtual Storefront Store { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace DatLog.Entities
{
    public partial class LineItem
    {
        public int LineitemId { get; set; }
        public int LineitemQuantity { get; set; }
        public int LineorderId { get; set; }
        public int LineproductId { get; set; }

        public virtual Order Lineorder { get; set; }
        public virtual Product Lineproduct { get; set; }


        
    }
}

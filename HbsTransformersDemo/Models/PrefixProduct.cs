using System;
using System.Collections.Generic;

namespace HbsTransformersDemo.Models
{
    public partial class PrefixProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual PrefixCategory Category { get; set; }
    }
}

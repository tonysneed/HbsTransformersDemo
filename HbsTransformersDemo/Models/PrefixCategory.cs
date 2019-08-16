using System;
using System.Collections.Generic;

namespace HbsTransformersDemo.Models
{
    public partial class PrefixCategory
    {
        public PrefixCategory()
        {
            Product = new HashSet<PrefixProduct>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<PrefixProduct> Product { get; set; }
    }
}

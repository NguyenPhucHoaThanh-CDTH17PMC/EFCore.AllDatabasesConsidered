using System;
using System.Collections.Generic;

namespace Northwind.Models
{
    public partial class Bang
    {
        public Bang()
        {
            NdBangs = new HashSet<NdBang>();
        }

        public long Id { get; set; }
        public long? SoDong { get; set; }
        public long? SoCot { get; set; }
        public string? TenBan { get; set; }

        public virtual ICollection<NdBang> NdBangs { get; set; }
    }
}

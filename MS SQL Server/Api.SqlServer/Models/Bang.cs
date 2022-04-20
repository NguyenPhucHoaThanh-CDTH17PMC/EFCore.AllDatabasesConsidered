using System;
using System.Collections.Generic;

namespace Northwind.Models
{
    public partial class Bang
    {
        public Bang()
        {
            Ndbangs = new HashSet<Ndbang>();
        }

        public string Id { get; set; } = null!;
        public int? SoDong { get; set; }
        public int? SoCot { get; set; }
        public string? TenBang { get; set; }

        public virtual ICollection<Ndbang> Ndbangs { get; set; }
    }
}

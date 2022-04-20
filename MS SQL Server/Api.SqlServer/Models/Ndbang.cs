using System;
using System.Collections.Generic;

namespace Northwind.Models
{
    public partial class Ndbang
    {
        public string Idbang { get; set; } = null!;
        public string Vtcot { get; set; } = null!;
        public string Vtdong { get; set; } = null!;
        public string? Nd { get; set; }

        public virtual Bang IdbangNavigation { get; set; } = null!;
    }
}

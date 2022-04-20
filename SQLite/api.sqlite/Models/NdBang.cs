namespace Northwind.Models
{
    public partial class NdBang
    {
        public string VtDong { get; set; } = null!;
        public string VtCot { get; set; } = null!;
        public string? NoiDung { get; set; }
        public long IdBang { get; set; }

        public virtual Bang? Bang { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Nxb
    {
        public Nxb()
        {
            Sachchitiets = new HashSet<Sachchitiet>();
        }

        public int Id { get; set; }
        public string? Tennxb { get; set; }
        public string? Ghichu { get; set; }
        public string? Diachi { get; set; }
        public string? Sdt { get; set; }
        public int? Trangthai { get; set; }

        public virtual ICollection<Sachchitiet> Sachchitiets { get; set; }
    }
}

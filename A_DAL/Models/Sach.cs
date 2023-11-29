using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Sach
    {
        public Sach()
        {
            SachTacgia = new HashSet<SachTacgium>();
            Sachchitiets = new HashSet<Sachchitiet>();
            Theloaisaches = new HashSet<Theloaisach>();
        }

        public int Id { get; set; }
        public string? Tensach { get; set; }
        public DateTime? Ngaynhap { get; set; }
        public int? Namxuatban { get; set; }

        public virtual ICollection<SachTacgium> SachTacgia { get; set; }
        public virtual ICollection<Sachchitiet> Sachchitiets { get; set; }
        public virtual ICollection<Theloaisach> Theloaisaches { get; set; }
    }
}

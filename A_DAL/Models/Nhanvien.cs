using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Phieumuons = new HashSet<Phieumuon>();
            Phieutras = new HashSet<Phieutra>();
        }

        public int Id { get; set; }
        public string? Hoten { get; set; }
        public string? Sdt { get; set; }
        public string? Vaitro { get; set; }
        public string? Email { get; set; }
        public string? Pass { get; set; }
        public int? Trangthai { get; set; }

        public virtual ICollection<Phieumuon> Phieumuons { get; set; }
        public virtual ICollection<Phieutra> Phieutras { get; set; }
    }
}

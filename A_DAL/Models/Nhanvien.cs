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
        public string Hoten { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string Vaitro { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public int? Trangthai { get; set; }

        public virtual ICollection<Phieumuon> Phieumuons { get; set; }
        public virtual ICollection<Phieutra> Phieutras { get; set; }
    }
}

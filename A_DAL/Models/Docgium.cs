using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Docgium
    {
        public Docgium()
        {
            Phieumuons = new HashSet<Phieumuon>();
            Phieutras = new HashSet<Phieutra>();
        }

        public int Id { get; set; }
        public string Hoten { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string? Diachi { get; set; }
        public string Cmnd { get; set; } = null!;
        public DateTime? Ngaysinh { get; set; }
        public DateTime Ngaycapthe { get; set; }
        public DateTime? Hanthe { get; set; }
        public int? Trangthai { get; set; }
        public int Idhang { get; set; }

        public virtual Hangthanhvien IdhangNavigation { get; set; } = null!;
        public virtual ICollection<Phieumuon> Phieumuons { get; set; }
        public virtual ICollection<Phieutra> Phieutras { get; set; }
    }
}

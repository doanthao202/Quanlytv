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
        public string? Hoten { get; set; }
        public string? Email { get; set; }
        public string? Sdt { get; set; }
        public string? Diachi { get; set; }
        public string? Cmnd { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public DateTime? Ngaycapthe { get; set; }
        public DateTime? Ngayhieuluc { get; set; }
        public DateTime? Hanthe { get; set; }
        public int? Trangthai { get; set; }
        public int Idhang { get; set; }

        public virtual Hangthanhvien IdhangNavigation { get; set; } = null!;
        public virtual ICollection<Phieumuon> Phieumuons { get; set; }
        public virtual ICollection<Phieutra> Phieutras { get; set; }
    }
}

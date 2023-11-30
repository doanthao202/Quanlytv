using System;
using System.Collections.Generic;

namespace A_DAL.Models1
{
    public partial class Phieumuon
    {
        public Phieumuon()
        {
            Phieumuoncts = new HashSet<Phieumuonct>();
        }

        public int Id { get; set; }
        public int? Iddocgia { get; set; }
        public int Idnhanvien { get; set; }
        public DateTime? Ngaymuon { get; set; }
        public DateTime? Ngaytradukien { get; set; }
        public decimal? Tiencoc { get; set; }
        public decimal? Phimuon { get; set; }
        public int? Tinhtrang { get; set; }

        public virtual Docgium? IddocgiaNavigation { get; set; }
        public virtual Nhanvien IdnhanvienNavigation { get; set; } = null!;
        public virtual ICollection<Phieumuonct> Phieumuoncts { get; set; }
    }
}

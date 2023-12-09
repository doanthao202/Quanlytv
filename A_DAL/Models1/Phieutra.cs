using System;
using System.Collections.Generic;

namespace A_DAL.Models1
{
    public partial class Phieutra
    {
        public Phieutra()
        {
            Phieutracts = new HashSet<Phieutract>();
        }

        public int Id { get; set; }
        public int Iddocgia { get; set; }
        public int Idnhanvien { get; set; }
        public string Tendocgia { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public DateTime? Ngaytra { get; set; }
        public decimal? Tienphat { get; set; }
        public string? Lydophat { get; set; }
        public decimal? Hoancoc { get; set; }

        public virtual Docgium IddocgiaNavigation { get; set; } = null!;
        public virtual Nhanvien IdnhanvienNavigation { get; set; } = null!;
        public virtual ICollection<Phieutract> Phieutracts { get; set; }
    }
}

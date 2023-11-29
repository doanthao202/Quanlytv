using System;
using System.Collections.Generic;

namespace A_DAL.Models
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
        public DateTime? Ngaytra { get; set; }
        public int? Tinhtrangtra { get; set; }

        public virtual Docgium IddocgiaNavigation { get; set; } = null!;
        public virtual Nhanvien IdnhanvienNavigation { get; set; } = null!;
        public virtual ICollection<Phieutract> Phieutracts { get; set; }
    }
}

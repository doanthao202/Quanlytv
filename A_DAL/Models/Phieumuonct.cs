using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Phieumuonct
    {
        public Phieumuonct()
        {
            Phieutracts = new HashSet<Phieutract>();
        }

        public int Id { get; set; }
        public int Idsachct { get; set; }
        public int Idphieumuon { get; set; }
        public string? Ghichu { get; set; }

        public virtual Phieumuon IdphieumuonNavigation { get; set; } = null!;
        public virtual Sachchitiet IdsachctNavigation { get; set; } = null!;
        public virtual ICollection<Phieutract> Phieutracts { get; set; }
    }
}

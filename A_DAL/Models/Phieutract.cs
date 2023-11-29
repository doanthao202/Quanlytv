using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Phieutract
    {
        public int Id { get; set; }
        public int Idphieutra { get; set; }
        public int Idphieumuonct { get; set; }
        public string? Ghichu { get; set; }

        public virtual Phieumuonct IdphieumuonctNavigation { get; set; } = null!;
        public virtual Phieutra IdphieutraNavigation { get; set; } = null!;
    }
}

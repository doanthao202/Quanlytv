using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Sachchitiet
    {
        public Sachchitiet()
        {
            Phieumuoncts = new HashSet<Phieumuonct>();
            SachctHangs = new HashSet<SachctHang>();
        }

        public int Id { get; set; }
        public int Idsach { get; set; }
        public int Idngonngu { get; set; }
        public int Idnxb { get; set; }
        public int? Lantaiban { get; set; }
        public decimal? Giasach { get; set; }
        public int? Dotuoidocsach { get; set; }
        public int? Tinhtrang { get; set; }

        public virtual Ngonngu IdngonnguNavigation { get; set; } = null!;
        public virtual Nxb IdnxbNavigation { get; set; } = null!;
        public virtual Sach IdsachNavigation { get; set; } = null!;
        public virtual ICollection<Phieumuonct> Phieumuoncts { get; set; }
        public virtual ICollection<SachctHang> SachctHangs { get; set; }
    }
}

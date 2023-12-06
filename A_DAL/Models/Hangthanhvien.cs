using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Hangthanhvien
    {
        public Hangthanhvien()
        {
            Docgia = new HashSet<Docgium>();
            SachctHangs = new HashSet<SachctHang>();
        }

        public int Id { get; set; }
        public string Tenhang { get; set; } = null!;
        public decimal? Dongia { get; set; }
        public int? Thoigianhieuluc { get; set; }

        public virtual ICollection<Docgium> Docgia { get; set; }
        public virtual ICollection<SachctHang> SachctHangs { get; set; }
    }
}

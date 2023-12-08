using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Viewmoder
{
    public class PmPtPmct
    {
        public int Idphieumuon { get; set; }
        public int? Iddocgia { get; set; }
        public int Idnhanvien { get; set; }
        public string? Tendocgia { get; set; }
        public string Sdt { get; set; }
        public DateTime? Ngaymuon { get; set; }
        public DateTime? Ngaytradukien { get; set; }
        public int? Tinhtrang { get; set; }
        public int Idphieumuonct { get; set; }
        public int Idphieutra { get; set; }
        //public int soluong { get; set; }
    }
}

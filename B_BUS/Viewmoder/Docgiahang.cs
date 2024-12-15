using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Viewmoder
{
    public class Docgiahang
    {
        public int Id { get; set; }
        public string? Hoten { get; set; }
        public string? Email { get; set; }
        public string? Sdt { get; set; }
        public string? Diachi { get; set; }
        public string? Cmnd { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public DateTime? Ngaycapthe { get; set; }
        public DateTime? Hanthe { get; set; }
        public int? Trangthai { get; set; }
        public string Tenhang { get; set; } = null!;
    }
}

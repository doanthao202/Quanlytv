using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Theloai
    {
        public Theloai()
        {
            Theloaisaches = new HashSet<Theloaisach>();
        }

        public int Id { get; set; }
        public string? Tentheloai { get; set; }
        public string? Vitri { get; set; }
        public int? Trangthai { get; set; }

        public virtual ICollection<Theloaisach> Theloaisaches { get; set; }
    }
}

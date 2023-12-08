using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Theloai
    {
        public Theloai()
        {
            Saches = new HashSet<Sach>();
        }

        public int Id { get; set; }
        public string Tentheloai { get; set; } = null!;
        public string? Vitri { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Theloaisach
    {
        public int Id { get; set; }
        public int Idsach { get; set; }
        public int Idtheloai { get; set; }

        public virtual Sach IdsachNavigation { get; set; } = null!;
        public virtual Theloai IdtheloaiNavigation { get; set; } = null!;
    }
}

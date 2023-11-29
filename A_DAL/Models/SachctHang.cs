using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class SachctHang
    {
        public int Id { get; set; }
        public int Idhang { get; set; }
        public int Idsachct { get; set; }

        public virtual Hangthanhvien IdhangNavigation { get; set; } = null!;
        public virtual Sachchitiet IdsachctNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class SachTacgium
    {
        public int Id { get; set; }
        public int Idsach { get; set; }
        public int Idtacgia { get; set; }
        public string? Vaitro { get; set; }
        public string? Ghichu { get; set; }

        public virtual Sach IdsachNavigation { get; set; } = null!;
        public virtual Tacgium IdtacgiaNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace A_DAL.Model
{
    public partial class Tacgium
    {
        public Tacgium()
        {
            SachTacgia = new HashSet<SachTacgium>();
        }

        public int Id { get; set; }
        public string? Tentacgia { get; set; }
        public string? Ghichu { get; set; }

        public virtual ICollection<SachTacgium> SachTacgia { get; set; }
    }
}

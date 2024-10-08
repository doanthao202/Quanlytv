﻿using System;
using System.Collections.Generic;

namespace A_DAL.Models1
{
    public partial class Tacgium
    {
        public Tacgium()
        {
            SachTacgia = new HashSet<SachTacgium>();
        }

        public int Id { get; set; }
        public string Tentacgia { get; set; } = null!;
        public string? Ghichu { get; set; }

        public virtual ICollection<SachTacgium> SachTacgia { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Ngonngu
    {
        public Ngonngu()
        {
            Sachchitiets = new HashSet<Sachchitiet>();
        }

        public int Id { get; set; }
        public string? Tennn { get; set; }

        public virtual ICollection<Sachchitiet> Sachchitiets { get; set; }
    }
}

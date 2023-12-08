using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface ISachHangRepos
    {
        IEnumerable<SachctHang> GetAll();

        bool Add(SachctHang sachctHang);
        bool Delete(int id);
    }
}

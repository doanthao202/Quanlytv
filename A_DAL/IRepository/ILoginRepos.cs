using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    public interface ILoginRepos
    {
        Nhanvien GetNhanvienByUsername(string username);
    }
}

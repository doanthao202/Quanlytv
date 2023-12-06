using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;

namespace A_DAL.IRepository
{
    internal interface IHangRepos
    {
        IEnumerable<Hangthanhvien> GetAllHang();

        int Add(Hangthanhvien hang);

        int Update(int id, Hangthanhvien hang);
        bool Delete(int id);
        Hangthanhvien GetById(string hang);
        List<Hangthanhvien> GetSearch(string searchText);
    }
}

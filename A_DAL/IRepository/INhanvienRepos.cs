using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface INhanvienRepos
    {
        IEnumerable<Nhanvien> GetAll();
       
       
        int Add(Nhanvien nhanvien);

        int Update(int id, Nhanvien nhanvien);
        bool Update1(int id, string passmoi);

        bool Delete(int id);
        List<Nhanvien> GetSearch1(string searchText);
    }
}

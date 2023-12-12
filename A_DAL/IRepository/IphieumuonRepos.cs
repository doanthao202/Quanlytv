using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface IphieumuonRepos
    {
        IEnumerable<Phieumuon> GetAll();
        //List<Sach> GetTheloaiByName(string name);

     bool Add(Phieumuon phieumuon);

        bool Update(int id);
        bool Update1(int id,DateTime y);
        bool Delete(int id);
        bool Delete1(int id);
        List<Phieumuon> GetSearch(string searchText,string x);
        List<Phieumuon> GetSearch1(string searchText);
    }
}

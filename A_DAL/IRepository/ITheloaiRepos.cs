using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface ITheloaiRepos
    {
       IEnumerable<Theloai> GetAllTheloai();
        List<Theloai> GetTheloaiByName(int id);
        Theloai GetById(string tentl);
       int Add(Theloai theloai);

        int Update(int id, Theloai theloai);
        bool Delete(int id);
        List<Theloai> GetSearch(string searchText);

    }
}

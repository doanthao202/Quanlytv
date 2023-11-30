using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface ISachrepos
    {
        IEnumerable<Sach> GetAllSach();
        //List<Sach> GetTheloaiByName(string name);
        Sach GetById(int id);
        int Add(Sach sach);

        int Update(int id, Sach sach);
        bool Delete(int id);
        List<Sach> GetSearch(string searchText);
    }
}

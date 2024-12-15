using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface IPhieutra
    {
        IEnumerable<Phieutra> GetAll();
        //List<Sach> GetTheloaiByName(string name);
        List<Phieutra> GetSearch(string searchText);
        bool Add(Phieutra phieutra);

        bool Delete(int id);
    }
}

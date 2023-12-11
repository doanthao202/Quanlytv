using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface INxbRepos
    {
        IEnumerable<Nxb> GetAll();

        int Add(Nxb nxb);

        int Update(int id, Nxb nxb);
        bool Delete(int id);
        List<Nxb> GetSearch(string searchText);
    }
}

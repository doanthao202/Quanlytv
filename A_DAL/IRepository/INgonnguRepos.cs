using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;

namespace A_DAL.IRepository
{
    internal interface INgonnguRepos


    {
        IEnumerable<Ngonngu> GetAllNgonngu();

        int Add(Ngonngu ngonngu);

        int Update(int id, Ngonngu ngonngu);
        bool Delete(int id);
        List<Ngonngu> GetSearch(string searchText);
    }
}

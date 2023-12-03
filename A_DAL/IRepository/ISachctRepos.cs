using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface ISachctRepos
    {
        IEnumerable<Sachchitiet> GetAll();
        
        int Add(Sachchitiet sachct);

        int Update(int id, Sachchitiet sachct);
        bool Delete(int id);
       /* List<Sachchitiet> GetSearch(string searchText);*/
    }
}

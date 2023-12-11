using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface ITacgiaRepos
    {
        IEnumerable<Tacgium> GetAll();
       
        Tacgium GetById(string tg);
        int Add(Tacgium tacgia);

        int Update(int id, Tacgium tacgia);
        bool Delete(int id);
        List<Tacgium> GetSearch(string searchText);
    }
}

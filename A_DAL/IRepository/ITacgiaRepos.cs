using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Model;

namespace A_DAL.IRepository
{
    internal interface ITacgiaRepos
    {
        IEnumerable<Tacgium> GetAlltacgia();
        List<Tacgium> GetTacgiaByName(string name);
        Tacgium GetById(int id);
        int Add(Tacgium tacgia);

        int Update(int id, Tacgium tacgia);
        bool Delete(int id);
        List<Tacgium> GetSearch(string searchText);
    }
}

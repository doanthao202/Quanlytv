using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface IDocgiaRepos
    {
        IEnumerable<Docgium> GetAll();

        int Add(Docgium docgium);

        int Update(int id, Docgium docgium);
        bool Delete(int id);
        
    }
}

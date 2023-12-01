using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;

namespace B_BUS.Services
{
    public class Tacgiaservice
    {
        TacgiaRepos _repos = new TacgiaRepos();
        public Tacgiaservice()
        {
            
        }

        public Tacgiaservice(TacgiaRepos repos)
        {
            _repos = repos;
        }
        public IEnumerable<Tacgium> GetAll()
        {
            return _repos.GetAll().ToList();
        }
    }
}

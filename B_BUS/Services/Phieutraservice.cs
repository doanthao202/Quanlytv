using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.Repository;

namespace B_BUS.Services
{
   public class Phieutraservice
    {
        PhieutraRepos _repos = new PhieutraRepos();
        public Phieutraservice()
        {
            
        }

        public Phieutraservice(PhieutraRepos repos)
        {
            _repos = repos;
        }
        public bool add(Phieutra phieutra)
        {
            return _repos.Add(phieutra);
        }public bool Delete(int id)
        {
            return _repos.Delete(id);
        }
        
        public IEnumerable<Phieutra> GetAll()
        {
            return _repos.GetAll().ToList();
        }
    }
}

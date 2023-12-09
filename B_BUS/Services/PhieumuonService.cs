using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;
using B_BUS.Viewmoder;
using Microsoft.EntityFrameworkCore;

namespace B_BUS.Services
{
   public class PhieumuonService
    {
        PhieumuonRepos _repos = new PhieumuonRepos(); 
       
        public PhieumuonService()
        {
            
        }

        public PhieumuonService(PhieumuonRepos repos)
        {
            _repos = repos;
        }

        public bool add(Phieumuon phieumuon)
        {
            
                return _repos.Add(phieumuon) ;
            
        }
        public bool Delete(int id)
        {
            return _repos.Delete(id);
        } public bool Delete1(int id)
        {
            return _repos.Delete1(id);
        }
        public IEnumerable<Phieumuon> GetAll()
        {
            return _repos.GetAll().ToList();
        }
       
      
        public int Update(int id, Phieumuon phieumuon)
        {
            return _repos.Update(id, phieumuon);
        }
        public List<Phieumuon> GetSearch(string searchText, string x)
        {
           return _repos.GetSearch(searchText, x).ToList();
           
        }
       
    }
}

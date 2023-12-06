using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
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

        public string add(Phieumuon phieumuon)
        {
            if (_repos.Add(phieumuon) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(phieumuon) == 1)
            {
                return "Tên  không được để trống";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public bool Delete(int id)
        {
            return _repos.Delete(id);
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

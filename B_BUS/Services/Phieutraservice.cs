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
        public string add(Phieutra phieutra)
        {
            if (_repos.Add(phieutra) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(phieutra) == 1)
            {
                return "Tên  không được để trống";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        
        public IEnumerable<Phieutra> GetAll()
        {
            return _repos.GetAll().ToList();
        }
    }
}

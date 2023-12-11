using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;
using B_BUS.Viewmoder;

namespace B_BUS.Services
{
    public class PhieutractService
    {
        PhieumuonctRepos _repos1 = new PhieumuonctRepos();
        PhieumuonRepos _pmrepos = new PhieumuonRepos();
        Phieutrachitietrepos _repos = new Phieutrachitietrepos();
        //PhieumuonctService _phieumuonctService= new PhieumuonctService();   
        public PhieutractService()
        {
            
        }

        public PhieutractService(Phieutrachitietrepos repos)
        {
            _repos = repos;
        }
        public string add(Phieutract phieutra)
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

        public IEnumerable<Phieutract> GetAll()
        {
            return _repos.GetAll().ToList();
        }
        
    }
}

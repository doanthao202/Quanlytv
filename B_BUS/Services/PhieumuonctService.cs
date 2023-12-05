using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;

namespace B_BUS.Services
{
    public class PhieumuonctService
    { 
        PhieumuonctRepos _repos = new PhieumuonctRepos();
        public PhieumuonctService()
        {
            
        }
        public string add(Phieumuonct phieumuon)
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
        public IEnumerable<Phieumuonct> GetAll()
        {
            return _repos.GetAll().ToList();
        }


        public int Update(int id, Phieumuonct phieumuon)
        {
            return _repos.Update(id, phieumuon);
        }
    }
}

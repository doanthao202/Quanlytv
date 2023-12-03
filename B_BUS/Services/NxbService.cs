using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;

namespace B_BUS.Services
{
    public class NxbService

    {
        NxbRepos _repos = new NxbRepos();
        public NxbService()
        {

        }

        public NxbService(NxbRepos repos)
        {
            _repos = repos;
        }

        public IEnumerable<Nxb> GetAll()
        {
            return _repos.GetAllHang().ToList();
        }
        public string add(Nxb nxb)
        {
            if (_repos.Add(nxb) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(nxb) == 1)
            {
                return "Tên tác giả không được để trống";
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


        public List<Nxb> GetSearch(string searchText)
        {
            return _repos.GetSearch(searchText);
        }
        public int Update(int id, Nxb nxb)
        {
            return _repos.Update(id, nxb);
        }
    }
}

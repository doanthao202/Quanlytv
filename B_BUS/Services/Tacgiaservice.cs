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
        public string add(Tacgium tacgia)
        {
            if (_repos.Add(tacgia) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(tacgia) == 1)
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

        
        public List<Tacgium> GetSearch(string searchText)
        {
            return _repos.GetSearch(searchText);
        }
        public int Update(int id, Tacgium tacgia)
        {
            return _repos.Update(id, tacgia);
        }
    }
}

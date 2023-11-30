using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;

namespace B_BUS.Services
{
    public class Sachservice
    {
        Sachrepos _repos = new Sachrepos();
        public Sachservice()
        {

        }

        public Sachservice(Sachrepos repos)
        {
            _repos = repos;

        }

        public string add(Sach sach)
        {
            if (_repos.Add(sach) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(sach) == 1)
            {
                return "Tên sách không được để trống";
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
        public IEnumerable<Sach> GetAll()
        {
            return _repos.GetAllSach().ToList();
        }
        public Sach GetById(int id)
        {
            return _repos.GetById(id);
        }
        public List<Sach> GetSearch(string searchText)
        {
            return _repos.GetSearch(searchText);
        }
        public int Update(int id, Sach sach)
        {
            return _repos.Update(id, sach);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.Repository;

namespace B_BUS.Services
{
    public class Ngonnguservice
    {
        NgonnguRepos _repos = new NgonnguRepos();
        public Ngonnguservice() { }
        public Ngonnguservice(NgonnguRepos repos)
        {
            _repos = repos;
        }
        public string add(Ngonngu ngonngu)
        {
            if (_repos.Add(ngonngu) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(ngonngu) == 1)
            {
                return "Tên ngôn ngữ không được để trống";
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
        public IEnumerable<Ngonngu> GetAll()
        {
            return _repos.GetAllNgonngu().ToList();
        }

        public List<Ngonngu> GetSearch(string searchText)
        {
            return _repos.GetSearch(searchText);
        }
        public int Update(int id, Ngonngu ngonngu)
        {
            return _repos.Update(id, ngonngu);
        }
    }
}

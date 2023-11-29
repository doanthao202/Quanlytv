using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.Repository;

namespace B_BUS.Services
{
    internal class Theloaiservi
    {
        TheloaiRepos _repos = new TheloaiRepos();
        public Theloaiservi()
        {
            
        }

        public Theloaiservi(TheloaiRepos repos)
        {
            _repos = repos;
        }
        public string add(Theloai theloai)
        {
            if (_repos.Add(theloai) == true)
            {
                return "Thêm thành công";

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
        public IEnumerable<Theloai> GetAll()
        {
            return _repos.GetAllTheloai().ToList();
        }
        public Theloai GetById(int id)
        {
            return _repos.GetById(id);
        }
        public List<Theloai> GetSearch(string searchText)
        {
            return _repos.GetSearch(searchText);
        }
        public bool Update(int id, Theloai theloai)
        {
            return _repos.Update(id, theloai);
        }
    }
}

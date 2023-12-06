using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.Repository;
using Microsoft.EntityFrameworkCore;

namespace B_BUS.Services
{
    public class Theloaiservi
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
            if (_repos.Add(theloai) == 2)
            {
                return "Thêm thành công";
            }
            else if(_repos.Add(theloai) == 1)
            {
                return "Tên thể loại không được để trống";
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
        public Theloai GetById(string tl)
        {
            return _repos.GetById(tl);
        }
        public List<Theloai> GetSearch(string searchText)
        {
            return _repos.GetSearch(searchText);
        }
        public int Update(int id, Theloai theloai)
        {
            return _repos.Update(id, theloai);
        }
        public List<Theloai> GetTheloaiByName(int id)
        {
            return _repos.GetTheloaiByName(id);
        }
    }
}

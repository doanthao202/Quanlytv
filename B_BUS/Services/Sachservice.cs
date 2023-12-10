using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.Repository;
using B_BUS.Viewmoder;
using Microsoft.EntityFrameworkCore;

namespace B_BUS.Services
{
    public class Sachservice
    {
        Sachrepos _repos = new Sachrepos();
        TheloaiRepos theloaiRepos = new TheloaiRepos();
        public Sachservice()
        {

        }

        public Sachservice(Sachrepos repos)
        {
            _repos = repos;

        }

        public Sachservice(Sachrepos repos, TheloaiRepos theloaiRepos)
        {
            _repos = repos;
            this.theloaiRepos = theloaiRepos;
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
        } public bool Delete1(int id)
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
        public List<TheloaiSach> Getview()
        {
            var joinData = from Sach in _repos.GetAllSach()
                           join Theloai in theloaiRepos.GetAllTheloai() on Sach.Idtheloai equals Theloai.Id
                           select new TheloaiSach
                           {
                               Id = Sach.Id,
                               Tensach = Sach.Tensach,
                               Ngaynhap = Sach.Ngaynhap,
                               Namxuatban = Sach.Namxuatban,
                               Tentheloai = Theloai.Tentheloai
                           };
            return joinData.ToList();
        }
        public List<TheloaiSach> GetSearch1(string searchText)
        {
            var joinData = from Sach in _repos.GetAllSach()
                           join Theloai in theloaiRepos.GetAllTheloai() on Sach.Idtheloai equals Theloai.Id
                           select new TheloaiSach
                           {
                               Id = Sach.Id,
                               Tensach = Sach.Tensach,
                               Ngaynhap = Sach.Ngaynhap,
                               Namxuatban = Sach.Namxuatban,
                               Tentheloai = Theloai.Tentheloai
                           };
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return joinData.ToList();
            }
            return joinData.Where(c => c.Tensach.Contains(searchText)).ToList();
        }
    }
}

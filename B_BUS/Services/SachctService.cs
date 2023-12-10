using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.Repository;
using B_BUS.Viewmoder;

namespace B_BUS.Services
{
   public class SachctService
    {
        SachctRepos _repos = new SachctRepos();
        Sachrepos _srepos = new Sachrepos();
        NgonnguRepos _nnrepos = new NgonnguRepos();
        NxbRepos _Nxbrepos = new NxbRepos();
        public SachctService()
        {
            
        }

        public SachctService(SachctRepos repos, Sachrepos srepos, NgonnguRepos nnrepos, NxbRepos nxbrepos)
        {
            _repos = repos;
            _srepos = srepos;
            _nnrepos = nnrepos;
            _Nxbrepos = nxbrepos;
        }

        public string add(Sachchitiet sachct)
        {
            if (_repos.Add(sachct) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(sachct) == 1)
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
        public bool Delete1(int id)
        {
            return _repos.Delete1(id);
        } public bool Delete2(int id)
        {
            return _repos.Delete2(id);
        } public bool Delete3(int id)
        {
            return _repos.Delete3(id);
        }
        public IEnumerable<Sachchitiet> GetAll()
        {
            return _repos.GetAll().ToList();
        }
     
        
        public int Update(int id, Sachchitiet sachct)
        {
            return _repos.Update(id, sachct);
        }
        public List<Viewsachchitiet> Getview()
        {
            var joinData = from Sach in _srepos.GetAllSach()
                           join Sachchitiet in _repos.GetAll() on Sach.Id equals Sachchitiet.Idsach
                           join Ngonngu in _nnrepos.GetAllNgonngu() on Sachchitiet.Idngonngu equals Ngonngu.Id
                           join Nxb in _Nxbrepos.GetAll() on Sachchitiet.Idnxb equals Nxb.Id
                           select new Viewsachchitiet
                           {
                               Id = Sachchitiet.Id,
                               Tensach = Sach.Tensach,
                               Tennn = Ngonngu.Tennn,
                               Tennxb = Nxb.Tennxb,
                               Lantaiban = Sachchitiet.Lantaiban,
                               Giasach=Sachchitiet.Giasach,
                               Dotuoidocsach =Sachchitiet.Dotuoidocsach,
                               Tinhtrang = Sachchitiet.Tinhtrang
                           };
            return joinData.ToList();
        }
       /* public List<TheloaiSach> GetSearch1(string searchText)
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
        }*/
    }
}

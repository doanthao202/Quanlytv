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
    public class Docgiaservice
    {
        DocgiaRepos _repos = new DocgiaRepos();
        HangRepos _hrepos = new HangRepos();
        public Docgiaservice()
        {
            
        }

        public Docgiaservice(DocgiaRepos repos, HangRepos hrepos)
        {
            _repos = repos;
            _hrepos = hrepos;
        }
        public string add(Docgium docgium)
        {
            if (_repos.Add(docgium) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(docgium) == 1)
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
        public IEnumerable<Docgium> GetAll()
        {
            return _repos.GetAll().ToList();
        }
       
        
        public int Update(int id, Docgium docgium)
        {
            return _repos.Update(id, docgium);
        }
        public List<Docgiahang> Getview()
        {
            var joinData = from Hangthanhvien in _hrepos.GetAllHang()
                           join Docgium in _repos.GetAll() on Hangthanhvien.Id equals Docgium.Idhang
                           select new Docgiahang
                           {
                               Id = Docgium.Id,
                               Hoten = Docgium.Hoten,
                               Email = Docgium.Email,
                               Sdt = Docgium.Sdt,
                               Diachi= Docgium.Diachi,
                               Cmnd = Docgium.Cmnd,
                               Ngaysinh = Docgium.Ngaysinh, 
                               Ngaycapthe=Docgium.Ngaycapthe,
                               Hanthe=Docgium.Hanthe,
                               Trangthai=Docgium.Trangthai,
                               Tenhang=Hangthanhvien.Tenhang

                           };
            return joinData.ToList();
        }
    }
}

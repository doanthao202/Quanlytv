using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;

namespace B_BUS.Services
{
    public class Nhanvienservice
    {
        NhanvienRepos _repos= new NhanvienRepos();
        public Nhanvienservice()
        {
            
        }

        public Nhanvienservice(NhanvienRepos repos)
        {
            _repos = repos;
        }


        public string add(Nhanvien nhanvien)
        {
            if (_repos.Add(nhanvien) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(nhanvien) == 1)
            {
                return "Bạn vui lòng nhập đầy đủ thông tin";
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
        public IEnumerable<Nhanvien> GetAll()
        {
            return _repos.GetAll().ToList();
        }
        
        public List<Nhanvien> GetSearch1(string searchText)
        {
            return _repos.GetSearch1(searchText);
        }
        public int Update(int id, Nhanvien nhanvien)
        {
            return _repos.Update(id, nhanvien);
        }
        public bool Update1(int id, string passmoi)
        {
            return _repos.Update1(id, passmoi);
        }

    }
}

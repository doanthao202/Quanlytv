using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models1;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Repository
{
    public class NhanvienRepos : INhanvienRepos
    {
        DUAN3Context _context = new DUAN3Context();
        public NhanvienRepos()
        {
            
        }

        public NhanvienRepos(DUAN3Context context)
        {
            _context = context;
        }

        public int Add(Nhanvien nhanvien)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nhanvien.Hoten)|| string.IsNullOrWhiteSpace(nhanvien.Sdt)|| string.IsNullOrWhiteSpace(nhanvien.Vaitro)|| string.IsNullOrWhiteSpace(nhanvien.Email)|| string.IsNullOrWhiteSpace(nhanvien.Hoten)|| string.IsNullOrWhiteSpace(nhanvien.Pass)|| string.IsNullOrWhiteSpace(Convert.ToString(nhanvien.Trangthai)))
                {
                    return 1;
                }
                
                else
                {
                    _context.Nhanviens.Add(nhanvien);
                    _context.SaveChanges();
                    return 2;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var exist = _context.Nhanviens.Find(id);


                _context.Nhanviens.Remove(exist);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Nhanvien> GetAll()
        {
            return _context.Nhanviens.ToList();
        }

        public List<Nhanvien> GetSearch1(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _context.Nhanviens.ToList();
            }
            return _context.Nhanviens.Where(c => c.Hoten.Contains(searchText)).ToList();
        }

        public int Update(int id, Nhanvien nhanvien)
        {
            try
            {
                var exist = _context.Nhanviens.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(nhanvien.Hoten) || string.IsNullOrWhiteSpace(nhanvien.Sdt) || string.IsNullOrWhiteSpace(nhanvien.Vaitro) || string.IsNullOrWhiteSpace(nhanvien.Email) || string.IsNullOrWhiteSpace(nhanvien.Hoten) || string.IsNullOrWhiteSpace(nhanvien.Pass) || string.IsNullOrWhiteSpace(Convert.ToString(nhanvien.Trangthai)))
                {
                    return 2;
                }
                else
                {
                    exist.Hoten = nhanvien.Hoten;
                    exist.Sdt = nhanvien.Sdt;
                    exist.Vaitro = nhanvien.Vaitro;
                    exist.Email = nhanvien.Email;
                    exist.Pass = nhanvien.Pass;
                    exist.Trangthai = nhanvien.Trangthai;
                    _context.Nhanviens.Update(exist);
                    _context.SaveChanges();
                    return 3;
                }

            }
            catch
            {
                return 1;
            }
        }
    }
}

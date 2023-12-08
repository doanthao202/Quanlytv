using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models1;

namespace A_DAL.Repository
{
    public class Sachrepos: ISachrepos
    {
        DUAN3Context _dbContext = new DUAN3Context();
        public Sachrepos()
        {

        }

        public Sachrepos(DUAN3Context dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(Sach sach)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sach.Tensach))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Saches.Add(sach);
                    _dbContext.SaveChanges();
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
                var exist = _dbContext.Saches.Find(id);


                _dbContext.Saches.Remove(exist);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Sach> GetAllSach()
        {
            return _dbContext.Saches.ToList();
        }

        public Sach GetById(int id)
        {
            return _dbContext.Saches.FirstOrDefault(c => c.Id == id);
        }

        public List<Sach> GetSearch(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Saches.ToList();
            }
            return _dbContext.Saches.Where(c => c.Tensach.Contains(searchText)).ToList();
        }

        public int Update(int id, Sach sach)
        {
            try
            {
                var exist = _dbContext.Saches.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(sach.Tensach))
                {
                    return 2;
                }
                else
                {
                    exist.Tensach = sach.Tensach;
                    exist.Ngaynhap = sach.Ngaynhap;
                    exist.Namxuatban = sach.Namxuatban;
                    exist.Idtheloai = sach.Idtheloai;
                    _dbContext.Saches.Update(exist);
                    _dbContext.SaveChanges();
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

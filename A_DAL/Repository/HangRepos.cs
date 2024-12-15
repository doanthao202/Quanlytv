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
    public class HangRepos: IHangRepos
    {
      DUAN3Context _dbContext= new DUAN3Context();
        public HangRepos()
        {

        }
        public HangRepos(DUAN3Context dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(Hangthanhvien hang)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(hang.Tenhang))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Hangthanhviens.Add(hang);
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
                var exist = _dbContext.Hangthanhviens.Find(id);

                _dbContext.Hangthanhviens.Remove(exist);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Hangthanhvien> GetAllHang()
        {
            return _dbContext.Hangthanhviens.ToList();
        }

        public Hangthanhvien GetById(string hang)
        {
            return _dbContext.Hangthanhviens.FirstOrDefault(c => c.Tenhang == hang);
        }

        public List<Hangthanhvien> GetSearch(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Hangthanhviens.ToList();
            }
            return _dbContext.Hangthanhviens.Where(c => c.Tenhang.Contains(searchText)).ToList();
        }

        public int Update(int id, Hangthanhvien hang)
        {
            try
            {
                var exist = _dbContext.Hangthanhviens.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(hang.Tenhang))
                {
                    return 2;
                }
                else
                {
                    exist.Tenhang = hang.Tenhang;
                    exist.Dongia = hang.Dongia;
                    exist.Thoigianhieuluc = hang.Thoigianhieuluc;
                    _dbContext.Hangthanhviens.Update(exist);
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

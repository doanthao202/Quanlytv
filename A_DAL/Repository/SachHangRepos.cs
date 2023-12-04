using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models1;

namespace A_DAL.Repository
{
    public class SachHangRepos : ISachHangRepos
    {
        DUAN1Context _dbContext = new DUAN1Context();
        public SachHangRepos()
        {
            
        }

        public SachHangRepos(DUAN1Context dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(SachctHang sachctHang)
        {
            try
            {

                _dbContext.SachctHangs.Add(sachctHang);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var exist = _dbContext.SachctHangs.Where(c => c.Idsachct == id).ToList();
                foreach (var item in exist)
                {
                    _dbContext.SachctHangs.Remove(item);

                }
                _dbContext.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<SachctHang> GetAll()
        {
            return _dbContext.SachctHangs.ToList();
        }
    }
}

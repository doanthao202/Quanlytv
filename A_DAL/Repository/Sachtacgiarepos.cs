using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models;

namespace A_DAL.Repository
{
  public class Sachtacgiarepos: ISachtacgiaRepos
    {
        DUAN3Context _dbContext = new DUAN3Context();
        public Sachtacgiarepos()
        {

        }

        public Sachtacgiarepos(DUAN3Context dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(SachTacgium sachtg)
        {
            try
            {

                _dbContext.SachTacgia.Add(sachtg);
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
                var exist = _dbContext.SachTacgia.Where(c=>c.Idsach==id).ToList();
                foreach(var item in exist)
                {
                    _dbContext.SachTacgia.Remove(item);
                   
                }
                _dbContext.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<SachTacgium> GetAll()
        {
            return _dbContext.SachTacgia.ToList();
        }

        
    }
}

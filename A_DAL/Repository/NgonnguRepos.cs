using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models;

namespace A_DAL.Repository
{
    public class NgonnguRepos: INgonnguRepos
    {
        DUAN3Context _dbContext=new DUAN3Context();
        public NgonnguRepos()
        {

        }

        public NgonnguRepos(DUAN3Context dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(Ngonngu ngonngu)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ngonngu.Tennn))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Ngonngus.Add(ngonngu);
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
                var exist = _dbContext.Ngonngus.Find(id);


                _dbContext.Ngonngus.Remove(exist);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<Ngonngu> GetAllNgonngu()
        {
            return _dbContext.Ngonngus.ToList();
        }



        public List<Ngonngu> GetSearch(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Ngonngus.ToList();
            }
            return _dbContext.Ngonngus.Where(c => c.Tennn.Contains(searchText)).ToList();
        }



        public int Update(int id, Ngonngu ngonngu)
        {
            try
            {
                var exist = _dbContext.Ngonngus.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(ngonngu.Tennn))
                {
                    return 2;
                }
                else
                {
                    exist.Tennn = ngonngu.Tennn;
                    _dbContext.Ngonngus.Update(exist);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models1;

namespace A_DAL.Repository
{
    public class NgonnguRepos: INgonnguRepos
    {
        DUAN1Context _dbContext = new DUAN1Context();
        public NgonnguRepos()
        {

        }

        public NgonnguRepos(DUAN1Context dbContext)
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

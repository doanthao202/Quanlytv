using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models;

namespace A_DAL.Repository
{
    public class NxbRepos: INxbRepos
    {
        DUAN3Context _dbContext = new DUAN3Context();
        public NxbRepos()
        {

        }

        public NxbRepos(DUAN3Context dbContext)
        {
            _dbContext = dbContext;
        }


        public int Add(Nxb nxb)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nxb.Tennxb))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Nxbs.Add(nxb);
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
                var exist = _dbContext.Nxbs.Find(id);


                _dbContext.Nxbs.Remove(exist);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<Nxb> GetSearch(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Nxbs.ToList();
            }
            return _dbContext.Nxbs.Where(c => c.Tennxb.Contains(searchText)).ToList();
        }



        public int Update(int id, Nxb nxb)
        {
            try
            {
                var exist = _dbContext.Nxbs.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(nxb.Tennxb))
                {
                    return 2;
                }
                else
                {
                    exist.Tennxb = nxb.Tennxb;

                    exist.Ghichu = nxb.Ghichu;
                    exist.Diachi = nxb.Diachi;
                    exist.Sdt = nxb.Sdt;
                    _dbContext.Nxbs.Update(exist);
                    _dbContext.SaveChanges();
                    return 3;
                }

            }
            catch
            {
                return 1;
            }
        }

        public IEnumerable<Nxb> GetAll()
        {
            return _dbContext.Nxbs.ToList();
        }
    }
}

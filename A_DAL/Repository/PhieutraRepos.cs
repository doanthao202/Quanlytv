using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models1;

namespace A_DAL.Repository
{
    public class PhieutraRepos : IPhieutra
    {
        DUAN3Context _dbContext = new DUAN3Context();
        public PhieutraRepos()
        {
            
        }

        public PhieutraRepos(DUAN3Context dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Phieutra phieutra)
        {
           
                    _dbContext.Phieutras.Add(phieutra);
                    _dbContext.SaveChanges();
                    return true;
          
        }

        public bool Delete(int id)
        {
            try
            {
                var exist = _dbContext.Phieutras.Where(c => c.Idnhanvien== id).ToList();
                foreach (var item in exist)
                {
                    _dbContext.Phieutras.Remove(item);

                }
                _dbContext.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Phieutra> GetAll()
        {
            return _dbContext.Phieutras.ToList();
        }
    }
}

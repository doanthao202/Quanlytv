using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models;

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

        public IEnumerable<Phieutra> GetAll()
        {
            return _dbContext.Phieutras.ToList();
        }
    }
}

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

        public int Add(Phieutra phieutra)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(phieutra.Idnhanvien.ToString()))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Phieutras.Add(phieutra);
                    _dbContext.SaveChanges();
                    return 2;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public IEnumerable<Phieutra> GetAll()
        {
            return _dbContext.Phieutras.ToList();
        }
    }
}

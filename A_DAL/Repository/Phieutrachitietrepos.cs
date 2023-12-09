using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models1;

namespace A_DAL.Repository
{
    public class Phieutrachitietrepos : Iphieutrachitiet
    {
        DUAN3Context _dbContext = new DUAN3Context();
        public Phieutrachitietrepos()
        {
            
        }

        public Phieutrachitietrepos(DUAN3Context dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(Phieutract phieutract)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(phieutract.Idphieutra.ToString())|| string.IsNullOrWhiteSpace(phieutract.Idphieumuonct.ToString()))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Phieutracts.Add(phieutract);
                    _dbContext.SaveChanges();
                    return 2;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public IEnumerable<Phieutract> GetAll()
        {
            return _dbContext.Phieutracts.ToList();
        }
    }
}

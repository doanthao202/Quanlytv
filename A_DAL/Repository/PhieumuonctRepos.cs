using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Repository
{
    public class PhieumuonctRepos : IPhieumuonct
    {
        DUAN3Context _dbContext = new DUAN3Context();
        public int Add(Phieumuonct phieumuonct)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(phieumuonct.Idsachct.ToString())|| string.IsNullOrWhiteSpace(phieumuonct.Idphieumuon.ToString()))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Phieumuoncts.Add(phieumuonct);
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
                var exist = _dbContext.Phieumuoncts.Find(id);


                _dbContext.Phieumuoncts.Remove(exist);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Phieumuonct> GetAll()
        {
            return _dbContext.Phieumuoncts.ToList();
        }

        public int Update(int id, Phieumuonct phieumuonct)
        {
            try
            {
                var exist = _dbContext.Phieumuoncts.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(phieumuonct.Idsachct.ToString()) || string.IsNullOrWhiteSpace(phieumuonct.Idphieumuon.ToString()))
                {
                    return 2;
                }
                else
                {
                    exist.Idsachct = phieumuonct.Idsachct;
                    exist.Idphieumuon= phieumuonct.Idphieumuon;
                    
                    _dbContext.Phieumuoncts.Update(exist);
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

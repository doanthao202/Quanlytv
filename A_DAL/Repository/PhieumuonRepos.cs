﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models1;

namespace A_DAL.Repository
{
    public class PhieumuonRepos : IphieumuonRepos
    {
        DUAN3Context _dbContext= new DUAN3Context();
        public PhieumuonRepos()
        {
            
        }

        public PhieumuonRepos(DUAN3Context dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(Phieumuon phieumuon)
        {
            try
            {
                if ( string.IsNullOrWhiteSpace(phieumuon.Idnhanvien.ToString()))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Phieumuons.Add(phieumuon);
                    _dbContext.SaveChanges();
                    return 2;
                }
            }
            catch (Exception)
            {

                return 0;
            }
            new NotImplementedException();
        }

        public bool Delete(int id)
        {
            try
            {
                var exist = _dbContext.Phieumuons.Find(id);


                _dbContext.Phieumuons.Remove(exist);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Phieumuon> GetAll()
        {
            return _dbContext.Phieumuons.ToList();
        }

        public int Update(int id, Phieumuon phieumuon)
        {
            try
            {
                var exist = _dbContext.Phieumuons.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(phieumuon.Idnhanvien.ToString()))
                {
                    return 2;
                }
                else
                {
                    exist.Iddocgia = phieumuon.Iddocgia;
                    exist.Tendocgia = phieumuon.Tendocgia;
                    exist.Sdt=phieumuon.Sdt;
                    exist.Idnhanvien = phieumuon.Idnhanvien;
                    exist.Ngaymuon = phieumuon.Ngaymuon;
                    exist.Ngaytradukien = phieumuon.Ngaytradukien;
                    exist.Tiencoc = phieumuon.Tiencoc;
                    exist.Phimuon = phieumuon.Phimuon;
                    exist.Tinhtrang = phieumuon.Tinhtrang;
                    _dbContext.Phieumuons.Update(exist);
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

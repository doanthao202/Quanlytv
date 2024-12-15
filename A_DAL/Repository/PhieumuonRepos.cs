using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public bool Add(Phieumuon phieumuon)
        {
          
                    _dbContext.Phieumuons.Add(phieumuon);
                    _dbContext.SaveChanges();
            return true;
               
            
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

        public bool Update(int id)
        {
            try
            {
                var exist = _dbContext.Phieumuons.Find(id);
                
                    exist.Tinhtrang = 0;
                    _dbContext.Phieumuons.Update(exist);
                    _dbContext.SaveChanges();
                    return true;
                

            }
            catch
            {
                return false;
            }
        }
        public bool Update1(int id, DateTime y)
        {
            try
            {
                var exist = _dbContext.Phieumuons.Find(id);

                exist.Ngaytradukien =  y;
                _dbContext.Phieumuons.Update(exist);
                _dbContext.SaveChanges();
                return true;


            }
            catch
            {
                return false;
            }
        }
        public List<Phieumuon> GetSearch(string searchText,string x)
        {
            if (string.IsNullOrWhiteSpace(searchText) && string.IsNullOrWhiteSpace(x))
            {
                return _dbContext.Phieumuons.ToList();
            }
            else if (x =="Khách lẻ"&& !string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Phieumuons.Where(c => c.Tendocgia.Contains(searchText)|| c.Sdt.Contains(searchText)&& c.Iddocgia==null ).ToList();
            }
            else if (x =="Khách lẻ"&& string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Phieumuons.Where(c=> c.Iddocgia==null ).ToList();
            }
            else if (x =="Thành viên"&& !string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Phieumuons.Where(c => c.Tendocgia.Contains(searchText)|| c.Sdt.Contains(searchText)&& c.Iddocgia!=null ).ToList();
            }else if (x =="Thành viên"&& string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Phieumuons.Where(c=>c.Iddocgia!=null ).ToList();
            }
           
            else
            {


                return _dbContext.Phieumuons.Where(c => c.Tendocgia.Contains(searchText) || c.Sdt.Contains(searchText)).ToList();

            }
           // return _dbContext.Theloais.Where(c => c.Tentheloai.Contains(searchText)).ToList();
        }

        public bool Delete1(int id)
        {
            try
            {
                var exist = _dbContext.Phieumuons.Where(c => c.Idnhanvien == id).ToList();
                foreach (var item in exist)
                {
                    _dbContext.Phieumuons.Remove(item);

                }
                _dbContext.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Phieumuon> GetSearch1(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Phieumuons.ToList();
            }
            return _dbContext.Phieumuons.Where(c => c.Id.ToString().Contains(searchText) || c.Tendocgia.Contains(searchText)).ToList();
        }
    }
}

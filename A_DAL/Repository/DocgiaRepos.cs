using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models1;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Repository
{
    public class DocgiaRepos : IDocgiaRepos
    {
        DUAN3Context _dbcontext = new DUAN3Context();
        public DocgiaRepos()
        {
            
        }

        public DocgiaRepos(DUAN3Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public int Add(Docgium docgium)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(docgium.Hoten))
                {
                    return 1;
                }
                else
                {
                    _dbcontext.Docgia.Add(docgium);
                    _dbcontext.SaveChanges();
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
                var exist = _dbcontext.Docgia.Find(id);


                _dbcontext.Docgia.Remove(exist);
                _dbcontext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete1(int id)
        {
            try
            {
                var exist = _dbcontext.Docgia.Where(c => c.Idhang == id).ToList();
                foreach (var item in exist)
                {
                    _dbcontext.Docgia.Remove(item);

                }
                _dbcontext.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Docgium> GetAll()
        {
            return _dbcontext.Docgia.ToList();
        }

        
        public int Update(int id, Docgium docgium)
        {
            try
            {
                var exist = _dbcontext.Docgia.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(docgium.Hoten))
                {
                    return 2;
                }
                else
                {
                    exist.Hoten = docgium.Hoten;
                    exist.Email = docgium.Email;
                    exist.Sdt = docgium.Sdt;
                    exist.Diachi = docgium.Diachi;
                    exist.Cmnd = docgium.Cmnd;
                    exist.Ngaysinh = docgium.Ngaysinh;
                    exist.Hanthe = docgium.Hanthe;
                    exist.Trangthai = docgium.Trangthai;
                    exist.Idhang = docgium.Idhang;

                    _dbcontext.Docgia.Update(exist);
                    _dbcontext.SaveChanges();
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

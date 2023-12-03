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
    public class TacgiaRepos : ITacgiaRepos
    {
        DUAN1Context _dbContext = new DUAN1Context();
        public TacgiaRepos()
        {
            
        }

        public TacgiaRepos(DUAN1Context dbcontext)
        {
            _dbContext = dbcontext;
        }

        public IEnumerable<Tacgium> GetAll()
        {
            return _dbContext.Tacgia.ToList(); 
        }
        public int Add(Tacgium tacgia)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tacgia.Tentacgia))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Tacgia.Add(tacgia);
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
                var exist = _dbContext.Tacgia.Find(id);


                _dbContext.Tacgia.Remove(exist);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public Tacgium GetById(string tg)
        {
            return _dbContext.Tacgia.FirstOrDefault(c => c.Tentacgia == tg);
        }

        public List<Tacgium> GetSearch(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Tacgia.ToList();
            }
            return _dbContext.Tacgia.Where(c => c.Tentacgia.Contains(searchText)).ToList();
        }



        public int Update(int id, Tacgium tacgia)
        {
            try
            {
                var exist = _dbContext.Tacgia.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(tacgia.Tentacgia))
                {
                    return 2;
                }
                else
                {
                    exist.Tentacgia = tacgia.Tentacgia;
                    exist.Ghichu = tacgia.Ghichu;
                    _dbContext.Tacgia.Update(exist);
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

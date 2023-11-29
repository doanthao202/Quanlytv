using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models;

namespace A_DAL.Repository
{
    public class TheloaiRepos : ITheloaiRepos
    {
        DUAN1Context _dbContext = new DUAN1Context();
        public TheloaiRepos()
        {
            
        }

        public TheloaiRepos(DUAN1Context dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(Theloai theloai)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(theloai.Tentheloai))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Theloais.Add(theloai);
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
                var exist = _dbContext.Theloais.Find(id);


                _dbContext.Theloais.Remove(exist);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<Theloai> GetAllTheloai()
        {
            return _dbContext.Theloais.ToList();
        }

        public Theloai GetById(int id)
        {
            return _dbContext.Theloais.FirstOrDefault(c => c.Id == id);
        }

        public List<Theloai> GetSearch(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Theloais.ToList();
            }
            return _dbContext.Theloais.Where(c => c.Tentheloai.Contains(searchText)).ToList();
        }

        public List<Theloai> GetTheloaiByName(string name)
        {
            return _dbContext.Theloais.Where(c => c.Tentheloai.Contains(name)).ToList();
        }

        public int Update(int id, Theloai theloai)
        {
            try
            {
                var exist = _dbContext.Theloais.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(theloai.Tentheloai))
                {
                    return 2;
                }
                else {
                    exist.Tentheloai = theloai.Tentheloai;
                    exist.Vitri = theloai.Vitri;
                    _dbContext.Theloais.Update(exist);
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

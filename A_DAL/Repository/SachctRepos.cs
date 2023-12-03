using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models1;

namespace A_DAL.Repository
{
   public class SachctRepos:ISachctRepos
    {
        DUAN1Context _dbContext = new DUAN1Context();
        public SachctRepos()
        {
            
        }

        public SachctRepos(DUAN1Context dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(Sachchitiet sachct)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Convert.ToString(sachct.Idsach))|| string.IsNullOrWhiteSpace(Convert.ToString(sachct.Idngonngu))||string.IsNullOrWhiteSpace(Convert.ToString(sachct.Idnxb)))
                {
                    return 1;
                }
                else
                {
                    _dbContext.Sachchitiets.Add(sachct);
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
                var exist = _dbContext.Sachchitiets.Find(id);


                _dbContext.Sachchitiets.Remove(exist);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Sachchitiet> GetAll()
        {
            return _dbContext.Sachchitiets.ToList();
        }

        

       /* public List<Sachchitiet> GetSearch(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _dbContext.Sachchitiets.ToList();
            }
            return _dbContext.Sachchitiets.Where(c => c.Idsach.Contains(searchText)).ToList();
        }*/

        public int Update(int id, Sachchitiet sachct)
        {
            try
            {
                var exist = _dbContext.Sachchitiets.Find(id);
                if (exist == null)
                {
                    return 1;
                }
                else if (string.IsNullOrWhiteSpace(Convert.ToString(sachct.Idsach)) || string.IsNullOrWhiteSpace(Convert.ToString(sachct.Idngonngu)) || string.IsNullOrWhiteSpace(Convert.ToString(sachct.Idnxb)))
                {
                    return 2;
                }
                else
                {
                    exist.Idsach = sachct.Idsach;
                    exist.Idngonngu= sachct.Idngonngu;
                    exist.Idnxb= sachct.Idnxb;
                    exist.Lantaiban = sachct.Lantaiban;
                    exist.Giasach = sachct.Giasach;
                    exist.Dotuoidocsach = sachct.Dotuoidocsach;
                    exist.Tinhtrang = sachct.Tinhtrang;
                    _dbContext.Sachchitiets.Update(exist);
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

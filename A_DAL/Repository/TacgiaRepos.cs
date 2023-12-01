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
        DUAN1Context _dbcontext = new DUAN1Context();
        public TacgiaRepos()
        {
            
        }

        public TacgiaRepos(DUAN1Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Tacgium> GetAll()
        {
            return _dbcontext.Tacgia.ToList(); 
        }
    }
}

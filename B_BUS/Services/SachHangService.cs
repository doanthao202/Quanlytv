using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;

namespace B_BUS.Services
{
    public class SachHangService
    {
        SachHangRepos _repos = new SachHangRepos();
        HangRepos _hangRepos = new HangRepos();
        public SachHangService()
        {
            
        }

        public SachHangService(SachHangRepos repos, HangRepos hangRepos)
        {
            _repos = repos;
            _hangRepos = hangRepos;
        }
        public bool add(SachctHang sachctHang)
        {
            return _repos.Add(sachctHang);
        }
        public IEnumerable<SachctHang> GetAll()
        {
            return _repos.GetAll().ToList();
        }
        public bool Delete(int id)
        {
            return _repos.Delete(id);
        }
    }
}

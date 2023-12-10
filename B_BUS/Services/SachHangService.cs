using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.Repository;
using B_BUS.Viewmoder;

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
        }  public bool Delete1(int id)
        {
            return _repos.Delete1(id);
        }
        public List<Sachhang> Getview(int id)
        {
            var joinData = from SachctHang in _repos.GetAll()
                           join Hangthanhvien in _hangRepos.GetAllHang() on SachctHang.Idhang equals Hangthanhvien.Id
                           where SachctHang.Idsachct == id
                           select new Sachhang
                           {
                               Tenhang= Hangthanhvien.Tenhang
                           };
            return joinData.ToList();
        }
    }
}

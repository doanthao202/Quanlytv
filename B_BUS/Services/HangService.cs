using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;

namespace B_BUS.Services
{
    public class HangService
    {
        HangRepos _hangRepos = new HangRepos();
        public HangService() { }
        public HangService(HangRepos hangRepos)
        {
            _hangRepos = hangRepos;
        }
        public string Add(Hangthanhvien hang)
        {
            if (_hangRepos.Add(hang) == 2)
            {
                return "Thêm thành công!!";
            }
            else if (_hangRepos.Add(hang) == 1)
            {
                return "Tên hạng không được bỏ trống!!";
            }
            else
            {
                return "Thêm thất bại!!";
            }
        }
        public bool Delete(int id)
        {
            return _hangRepos.Delete(id);
        }
        public IEnumerable<Hangthanhvien> GetAll()
        {
            return _hangRepos.GetAllHang().ToList();
        }

        public List<Hangthanhvien> GetSearch(string SearchText)
        {
            return _hangRepos.GetSearch(SearchText);
        }
        public int Update(int id, Hangthanhvien hang)
        {
            return _hangRepos.Update(id, hang);
        }
        public Hangthanhvien GetById(string hang)
        {
            return _hangRepos.GetById(hang);
        }
    }
}

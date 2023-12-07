using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models;

namespace A_DAL.Repository
{
    public class LoginRepos : ILoginRepos
    {
        private DUAN3Context _duAnOne;
        public LoginRepos()
        {
            _duAnOne = new DUAN3Context();
        }



        public Nhanvien GetNhanvienByUsername(string username)
        {
            return _duAnOne.Nhanviens.Where(x => x.Sdt == username || x.Email == username).FirstOrDefault();
        }
    }
}

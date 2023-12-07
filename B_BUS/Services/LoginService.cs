using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepository;
using A_DAL.Models;
using A_DAL.Repository;

namespace B_BUS.Services
{
    public class LoginService
    {
        private readonly ILoginRepos iloginRepostory;
        

       

        public LoginService(LoginRepos iloginRepostory)
        {
            this.iloginRepostory = iloginRepostory;
        }

        public Nhanvien GetNhanvienByUsername(string username)
        {
            return iloginRepostory.GetNhanvienByUsername(username);
        }
    }
}

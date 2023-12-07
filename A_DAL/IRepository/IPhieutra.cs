using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;

namespace A_DAL.IRepository
{
    internal interface IPhieutra
    {
        IEnumerable<Phieutra> GetAll();
        //List<Sach> GetTheloaiByName(string name);

        bool Add(Phieutra phieutra);

       
    }
}

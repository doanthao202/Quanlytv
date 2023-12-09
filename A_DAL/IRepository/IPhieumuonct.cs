using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;

namespace A_DAL.IRepository
{
    internal interface IPhieumuonct
    {
        IEnumerable<Phieumuonct> GetAll();

        int Add(Phieumuonct phieumuonct);
        int Update(int id, Phieumuonct phieumuonct);
        bool Delete(int id);
        bool Delete1(int id);
    }
}

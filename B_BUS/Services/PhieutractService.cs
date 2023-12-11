using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;
using B_BUS.Viewmoder;

namespace B_BUS.Services
{
    public class PhieutractService
    {
        PhieumuonctRepos _repos1 = new PhieumuonctRepos();
        PhieumuonRepos _pmrepos = new PhieumuonRepos();
        Phieutrachitietrepos _repos = new Phieutrachitietrepos();
        //PhieumuonctService _phieumuonctService= new PhieumuonctService();   
        public PhieutractService()
        {
            
        }

        public PhieutractService(Phieutrachitietrepos repos)
        {
            _repos = repos;
        }
        public string add(Phieutract phieutra)
        {
            if (_repos.Add(phieutra) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(phieutra) == 1)
            {
                return "Tên  không được để trống";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public IEnumerable<Phieutract> GetAll()
        {
            return _repos.GetAll().ToList();
        }
        public List<PmPtPmct> Getview1()
        {

            var joinData = from Phieumuon in _pmrepos.GetAll()
                           join Phieumuonct in _repos1.GetAll() on Phieumuon.Id equals Phieumuonct.Idphieumuon
                           from Phieutract in _repos.GetAll()
                           where (Phieumuon.Tinhtrang == 1 && Phieumuon.Id == Phieumuonct.Idphieumuon && Phieumuonct.Id != Phieutract.Idphieumuonct && DateTime.Now > Phieumuon.Ngaytradukien)

                           group Phieumuon by Phieumuon.Id into a
                           select new PmPtPmct
                           {
                               Idphieumuon = a.First().Id,
                               Iddocgia = a.First().Iddocgia,
                               Idnhanvien = a.First().Idnhanvien,
                               Tendocgia = a.First().Tendocgia,
                               Sdt = a.First().Sdt,
                               Ngaymuon = a.First().Ngaymuon,
                               Ngaytradukien = a.First().Ngaytradukien,
                               /* Idphieumuon = Phieumuon.Id,
                                Iddocgia = Phieumuon.Iddocgia,
                                Idnhanvien = Phieumuon.Idnhanvien,
                                Tendocgia = Phieumuon.Tendocgia,
                                Sdt = Phieumuon.Sdt,
                                Ngaymuon = Phieumuon.Ngaymuon,
                                Ngaytradukien = Phieumuon.Ngaytradukien,
                                Tinhtrang = Phieumuon.Tinhtrang,
                                Idphieumuonct = Phieumuonct.Id,
                                Idphieutract = (Phieumuonct.Id == Phieutract.Idphieumuonct) ? Phieutract.Idphieumuonct : 0,*/
                               soluong = (a.Count())/298

                           };
            return joinData.ToList();
        }
    }
}

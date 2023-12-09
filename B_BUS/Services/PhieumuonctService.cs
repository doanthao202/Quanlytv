using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;
using B_BUS.Viewmoder;
using BoldReports.Data;

namespace B_BUS.Services
{
    public class PhieumuonctService
    { 
        PhieumuonctRepos _repos = new PhieumuonctRepos();
        SachctRepos _srepos = new SachctRepos();
        Sachrepos _schrepos = new Sachrepos();
        NgonnguRepos _nnrepos = new NgonnguRepos();
        NxbRepos _nxbrepos = new NxbRepos();
        PhieumuonService _pmrepos = new PhieumuonService();
      PhieutractService _ptct = new PhieutractService();
        public PhieumuonctService()
        {
            
        }

        public PhieumuonctService(PhieumuonctRepos repos, SachctRepos srepos, Sachrepos schrepos, NgonnguRepos nnrepos, NxbRepos nxbrepos, PhieumuonService pmrepos, PhieutractService ptct)
        {
            _repos = repos;
            _srepos = srepos;
            _schrepos = schrepos;
            _nnrepos = nnrepos;
            _nxbrepos = nxbrepos;
            _pmrepos = pmrepos;
            _ptct = ptct;
        }

        public string add(Phieumuonct phieumuon)
        {
            if (_repos.Add(phieumuon) == 2)
            {
                return "Thêm thành công";
            }
            else if (_repos.Add(phieumuon) == 1)
            {
                return "Tên  không được để trống";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public bool Delete(int id)
        {
            return _repos.Delete(id);
        }public bool Delete1(int id)
        {
            return _repos.Delete1(id);
        }
        public IEnumerable<Phieumuonct> GetAll()
        {
            return _repos.GetAll().ToList();
        }


        public int Update(int id, Phieumuonct phieumuon)
        {
            return _repos.Update(id, phieumuon);
        }
      //  var y = _ptct.GetAll().ToList();
        public List<SachctSachPmct> Getview()
        {
            
            var joinData = from Sach in _schrepos.GetAllSach()
                           join Sachchitiet in _srepos.GetAll() on Sach.Id equals Sachchitiet.Idsach
                           join Ngonngu in _nnrepos.GetAllNgonngu() on Sachchitiet.Idngonngu equals Ngonngu.Id
                           join Nxb in _nxbrepos.GetAll() on Sachchitiet.Idnxb equals Nxb.Id
                           join Phieumuonct in _repos.GetAll() on Sachchitiet.Id equals Phieumuonct.Idsachct
                           join Phieumuon in _pmrepos.GetAll() on Phieumuonct.Idphieumuon equals Phieumuon.Id

                           //where (Phieumuonct.Id != y.id)

                           select new SachctSachPmct
                           {
                               Id = Phieumuonct.Id,
                               Idsachct = Sachchitiet.Id,
                               Tensach = Sach.Tensach,
                               Idphieumuon = Phieumuonct.Idphieumuon,
                               Iddocgia = Phieumuon.Iddocgia,
                               Tendocgia = Phieumuon.Tendocgia,
                               Sdt = Phieumuon.Sdt,
                               Tennn = Ngonngu.Tennn,
                               Tennxb = Nxb.Tennxb,
                               Lantaiban = Sachchitiet.Lantaiban,
                              //Idphieutra = (b != null) ? b.Idphieutra 
                           };
            return joinData.ToList();
        }

        public List<PmPtPmct> Getview1()
        {

            var joinData = from Phieumuon in _pmrepos.GetAll()
                           join Phieumuonct in _repos.GetAll() on Phieumuon.Id equals Phieumuonct.Idphieumuon
                           from Phieutract in _ptct.GetAll()

                           where (Phieumuon.Tinhtrang == 1 && Phieumuon.Id == Phieumuonct.Idphieumuon && Phieumuonct.Id != Phieutract.Idphieumuonct && DateTime.Now>Phieumuon.Ngaytradukien)

                           group Phieumuon by Phieumuon.Id into a
                           select new PmPtPmct
                           {
                               Idphieumuon = a.FirstOrDefault().Id,
                               Iddocgia = a.FirstOrDefault().Iddocgia,
                               Idnhanvien = a.FirstOrDefault().Idnhanvien,
                               Tendocgia = a.FirstOrDefault().Tendocgia,
                               Sdt = a.FirstOrDefault().Sdt,
                               Ngaymuon = a.FirstOrDefault().Ngaymuon,
                               Ngaytradukien = a.FirstOrDefault().Ngaytradukien,
                               //Tinhtrang = Phieumuon.Tinhtrang,
                               //Idphieumuonct =Phieumuonct.Id,
                               //Idphieutra= (Phieumuonct.Id==Phieutract.Idphieumuonct) ? Phieutract.Idphieumuonct : 0,
                               soluong = a.Count()

                           };
            return joinData.ToList();
        }
    }
}

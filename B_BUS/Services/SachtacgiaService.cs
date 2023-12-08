using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.Repository;
using B_BUS.Viewmoder;
using Microsoft.EntityFrameworkCore;

namespace B_BUS.Services
{
    public class SachtacgiaService
    {
        Sachtacgiarepos _repos = new Sachtacgiarepos();
        TacgiaRepos _tgrepoes = new TacgiaRepos();
        public SachtacgiaService()
        {

        }

        public SachtacgiaService(Sachtacgiarepos repos)
        {
            _repos = repos;
        }

        public SachtacgiaService(TacgiaRepos tgrepoes)
        {
            _tgrepoes = tgrepoes;
        }

        public bool add(SachTacgium sachtg)
        {
            return _repos.Add(sachtg);
        }
        public IEnumerable<SachTacgium> GetAll()
        {
            return _repos.GetAll().ToList();
        }
        public bool Delete(int id)
        {
            return _repos.Delete(id);
        }
        public List<Sachtacgia> Getview(int id)
        {
            var joinData = from SachTacgium in _repos.GetAll()
                           join Tacgium in _tgrepoes.GetAll() on SachTacgium.Idtacgia equals Tacgium.Id where SachTacgium.Idsach == id
                           select new Sachtacgia
                           {
                               Idsach = SachTacgium.Idsach,
                               Tentacgia= Tacgium.Tentacgia,
                               Vaitro = SachTacgium.Vaitro
                           };
            return joinData.ToList();
        }
    }
}

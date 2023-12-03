using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models1;
using A_DAL.Repository;
using Microsoft.EntityFrameworkCore;

namespace B_BUS.Services
{
    public class SachtacgiaService
    {
        Sachtacgiarepos _repos = new Sachtacgiarepos();
        public SachtacgiaService()
        {

        }

        public SachtacgiaService(Sachtacgiarepos repos)
        {
            _repos = repos;
        }
        public bool add(SachTacgium sachtg)
        {
            return _repos.Add(sachtg);
        }
        public IEnumerable<SachTacgium> GetAll()
        {
            return _repos.GetAll().ToList();
        }
    }
}

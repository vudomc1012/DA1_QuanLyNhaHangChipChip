using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _1_DAL.iDALServices
{
    public interface IThucDonService
    {
        public string AddThucDon(ThucDon thucDon);
        public string UpdateThucDon(ThucDon thucDon);
        public string DeleteThucDon(ThucDon thucDon);
        public string SaveThucDon();
        public List<ThucDon> GetThucDonFromDB();
    }
}

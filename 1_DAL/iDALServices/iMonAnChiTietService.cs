using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iMonAnChiTietService
    {
        public string AddMonAnChiTiet(MonAnChiTiet MonAnChiTiet);
        public string UpdateMonAnChiTiet(MonAnChiTiet MonAnChiTiet);
        public string DeleteMonAnChiTiet(MonAnChiTiet MonAnChiTiet);
        public string SaveMonAnChiTiet();
        public List<MonAnChiTiet> GetDetailsFromDB();
    }
}

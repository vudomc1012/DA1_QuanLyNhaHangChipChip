using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iHoaDonService
    {
        public void AddHoaDon(HoaDon HoaDon);
        public void UpdateHoaDon(HoaDon HoaDon);
        public string DeleteHoaDon(HoaDon HoaDon);
        public string SaveHoaDon();
        public List<HoaDon> GetBillsFromDB();
    }
}

using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iBillDetailService
    {
        public string AddHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet);
        public string UpdateHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet);
        public string DeleteHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet);
        public string SaveHoaDonChiTiet();
        public List<HoaDonChiTiet> GetDetailsFromDB();
    }
}

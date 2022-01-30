using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Context;
using _1_DAL.iDALServices;
using _1_DAL.Models;

namespace _1_DAL.DALServices
{
    public class BillDetailService : iBillDetailService
    {
        DatabaseContext _dbContext = new DatabaseContext();
        List<HoaDonChiTiet> _lstTables;

        public BillDetailService()
        {
        }

        public string AddHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet)
        {
            _dbContext.HoaDonChiTiets.Add(HoaDonChiTiet);
            return "Thêm thành công";
        }
        public string UpdateHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet)
        {
            _dbContext.HoaDonChiTiets.Update(HoaDonChiTiet);
            return "Sửa thành công";
        }
        public string DeleteHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet)
        {
            _dbContext.HoaDonChiTiets.Remove(HoaDonChiTiet);
            return "Xóa thành công";
        }
        public string SaveHoaDonChiTiet()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }
        public List<HoaDonChiTiet> GetDetailsFromDB()
        {
            return _lstTables = _dbContext.HoaDonChiTiets.ToList();
        }
    }
}

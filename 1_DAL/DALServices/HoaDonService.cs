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
    public class HoaDonService : iHoaDonService
    {
        DatabaseContext _dbContext = new DatabaseContext();
        List<HoaDon> _lstTables;
        public void AddHoaDon(HoaDon HoaDon)
        {
            _dbContext.HoaDons.Add(HoaDon);
            _dbContext.SaveChanges();
        }
        public void UpdateHoaDon(HoaDon HoaDon)
        {
            _dbContext.HoaDons.Update(HoaDon);
            _dbContext.SaveChanges();
        }
        public string DeleteHoaDon(HoaDon HoaDon)
        {
            _dbContext.HoaDons.Remove(HoaDon);
            return "Xóa thành công";
        }
        public string SaveHoaDon()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }
        public List<HoaDon> GetBillsFromDB()
        {
            return _lstTables = _dbContext.HoaDons.ToList();
        }

        
    }
}

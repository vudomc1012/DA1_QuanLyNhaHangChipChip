using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using _1_DAL.Context;

namespace _1_DAL.DALServices
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        DatabaseContext _dbConText;
        public HoaDonChiTietService()
        {
            _dbConText = new DatabaseContext();
        }
        public void AddHoaDonCT(HoaDonChiTiet HoaDon)
        {
            _dbConText.HoaDonChiTiets.Add(HoaDon);
            _dbConText.SaveChanges();
           
        }

        public void DeleteHoaDonCT(HoaDonChiTiet HoaDon)
        {
            _dbConText.HoaDonChiTiets.Update(HoaDon);
            _dbConText.SaveChanges();
           
        }

        public List<HoaDonChiTiet> GetHoaDonCTFromDB()
        {
            return _dbConText.HoaDonChiTiets.ToList();
        }

        public string SaveHoaDon()
        {
            _dbConText.SaveChanges();
            return "Lưu thành công";
        }

        public void UpdateHoaDonCT(HoaDonChiTiet HoaDon)
        {
            _dbConText.HoaDonChiTiets.Update(HoaDon);
            _dbConText.SaveChanges();
            
        }
    }
}

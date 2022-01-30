using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Context;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL.DALServices
{
    public class NhanVienService : INhanVienService
    {
        private DatabaseContext _dbContext = new DatabaseContext();
        private List<NhanVien> _lstNV = new List<NhanVien>();

        public NhanVienService()
        {

        }
        //
        public string AddNV(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Add(nhanVien);

            return "Thêm thành công";
        }

        public string EditNV(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Update(nhanVien);

            return "Sửa thành công";
        }

        public string removeNV(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Remove(nhanVien);

            return "Xóa thành công";
        }
        public List<NhanVien> GetLstNVfromDB()
        {
            return _lstNV = _dbContext.NhanViens.AsNoTracking().ToList();
        }
        public string Save()
        {
            _dbContext.SaveChanges();
                return "Lưu thành công";
        }
    }
}
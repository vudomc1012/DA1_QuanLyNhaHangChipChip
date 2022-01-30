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
    public class CachCheBienService : iCachChebienService
    {
        DatabaseContext _dbContext = new DatabaseContext();
        List<CachCheBien> _lstTables;

        public CachCheBienService()
        {
        }

        public string AddCachCheBien(CachCheBien CachCheBien)
        {
            _dbContext.CachCheBiens.Add(CachCheBien);
            return "Thêm thành công";
        }
        public string UpdateCachCheBien(CachCheBien CachCheBien)
        {
            _dbContext.CachCheBiens.Update(CachCheBien);
            return "Sửa thành công";
        }
        public string DeleteCachCheBien(CachCheBien CachCheBien)
        {
            _dbContext.CachCheBiens.Remove(CachCheBien);
            return "Xóa thành công";
        }
        public string SaveCachCheBien()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }
        public List<CachCheBien> GetMethodsFromDB()
        {
            return _lstTables = _dbContext.CachCheBiens.ToList();
        }
    }
}

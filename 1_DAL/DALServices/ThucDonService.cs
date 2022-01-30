using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
using _1_DAL.iDALServices;
using _1_DAL.Context;

namespace _1_DAL.DALServices
{
    public class ThucDonService : IThucDonService
    {
        DatabaseContext _dbContext;
        List<ThucDon> _lstThucDon;
        public ThucDonService()
        {
            _dbContext = new DatabaseContext();
        }
        public string AddThucDon(ThucDon thucDon)
        {
            _dbContext.ThucDons.Add(thucDon);
            return "Thêm thành công";
        }

        public string DeleteThucDon(ThucDon thucDon)
        {
            _dbContext.ThucDons.Remove(thucDon);
            return "Xóa thành công";
        }

        public List<ThucDon> GetThucDonFromDB()
        {
            return _lstThucDon = _dbContext.ThucDons.ToList();
        }

        public string SaveThucDon()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }

        public string UpdateThucDon(ThucDon thucDon)
        {
            _dbContext.ThucDons.Update(thucDon);
            return "Sửa thành công";
        }
    }
}

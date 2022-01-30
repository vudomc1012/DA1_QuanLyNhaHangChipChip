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
    public class DonViService : iDonViService
    {
        DatabaseContext _dbContext = new DatabaseContext();
        List<DonVi> _lstTables;

        public DonViService()
        {
        }

        public string AddDonVi(DonVi DonVi)
        {
            _dbContext.DonVis.Add(DonVi);
            return "Thêm thành công";
        }
        public string UpdateDonVi(DonVi DonVi)
        {
            _dbContext.DonVis.Update(DonVi);
            return "Sửa thành công";
        }
        public string DeleteDonVi(DonVi DonVi)
        {
            _dbContext.DonVis.Remove(DonVi);
            return "Xóa thành công";
        }
        public string SaveDonVi()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }
        public List<DonVi> GetUnitsFromDB()
        {
            return _lstTables = _dbContext.DonVis.ToList();
        }
    }
}

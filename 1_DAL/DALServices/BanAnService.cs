using _1_DAL.Context;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DALServices
{
    public class BanAnService : iBanAnService
    {
        DatabaseContext _dbContext = new DatabaseContext();

        public BanAnService()
        {
            
        }

        public string AddBanAn(BanAn BanAn)
        {
            _dbContext.BanAns.Add(BanAn);
            _dbContext.SaveChanges();
            return "Thêm thành công";
        }
        public void UpdateBanAn(BanAn BanAn)
        {
            _dbContext.BanAns.Update(BanAn);
            _dbContext.SaveChanges();            
        }
        public string DeleteBanAn(BanAn BanAn)
        {
            _dbContext.BanAns.Remove(BanAn);
            _dbContext.SaveChanges();
            return "Xóa thành công";
        }        
        public List<BanAn> GetTablesFromDB()
        {
            return _dbContext.BanAns.ToList();
        }
    }
}

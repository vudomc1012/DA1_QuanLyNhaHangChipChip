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
    public class DMFoodService : iDMFoodService
    {
        DatabaseContext _dbContext = new DatabaseContext();
        List<DanhMucFood> _lstTables;

        public DMFoodService()
        {
        }

        public string AddDMFood(DanhMucFood DMFood)
        {
            _dbContext.DanhMucFoods.Add(DMFood);
            return "Thêm thành công";
        }
        public string UpdateDMFood(DanhMucFood DMFood)
        {
            _dbContext.DanhMucFoods.Update(DMFood);
            return "Sửa thành công";
        }
        public string DeleteDMFood(DanhMucFood DMFood)
        {
            _dbContext.DanhMucFoods.Remove(DMFood);
            return "Xóa thành công";
        }
        public string SaveDMFood()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }
        public List<DanhMucFood> GetCategoriesFromDB()
        {
            return _lstTables = _dbContext.DanhMucFoods.ToList();
        }
    }
}

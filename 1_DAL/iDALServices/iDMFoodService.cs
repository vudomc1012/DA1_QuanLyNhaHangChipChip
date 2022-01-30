using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iDMFoodService
    {
        public string AddDMFood(DanhMucFood DMFood);
        public string UpdateDMFood(DanhMucFood DMFood);
        public string DeleteDMFood(DanhMucFood DMFood);
        public string SaveDMFood();
        public List<DanhMucFood> GetCategoriesFromDB();
    }
}

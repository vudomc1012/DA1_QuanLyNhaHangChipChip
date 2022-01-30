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
    public class FloorService : iFloorService
    {
        DatabaseContext _dbContext = new DatabaseContext();
        List<Floor> _lstTables;

        public FloorService()
        {
        }

        public string AddFloor(Floor Floor)
        {
            _dbContext.Floors.Add(Floor);
            _dbContext.SaveChanges();
            return "Thêm thành công";
        }
        public string UpdateFloor(Floor Floor)
        {
            _dbContext.Floors.Update(Floor);
            _dbContext.SaveChanges();
            return "Sửa thành công";
        }
        public string DeleteFloor(Floor Floor)
        {
            _dbContext.Floors.Remove(Floor);
            _dbContext.SaveChanges();
            return "Xóa thành công";
        }        
        public List<Floor> GetFloorsFromDB()
        {
            return _lstTables = _dbContext.Floors.ToList();
        }
    }
}

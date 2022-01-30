using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iFloorService
    {
        public string AddFloor(Floor Floor);
        public string UpdateFloor(Floor Floor);
        public string DeleteFloor(Floor Floor);
        public List<Floor> GetFloorsFromDB();
    }
}

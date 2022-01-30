using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
using _1_DAL.DALServices;
using _1_DAL.iDALServices;
using _2_BUS.iBUSServices;
using _2_BUS.Models;

namespace _2_BUS.BUSServices
{
    public class QLBanAnService : IQLBanAnService
    {
        iBanAnService _Ba;
        List<ViewBanAn> _lstBan;
        iFloorService _F;
        public QLBanAnService()
        {
            _Ba = new BanAnService();
            _F = new FloorService();
            _lstBan = new List<ViewBanAn>();
        }
        public string AddBanAn(BanAn BanAn)
        {
            return _Ba.AddBanAn(BanAn);
        }

        public string AddFloor(Floor Floor)
        {
            return _F.AddFloor(Floor);
        }

        public string DeleteBanAn(BanAn BanAn)
        {
            return _Ba.DeleteBanAn(BanAn);
        }

        public string DeleteFloor(Floor Floor)
        {
            return _F.DeleteFloor(Floor);
        }

        public List<Floor> GetFloorsFromDB()
        {
            return _F.GetFloorsFromDB();
        }

        public List<ViewBanAn> GetlistBanAn()
        {
            return _lstBan = (from a in _Ba.GetTablesFromDB()
                              join b in _F.GetFloorsFromDB()
                              on a.Floor equals b.Id
                              select new ViewBanAn()
                              {
                                    BanAn = a, 
                                    Tang = b
                              }).ToList();
        }

        public List<BanAn> GetTablesFromDB()
        {
            return _Ba.GetTablesFromDB();
        }

        //public List<BanAn> LoadBanlist()
        //{
        //    List<BanAn> bananlist = new List<BanAn>();
        //    //foreach ( item in collection)
        //    //{

        //    //}
        //    return bananlist;
        //}

        public void UpdateBanAn(BanAn BanAn)
        {
             _Ba.UpdateBanAn(BanAn);
        }

        public string UpdateFloor(Floor Floor)
        {
            return _F.UpdateFloor(Floor);
        }

    }
}

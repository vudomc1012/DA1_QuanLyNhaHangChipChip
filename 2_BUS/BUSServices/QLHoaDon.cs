using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.iBUSServices;
using _1_DAL.Models;
using _1_DAL.DALServices;
using _1_DAL.iDALServices;
using _2_BUS.Models;

namespace _2_BUS.BUSServices
{
    public class QLHoaDon : IQLHoaDon
    {
        IHoaDonChiTietService _HDCT;
        iHoaDonService _HD;
        List<ViewHoaDon> _lstViewHD;
        iBanAnService _iBan;
        iMonAnChiTietService _monCT;
        IQLNhanVienService _NV;
        public QLHoaDon()
        {
            _HD = new HoaDonService();
            _HDCT = new HoaDonChiTietService();
            _iBan = new BanAnService();
            _monCT = new MonAnChiTietService();
            _NV = new QLNhanVienService();
        }
        public void AddHoaDon(HoaDon HoaDon)
        {
             _HD.AddHoaDon(HoaDon);
        }        

        public void AddHoaDonCT(HoaDonChiTiet HoaDon)
        {
             _HDCT.AddHoaDonCT(HoaDon);
        }

        public void DeleteHoaDon(HoaDon HoaDon)
        {
             _HD.DeleteHoaDon(HoaDon);
        }        

        public void DeleteHoaDonCT(HoaDonChiTiet HoaDon)
        {
             _HDCT.DeleteHoaDonCT(HoaDon);
        }

        public List<HoaDon> GetBillsFromDB()
        {
            return _HD.GetBillsFromDB();
        }

        public List<HoaDonChiTiet> GetHoaDonCTFromDB()
        {
            return _HDCT.GetHoaDonCTFromDB();
        }

        public List<ViewHoaDon> GetListDSHoaDon()
        {
            return _lstViewHD = (from a in _HD.GetBillsFromDB()
                                 join b in _HDCT.GetHoaDonCTFromDB()
                                 on a.Id equals b.Idbill
                                 join c in _iBan.GetTablesFromDB()
                                 on a.Idtable equals c.Id
                                 join d in _monCT.GetDetailsFromDB()
                                 on b.Idfood equals d.Id
                                 join e in _NV.getlstNhanViens()
                                 on a.IdnhanVien equals e.Id
                                 select new ViewHoaDon() 
                                 {
                                     hoaDon=a,
                                     hoaDonChiTiet=b,
                                     banAn= c,
                                     monAnChiTiet = d,
                                     nhanVien =e
                                 }).ToList();
        }

        public string SaveHoaDon()
        {
            return _HD.SaveHoaDon();
        }

        public string SaveHoaDonChiTiet()
        {
            return _HDCT.SaveHoaDon();
        }

        public void UpdateHoaDon(HoaDon HoaDon)
        {
             _HD.UpdateHoaDon(HoaDon);
        }        

        public void UpdateHoaDonCT(HoaDonChiTiet HoaDon)
        {
             _HDCT.UpdateHoaDonCT(HoaDon);
        }
    }
}

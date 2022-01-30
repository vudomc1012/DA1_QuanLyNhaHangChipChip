using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DALServices;
using _1_DAL.iDALServices;
using Microsoft.EntityFrameworkCore;

namespace _2_BUS.BUSServices
{
    public class QLNhanVienService : IQLNhanVienService
    {
        private INhanVienService _iNhanVienService;
        private List<NhanVien> _getLstNhanViens;
        public static bool _startSave = true;

        public QLNhanVienService()
        {
            _iNhanVienService = new NhanVienService();
            getLst();
        }
        public string Add(NhanVien nhanVien)
        {
            _startSave = false;
            _getLstNhanViens.Add(nhanVien);
            return _iNhanVienService.AddNV(nhanVien);
        }

        public string Delete(NhanVien nhanVien)
        {
            _getLstNhanViens.Remove(nhanVien);
            return _iNhanVienService.removeNV(nhanVien);
        }

        public List<NhanVien> searchNhanViens(string nv)
        {
            return _getLstNhanViens.Where(c => c.Name.Equals(nv)).ToList();
        }

        public string Update(NhanVien nhanVien)
        {
            _startSave = false;
            var index = _getLstNhanViens.FindIndex(c => c == nhanVien);
            _getLstNhanViens[index] = nhanVien;
            return _iNhanVienService.EditNV(nhanVien);
        }

        public string Save()
        {
            _startSave = true;
            return  _iNhanVienService.Save();
           
        }

        public List<NhanVien> getlstNhanViens()
        {
            return _getLstNhanViens;
        }

        public void getLst()
        {
            _getLstNhanViens = _iNhanVienService.GetLstNVfromDB();
        }
    }
}

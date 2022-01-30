using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _2_BUS.BUSServices
{
    public interface IQLNhanVienService
    {
        List<NhanVien> getlstNhanViens();
        List<NhanVien> searchNhanViens(string nv);
        public string Add(NhanVien nhanVien);
        public string Update(NhanVien nhanVien);
        public string Delete(NhanVien nhanVien);
        public string Save();
        public void getLst();
    }
}

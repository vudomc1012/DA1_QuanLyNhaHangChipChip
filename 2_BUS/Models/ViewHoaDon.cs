using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _2_BUS.Models
{
    public class ViewHoaDon
    {
        public HoaDon hoaDon { get; set; }
        public HoaDonChiTiet hoaDonChiTiet { get; set; }
        public BanAn banAn { get; set; }
        public MonAnChiTiet monAnChiTiet { get; set; }
        public NhanVien nhanVien { get; set; }
    }
}

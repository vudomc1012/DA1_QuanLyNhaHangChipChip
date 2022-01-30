using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _2_BUS.Models
{
    public class ViewMenu
    {
        public MonAnChiTiet details { get; set; }
        public DonVi unit { get; set; }
        public CachCheBien method { get; set; }
        public DanhMucFood cat { get; set; }

    }
}

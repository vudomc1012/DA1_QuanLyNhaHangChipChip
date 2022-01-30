using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
using _2_BUS.Models;

namespace _2_BUS.iBUSServices
{
    public interface iQLMenuService
    {
        public bool AddItem(ThucDon food);
        public bool AddDetail(MonAnChiTiet food);
        public bool AddUnit(DonVi unit);
        public bool AddCategory(DanhMucFood cat);
        public bool AddMethod(CachCheBien method);

        public bool UpdateItem(ThucDon food);
        public bool UpdateDetail(MonAnChiTiet food);
        public bool UpdateUnit(DonVi unit);
        public bool UpdateCategory(DanhMucFood cat);
        public bool UpdateMethod(CachCheBien method);

        public bool DeleteItem(ThucDon food);
        public bool DeleteDetail(MonAnChiTiet food);
        public bool DeleteUnit(DonVi unit);
        public bool DeleteCategory(DanhMucFood cat);
        public bool DeleteMethod(CachCheBien method);

        public List<MonAnChiTiet> GetMonAnChiTiets();
        public List<DonVi> GetDonVis();
        public List<DanhMucFood> GetDanhMucFoods();
        public List<ViewMenu> GetViewMenus();
        public List<ViewMenu> TimKiem(string str);
        public List<CachCheBien> GetCachCheBiens();
        public List<ThucDon> GetThucDons();


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using _1_DAL.DALServices;
using _2_BUS.iBUSServices;
using _2_BUS.Models;

namespace _2_BUS.BUSServices
{
    public class QLMenuService : iQLMenuService
    {
        private iMonAnChiTietService _iMonAnChiTietService;
        private iDonViService _iDonViService;
        private iCachChebienService _iCachChebienService;
        private IThucDonService _iThucDonService;
        private iDMFoodService _iDMFoodService;
        private List<MonAnChiTiet> _lstMonAnCT;
        private List<ThucDon> _lstMenu;
        private List<DonVi> _lstDonVi;
        private List<CachCheBien> _lstCachCheBien;
        private List<DanhMucFood> _lstDMFood;
        private List<ViewMenu> _viewMenus;

        public QLMenuService()
        {
            _iMonAnChiTietService = new MonAnChiTietService();
            _iDonViService = new DonViService();
            _iThucDonService = new ThucDonService();
            _iCachChebienService = new CachCheBienService();
            _iDMFoodService = new DMFoodService();

        }
        public bool AddCategory(DanhMucFood cat)
        {
            _iDMFoodService.AddDMFood(cat);
            _iDMFoodService.SaveDMFood();
            return true;
        }

        public bool AddDetail(MonAnChiTiet food)
        {
            _iMonAnChiTietService.AddMonAnChiTiet(food);
            _iMonAnChiTietService.SaveMonAnChiTiet();

            return true;
        }



        public bool AddItem(ThucDon food)
        {
            _iThucDonService.AddThucDon(food);
            _iThucDonService.SaveThucDon();
            return true;
        }

        public bool AddMethod(CachCheBien method)
        {
            _iCachChebienService.AddCachCheBien(method);
            _iCachChebienService.SaveCachCheBien();
            return true;
        }



        public bool AddUnit(DonVi unit)
        {
            _iDonViService.AddDonVi(unit);
            _iDonViService.SaveDonVi();
            return true;
        }

        

        public bool DeleteCategory(DanhMucFood cat)
        {
            _iDMFoodService.DeleteDMFood(cat);
            _iDMFoodService.SaveDMFood();
            return true;
        }

        public bool DeleteDetail(MonAnChiTiet food)
        {
            _iMonAnChiTietService.DeleteMonAnChiTiet(food);
            _iMonAnChiTietService.SaveMonAnChiTiet();

            return true;
        }



        public bool DeleteItem(ThucDon food)
        {
            _iThucDonService.DeleteThucDon(food);
            _iThucDonService.SaveThucDon();
            return true;
        }

        public bool DeleteMethod(CachCheBien method)
        {
            _iCachChebienService.DeleteCachCheBien(method);
            _iCachChebienService.SaveCachCheBien();
            return true;
        }



        public bool DeleteUnit(DonVi unit)
        {
            _iDonViService.DeleteDonVi(unit);
            _iDonViService.SaveDonVi();
            return true;
        }

        public List<CachCheBien> GetCachChebiens()
        {
            return _iCachChebienService.GetMethodsFromDB();
        }



        public List<DanhMucFood> GetDanhMucFoods()
        {
            return _iDMFoodService.GetCategoriesFromDB();
        }

        public List<DonVi> GetDonVis()
        {
            return _iDonViService.GetUnitsFromDB();
        }

        public List<MonAnChiTiet> GetMonAnChiTiets()
        {
            return _iMonAnChiTietService.GetDetailsFromDB();
        }



        public List<ThucDon> GetThucDons()
        {
            return _iThucDonService.GetThucDonFromDB();
        }



        public List<ViewMenu> GetViewMenus()
        {
            return _viewMenus = (from a in _iMonAnChiTietService.GetDetailsFromDB()
                                 join b in _iDonViService.GetUnitsFromDB() on a.Idunit equals b.Id
                                 join c in _iDMFoodService.GetCategoriesFromDB() on a.Idcategory equals c.Id
                                 join d in _iCachChebienService.GetMethodsFromDB() on a.Idmethod equals d.Id
                                 select new ViewMenu()
                                 {
                                     details = a,
                                     unit = b,
                                     cat = c,
                                     method = d
                                 }).ToList();
        }

        public List<ViewMenu> TimKiem(string str)
        {
            return _viewMenus = (from a in _iMonAnChiTietService.GetDetailsFromDB()
                                 join b in _iDonViService.GetUnitsFromDB() on a.Idunit equals b.Id
                                 join c in _iDMFoodService.GetCategoriesFromDB() on a.Idcategory equals c.Id
                                 join d in _iCachChebienService.GetMethodsFromDB() on a.Idmethod equals d.Id
                                 where a.Name.Contains(str) || a.Price.ToString().Contains(str) || b.Name.Contains(str) || c.Name.Contains(str) || d.Name.Contains(str)
                                 select new ViewMenu()
                                 {
                                     details = a,
                                     unit = b,
                                     cat = c,
                                     method = d
                                 }).ToList();
        }

        public bool UpdateCategory(DanhMucFood cat)
        {
            try
            {
                _iDMFoodService.UpdateDMFood(cat);
                _iDMFoodService.SaveDMFood();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateDetail(MonAnChiTiet food)
        {
            try
            {
                _iMonAnChiTietService.UpdateMonAnChiTiet(food);
                _iMonAnChiTietService.SaveMonAnChiTiet();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public bool UpdateItem(ThucDon food)
        {
            try
            {
                _iThucDonService.UpdateThucDon(food);
                _iThucDonService.SaveThucDon();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateMethod(CachCheBien method)
        {
            try
            {
                _iCachChebienService.UpdateCachCheBien(method);
                _iCachChebienService.SaveCachCheBien();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool UpdateUnit(DonVi unit)
        {
            try
            {
                _iDonViService.UpdateDonVi(unit);
                _iDonViService.SaveDonVi();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        List<CachCheBien> iQLMenuService.GetCachCheBiens()
        {
            return _iCachChebienService.GetMethodsFromDB();
        }
    }
}

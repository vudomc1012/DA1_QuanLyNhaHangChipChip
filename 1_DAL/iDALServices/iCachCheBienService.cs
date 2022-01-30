using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iCachChebienService
    {
        public string AddCachCheBien(CachCheBien CachChebien);
        public string UpdateCachCheBien(CachCheBien CachChebien);
        public string DeleteCachCheBien(CachCheBien CachChebien);
        public string SaveCachCheBien();
        public List<CachCheBien> GetMethodsFromDB();
    }
}

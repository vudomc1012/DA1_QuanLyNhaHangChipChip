using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iDonViService
    {
        public string AddDonVi(DonVi DonVi);
        public string UpdateDonVi(DonVi DonVi);
        public string DeleteDonVi(DonVi DonVi);
        public string SaveDonVi();
        public List<DonVi> GetUnitsFromDB();
    }
}
